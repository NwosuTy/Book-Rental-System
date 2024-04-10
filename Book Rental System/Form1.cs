using System;
using System.Text;
using MaterialSkin;
using MaterialSkin.Controls;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Book_Rental_System
{
    public partial class LoginForm : MaterialForm
    {
        bool emptyFieldsExist;

        SqlCommand sqlCommand;
        SqlConnection sqlConnection;
        SqlDataReader sqlDataReader;

        public LoginForm()
        {
            InitializeComponent();
            MaterialSkinManager skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.DARK;
            skinManager.ColorScheme = new ColorScheme(Primary.Green900, Primary.BlueGrey900, Primary.Blue500, Accent.Orange700, TextShade.WHITE);
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(@"Data Source=DESKTOP-KT1MQS7;Initial Catalog=BOOK_RENTAL_SERVICE;" +
                "   Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
            sqlConnection.Open();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            CheckForEmptyFields();

            if(emptyFieldsExist != true)
            {
                CheckInformation();
            }
        }

        private void CheckInformation()
        {
            string query = $"select * from users where username = '{userNameBox.Text}' " +
                $"and convert(varchar, password) = '{passwordBox.Text}'";

            sqlCommand = new SqlCommand(query, sqlConnection);
            sqlDataReader = sqlCommand.ExecuteReader();
            if (sqlDataReader.Read())
            {
                sqlDataReader.Close();

                this.Hide();
                Home home = new();
                home.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Incorrect password, please try again", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
        }

        private void CheckForEmptyFields()
        {
            if(!StaticFunctions.CheckIfTextBoxIsNull(userNameBox))
            {
                emptyFieldsExist = true;
                MessageBox.Show("Please Fill in your Username", "Error", MessageBoxButtons.OK, 
                    MessageBoxIcon.Error);
                return;
            }
            if(!StaticFunctions.CheckIfTextBoxIsNull(passwordBox))
            {
                emptyFieldsExist = true;
                MessageBox.Show("Please Fill in your Password", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            emptyFieldsExist = false;
        }
    }
}
