using GeraListaVendas.Models;
using Newtonsoft.Json;

Console.WriteLine("--------------------------------------------------------------------------------");
Console.WriteLine("Criando uma arquivo json com as informações da lista em C#");
Console.WriteLine("Serializando...");
Console.WriteLine("--------------------------------------------------------------------------------");

List<Venda> vendas = new List<Venda>();

#region Populando a lista;
vendas.Add(new Venda { Codigo = 1, NomeProduto = "Camiseta", Valor = 25.99m, DateCompra = DateTime.Now.AddDays(-5) });
vendas.Add(new Venda { Codigo = 2, NomeProduto = "Notebook", Valor = 1299.99m, DateCompra = DateTime.Now.AddDays(-3) });
vendas.Add(new Venda { Codigo = 3, NomeProduto = "Livro", Valor = 15.50m, DateCompra = DateTime.Now.AddDays(-1) });
vendas.Add(new Venda { Codigo = 4, NomeProduto = "Cadeira", Valor = 89.99m, DateCompra = DateTime.Now.AddDays(-7) });
vendas.Add(new Venda { Codigo = 5, NomeProduto = "Mouse", Valor = 12.50m, DateCompra = DateTime.Now.AddDays(-10) });
vendas.Add(new Venda { Codigo = 6, NomeProduto = "Teclado", Valor = 34.99m, DateCompra = DateTime.Now.AddDays(-15) });
vendas.Add(new Venda { Codigo = 7, NomeProduto = "Celular", Valor = 599.99m, DateCompra = DateTime.Now.AddDays(-2) });
vendas.Add(new Venda { Codigo = 8, NomeProduto = "Monitor", Valor = 199.99m, DateCompra = DateTime.Now.AddDays(-6) });
vendas.Add(new Venda { Codigo = 9, NomeProduto = "Fone de Ouvido", Valor = 49.99m, DateCompra = DateTime.Now.AddDays(-8) });
vendas.Add(new Venda { Codigo = 10, NomeProduto = "Mesa", Valor = 129.99m, DateCompra = DateTime.Now.AddDays(-12) });
vendas.Add(new Venda { Codigo = 11, NomeProduto = "Impressora", Valor = 179.99m, DateCompra = DateTime.Now.AddDays(-4) });
vendas.Add(new Venda { Codigo = 12, NomeProduto = "Chinelo", Valor = 9.99m, DateCompra = DateTime.Now.AddDays(-9) });
vendas.Add(new Venda { Codigo = 13, NomeProduto = "Câmera", Valor = 299.99m, DateCompra = DateTime.Now.AddDays(-11) });
vendas.Add(new Venda { Codigo = 14, NomeProduto = "Headset", Valor = 69.99m, DateCompra = DateTime.Now.AddDays(-14) });
vendas.Add(new Venda { Codigo = 15, NomeProduto = "Smartwatch", Valor = 119.99m, DateCompra = DateTime.Now.AddDays(-13) });
vendas.Add(new Venda { Codigo = 16, NomeProduto = "Mochila", Valor = 39.99m, DateCompra = DateTime.Now.AddDays(-16) });
vendas.Add(new Venda { Codigo = 17, NomeProduto = "Tablet", Valor = 199.99m, DateCompra = DateTime.Now.AddDays(-18) });
vendas.Add(new Venda { Codigo = 18, NomeProduto = "Bolsa", Valor = 29.99m, DateCompra = DateTime.Now.AddDays(-20) });
vendas.Add(new Venda { Codigo = 19, NomeProduto = "Carregador", Valor = 14.99m, DateCompra = DateTime.Now.AddDays(-17) });
vendas.Add(new Venda { Codigo = 20, NomeProduto = "Ventilador", Valor = 79.99m, DateCompra = DateTime.Now.AddDays(-19) });
#endregion

string caminho = "Arquivos\\Vendas.json";

try { 
string serialize = JsonConvert.SerializeObject(vendas, Formatting.Indented);

File.WriteAllText(caminho, serialize);

Console.WriteLine(serialize);
}
catch(Exception ex)
{
    Console.WriteLine("Ocorreu uma exceção: " + ex.Message);
}
finally
{
    Console.WriteLine("--------------------------------------------------------------------------------");
    Console.WriteLine("----Fim do programa----");
    Console.WriteLine("---Pressione ENTER para encerrar---");
    Console.WriteLine("--------------------------------------------------------------------------------");
    Console.ReadLine();
    
}