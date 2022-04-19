using CRUDWithEntityHW.Entities;
using CRUDWithEntityHW.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUDWithEntityHW.Controllers
{
    public class AdminController : Controller
    {

        private IRepository _repository;

        public AdminController(IRepository repository)
        {
            _repository = repository;
        }

        public IActionResult Index()
        {
            return View(_repository.GetAll());
        }

        [HttpGet]
        public IActionResult Create()
        {

            return View();
        }


        [HttpPost]
        public IActionResult Create(Admin admin)
        {
            _repository.Add(admin);
            return Redirect("Index");
        }
    }
}
