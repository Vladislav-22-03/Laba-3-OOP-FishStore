using Laba_3_OOP_FishStore.Features.DtoModels.User;
using Laba_3_OOP_FishStore.Features.Interfaces.Managers;
using Microsoft.AspNetCore.Mvc;

namespace Laba_3_OOP_FishStore.Controllers
{
    [Route("Registration")]
    public class RegistrationController : Controller
    {
        private readonly IUserManager userManager;

        public RegistrationController(IUserManager userManager)
        {
            this.userManager = userManager;
        }


        [HttpGet, Route("Register")]
        public async Task<ActionResult> Register()
        {
            return View();
        }

        [HttpPost(nameof(CreateRegister), Name = "CreateRegister")]
        public async Task<ActionResult> CreateRegister(EditUser model)
        {
            if (ModelState.IsValid)
            {

                // Добавление пользователя в контекст данных и сохранение его в базе данных
                try
                {
                    var _model = new EditUser
                    {
                        IsnNode = model.IsnNode == Guid.Empty ? Guid.NewGuid() : model.IsnNode,
                        SurName = model.SurName,
                        Name = model.Name,
                        Mail = model.Mail,
                        Password = model.Password,
                    };
                    userManager.Create(_model);


                    return RedirectToAction("Index", "Home");
                }
                catch (Exception ex)
                {
                    // Пример редиректа на главную страницу после регистрации
                    return RedirectToAction("Index", "Home");
                }

            }

            // Если валидация модели не удалась, вернуть представление с ошибками
            return View(nameof(Register), model);
        }
    }
}
