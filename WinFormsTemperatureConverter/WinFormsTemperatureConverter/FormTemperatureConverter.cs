using System.Globalization;

namespace WinFormsApp2
{
    public partial class Form_Converter : Form
    {
        public Form_Converter()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

       
        private float ConvertCelsiusToFarnheit(float c)
        {
            return (c * 9 / 5) + 32;
        }

        private float ConvertFarnheitToCelsius(float f)
        {
            return (f - 32) * 5 / 9;
        }

        private void button_FarenheitToCelsius_Click(object sender, EventArgs e)
        {
            Convertion(textBox_Entry.Text, "f2c");
        }
        
        private void button_CelsiusToFarenheit_Click(object sender, EventArgs e)
        {
            Convertion(textBox_Entry.Text, "c2f");
        }

        private void Convertion(string input, string conversionType)
        {
            try
            {
                float entry = float.Parse(input, CultureInfo.InvariantCulture.NumberFormat);
                float exit = 0;
                if (conversionType == "c2f")
                {
                    exit = ConvertCelsiusToFarnheit(  entry);
                    label_Result.Text = exit.ToString(CultureInfo.InvariantCulture.NumberFormat) + "°F";
                }
                else if (conversionType == "f2c")
                {
                    exit = ConvertFarnheitToCelsius(  entry);
                    label_Result.Text = exit.ToString(CultureInfo.InvariantCulture.NumberFormat) + "°C";
                }
               
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter a number");
            }
            catch (OverflowException)
            {
                MessageBox.Show("Please enter a smaller number");
            }
        }
       
    }
}