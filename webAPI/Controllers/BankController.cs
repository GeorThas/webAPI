using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.InteropServices;
using System.Web.Http;
using System.Web.Http.Results;
using webAPI.Models;

namespace webAPI.Controllers
{
    public class BankController : ApiController
    {

        //GET
        [HttpGet, Route("currencies")]
        public IEnumerable<Currency> currencies()
        {
            Currency CurUSD = new Currency();
            CurUSD.Name = "USD";
            CurUSD.ID = 1;

            Currency CurRUB = new Currency();
            CurRUB.Name = "RUB";
            CurRUB.ID = 2;

            List<Currency> CurLst = new List<Currency>();
            CurLst.Add(CurUSD);
            CurLst.Add(CurRUB);

            return CurLst;

        }


        [HttpGet, Route("currencies/{id}")]
        public Currency currency(int id)
        {
            Currency CurUSD = new Currency();
            CurUSD.Name = "USD";
            CurUSD.ID = id;
            // поиск по бд
            // ...
            //
            return CurUSD;
        }


        [HttpPost, Route("currencies/new/{id}/{name}")]
        public IHttpActionResult newCurrency(int id, string name)
        {
            // звпись в бд
            // ...
            //

            string info = Request.Content.ReadAsStringAsync().Result;

            if (id == 1)
            return Ok();
            else
                return BadRequest();
        }
    }
}
