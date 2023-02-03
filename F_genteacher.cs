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
    public partial class F_genteacher : Form
    {
        public F_genteacher()
        {
            InitializeComponent();
        }

        private void btn_genclean_Click(object sender, EventArgs e)
        {
            txt_genidteacher.Text = "";
            txt_gennameteacher.Text = "";
            txt_gennickteacher.Text = "";
            txt_genareateacher.Text = "";
            txt_gensetorteacher.Text = "";
            txt_gentelteacher.Text = "";
            txt_genturnteacher.Text = "";
        }

        private void btn_genupdate_Click(object sender, EventArgs e)
        {
            int linha = dgv_teacher.SelectedRows[0].Index;

            Professor professor = new Professor();
            professor.id_professor = Convert.ToInt32(txt_genidteacher.Text);
            professor.nome_professor = txt_gennameteacher.Text;
            professor.sobrenome_professor = txt_gennickteacher.Text;
            professor.area_professor = txt_genareateacher.Text;
            professor.setor_professor = txt_gensetorteacher.Text;
            professor.telefone_professor = txt_gentelteacher.Text;
            professor.turno_professor = txt_genturnteacher.Text;

            Banco.AtualizarProfessor(professor);

            dgv_teacher[1, linha].Value = txt_genidteacher.Text;
        }

        private void btn_gennew_Click(object sender, EventArgs e)
        {
            F_newteacher f_newteacher = new F_newteacher();
            f_newteacher.ShowDialog();
            dgv_teacher.DataSource = Banco.ObterTeacherID();
        }

        private void btn_generase_Click(object sender, EventArgs e)
        {
            DialogResult resposta = MessageBox.Show("Confirmar Exclusão?", "Excluir Professor", MessageBoxButtons.YesNo);

            if (resposta == DialogResult.Yes)
            {
                Banco.RemoverProfessor(txt_genidteacher.Text);
                dgv_teacher.Rows.Remove(dgv_teacher.CurrentRow);

                txt_genidteacher.Text = "";
                txt_gennameteacher.Text = "";
                txt_gennickteacher.Text = "";
                txt_genareateacher.Text = "";
                txt_gensetorteacher.Text = "";
                txt_gentelteacher.Text = "";
                txt_genturnteacher.Text = "";
            }
        }

        private void dgv_teacher_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dgv = sender as DataGridView;
            int qtdLinhas = dgv.SelectedRows.Count;

            if (qtdLinhas > 0)
            {
                DataTable dt = new DataTable();
                string userId = dgv.SelectedRows[0].Cells[0].Value.ToString();
                dt = Banco.ObterDadosPorIdTeacher(userId);

                txt_genidteacher.Text = dt.Rows[0].Field<Int64>("id_professor").ToString();
                txt_gennameteacher.Text = dt.Rows[0].Field<string>("nome_professor");
                txt_gennickteacher.Text = dt.Rows[0].Field<string>("sobrenome_professor");
                txt_genareateacher.Text = dt.Rows[0].Field<string>("area_professor");
                txt_gensetorteacher.Text = dt.Rows[0].Field<string>("setor_professor");
                txt_gentelteacher.Text = dt.Rows[0].Field<string>("telefone_professor");
                txt_genturnteacher.Text = dt.Rows[0].Field<string>("turno_professor");
            }
        }

        private void F_genteacher_Load(object sender, EventArgs e)
        {
            dgv_teacher.DataSource = Banco.ObterTeacherID();

            dgv_teacher.Columns[0].Width = 40;
            dgv_teacher.Columns[1].Width = 180;
        }

        private void btn_genclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}