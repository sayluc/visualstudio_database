using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    internal class Turma
    {
        // Conforme temos registrado no BancoDeDados
        public Int32 id_turma = 0;
        public Int32 id_curso = 0;
        public Int32 id_horario_turma = 0;
        public Int32 id_prof_turma = 0;
        public Int32 max_alunos_turma = 0;
        public string status_turma = "";
    }
}