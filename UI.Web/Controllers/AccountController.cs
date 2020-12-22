using DDD.Domain.Interfaces.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UI.Web.Util;
using UI.Web.ViewModels;

namespace UI.Web.Controllers
{
    public class AccountController : Controller
    {

        private readonly IServicoDeUsuarioDomain _servicoDoUsuarioDomain;

        public AccountController(IServicoDeUsuarioDomain servicoDeUsuarioDomain)
        {
            _servicoDoUsuarioDomain = servicoDeUsuarioDomain;
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(LoginViewModel viewModel)
        {
            if (!ModelState.IsValid)
                return View(viewModel);

            var usuario = _servicoDoUsuarioDomain.LogarUsuario(viewModel.Email, viewModel.Password);

            if (usuario == null)
            {
                ModelState.AddModelError("", "Email ou Senha incorretos");
                return View(viewModel);
            }

            SessionManager.UsuarioLogado = usuario;

            return RedirectToAction("Index", "Home");
        }

        public ActionResult Logoff()
        {
            Session.Abandon();
            Session.RemoveAll();
            return RedirectToAction("Index", "Home");
        }
    }
}