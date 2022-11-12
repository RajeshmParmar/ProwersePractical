using AutoMotiveDB.Models;
using AutoMotiveWorkshop.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoMotiveWorkshop.Controllers
{
    public class CustomerController : Controller
    {
        // GET: CustomerController
        public ActionResult Index()
        {
            List<CustomerViewModel> cvm = new();
            var context = new AutoMotiveWorkshopContext();

            var customers = context.Customers.ToList();
            foreach (var item in customers)
            {
                cvm.Add(new CustomerViewModel() { CustomerId = item.CustomerId, Name = item.Name, Address = item.Address,PhoneNo = item.PhoneNo });
            }
            return View(cvm);
        }

        // GET: CustomerController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CustomerController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CustomerController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CustomerController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CustomerController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
        public ActionResult Search(int id)
        {
            List<VehicleViewModel> vehicleViews = new();
            var context = new AutoMotiveWorkshopContext();

            var vehicles = context.Vehicles.Where(s => s.CustomerId == id).ToList();
            foreach (var item in vehicles)
            {
                vehicleViews.Add(new VehicleViewModel() { Id = item.Id, ModelName = item.ModelName, Number = item.Number, ServiceDueDate = item.ServiceDueDate });
            }
            return View(vehicleViews);
        }
        public ActionResult Vehicles(int id)
        {
            List<VehicleViewModel> vehicleViews = new();
            var context = new AutoMotiveWorkshopContext();

            var vehicles = context.Vehicles.Where(s => s.CustomerId == id).ToList();
            foreach (var item in vehicles)
            {
                vehicleViews.Add(new VehicleViewModel() { Id = item.Id,ModelName = item.ModelName, Number = item.Number, ServiceDueDate = item.ServiceDueDate });
            }
            return View(vehicleViews);
        }

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        public ActionResult Service(int id)
        {
            try
            {

                var context = new AutoMotiveWorkshopContext();
                var vehicle = context.Vehicles.Where(s => s.Id == id).SingleOrDefault();

                Service service = new Service();

                service.ServiceDate = vehicle.ServiceDueDate;
                service.VehicleId = id;
                context.Services.Add(service);

                vehicle.ServiceDueDate = vehicle.ServiceDueDate.Value.AddMonths(3);
                context.SaveChanges();


                return RedirectToAction("Vehicles", new {id = vehicle.CustomerId});
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message + Environment.NewLine + ex.StackTrace);
                return View();
            }
        }
        
    }
}
