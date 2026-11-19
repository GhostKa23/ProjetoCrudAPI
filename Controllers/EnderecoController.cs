using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;


namespace ProjetoCrudAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EnderecoController : ControllerBase
    {
        private readonly DataContext _context;

        public EnderecoController(DataContext context)
        {
            _context = context;
        }

    [HttpPost]
    public IActionResult Cadastrar(Endereco novoEndereco)
    {
        // Validação simples
        if (string.IsNullOrWhiteSpace(novoEndereco.Cep) || 
            string.IsNullOrWhiteSpace(novoEndereco.Rua) || 
            string.IsNullOrWhiteSpace(novoEndereco.Cidade))
        {
            return BadRequest(new { erro = "Os campos CEP, Rua e Cidade são obrigatórios." });
        }

        // Atribuindo um ID simulado
        novoEndereco.Id = _enderecos.Count + 1;
        _enderecos.Add(novoEndereco);

        // Retorna status 201 Created com o objeto criado
        return CreatedAtAction(nameof(Cadastrar), new { id = novoEndereco.Id }, new {
            mensagem = "Endereço cadastrado com sucesso!",
            endereco = novoEndereco
        });
    }
            }
}