using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1.Interfaces;

namespace WebApplication1.Services
{
    public class TestServices : ITestServices
    {
        public string TestMethod()
        {
            return "This thing worked!";
        }
    }
}