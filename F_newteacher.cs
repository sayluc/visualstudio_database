using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class F_newteacher : Form
    {
        F_escola f_newteacher;
        DataTable dt = new DataTable();
        public F_newteacher(F_escola f)
        {
            InitializeComponent();
            f_newteacher = f;
        }

        private void btn_closet_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_cleant_Click(object sender, EventArgs e)
        {
            txt_namet.Clear();
            txt_areat.Clear();
            txt_floort.Clear();
        }

        private void btn_savet_Click(object sender, EventArgs e)
        {
            Professor professor = new Professor();

            professor.nome_professor = txt_namet.Text;
            professor.area_professor = txt_areat.Text;
            professor.setor_professor = txt_floort.Text;

            Banco.NovoProfessor(professor);
        }
    }
}