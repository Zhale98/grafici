using grafici.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Smeni.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Smeni.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            List<Grafici> Model;
            Model = new List<Grafici>()
        {
            new Grafici()
            { Id =1,Nomer="I", Ot=new DateTime(2021, 06, 15), Do = new DateTime(2021, 06, 24) },
            new Grafici()
            { Id =2,Nomer="II", Ot = new DateTime(2021, 06, 26),Do = new DateTime(2021, 07, 05) },
            new Grafici()
            { Id =3,Nomer="III", Ot = new DateTime(2021, 07, 07),Do = new DateTime(2021, 07, 16)},
            new Grafici()
            { Id =4,Nomer="IV", Ot = new DateTime(2021, 07, 18),Do = new DateTime(2021, 07, 27)},
            new Grafici()
            { Id =5,Nomer="V", Ot = new DateTime(2021, 07, 29),Do = new DateTime(2021, 08, 07) },
            new Grafici()
            { Id =6,Nomer="VI", Ot = new DateTime(2021, 08, 09),Do = new DateTime(2021, 08, 18) },
             new Grafici()
            { Id =7,Nomer="VII", Ot = new DateTime(2021, 08, 20),Do = new DateTime(2021, 08, 29) },
              new Grafici()
            { Id =8,Nomer="VIII", Ot = new DateTime(2021, 08, 31),Do = new DateTime(2021, 09, 09) },
        };
        
       
            return View(Model);
        }
    }
}