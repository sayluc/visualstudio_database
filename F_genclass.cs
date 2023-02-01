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
            txt_gennickclass.Text = "";
            txt_genpassclass.Text = "";
            cmb_genstateclass.Text = "";
            nud_genlevelclass.Text = "";
            txt_genidclass.Text = "";
        }

        private void btn_genupdate_Click(object sender, EventArgs e)
        {
            int linha = dgv_class.SelectedRows[0].Index;

            Usuario user = new Usuario();
            user.id_usuario = Convert.ToInt32(txt_genidclass.Text);
            user.nome_usuario = txt_gennameclass.Text;
            user.username_usuario = txt_gennickclass.Text;
            user.senha_usuario = txt_genpassclass.Text;
            user.status_usuario = cmb_genstateclass.Text;
            user.nivel_usuario = Convert.ToInt32(Math.Round(nud_genlevelclass.Value, 0));

            Banco.AtualizarUsuario(user);

            dgv_class[1, linha].Value = txt_gennameclass.Text;
        }

        private void btn_gennew_Click(object sender, EventArgs e)
        {
            F_newuser f_newuser = new F_newuser();
            f_newuser.ShowDialog();
            dgv_class.DataSource = Banco.ObterUserID();
        }

        private void btn_generase_Click(object sender, EventArgs e)
        {
            DialogResult resposta = MessageBox.Show("Confirmar Exclusão?", "Excluir Usuário", MessageBoxButtons.YesNo);

            if (resposta == DialogResult.Yes)
            {
                Banco.RemoverUsuario(txt_genidclass.Text);
                dgv_class.Rows.Remove(dgv_class.CurrentRow);

                txt_gennameclass.Text = "";
                txt_gennickclass.Text = "";
                txt_genpassclass.Text = "";
                cmb_genstateclass.Text = "";
                nud_genlevelclass.Text = "";
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
                dt = Banco.ObterDadosPorId(userId);

                txt_genidclass.Text = dt.Rows[0].Field<Int64>("id_usuario").ToString();
                txt_gennameclass.Text = dt.Rows[0].Field<string>("nome_usuario").ToString();
                txt_gennickclass.Text = dt.Rows[0].Field<string>("username_usuario").ToString();
                txt_genpassclass.Text = dt.Rows[0].Field<string>("senha_usuario").ToString();
                cmb_genstateclass.Text = dt.Rows[0].Field<string>("status_usuario").ToString();
                nud_genlevelclass.Text = dt.Rows[0].Field<Int64>("nivel_usuario").ToString();
            }
        }

        private void F_genclass_Load(object sender, EventArgs e)
        {
            dgv_class.DataSource = Banco.ObterUserID();

            dgv_class.Columns[0].Width = 40;
            dgv_class.Columns[1].Width = 180;
        }

        private void btn_genclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}