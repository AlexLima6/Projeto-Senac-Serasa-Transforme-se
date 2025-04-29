using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoIntegrador.DTO
{
    internal class ClientesDTO
    {
        public string idClientes { get; set; }

        public string Nome { get; set; }

        public string Email { get; set; }

        public string Senha { get; set; }

        public string Endereço { get; set; }

        public ClientesDTO(string idClientes, string nome, string email, string senha, string endereço)
        {
            this.idClientes = idClientes;
            Nome = nome;
            Email = email;
            Senha = senha;
            Endereço = endereço;
        }
    }
}
