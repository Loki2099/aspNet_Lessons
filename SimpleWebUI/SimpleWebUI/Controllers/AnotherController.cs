using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SimpleWebUI.Controllers
{
 [Route("[controller]")]
    public class AnotherController
    {
        [Route("")]
        public string AnotherActionMethod()
        {
            return "AnotherController.AnotherActionMethod called!";
        }

        [Route("[action]")]
        public string YetAnotherActionMethod()
        {
            return "AnotherController.YetAnotherActionMethod called!";
        }
    }}
