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
    public partial class F_genclass : Form
    {
        public F_genclass()
        {
            InitializeComponent();
        }

        private void btn_genclean_Click(object sender, EventArgs e)
        {
            txt_gennameclass.Text = "";
            txt_genareaclass.Text = "";
            cmb_genstateclass.Text = "";
            txt_genidclass.Text = "";
        }

        private void btn_genupdate_Click(object sender, EventArgs e)
        {
            int linha = dgv_class.SelectedRows[0].Index;

            Curso curso = new Curso();
            curso.id_curso = Convert.ToInt32(txt_genidclass.Text);
            curso.nome_curso = txt_gennameclass.Text;
            curso.area_curso = txt_genareaclass.Text;          
            curso.status_curso = cmb_genstateclass.Text;

            Banco.AtualizarCurso(curso);

            dgv_class[1, linha].Value = txt_gennameclass.Text;
        }

        private void btn_gennew_Click(object sender, EventArgs e)
        {
            F_newclass f_newclass = new F_newclass();
            f_newclass.ShowDialog();
            dgv_class.DataSource = Banco.ObterClassID();
        }

        private void btn_generase_Click(object sender, EventArgs e)
        {
            DialogResult resposta = MessageBox.Show("Confirmar Exclusão?", "Excluir Curso", MessageBoxButtons.YesNo);

            if (resposta == DialogResult.Yes)
            {
                Banco.RemoverCurso(txt_genidclass.Text);
                dgv_class.Rows.Remove(dgv_class.CurrentRow);

                txt_gennameclass.Text = "";
                txt_genareaclass.Text = "";
                cmb_genstateclass.Text = "";
                txt_genidclass.Text = "";
            }
        }

        private void dgv_user_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dgv = sender as DataGridView;
            int qtdLinhas = dgv.SelectedRows.Count;

            if (qtdLinhas > 0)
            {
                DataTable dt = new DataTable();
                string userId = dgv.SelectedRows[0].Cells[0].Value.ToString();
                dt = Banco.ObterDadosPorIdClass(userId);

                txt_genidclass.Text = dt.Rows[0].Field<Int64>("id_curso").ToString();
                txt_gennameclass.Text = dt.Rows[0].Field<string>("nome_curso");
                txt_genareaclass.Text = dt.Rows[0].Field<string>("area_curso");
                cmb_genstateclass.Text = dt.Rows[0].Field<string>("status_curso");
            }
        }

        private void F_genclass_Load(object sender, EventArgs e)
        {
            dgv_class.DataSource = Banco.ObterClassID();

            dgv_class.Columns[0].Width = 40;
            dgv_class.Columns[1].Width = 180;
        }

        private void btn_genclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}