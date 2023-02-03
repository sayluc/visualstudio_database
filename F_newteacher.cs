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
        public F_newteacher()
        {
            InitializeComponent();
        }

        private void btn_closet_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_cleant_Click(object sender, EventArgs e)
        {
            txt_namet.Clear();
            txt_nickt.Clear();
            txt_areat.Clear();
            txt_setort.Clear();
            txt_phonet.Clear();
            txt_turnt.Clear();
        }

        private void btn_savet_Click(object sender, EventArgs e)
        {
            Professor professor = new Professor();

            professor.nome_professor = txt_namet.Text;
            professor.sobrenome_professor = txt_nickt.Text;
            professor.area_professor = txt_areat.Text;
            professor.setor_professor = txt_setort.Text;
            professor.telefone_professor = txt_phonet.Text;
            professor.turno_professor = txt_turnt.Text;

            Banco.NovoProfessor(professor);
        }
    }
}