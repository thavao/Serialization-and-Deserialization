# Projeto de Estudo
## Serialization and Deserialization
## **O que é serialização ?**

"A Serialização, como implementada no namespace  **System.Runtime.Serialization**, é o processo de serializar e desserializar objetos de modo que eles possam ser armazenados ou transferidos e depois recriados. Temos assim que:

-   A  **Serialização**  é o processo de converter um objeto em uma sequência linear de bytes que podem ser armazenados ou transferidos;
-   A  **Desserialização**  é o processo de conversão de uma sequência previamente serializada de bytes em um objeto;

Então se você quiser armazenar um objeto  _(ou vários objetos)_  em um arquivo para posterior recuperação, você armazena a saída da serialização, e, na próxima vez que você quiser ler os objetos, você chama os métodos da desserialização, e seu objeto é recriado exatamente como anteriormente." - [José Carlos Macoratti](http://www.macoratti.net/)

## Pacotes Utilizados:

 [Newtonsoft.Json](https://www.nuget.org/packages/Newtonsoft.Json)
## Motivo:
Este é um projeto que fiz única e exclusivamente para por em prática conteúdos que vi nas aulas do curso "Explorando a linguagem C#" da [DIO](https://web.dio.me/home)
## Projetos:
A Solução tem dois projetos: **GeraListaVendas** e **ListaAlunos**

**GeraListaVendas**: Usei o **ChatGPT** para gerar uma lista de vendas fictícias em C#. O programa **Serializa** esses dados em um único arquivo **Json** e mostra o conteúdo do arquivo.

**ListaAlunos**: Usei o **ChatGPT** para gerar um **Json** com dados de alunos fictícios. O programa **Desserializa** esses dados em **Objetos C#**, depois lê as médias dos alunos define se foram aprovados ou não e mostra esses dados na tela.

## Como utilizar ?

 1. Baixe os arquivos do projeto
 2. Vá até a pasta do projeto que deseja rodar
 3. Acesse a pasta "Executavel"
 4. Execute o arquivo .exe (executavel)

## Tecnologias usadas
- C# com .NET 7
- Visual Studio Community 2022
- ChatGPT
