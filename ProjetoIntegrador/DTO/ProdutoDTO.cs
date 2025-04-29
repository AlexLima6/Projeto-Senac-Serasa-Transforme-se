using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoIntegrador.DTO
{
   
    
    
    public class ProdutoDTO
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public decimal Valor { get; set; }

        public string urlImage { get; set; }

        public int idCategoria { get; set; }

        public string Categoria { get; set; }
        
        public string Descricao { get; set; }

        public ProdutoDTO(int id, string nome, decimal valor, string urlImage, int idCategoria, string categoria, string descricao)
        {
            Id = id;
            Nome = nome;
            Valor = valor;
            this.urlImage = urlImage;
            this.idCategoria = idCategoria;
            Categoria = categoria;
            Descricao = descricao;
        }
    
    
    }


    
}
