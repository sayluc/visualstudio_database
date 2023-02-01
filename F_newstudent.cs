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
    public partial class F_aluno : Form
    {
        F_escola f_aluno;
        DataTable dt = new DataTable();
        public F_aluno(F_escola f)
        {
            InitializeComponent();
            f_aluno = f;
        }

        private void btn_closestud_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void btn_cleanstud_Click(object sender, EventArgs e)
        {
            txt_namestud.Clear();
            txt_classtud.Clear();
            txt_periodstud.Clear();
        }       

        private void btn_savestud_Click(object sender, EventArgs e)
        {
            Aluno aluno = new Aluno();

            aluno.nome_aluno = txt_namestud.Text;
            aluno.curso_aluno = txt_classtud.Text;
            aluno.periodo_aluno = txt_periodstud.Text;

            Banco.NovoAluno(aluno);
        }
    }
}