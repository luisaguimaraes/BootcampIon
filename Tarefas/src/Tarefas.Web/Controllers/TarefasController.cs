using Microsoft.AspNetCore.Mvc;
using Tarefas.Web.Models;

namespace Tarefas.Web.Controllers;

public class TarefasController : Controller
{
    public IActionResult Create()
    {
        return View();
    }

    public IActionResult Index()
    {
        var listaDeTarefas = new List<TarefaViewModel>()
        {
            new TarefaViewModel(){ Titulo = "Escovar os dentes" , Descricao = "Lembrar de usar o Listerine" },
            new TarefaViewModel(){ Titulo = "Arrumar a cama" , Descricao = "Alinhar o lençol de elástico"},
            new TarefaViewModel(){ Titulo = "Por o lixo pra fora" , Descricao = "Somente às terças, quintas e sábados."}
        };

        return View(listaDeTarefas);
    }
}