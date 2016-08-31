using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication2.Entities;

namespace WindowsFormsApplication2
{
    public partial class Form2 : Form
    {
        public Lucrari lucrare;
        public Form2(Lucrari _lucrare)
        {
            lucrare = _lucrare;
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            tb_codL.Text = lucrare.CodL.ToString();
            tb_denumL.Text = lucrare.DenumL;
            tb_sectiuni.Text = lucrare.Sectiune.ToString();
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            lucrare.CodL = int.Parse(tb_codL.Text);
            lucrare.DenumL = tb_denumL.Text;
            lucrare.Sectiune = int.Parse(tb_sectiuni.Text);
        }

    }
}
