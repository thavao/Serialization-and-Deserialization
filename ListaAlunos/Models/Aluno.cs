using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaAlunos.Models
{
    internal class Aluno
    {
        [JsonProperty("nome")]
        public string Nome { get; set; }

        [JsonProperty("turma")]
        public string Turma { get; set; }

        [JsonProperty("media")]
        public double Media { get; set; }

        public bool Aprovado { get; set; }

        public void ListarAluno(Aluno aluno)
        {

            this.Nome = aluno.Nome;
            this.Turma = aluno.Turma;
            this.Media = aluno.Media;
            if (aluno.Media >= 7)
            {
                this.Aprovado = true;
            }
            else
            {
                this.Aprovado = false;
            }
            ListarSituacaoAlunos();
        }
        public void ListarSituacaoAlunos()
        {
            Console.WriteLine($"Nome: {this.Nome} | Turma: {this.Turma} | Média: {this.Media}| Situação: {(this.Aprovado ? "Aprovado [V]" : "Reprovado [X]")}");

        }
    }
}
