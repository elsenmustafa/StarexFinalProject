using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StarexFinal.Data;
using StarexFinalProject.Contexts;
using StarexFinalProject.Interfaces;
using StarexFinalProject.ViewModel;

namespace StarexFinalProject.Controllers
{
    public class DeclarationController : Controller
    {
        private readonly IDeclarationsStatusRepository declarationsStatus;
        private readonly IDeclarationRepository declarationRepository;
        private readonly StarexDbContext context;
       
        public DeclarationController(IDeclarationRepository _declarationRepository,
            StarexDbContext context, IDeclarationsStatusRepository _declarationsStatus)
        {
            declarationRepository = _declarationRepository;
            declarationsStatus = _declarationsStatus;
            this.context = context;
        }
        public IActionResult Create()
        {
            ViewBag.data = declarationsStatus.GetAll();


            return View();
        }
        [HttpPost]
        public IActionResult Create(DeclarationViewModel declarationViewModel)
        {
            var userId = HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier);
            //var warehouseId = context.Users.FirstOrDefault(x => x.Id == userId).WarehouseId;

            if (ModelState.IsValid)
            {
                Declarations declarations = new Declarations()
                {
                    UserId=userId,
                    CountryId=2,
                    TrackingCode="qwerty",
                    Warehouse_Id= declarationViewModel.Warehouse_Id,
                    Shop =declarationViewModel.Shop,
                    OrderNumber=declarationViewModel.OrderNumber,
                    ProductPrice=declarationViewModel.ProductPrice,
                    DeliveryCode = declarationViewModel.DeliveryCode,
                    ProductType=declarationViewModel.ProductType,
                    Comment=declarationViewModel.Comment,
                    FileName=declarationViewModel.FileName,
                    Quantity=declarationViewModel.Quantity,
                    DeclarationDate=DateTime.Now,
                };
                var result = declarationRepository.Add(declarations);

                if (result == true)
                {
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Emeliyyat ugursuzdur!");
                }
            }

            return View(declarationViewModel);
        }
    }
}
