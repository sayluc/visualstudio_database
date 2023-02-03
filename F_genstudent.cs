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
    public partial class F_genstudent : Form
    {
        public F_genstudent()
        {
            InitializeComponent();
        }

        private void btn_genclean_Click(object sender, EventArgs e)
        {
            txt_gennamestudent.Text = "";
            txt_gennickstudent.Text = "";
            txt_genclasstudent.Text = "";
            txt_gentelstudent.Text = "";
            txt_genturnstudent.Text = "";
            txt_genidstudent.Text = "";
        }

        private void btn_genupdate_Click(object sender, EventArgs e)
        {
            int linha = dgv_student.SelectedRows[0].Index;

            Aluno aluno = new Aluno();
            aluno.id_aluno = Convert.ToInt32(txt_genidstudent.Text);
            aluno.nome_aluno = txt_gennamestudent.Text;
            aluno.sobrenome_aluno = txt_gennickstudent.Text;
            aluno.curso_aluno = txt_genclasstudent.Text;
            aluno.telefone_aluno = txt_gentelstudent.Text;
            aluno.periodo_aluno = txt_genturnstudent.Text;

            Banco.AtualizarEstudante(aluno);

            dgv_student[1, linha].Value = txt_gennamestudent.Text;
        }

        private void btn_gennew_Click(object sender, EventArgs e)
        {
            F_newstudent f_newstudent = new F_newstudent();
            f_newstudent.ShowDialog();
            dgv_student.DataSource = Banco.ObterUserID();
        }

        private void btn_generase_Click(object sender, EventArgs e)
        {
            DialogResult resposta = MessageBox.Show("Confirmar Exclusão?", "Excluir Aluno", MessageBoxButtons.YesNo);

            if (resposta == DialogResult.Yes)
            {
                Banco.RemoverEstudante(txt_genidstudent.Text);
                dgv_student.Rows.Remove(dgv_student.CurrentRow);

                txt_gennamestudent.Text = "";
                txt_gennickstudent.Text = "";
                txt_genclasstudent.Text = "";
                txt_gentelstudent.Text = "";
                txt_genturnstudent.Text = "";
                txt_genidstudent.Text = "";
            }
        }

        private void dgv_student_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dgv = sender as DataGridView;
            int qtdLinhas = dgv.SelectedRows.Count;

            if (qtdLinhas > 0)
            {
                DataTable dt = new DataTable();
                string userId = dgv.SelectedRows[0].Cells[0].Value.ToString();
                dt = Banco.ObterDadosPorIdStudent(userId);

                txt_genidstudent.Text = dt.Rows[0].Field<Int64>("id_aluno").ToString();
                txt_gennamestudent.Text = dt.Rows[0].Field<string>("nome_aluno");
                txt_gennickstudent.Text = dt.Rows[0].Field<string>("sobrenome_aluno");
                txt_genclasstudent.Text = dt.Rows[0].Field<string>("curso_aluno");
                txt_gentelstudent.Text = dt.Rows[0].Field<string>("telefone_aluno").ToString();
                txt_genturnstudent.Text = dt.Rows[0].Field<string>("periodo_aluno");
            }
        }

        private void F_genstudent_Load(object sender, EventArgs e)
        {
            dgv_student.DataSource = Banco.ObterStudentID();

            dgv_student.Columns[0].Width = 40;
            dgv_student.Columns[1].Width = 180;
        }

        private void btn_genclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}