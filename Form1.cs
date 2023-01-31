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
    public partial class F_escola : Form
    {
        public F_escola()
        {
            InitializeComponent();
            F_login f_login = new F_login(this);
            f_login.ShowDialog();
        }

        private void logonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_login f_login = new F_login(this);
            f_login.ShowDialog();
        }

        private void novoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Globais.nivel >= 3)
            {
                F_newuser f_newuser = new F_newuser();
                f_newuser.ShowDialog();
            }
            else
            {
                MessageBox.Show("Nivel de acesso baixo, permissão negada!");
            }       
        }

        private void novoCursoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_newclass f_newclass = new F_newclass(this);
            f_newclass.ShowDialog();
        }

        private void novoToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            F_aluno f_aluno = new F_aluno(this);
            f_aluno.ShowDialog();
        }

        private void cadastrarProfessorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_newteacher f_newteacher = new F_newteacher(this);
            f_newteacher.ShowDialog();
        }

        private void gerenciamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_genuser f_genuser = new F_genuser(this);
            f_genuser.ShowDialog();
        }
    }
}
