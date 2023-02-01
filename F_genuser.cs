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
    public partial class F_genuser : Form
    {
        // F_escola f_genuser;
        // DataTable dt = new DataTable();

        public F_genuser(F_escola f)
        {
            InitializeComponent();
            // f_genuser = f;
        }

        private void btn_genclean_Click(object sender, EventArgs e)
        {
            txt_genname.Text = "";
            txt_gennick.Text = "";
            txt_genpass.Text = "";
            cmb_genstate.Text = "";
            nud_genlevel.Text = "";
            txt_genid.Text = "";
        }
        
        private void btn_genupdate_Click(object sender, EventArgs e)
        {
            int linha = dgv_user.SelectedRows[0].Index;

            Usuario user = new Usuario();
            user.id_usuario = Convert.ToInt32(txt_genid.Text);
            user.nome_usuario = txt_genname.Text;
            user.username_usuario = txt_gennick.Text;
            user.senha_usuario = txt_genpass.Text;
            user.status_usuario = cmb_genstate.Text;
            user.nivel_usuario = Convert.ToInt32(Math.Round(nud_genlevel.Value, 0));

            Banco.AtualizarUsuario(user);

            dgv_user[1, linha].Value = txt_genname.Text;
        }

        private void btn_gennew_Click(object sender, EventArgs e)
        {
            F_newuser f_newuser = new F_newuser();
            f_newuser.ShowDialog();
            dgv_user.DataSource = Banco.ObterUserID();
        }
        
        private void btn_generase_Click(object sender, EventArgs e)
        {
            DialogResult resposta = MessageBox.Show("Confirmar Exclusão?", "Excluir Usuário", MessageBoxButtons.YesNo);

            if (resposta == DialogResult.Yes)
            {
                Banco.RemoverUsuario(txt_genid.Text);
                dgv_user.Rows.Remove(dgv_user.CurrentRow);

                txt_genname.Text = "";
                txt_gennick.Text = "";
                txt_genpass.Text = "";
                cmb_genstate.Text = "";
                nud_genlevel.Text = "";
                txt_genid.Text = "";
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

                txt_genid.Text = dt.Rows[0].Field<Int64>("id_usuario").ToString();
                txt_genname.Text = dt.Rows[0].Field<string>("nome_usuario").ToString();
                txt_gennick.Text = dt.Rows[0].Field<string>("username_usuario").ToString();
                txt_genpass.Text = dt.Rows[0].Field<string>("senha_usuario").ToString();
                cmb_genstate.Text = dt.Rows[0].Field<string>("status_usuario").ToString();
                nud_genlevel.Text = dt.Rows[0].Field<Int64>("nivel_usuario").ToString();
            }
        }

        private void F_genuser_Load_1(object sender, EventArgs e)
        {
            dgv_user.DataSource = Banco.ObterUserID();

            dgv_user.Columns[0].Width = 40;
            dgv_user.Columns[1].Width = 180;
        }

        private void btn_genclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
