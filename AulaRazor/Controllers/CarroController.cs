using AulaRazor.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace AulaRazor.Controllers
{
    public class CarroController : Controller
    {
        //Lista estática para armazenar os carros
        private static List<Carro> _lista = new List<Carro>();

        public IActionResult Index()
        {
            //Ajustar o Index para exibir todos os carros da lista 
            //em uma tabela HTMl
            //Enviar a lista de carros para a view
            //ViewBag.acai = _lista;
            //Criar a view e tabela html com os dados
            return View(_lista);
        }

        [HttpGet]  //Retorna a view com o formulário
        public IActionResult Cadastrar()
        {
            //Criar uma lista de string com fabricantes
            var lista = new List<string>(new string[] {"Nissan", "Toyota", "Ford", "FIAT", "Honda", "Caoa", "Chevrolet"});
            //Enviar o SelectList para a view criar as options do select
            ViewBag.fabricantes = new SelectList(lista, "Fabricante");

            return View();
        }
        
        [HttpPost] //Receber os valores do formulário HTML
        public IActionResult Cadastrar(Carro carro)
        {
            //Adicionar o carro na lista
            _lista.Add(carro);
            //Exibir mensagem de sucesso
            ViewData["churros"] = "Carro cadastrado!";
            return View();
        }
    }
}
