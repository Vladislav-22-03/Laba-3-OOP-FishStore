﻿using Laba_3_OOP_FishStore.Features.DtoModels.Login;
using Laba_3_OOP_FishStore.Features.Interfaces.Managers;
using Microsoft.AspNetCore.Mvc;

namespace Laba_3_OOP_FishStore.Controllers
{
    [Route(Log)]
    public class LoginController : Controller
    {
        private readonly IUserManager userManager;
        public const string Log = "Login";

        public LoginController(IUserManager _userManager)
        {
            userManager = _userManager;
        }

        //Прописал, чтобы адекватно выводил вид
        [HttpGet(nameof(Login), Name = nameof(Login))]
        public async Task<ActionResult> Login()
        {
            return View();
        }


        //Метод поискка пользователя по его email
        [HttpPost(nameof(FindUserAsync), Name = nameof(FindUserAsync))]
        public async Task<ActionResult> FindUserAsync(LoginModel LogMod)
        {
            if (!ModelState.IsValid)
                return View(nameof(Log), LogMod);
            try
            {
                var user = await userManager.GetUserByMail(LogMod.Mail);
                if (user == null) throw new Exception("Пользователь не найден");
                if (user.Password != LogMod.Password) throw new Exception("Неверный пароль");
                //return RedirectToAction(nameof(ManageController.Sales), "Manage", new { usId = user.IsnNode});
                //return RedirectToAction(nameof(UserMenuController.Menu), "UserMenu", new { usId = user.IsnNode, name = user.Name, surname = user.Surname });

                return RedirectToAction("Success", "Donation");
            }
            catch (Exception ex)
            {
                ModelState.AddModelError(string.Empty, ex.Message);
                return View(nameof(Login), LogMod);
            }
        }


    }

}
