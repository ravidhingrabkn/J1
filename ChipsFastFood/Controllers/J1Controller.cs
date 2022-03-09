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


            if (burger > 4 || drink > 4 || side > 4 || dessert > 4)
            {
                return "invalid input.";
            }
            else if (burger < 1 || drink < 1 || side < 1 || dessert < 1)
            {
                return "invalid input.";

            }
            else
            {
                tCalories = bCalories[burger - 1] + dCalories[drink - 1] + sCalories[side - 1] + desCalories[dessert - 1];
                return "Your total calorie count is " + tCalories.ToString();

            }
                
            
            
            

        }
    }
}
