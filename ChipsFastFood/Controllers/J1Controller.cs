using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ChipsFastFood.Controllers
{
    public class J1Controller : ApiController
    {
        [HttpGet]
        [Route("api/J1/Menu/{burger}/{drink}/{side}/{dessert}")]
        public string Menu(int burger, int drink, int side, int dessert )
        {
            int[] bCalories = { 461, 431, 420, 0 };
            int[] dCalories = { 130, 160, 118, 0 };
            int[] sCalories = { 100, 57, 70, 0 };
            int[] desCalories = { 167, 266, 75, 0 };
            int tCalories;
            


            if (burger > 4 || burger == 0 ||  drink > 4 || drink == 0 || side > 4 || side == 0 || dessert > 4 || dessert == 0 )
            {
                return "invalid input.";

            }
            tCalories = bCalories[burger-1] + dCalories[drink-1] + sCalories[side-1] + desCalories[dessert-1];
            
             string cCount = "Your total calorie count is " + tCalories.ToString();
            
            return cCount;

        }
    }
}
