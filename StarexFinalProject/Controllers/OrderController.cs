using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StarexFinal.Data;
using StarexFinalProject.Contexts;
using StarexFinalProject.Interfaces;
using StarexFinalProject.ViewModel;

namespace StarexFinalProject.Controllers
{
    public class OrderController: Controller
    {
        private readonly IOrderRepository orderRepository;
        public OrderController(IOrderRepository _orderRepository)
        {
            orderRepository = _orderRepository;
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public  IActionResult Create (OrderViewModel orderViewModel)
        {
            var userId = HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier);
            if (ModelState.IsValid)
            {
                Orders orders = new Orders()
                {
                    Url = orderViewModel.Url,
                    Quantity = orderViewModel.Quantity,
                    Cargo_Price = orderViewModel.Cargo_Price,
                    Color = orderViewModel.ProductColor,
                    Comment = orderViewModel.Comment,
                    CountryId = orderViewModel.CountryId,
                    CreatTime =DateTime.Now,
                    ProductPrice = orderViewModel.ProductPrice,
                    ProductSize = orderViewModel.ProductSize,
                    Total_Price = orderViewModel.Total_Price,
                    TrackingCode = orderViewModel.TrackingCode,
                    StatusId=orderViewModel.StatusId,
                    UserId=userId,
                };
                var result = orderRepository.Add(orders);

                if (result==true)
                {
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Emeliyyat ugursuzdur!");
                }
            }
            return View(orderViewModel);
        }


    }
}
