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
    public partial class F_newstudent : Form
    {
        public F_newstudent()
        {
            InitializeComponent();
        }

        private void btn_closestud_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void btn_cleanstud_Click(object sender, EventArgs e)
        {
            txt_namestud.Clear();
            txt_nickstud.Clear();
            txt_classtud.Clear();
            txt_periodstud.Clear();
            txt_telstud.Clear();
        }       

        private void btn_savestud_Click(object sender, EventArgs e)
        {
            Aluno aluno = new Aluno();

            aluno.nome_aluno = txt_namestud.Text;
            aluno.sobrenome_aluno = txt_nickstud.Text;
            aluno.curso_aluno = txt_classtud.Text;
            aluno.periodo_aluno = txt_periodstud.Text;
            aluno.telefone_aluno = txt_telstud.Text;

            Banco.NovoAluno(aluno);
        }
    }
}