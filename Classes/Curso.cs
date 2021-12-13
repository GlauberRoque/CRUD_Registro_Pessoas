using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Desafio1.Classes
{
    class Curso : Aluno
    {
        public int Id { get; set; }
        public string CursoNome { get; set; }

        public void ApresentarDadosCurso()
        {
            Console.WriteLine($"Y - {Matricula} - {Id} - {NomeCurso}");
        }


    }
}
