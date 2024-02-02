using ListaAlunos.Models;
using Newtonsoft.Json;
using System.Text.Json.Nodes;
using ListaAlunos;

Console.WriteLine("--------------------------------------------------------------------------------");
Console.WriteLine("Lendo informações do arquivo json e mostrando situação do aluno");
Console.WriteLine("Desserializando...");
Console.WriteLine("--------------------------------------------------------------------------------");


string caminho = "Arquivos\\Notas.json";

List<Aluno> alunos = new List<Aluno>();
try
{
    string Notas = File.ReadAllText(caminho);

    alunos = JsonConvert.DeserializeObject<List<Aluno>>(Notas);

    foreach (var aluno in alunos)
    {
        aluno.ListarAluno(aluno);
    }

}
catch (Exception ex)
{
    Console.WriteLine("Houve uma exceção: " + ex.Message);
}
finally
{

    Console.WriteLine("--------------------------------------------------------------------------------");
    Console.WriteLine("----Fim do programa----");
    Console.WriteLine("---Pressione ENTER para encerrar---");
    Console.WriteLine("--------------------------------------------------------------------------------");
    Console.ReadLine();
}