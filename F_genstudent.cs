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
            txt_genpassstudent.Text = "";
            cmb_genstatestudent.Text = "";
            nud_genlevelstudent.Text = "";
            txt_genidstudent.Text = "";
        }

        private void btn_genupdate_Click(object sender, EventArgs e)
        {
            int linha = dgv_student.SelectedRows[0].Index;

            Usuario user = new Usuario();
            user.id_usuario = Convert.ToInt32(txt_genidstudent.Text);
            user.nome_usuario = txt_gennamestudent.Text;
            user.username_usuario = txt_gennickstudent.Text;
            user.senha_usuario = txt_genpassstudent.Text;
            user.status_usuario = cmb_genstatestudent.Text;
            user.nivel_usuario = Convert.ToInt32(Math.Round(nud_genlevelstudent.Value, 0));

            Banco.AtualizarUsuario(user);

            dgv_student[1, linha].Value = txt_gennamestudent.Text;
        }

        private void btn_gennew_Click(object sender, EventArgs e)
        {
            F_newuser f_newuser = new F_newuser();
            f_newuser.ShowDialog();
            dgv_student.DataSource = Banco.ObterUserID();
        }

        private void btn_generase_Click(object sender, EventArgs e)
        {
            DialogResult resposta = MessageBox.Show("Confirmar Exclusão?", "Excluir Usuário", MessageBoxButtons.YesNo);

            if (resposta == DialogResult.Yes)
            {
                Banco.RemoverUsuario(txt_genidstudent.Text);
                dgv_student.Rows.Remove(dgv_student.CurrentRow);

                txt_gennamestudent.Text = "";
                txt_gennickstudent.Text = "";
                txt_genpassstudent.Text = "";
                cmb_genstatestudent.Text = "";
                nud_genlevelstudent.Text = "";
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
                dt = Banco.ObterDadosPorId(userId);

                txt_genidstudent.Text = dt.Rows[0].Field<Int64>("id_usuario").ToString();
                txt_gennamestudent.Text = dt.Rows[0].Field<string>("nome_usuario").ToString();
                txt_gennickstudent.Text = dt.Rows[0].Field<string>("username_usuario").ToString();
                txt_genpassstudent.Text = dt.Rows[0].Field<string>("senha_usuario").ToString();
                cmb_genstatestudent.Text = dt.Rows[0].Field<string>("status_usuario").ToString();
                nud_genlevelstudent.Text = dt.Rows[0].Field<Int64>("nivel_usuario").ToString();
            }
        }

        private void F_genstudent_Load(object sender, EventArgs e)
        {
            dgv_student.DataSource = Banco.ObterUserID();

            dgv_student.Columns[0].Width = 40;
            dgv_student.Columns[1].Width = 180;
        }

        private void btn_genclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}