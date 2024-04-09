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
                "   Integrated Security=True;Encrypt=True;Trust Server Certificate=True");
        }
    }
}
