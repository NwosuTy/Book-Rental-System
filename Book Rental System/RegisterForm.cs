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
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(@"Data Source=DESKTOP-KT1MQS7;" +
                "   Initial Catalog=BOOK_RENTAL_SERVICE;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
            sqlConnection.Open();
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            CheckForEmptyFields();

            if (emptyFieldsExist)
            {
                return;
            }
            ConfirmPasswordAndCheckUsername();
        }

        private void CheckForEmptyFields()
        {
            if (!CheckIfTextBoxIsNull(firstNameBox) && !CheckIfTextBoxIsNull(lastNameBox) && !CheckIfTextBoxIsNull(emailBox) &&
                !CheckDateBox(dateTimePicker) && !CheckIfTextBoxIsNull(userNameBox) && !CheckIfTextBoxIsNull(passwordBox) && !CheckIfTextBoxIsNull(confirmPasswordBox))
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
            MessageBox.Show("Account Created", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private bool CheckIfTextBoxIsNull(MaterialTextBox2 textBox)
        {
            if (textBox.Text == String.Empty)
            {
                return false;
            }
            return true;
        }

        private bool CheckDateBox(DateTimePicker dateTimePicker)
        {
            if (dateTimePicker.Text == String.Empty)
            {
                return false;
            }
            return true;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker.CustomFormat = "dd/mm/yyyy";
        }

        private void dateTimePicker1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Back)
            {
                dateTimePicker.CustomFormat = " ";
            }
        }
    }
}
