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
    public partial class F_newclass : Form
    {
        F_escola f_newclass;
        DataTable dt = new DataTable();
        public F_newclass(F_escola f)
        {
            InitializeComponent();
            f_newclass = f;
        }

        private void btn_classclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_classclean_Click(object sender, EventArgs e)
        {
            txt_nameclass.Clear();
            txt_areaclass.Clear();
            txt_stateclass.Clear();
        }

        private void btn_classave_Click(object sender, EventArgs e)
        {
            Curso curso = new Curso();

            curso.nome_curso = txt_nameclass.Text;
            curso.area_curso = txt_areaclass.Text;
            curso.status_curso = txt_stateclass.Text;

            Banco.NovoCurso(curso);
        }       
    }
}