using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using SPAAngularExample.Models.Clientes;
using SPAAngularExample.Models.Produtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SPAAngularExample.Models.Cadastros
{
    public class CadastroFactory
    {
        public Cadastro BuildCadastro()
        {
            var cadastro = new Cadastro
            {
                Produtos = GetSerializedProdutos(),
                Clientes = GetSerializedClientes(),
            };
            return cadastro;
        }

        private string GetSerializedProdutos()
        {
            var produtos = new[]
            {
                new Produto { Codigo= "1L", Nome= "Larger", Descricao = "Cerveja Lager 600ML" },
                new Produto { Codigo= "2S", Nome= "Stout", Descricao = "Cerveja STOUT 250ml" },
                new Produto { Codigo= "3I", Nome= "IPA", Descricao = "Cerveja IPA 600ml" },
                new Produto { Codigo= "4F", Nome= "Fun Weiss", Descricao = "Cerveja Fun Weiss 600 Ml" },
                new Produto { Codigo= "5R", Nome= "Red Ale", Descricao = "Cerveja Red Ale 600 Ml" }
            };

            JsonSerializerSettings settings = new JsonSerializerSettings { ContractResolver = new CamelCasePropertyNamesContractResolver() };

            return JsonConvert.SerializeObject(produtos, Formatting.None, settings);
        }

        private string GetSerializedClientes()
        {
            var clientes = new[]
            {
                new Cliente { Codigo = "1", Nome= "Supermercado Esperança", Email = "esperanca@email.com" },
                new Cliente { Codigo = "2", Nome= "Supermercado da Economia", Email = "economia@email.com" },
                new Cliente { Codigo = "3", Nome= "Supermercado do Zé", Email = "doze@email.com" },
                new Cliente { Codigo = "4", Nome= "Supermercado Dia", Email = "dia@email.com" },
                new Cliente { Codigo = "5", Nome= "Supermercado Extra", Email = "extra@email.com" },
            };

            JsonSerializerSettings settings = new JsonSerializerSettings { ContractResolver = new CamelCasePropertyNamesContractResolver() };

            return JsonConvert.SerializeObject(clientes, Formatting.None, settings);
        }
    }
}