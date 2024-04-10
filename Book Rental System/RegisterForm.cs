using MaterialSkin;
using MaterialSkin.Controls;
using System.Data.SqlClient;

namespace Book_Rental_System
{
    public partial class RegisterForm : MaterialForm
    {
        bool emptyFieldsExist;

        SqlCommand sqlCommand;
        SqlConnection sqlConnection;
        SqlDataReader sqlDataReader;

        public RegisterForm()
        {
            InitializeComponent();
            MaterialSkinManager skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.DARK;
            skinManager.ColorScheme = new ColorScheme(Primary.Green900, Primary.BlueGrey900, Primary.Blue500, Accent.Orange700, TextShade.WHITE);
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(@"Data Source=DESKTOP-KT1MQS7;" +
                "   Initial Catalog=BOOK_RENTAL_SERVICE;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
            sqlConnection.Open();
        }

        #region events
        private void RegisterButton_Click(object sender, EventArgs e)
        {
            CheckForEmptyFields();

            if (emptyFieldsExist)
            {
                return;
            }
            ConfirmPasswordAndCheckUsername();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker.CustomFormat = "dd/mm/yyyy";
        }

        private void dateTimePicker1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                dateTimePicker.CustomFormat = " ";
            }
        }

        #endregion

        #region functions
        private void CheckForEmptyFields()
        {
            if (!StaticFunctions.CheckIfTextBoxIsNull(firstNameBox) && !StaticFunctions.CheckIfTextBoxIsNull(lastNameBox) && !StaticFunctions.CheckIfTextBoxIsNull(emailBox) &&
                !StaticFunctions.CheckDateBox(dateTimePicker) && !StaticFunctions.CheckIfTextBoxIsNull(userNameBox) && !StaticFunctions.CheckIfTextBoxIsNull(passwordBox) && !StaticFunctions.CheckIfTextBoxIsNull(confirmPasswordBox))
            {
                emptyFieldsExist = true;
                MessageBox.Show("Please Fill All Fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ConfirmPasswordAndCheckUsername()
        {
            if (passwordBox.Text != confirmPasswordBox.Text)
            {
                MessageBox.Show("Please Enter Same Password", "Error", MessageBoxButtons.OK);
            }
            else
            {
                CheckIfUserNameExists();
            }
        }

        private void CheckIfUserNameExists()
        {
            sqlCommand = new SqlCommand($"select * from USERS where username = '{userNameBox.Text}' " +
                $"  or email = '{emailBox.Text}'", sqlConnection);
            sqlDataReader = sqlCommand.ExecuteReader();

            if (sqlDataReader.Read())
            {
                sqlDataReader.Close();
                MessageBox.Show($"Username {userNameBox.Text} already exists please use another", "Warning", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                InsertInformation();
                MessageBox.Show("Account Created", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Hide();
                LoginForm loginForm = new LoginForm();
                loginForm.ShowDialog();
                this.Close();
            }
        }

        private void InsertInformation()
        {
            sqlDataReader.Close();
            string query = "insert into USERS values(@firstName,@lastName,@email,@username,@password,@date)";
            sqlCommand = new SqlCommand(query, sqlConnection);

            sqlCommand.Parameters.AddWithValue("firstname", firstNameBox.Text);
            sqlCommand.Parameters.AddWithValue("lastname", lastNameBox.Text);
            sqlCommand.Parameters.AddWithValue("email", emailBox.Text);
            sqlCommand.Parameters.AddWithValue("date", dateTimePicker.Value);
            sqlCommand.Parameters.AddWithValue("username", userNameBox.Text);
            sqlCommand.Parameters.AddWithValue("password", passwordBox.Text);
            sqlCommand.ExecuteNonQuery();
        }
#endregion
    }
}
