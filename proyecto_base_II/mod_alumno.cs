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
    public partial class mod_alumno : Form
    {
        public mod_alumno()
        {
            InitializeComponent();
        }

        private void mod_alumno_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            menu frm = new menu();
            frm.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ing_alumno frm = new ing_alumno();
            frm.Show();
            this.Hide();
        }
    }
}
