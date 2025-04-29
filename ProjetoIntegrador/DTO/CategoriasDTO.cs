
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoIntegrador.DTO
{
    internal class CategoriasDTO
    {
        public int id { get; set; }
        public string Nome { get; set; }

        public CategoriasDTO(int id, string nome)
        {
            this.id = id;
            Nome = nome;
        }
    }
}
