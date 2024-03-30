using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplicationMVC.Models;

namespace WebApplicationMVC.Controllers
{
    public class InvoiceController : Controller
    {
        Repository repository = new Repository();

        // GET: Resume
        public ActionResult Index()
        {
            var data = repository.GetList();
            return View(data);
        }
        [HttpGet]
        public ActionResult Create()
        {
            InvoiceInfo applicant = new InvoiceInfo();

            applicant.Details.Add( new Productdetails() );

            return View(applicant);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(InvoiceInfo applicant)
        {


            if (ModelState.IsValid)
            {

                repository.Save(applicant);


                return RedirectToActionPermanent("Index");
               ;
            }



            return View(applicant);
        }


        [HttpGet]
        public ActionResult Edit(Guid id)
        {
            
            var applicant = repository.Get(id);



            return View(applicant);
        }
        [HttpPost]
        public ActionResult Edit(InvoiceInfo p)
        {
            try
            {

                if (ModelState.IsValid)
                {
                    repository.UpdateInvoice(p);
                    return RedirectToActionPermanent("Index");
                }
                return View(p);

            }
            catch (Exception)
            {


            }


            return View(p);
        }

        [HttpGet]
        public ActionResult Delete(Guid id)
        {
            var applicant = repository.Get(id);



            return View(applicant);




        }
        [HttpPost]
        public ActionResult Delete(InvoiceInfo a)
        {
            repository.Delete(a.Id);



            return RedirectToAction("Index");




        }


        [HttpGet]
        public ActionResult Details (Guid id)
        {
            var applicant = repository.Get(id);



            return View(applicant);




        }


    }
}