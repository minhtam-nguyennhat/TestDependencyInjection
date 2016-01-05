using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BusinessLayer.Interfaces;

namespace BusinessLayer.Services
{
    public class TestServicesTwo : ITestServices
    {
        public string TestMethod()
        {
            return "This thing worked! Two";
        }
    }
}