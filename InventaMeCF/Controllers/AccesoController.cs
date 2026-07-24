using InventaMeCF.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

namespace InventaMeCF.Controllers
{
    public class AccesoController : Controller
    {
        private readonly InventaMeCFContext _context;

        public AccesoController(InventaMeCFContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(InfoLogin infoLogin)
        {


            if (infoLogin != null)
            {
                //string sql = String.Format("select Id, Login, Password from Usuarios a where Login='{0}' and convert(varchar(256), DecryptByPassPhrase('osni',a.Password)) = '{1}'", infoLogin.Login, infoLogin.Password);
                //Usuario? usuario = _context.Usuarios.FromSqlRaw(sql).FirstOrDefault<Usuario>();
                string? usuario = "moises";
                if (usuario != null)
                {
                    var claims = new List<Claim> {
                        new Claim(ClaimTypes.Name,"moises"), // usuario.Login
                        new Claim("Otro","otro dato")
                    };
                    /*
                    List<Role> lista = (from rls in _context.Roles
                                        join rlsa in _context.RolesAsignados
                                        on rls.Id equals rlsa.IdRol
                                        where rlsa.IdUsuario == usuario.Id
                                        select rls).ToList();
                    */
                    List<string> lista = new List<string>();
                    foreach (string rol in lista)
                    {
                        claims.Add(new Claim(ClaimTypes.Role, "administrador")); // rol.Nombre
                    }
                    var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);

                    await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(claimsIdentity));

                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    return View();
                }
            }
            else
            {
                return View();
            }
        }
        public async Task<IActionResult> Salir()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Index", "Acceso");
        }
    }
}

