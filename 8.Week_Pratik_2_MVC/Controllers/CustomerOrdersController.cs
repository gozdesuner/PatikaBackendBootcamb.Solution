using Microsoft.AspNetCore.Mvc;

namespace _8.Week_Pratik_2_MVC.Controllers
{
    public class CustomerOrdersController : Controller
    {
        public IActionResult Index()
        {
            var customer = new Customer
            {
                Id = 1,
                FirstName = "Gözde",
                LastName = "Süner",
                Email = "gözde@example.com"
            };
            var orders = new List<Order>
            {
                new Order { Id = 101, ProductName = "Laptop", Price = 1200.50m, Quantity = 1 },
                new Order { Id = 102, ProductName = "Smartphone", Price = 800.00m, Quantity = 2 },
                new Order { Id = 103, ProductName = "Headphones", Price = 150.75m, Quantity = 1 }
            };

            // ViewModel oluşturma
            var viewModel = new CustomerOrderViewModel
            {
                Customer = customer,
                Orders = orders
            };

            // View'e ViewModel gönderme
            return View(viewModel);
        }
    }
}


