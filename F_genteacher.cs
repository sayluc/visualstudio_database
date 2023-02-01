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
            txt_gennickteacher.Text = "";
            txt_genpassteacher.Text = "";
            cmb_genstateteacher.Text = "";
            nud_genlevelteacher.Text = "";
            txt_genidteacher.Text = "";
        }

        private void btn_genupdate_Click(object sender, EventArgs e)
        {
            int linha = dgv_teacher.SelectedRows[0].Index;

            Usuario user = new Usuario();
            user.id_usuario = Convert.ToInt32(txt_genidteacher.Text);
            user.nome_usuario = txt_genidteacher.Text;
            user.username_usuario = txt_gennickteacher.Text;
            user.senha_usuario = txt_genpassteacher.Text;
            user.status_usuario = cmb_genstateteacher.Text;
            user.nivel_usuario = Convert.ToInt32(Math.Round(nud_genlevelteacher.Value, 0));

            Banco.AtualizarUsuario(user);

            dgv_teacher[1, linha].Value = txt_genidteacher.Text;
        }

        private void btn_gennew_Click(object sender, EventArgs e)
        {
            F_newuser f_newuser = new F_newuser();
            f_newuser.ShowDialog();
            dgv_teacher.DataSource = Banco.ObterUserID();
        }

        private void btn_generase_Click(object sender, EventArgs e)
        {
            DialogResult resposta = MessageBox.Show("Confirmar Exclusão?", "Excluir Usuário", MessageBoxButtons.YesNo);

            if (resposta == DialogResult.Yes)
            {
                Banco.RemoverUsuario(txt_genidteacher.Text);
                dgv_teacher.Rows.Remove(dgv_teacher.CurrentRow);

                txt_genidteacher.Text = "";
                txt_gennickteacher.Text = "";
                txt_genpassteacher.Text = "";
                cmb_genstateteacher.Text = "";
                nud_genlevelteacher.Text = "";
                txt_genidteacher.Text = "";
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
                dt = Banco.ObterDadosPorId(userId);

                txt_genidteacher.Text = dt.Rows[0].Field<Int64>("id_usuario").ToString();
                txt_genidteacher.Text = dt.Rows[0].Field<string>("nome_usuario").ToString();
                txt_gennickteacher.Text = dt.Rows[0].Field<string>("username_usuario").ToString();
                txt_genpassteacher.Text = dt.Rows[0].Field<string>("senha_usuario").ToString();
                cmb_genstateteacher.Text = dt.Rows[0].Field<string>("status_usuario").ToString();
                nud_genlevelteacher.Text = dt.Rows[0].Field<Int64>("nivel_usuario").ToString();
            }
        }

        private void F_genteacher_Load(object sender, EventArgs e)
        {
            dgv_teacher.DataSource = Banco.ObterUserID();

            dgv_teacher.Columns[0].Width = 40;
            dgv_teacher.Columns[1].Width = 180;
        }

        private void btn_genclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}