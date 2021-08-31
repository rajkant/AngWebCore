using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AngWeb.Models;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AngWeb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [HttpGet]
        [Route("GetDropDown")]
        public IEnumerable<string> GetDropDown()
        {
            return new string[] { "Hello", "World" };
        }
      
        [HttpPost]
        [Route("Post")]
        public string Post(string test)
        {
            return test;
        }
            
        [HttpGet]
        [Route("GetRoutingNums")]
        public List<BankInformation> GetRoutingNums(string test)
        {
            List<BankInformation> bankList = new List<BankInformation>();
            var bi = new BankInformation
            {   state = "GA", institution_status_code = "", office_code = "O", data_view_code = "", message = "OK", new_routing_number = "000000000", rn = "011000015", telephone = "372-877-2457", city = "ATLANTA", change_date = "122415", zip = "30309", customer_name = "FEDERAL RESERVE BANK", code = 200, routing_number = "011000015", record_type_code = "0", address = "1000 PEACHTREE ST N.E." };
            bankList.Add(bi);
            bi = new BankInformation
            { state = "KY", institution_status_code = "", office_code = "O", data_view_code = "", message = "OK", new_routing_number = "000000000", rn = "011000015", telephone = "372-877-2457", city = "LOUISVILLE", change_date = "122415", zip = "40245", customer_name = "KY RESERVE BANK", code = 200, routing_number = "011000015", record_type_code = "0", address = "900 PEACHTREE ST N.E." };
            bankList.Add(bi);
            bi = new BankInformation
            { state = "CA", institution_status_code = "", office_code = "O", data_view_code = "", message = "OK", new_routing_number = "000000000", rn = "011000015", telephone = "372-877-2457", city = "SAN JOSE", change_date = "122415", zip = "90345", customer_name = "CA RESERVE BANK", code = 200, routing_number = "011000015", record_type_code = "0", address = "900 PEACHTREE ST N.E." };
            bankList.Add(bi);
            bi = new BankInformation
            { state = "PA", institution_status_code = "", office_code = "O", data_view_code = "", message = "OK", new_routing_number = "000000000", rn = "011000015", telephone = "372-877-2457", city = "PA CITY", change_date = "122415", zip = "34345", customer_name = "PA RESERVE BANK", code = 200, routing_number = "011000015", record_type_code = "0", address = "900 PEACHTREE ST N.E." };
            bankList.Add(bi);
            bi = new BankInformation
            { state = "IL", institution_status_code = "", office_code = "O", data_view_code = "", message = "OK", new_routing_number = "000000000", rn = "011000015", telephone = "372-877-2457", city = "IL CITY", change_date = "122415", zip = "34345", customer_name = "IL RESERVE BANK", code = 200, routing_number = "011000015", record_type_code = "0", address = "900 PEACHTREE ST N.E." };
            bankList.Add(bi);
            bi = new BankInformation
            { state = "MN", institution_status_code = "", office_code = "O", data_view_code = "", message = "OK", new_routing_number = "000000000", rn = "011000015", telephone = "372-877-2457", city = "MN CITY", change_date = "122415", zip = "34345", customer_name = "MN RESERVE BANK", code = 200, routing_number = "011000015", record_type_code = "0", address = "900 PEACHTREE ST N.E." };            
            bankList.Add(bi);
            bi = new BankInformation
            { state = "NJ", institution_status_code = "", office_code = "O", data_view_code = "", message = "OK", new_routing_number = "000000000", rn = "011000015", telephone = "372-877-2457", city = "NJ CITY", change_date = "122415", zip = "34345", customer_name = "NJ RESERVE BANK", code = 200, routing_number = "011000015", record_type_code = "0", address = "900 PEACHTREE ST N.E." };
            bankList.Add(bi);
            bi = new BankInformation
            { state = "NM", institution_status_code = "", office_code = "O", data_view_code = "", message = "OK", new_routing_number = "000000000", rn = "011000015", telephone = "372-877-2457", city = "NM CITY", change_date = "122415", zip = "34345", customer_name = "NM RESERVE BANK", code = 200, routing_number = "011000015", record_type_code = "0", address = "900 PEACHTREE ST N.E." };
            bankList.Add(bi);
            bi = new BankInformation
            { state = "AT", institution_status_code = "", office_code = "O", data_view_code = "", message = "OK", new_routing_number = "000000000", rn = "011000015", telephone = "372-877-2457", city = "AT CITY", change_date = "122415", zip = "34345", customer_name = "AT RESERVE BANK", code = 200, routing_number = "011000015", record_type_code = "0", address = "900 PEACHTREE ST N.E." };
            bankList.Add(bi);
            bi = new BankInformation
            { state = "MO", institution_status_code = "", office_code = "O", data_view_code = "", message = "OK", new_routing_number = "000000000", rn = "011000015", telephone = "372-877-2457", city = "MO CITY", change_date = "122415", zip = "34345", customer_name = "MO RESERVE BANK", code = 200, routing_number = "011000015", record_type_code = "0", address = "900 PEACHTREE ST N.E." };
            bankList.Add(bi);
            bi = new BankInformation
            { state = "NY", institution_status_code = "", office_code = "O", data_view_code = "", message = "OK", new_routing_number = "000000000", rn = "011000015", telephone = "372-877-2457", city = "NY CITY", change_date = "122415", zip = "34345", customer_name = "NY RESERVE BANK", code = 200, routing_number = "011000015", record_type_code = "0", address = "900 PEACHTREE ST N.E." };
            bankList.Add(bi);
            bi = new BankInformation
            { state = "VI", institution_status_code = "", office_code = "O", data_view_code = "", message = "OK", new_routing_number = "000000000", rn = "011000015", telephone = "372-877-2457", city = "VI CITY", change_date = "122415", zip = "34345", customer_name = "VI RESERVE BANK", code = 200, routing_number = "011000015", record_type_code = "0", address = "900 PEACHTREE ST N.E." };
            bankList.Add(bi);
            bi = new BankInformation
            { state = "KY", institution_status_code = "", office_code = "O", data_view_code = "", message = "OK", new_routing_number = "000000000", rn = "011000015", telephone = "372-877-2457", city = "LOUISVILLE", change_date = "122415", zip = "40245", customer_name = "KY RESERVE BANK", code = 200, routing_number = "011000015", record_type_code = "0", address = "900 PEACHTREE ST N.E." };
            bankList.Add(bi);
            bi = new BankInformation
            { state = "CA", institution_status_code = "", office_code = "O", data_view_code = "", message = "OK", new_routing_number = "000000000", rn = "011000015", telephone = "372-877-2457", city = "SAN JOSE", change_date = "122415", zip = "90345", customer_name = "CA RESERVE BANK", code = 200, routing_number = "011000015", record_type_code = "0", address = "900 PEACHTREE ST N.E." };
            bankList.Add(bi);
            bi = new BankInformation
            { state = "PA", institution_status_code = "", office_code = "O", data_view_code = "", message = "OK", new_routing_number = "000000000", rn = "011000015", telephone = "372-877-2457", city = "PA CITY", change_date = "122415", zip = "34345", customer_name = "PA RESERVE BANK", code = 200, routing_number = "011000015", record_type_code = "0", address = "900 PEACHTREE ST N.E." };
            bankList.Add(bi);
            bi = new BankInformation
            { state = "IL", institution_status_code = "", office_code = "O", data_view_code = "", message = "OK", new_routing_number = "000000000", rn = "011000015", telephone = "372-877-2457", city = "IL CITY", change_date = "122415", zip = "34345", customer_name = "IL RESERVE BANK", code = 200, routing_number = "011000015", record_type_code = "0", address = "900 PEACHTREE ST N.E." };
            bankList.Add(bi);
            bi = new BankInformation
            { state = "MN", institution_status_code = "", office_code = "O", data_view_code = "", message = "OK", new_routing_number = "000000000", rn = "011000015", telephone = "372-877-2457", city = "MN CITY", change_date = "122415", zip = "34345", customer_name = "MN RESERVE BANK", code = 200, routing_number = "011000015", record_type_code = "0", address = "900 PEACHTREE ST N.E." };
            bankList.Add(bi);
            bi = new BankInformation
            { state = "NJ", institution_status_code = "", office_code = "O", data_view_code = "", message = "OK", new_routing_number = "000000000", rn = "011000015", telephone = "372-877-2457", city = "NJ CITY", change_date = "122415", zip = "34345", customer_name = "NJ RESERVE BANK", code = 200, routing_number = "011000015", record_type_code = "0", address = "900 PEACHTREE ST N.E." };
            bankList.Add(bi);
            bi = new BankInformation
            { state = "NM", institution_status_code = "", office_code = "O", data_view_code = "", message = "OK", new_routing_number = "000000000", rn = "011000015", telephone = "372-877-2457", city = "NM CITY", change_date = "122415", zip = "34345", customer_name = "NM RESERVE BANK", code = 200, routing_number = "011000015", record_type_code = "0", address = "900 PEACHTREE ST N.E." };
            bankList.Add(bi);
            bi = new BankInformation
            { state = "AT", institution_status_code = "", office_code = "O", data_view_code = "", message = "OK", new_routing_number = "000000000", rn = "011000015", telephone = "372-877-2457", city = "AT CITY", change_date = "122415", zip = "34345", customer_name = "AT RESERVE BANK", code = 200, routing_number = "011000015", record_type_code = "0", address = "900 PEACHTREE ST N.E." };
            bankList.Add(bi);
            bi = new BankInformation
            { state = "MO", institution_status_code = "", office_code = "O", data_view_code = "", message = "OK", new_routing_number = "000000000", rn = "011000015", telephone = "372-877-2457", city = "MO CITY", change_date = "122415", zip = "34345", customer_name = "MO RESERVE BANK", code = 200, routing_number = "011000015", record_type_code = "0", address = "900 PEACHTREE ST N.E." };
            bankList.Add(bi);
            bi = new BankInformation
            { state = "NY", institution_status_code = "", office_code = "O", data_view_code = "", message = "OK", new_routing_number = "000000000", rn = "011000015", telephone = "372-877-2457", city = "NY CITY", change_date = "122415", zip = "34345", customer_name = "NY RESERVE BANK", code = 200, routing_number = "011000015", record_type_code = "0", address = "900 PEACHTREE ST N.E." };
            bankList.Add(bi);
            bi = new BankInformation
            { state = "VI", institution_status_code = "", office_code = "O", data_view_code = "", message = "OK", new_routing_number = "000000000", rn = "011000015", telephone = "372-877-2457", city = "VI CITY", change_date = "122415", zip = "34345", customer_name = "VI RESERVE BANK", code = 200, routing_number = "011000015", record_type_code = "0", address = "900 PEACHTREE ST N.E." };
            bankList.Add(bi);
            return bankList;
    }
        
  }
}
