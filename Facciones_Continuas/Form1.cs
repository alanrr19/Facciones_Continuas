using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Facciones_Continuas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            int a, b;
            a = int.Parse(TxtNum1.Text);
            b = int.Parse(TxtNum2.Text);
            TablaDatos.Rows.Clear();
            CalcularFraccionContinua(a, b);
        }

        private void CalcularFraccionContinua(int a, int b)
        {
            if (b == 0)
            return;

            int resultante = a / b;
            int residuo = a % b;

            string ecuacion;
            if (residuo == 0)
            {
                ecuacion = a + "/" + b + " = " + resultante;
            }
            else
            {
                ecuacion = a + "/" + b + " = " + resultamte + " + 1/" + b + " / " + residuo;
            }    

            TablaDatos.Rows.Add(TablaDatos.Rows.Count, a + " dividido entre " + b + " es " + resultante + " y sobran " + residuo, ecuacion);
    
            CalcularFraccionContinua(b, residuo);
        }
    }
}
