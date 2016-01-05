using BusinessLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BusinessLayer.Services
{
    public class TestServicesThree : ITestServices
    {
        public string TestMethod()
        {
            return "This is another one ! Mother fucking cool";
        }
    }
}