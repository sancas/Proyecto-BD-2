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
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void menu_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ing_docente frm = new ing_docente();
            frm.Show();
            this.Hide(); 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ing_materia frm = new ing_materia();
            frm.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ing_alumno frm = new ing_alumno();
            frm.Show();
            this.Hide();
        }
    }
}
