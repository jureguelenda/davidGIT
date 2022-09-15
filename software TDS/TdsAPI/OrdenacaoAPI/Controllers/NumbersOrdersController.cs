using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OrdenacaoAPI.Models;


namespace OrdenacaoAPI.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class NumbersOrdersController : ControllerBase
    {
         NumbersOrders numbers = new NumbersOrders();
        [HttpGet]
        [Route("change")]
        public int[] change(int number1, int number2)
        {
           

            return numbers.Change(number1,number2);
        }

        [HttpGet]
        [Route("ChangeNegative")]
        public int ChangeNegative(int number)
        {
            return numbers.ChangeNegative(number);
        }
    }
}