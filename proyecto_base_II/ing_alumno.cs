using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyecto_base_II
{
    public partial class ing_alumno : Form
    {
        public ing_alumno()
        {
            InitializeComponent();
        }

        private void ing_alumno_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            menu frm1 = new menu();
            frm1.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           mod_alumno frm1 = new mod_alumno();
            frm1.Show();
            this.Hide();
        }
    }
}
