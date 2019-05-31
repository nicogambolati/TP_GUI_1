using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tp_GUI
{
    public partial class Form2 : Form
    {
        bool flag = false; // bandera
        

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressbarFRM.PerformStep(); // carga la progress bar

            if (progressbarFRM.Value == 100 && flag == false) // le puse la bardera porque sino me entraba en un bucle 
            {
                flag = true;
                MessageBox.Show("Pedido Aceptado");
                this.Close();
            }
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1 padre = (Form1)this.Owner;
            padre.btnAceptar.Enabled = true;
            padre.Focus();
            
             
            
        }
    }
}
