using System;
using Microsoft.AspNetCore.Mvc;
using Sem_4_Programita_1x2.Models;
namespace Sem_4_Programita_1x2.Controllers{
    public class HomeController:Controller{

        private readonly DatabaseContext _context;

        public HomeController(DatabaseContext context)
        {
            _context = context;
        }
        public IActionResult Index(){
            return View();
        }
        [HttpPost]
        public IActionResult Calculo(Factura objF){
            objF.invoice=(new Random()).Next(2019200001, 2019299999);
            if(objF.producto.Equals("P1")){
                objF.precio=100;
            }else if(objF.producto.Equals("P2")){
                objF.precio=200;
            }else{
                objF.precio=300;
            }objF.subtotal=objF.precio*objF.cantidad;
            objF.total=1.18*objF.subtotal;
            objF.fecha=DateTime.Now;
            return View(objF);
        }
    }
}