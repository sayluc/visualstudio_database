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

        private void gerenciamentoUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_genuser f_genuser = new F_genuser();
            f_genuser.ShowDialog();
        }

        private void gerenciamentoAlunosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_genstudent f_genstudent = new F_genstudent();
            f_genstudent.ShowDialog();
        }

        private void gerenciamentoProfessoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_genteacher f_genuser = new F_genteacher();
            f_genuser.ShowDialog();
        }

        private void gerenciamentoCursosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_genclass f_genuser = new F_genclass();
            f_genuser.ShowDialog();
        }

        private void novoUsuario_Click(object sender, EventArgs e)
        {
            if (Globais.nivel >= 3)
            {
                F_newuser f_newuser = new F_newuser();
                f_newuser.ShowDialog();
            }
            else
            {
                MessageBox.Show("Nivel de acesso baixo, permissão negada");
            }
        }

        private void novoAluno_Click(object sender, EventArgs e)
        {
            if (Globais.nivel >= 3)
            {
                F_newstudent f_newstudent = new F_newstudent();
                f_newstudent.ShowDialog();
            }
            else
            {
                MessageBox.Show("Nivel de acesso baixo, permissão negada");
            }
        }

        private void novoProfessor_Click(object sender, EventArgs e)
        {
            if (Globais.nivel >= 3)
            {
                F_newteacher f_newteacher = new F_newteacher();
                f_newteacher.ShowDialog();
            }
            else
            {
                MessageBox.Show("Nivel de acesso baixo, permissão negada");
            }
        }

        private void novoCurso_Click(object sender, EventArgs e)
        {
            if (Globais.nivel >= 3)
            {
                F_newclass f_newclass = new F_newclass();
                f_newclass.ShowDialog();
            }
            else
            {
                MessageBox.Show("Nivel de acesso baixo, permissão negada");
            }  
        }

        private void logoffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que desaja sair? ", "Sair", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                lb_nivel.Text = "--"; 
                lb_user.Text = "--"; 
                pb_login.Image = Properties.Resources.bamarela; Globais.nivel = 0;
                Globais.logado = false;
            }
        }

        private void aToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_classroom f_Classroom = new F_classroom();
            f_Classroom.ShowDialog();
        }

        private void F_escola_Load(object sender, EventArgs e)
        {

        }
    }
}