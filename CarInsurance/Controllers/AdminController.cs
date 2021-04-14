using CarInsurance.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CarInsurance.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            using (InsuranceEntities db = new InsuranceEntities())
            {
                var insuredNow = new List<Insuree>();
                foreach (var insuree in db.Insurees)
                {
                    
                    var insured = new Insuree();
                    insured.FirstName = insuree.FirstName;
                    insured.LastName = insuree.LastName;
                    insured.EmailAddress = insuree.EmailAddress;
                    insuree.Quote = decimal.Round(insuree.Quote, 2);
                    insured.Quote = insuree.Quote;

                    insuredNow.Add(insured);
                }
                return View(insuredNow);
            }
            
        }
    }
}