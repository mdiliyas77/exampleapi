using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace demo.Models
{
    public class service
    {
        public int AddNumber(models obj)
        {
            int res = obj.num1 + obj.num2;
            return res;
        }
    }
}