using System;
using MaterialSkin;
using MaterialSkin.Controls;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Book_Rental_System
{
    public partial class Home : MaterialForm
    {
        public Home()
        {
            InitializeComponent();
            MaterialSkinManager skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.DARK;
            skinManager.ColorScheme = new ColorScheme(Primary.Green900, Primary.BlueGrey900, Primary.Blue500, Accent.Orange700, TextShade.WHITE);
        }
    }
}
