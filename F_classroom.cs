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
    public partial class F_classroom : Form
    {
        public F_classroom()
        {
            InitializeComponent();
        }

        private void btn_closeroom_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_modifyroom_Click(object sender, EventArgs e)
        {

        }

        private void dgv_classroom_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dgv = sender as DataGridView;
            int qtdLinhas = dgv.SelectedRows.Count;

            if (qtdLinhas > 0)
            {
                DataTable dt = new DataTable();
                string userId = dgv.SelectedRows[0].Cells[0].Value.ToString();
                dt = Banco.ObterDadosPorIdSala(userId);

                txt_idclassroom.Text = dt.Rows[0].Field<Int64>("id_turma").ToString();
                txt_idcourseclassroom.Text = dt.Rows[0].Field<Int64>("id_curso").ToString();
                txt_idtimeclassroom.Text = dt.Rows[0].Field<Int64>("id_horario_turma").ToString();
                txt_idteacherclassroom.Text = dt.Rows[0].Field<Int64>("id_prof_turma").ToString();          
                txt_maxclassroom.Text = dt.Rows[0].Field<Int64>("max_alunos_turma").ToString();
                txt_stateclassroom.Text = dt.Rows[0].Field<string>("status_turma");
            }
        }

        private void F_classroom_Load(object sender, EventArgs e)
        {
            dgv_classroom.DataSource = Banco.ObterSalaID();

            dgv_classroom.Columns[0].Width = 50;
            dgv_classroom.Columns[1].Width = 50;
            dgv_classroom.Columns[2].Width = 90;
            dgv_classroom.Columns[3].Width = 80;
            dgv_classroom.Columns[4].Width = 100;
            dgv_classroom.Columns[5].Width = 90;
        }

        private void btn_eraseclassroom_Click(object sender, EventArgs e)
        {
            DialogResult resposta = MessageBox.Show("Confirmar Exclusão?", "Excluir Turma", MessageBoxButtons.YesNo);

            if (resposta == DialogResult.Yes)
            {
                Banco.RemoverSala(txt_idclassroom.Text);
                dgv_classroom.Rows.Remove(dgv_classroom.CurrentRow);

                txt_idcourseclassroom.Text = "";
                txt_idteacherclassroom.Text = "";
                txt_idtimeclassroom.Text = "";
                txt_maxclassroom.Text = "";
                txt_stateclassroom.Text = "";
                txt_teacherclassroom.Text = "";
            }
        }
    }
}