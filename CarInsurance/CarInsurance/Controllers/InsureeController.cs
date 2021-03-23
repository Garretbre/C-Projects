using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CarInsurance.Models;

//3. Email all database .mdf and .ldf files to an Instructor. These are located in your project’s app_data folder. I have my work in Global.asax.cs
namespace CarInsurance.Controllers
{
    public class InsureeController : Controller
    {
        public InsuranceEntities db = new InsuranceEntities();

        // GET: Insuree
        public ActionResult Index()
        {
            return View(db.Insurees.ToList());
        }

        // GET: Insuree/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // GET: Insuree/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Insuree/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")] Insuree insuree)
        {
            if (ModelState.IsValid)
            {
                
                //Start with a base of $50 / month.
                
                
                insuree.Quote = 50;
                
                

                //If the car's Make is a Porsche, add $25 to the price.
                if (insuree.CarMake == "Porsche")
                {
                    insuree.Quote += 25;
                }
                //If the car's Make is a Porsche and its model is a 911 Carrera, add an additional $25 to the price.
                if (insuree.CarMake == "Porsche" && insuree.CarModel == "911 Carrera")
                {
                    insuree.Quote += 25;
                }
                //If the user is 18 and under, add $100 to the monthly total.
                
                
                var data01 = new DateTime(2003, 1, 1, 1, 1, 1);
                if (insuree.DateOfBirth > data01)
                {
                    insuree.Quote += 100;
                }
                //If the user is between 19 and 25, add $50 to the monthly total.
                var data02 = new DateTime(2002, 1, 1, 1, 1, 1);
                var data03 = new DateTime(1996, 1, 1, 1, 1, 1);
                if (insuree.DateOfBirth >= data02 && insuree.DateOfBirth <= data03)
                {
                    insuree.Quote += 50;
                }
                //If the user is over 25, add $25 to the monthly total.
                var data04 = new DateTime(1996, 1, 1, 1, 1, 1);
                if (insuree.DateOfBirth < data04)
                {
                    insuree.Quote += 25;
                }
                //If the car's year is before 2000, add $25 to the monthly total.
                if (insuree.CarYear < 2000)
                {
                    insuree.Quote += 25;
                }
                //If the car's year is after 2015, add $25 to the monthly total.
                if (insuree.CarYear > 2015)
                {
                    insuree.Quote += 25;
                }
                //Add $10 to the monthly total for every speeding ticket the user has.
                
                if (insuree.SpeedingTickets > 0)
                {
                    insuree.Quote += insuree.SpeedingTickets * 10;
                }

                //If the user has ever had a DUI, add 25 % to the total.
                if (insuree.DUI == true)
                {
                    insuree.Quote += insuree.Quote * .25m;
                }

                db.Insurees.Add(insuree);

                //If it's full coverage, add 50% to the total.
                if (insuree.CoverageType == true)
                {
                    insuree.Quote += insuree.Quote * .50m;
                }

                db.Insurees.Add(insuree);
                var v = db.SaveChanges();
                return RedirectToAction("Index");
                
            }

            return View(insuree);
        }

        // GET: Insuree/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // POST: Insuree/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")] Insuree insuree)
        {
            if (ModelState.IsValid)
            {
                db.Entry(insuree).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(insuree);
        }

        // GET: Insuree/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // POST: Insuree/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Insuree insuree = db.Insurees.Find(id);
            db.Insurees.Remove(insuree);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        //Create an Admin view for a site administrator.This page must:

        //Show all quotes issued, along with the user's first name, last name, and email address.


        public ActionResult Admin()
        {
            return View(db.Insurees.ToList());
        }
    }
}
