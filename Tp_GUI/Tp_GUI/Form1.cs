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
    public partial class Form1 : Form
    {
        Color fondo;
        List<Color> listaColores = new List<Color>();

        public Form1()
        {
            InitializeComponent();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.FromArgb(255, trackBar1.Value, trackBar2.Value, trackBar3.Value);
            fondo = pictureBox1.BackColor;
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.FromArgb(255, trackBar1.Value, trackBar2.Value, trackBar3.Value);
            fondo = pictureBox1.BackColor;
        }

        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.FromArgb(255, trackBar1.Value, trackBar2.Value, trackBar3.Value);
            fondo = pictureBox1.BackColor;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.Owner = this;
            frm.Show();
            btnAceptar.Enabled = false; // bloqueo el boton para que el usuario no siga presionando
            System.Diagnostics.Process.Start("https://www.google.com.ar/search?q="+ "%23" + fondo.Name.Substring(2));

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void GuardarColorBtn_Click(object sender, EventArgs e)
        {
            if(!listaColores.Contains(fondo) && fondo.Name!="0")
            {
                listaColores.Add(fondo);
                RefrescarCheckedListbox();
                RefrescarPicturebox();
            }
        }
        private void RefrescarCheckedListbox()
        {
            checkedListBox1.DataSource = null;
            checkedListBox1.DataSource = listaColores;
            checkedListBox1.DisplayMember = "Name";
        }
        private void RefrescarPicturebox()
        {
            trackBar1.Value = 0;
            trackBar2.Value = 0;
            trackBar3.Value = 0;
            pictureBox1.BackColor = SystemColors.Control;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.Black;
        }
    }
}
