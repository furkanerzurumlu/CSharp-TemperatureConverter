using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class TemperatureConverter : Form
    {
        public TemperatureConverter()
        {
            InitializeComponent();
        }

        private void btnFahrenayt_Click(object sender, EventArgs e)
        {
            double value = Convert.ToDouble(txtValue.Text); //txtDeğer'de ki (TextBox) değeri alır ve double'a çevirir.
            double result=(value * 9 / 5) + 32; //Girilen değeri formülde kullanır, sonuç değişkenine atar.
            txtResult.Text = result.ToString()+" F"; //Sonuç değerini Fahrenayt eşiti şeklinde txtSonuç'a (TextBox'a) "...F" şeklinde yazdırır.
        }

        private void btnSantigrad_Click(object sender, EventArgs e)
        {
            double value = Convert.ToDouble(txtValue.Text); //txtDeğer'de ki (TextBox) değeri alır ve double'a çevirir.
            double result = (value - 32) * 5 / 9; //Girilen değeri formülde kullanır, sonuç değişkenine atar.
            txtResult.Text = result.ToString()+" C"; //Sonuç değerini Santigrad eşiti şeklinde txtSonuç'a (TextBox'a) "...C" şekinde yazdırır.

        }
    }
}
