using MaterialSkin.Controls;

namespace Book_Rental_System
{
    public static class StaticFunctions
    {
        public static bool CheckIfTextBoxIsNull(MaterialTextBox2 textBox)
        {
            if (textBox.Text == String.Empty)
            {
                return false;
            }
            return true;
        }

        public static bool CheckIfTextBoxIsNull(MaterialTextBox textBox)
        {
            if (textBox.Text == String.Empty)
            {
                return false;
            }
            return true;
        }

        public static bool CheckDateBox(DateTimePicker dateTimePicker)
        {
            if (dateTimePicker.Text == String.Empty)
            {
                return false;
            }
            return true;
        }
    }
}
