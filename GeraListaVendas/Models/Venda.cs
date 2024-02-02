using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeraListaVendas.Models
{
    internal class Venda
    {
        public int Codigo { get; set; }
        public string NomeProduto { get; set; }
        public decimal Valor { get; set; }
        [JsonProperty("DataCompra")]
        public DateTime DateCompra { get; set; }
    }
}
