using Microsoft.AspNetCore.Mvc;

namespace RafaePassos.Controllers
{
    public class BaseController : Controller
    {
        public string MensagemErro
        {
            get => TempData["Erro"].ToString();
            set => TempData["Erro"] = value;
        }

        public string MensagemAtencao
        {
            get => TempData["Atencao"].ToString();
            set => TempData["Atencao"] = value;
        }

        public string MensagemSucesso
        {
            get => TempData["Sucesso"].ToString();
            set => TempData["Sucesso"] = value;
        }

        public string MensagemInformacao
        {
            get => TempData["Informacao"].ToString();
            set => TempData["Informacao"] = value;
        }
    }
}
