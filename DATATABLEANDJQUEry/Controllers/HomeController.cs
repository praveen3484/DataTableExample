using DATATABLEANDJQUEry.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;

namespace DATATABLEANDJQUEry.Controllers
{
    public class HomeController : ApiController
    {
        private Context db = new Context();
        public IHttpActionResult GetAStudent(string query = null)
        {
            // var customersQuery = db.AStudentAlls;
            var customerDtos = db.Students3.ToList();

            return Ok(customerDtos);
        }



        // GET: api/Home/5
        [ResponseType(typeof(Students3))]
        public IHttpActionResult GetAStudent(int id)
        {
            Students3 aEmployee = db.Students3.Find(id);
            if (aEmployee == null)
            {
                return NotFound();
            }

            return Ok(aEmployee);
        }



        // PUT: api/Home/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutAStudent(int id, Students3 aStudentAll)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != aStudentAll.Id)
            {
                return BadRequest();
            }

            db.Entry(aStudentAll).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AStudentExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Home
        [ResponseType(typeof(Students3))]
        public IHttpActionResult PostAStudent(Students3 aStudentAll)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Students3.Add(aStudentAll);
            db.SaveChanges();

            // return CreatedAtRoute("DefaultApi", new { id = aStudentAll.Id }, aStudentAll);
            return RedirectToRoute("Index", "Home");
        }

        // DELETE: api/Home/5
        [ResponseType(typeof(Students3))]
        public IHttpActionResult DeleteAStudent(int id)
        {
            Students3 aEmployee = db.Students3.Find(id);
            if (aEmployee == null)
            {
                return NotFound();
            }

            db.Students3.Remove(aEmployee);
            db.SaveChanges();

            return Ok(aEmployee);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool AStudentExists(int id)
        {
            return db.Students3.Count(e => e.Id == id) > 0;
        }
    }
}
