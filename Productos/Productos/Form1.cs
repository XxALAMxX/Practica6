using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Productos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double p1, p2, p3, total, IVA;
        private void btFacturar_Click(object sender, EventArgs e)
        {
            if (tbProducto1 != null && tbProducto2 != null && tbProducto3 != null)
            {
                p1 = double.Parse(tbProducto1.Text);
                p2 = double.Parse(tbProducto2.Text);
                p3 = double.Parse(tbProducto3.Text);
                total = p1 + p2 + p3;
                tbSub.Text = total.ToString();
                IVA = total * .16;
                tbIVA.Text = IVA.ToString();
                tbTotal.Text = (total + IVA).ToString();
            }
        }

        private void btLimpiar_Click(object sender, EventArgs e)
        {
            this.tbProducto1.Clear();
            this.tbProducto2.Clear();
            this.tbProducto3.Clear();
            this.tbSub.Clear();
            this.tbIVA.Clear();
            this.tbTotal.Clear();
        }
    }
}
