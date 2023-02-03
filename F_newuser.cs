using System;
using System.Data;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class F_newuser : Form
    {
        public F_newuser()
        {
            InitializeComponent();
        }

        private void bt_closeuser_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_cleanuser_Click(object sender, EventArgs e)
        {
            txt_name.Clear();
            txt_nick.Clear();
            txt_pass.Clear();
            cmb_state.Items.Clear();
            nud_level.Value = 0;
        }

        private void bt_saveuser_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();

            usuario.nome_usuario = txt_name.Text;
            usuario.username_usuario = txt_nick.Text;
            usuario.senha_usuario = txt_pass.Text;
            usuario.status_usuario = cmb_state.Text;
            usuario.nivel_usuario = Convert.ToInt32(Math.Round(nud_level.Value, 0));
            Banco.NovoUser(usuario);

            Banco.NovoUser(usuario);
        }

        private void cmb_state_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}