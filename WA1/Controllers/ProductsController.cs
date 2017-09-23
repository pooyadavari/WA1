using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using Models;
using Ninject;
using DAL;

namespace WA1.Controllers
{
    public class ProductsController : ApiController
    {
        IUnitOfWork u;

        public ProductsController()
        {
            //IKernel ninjectKernel = new StandardKernel();
            //ninjectKernel.Bind<IUnitOfWork>().To<UnitOfWork>();
            //u = ninjectKernel.Get<IUnitOfWork>();
        }

        public ProductsController(IUnitOfWork uParam)
        {
            u = uParam;
        }

        // GET: api/Products
        public IQueryable<Product> GetProducts()
        {
            //return db.Products;
            return u.ProductRepository.Get();
        }



        //// GET: api/Products/5
        //[ResponseType(typeof(Product))]
        //public IHttpActionResult GetProduct(Guid id)
        //{
        //    //Product product = db.Products.Find(id);
        //    Product product = u.ProductRepository.GetById(id);
        //    if (product == null)
        //    {
        //        return NotFound();
        //    }

        //    return Ok(product);
        //}

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                u.Dispose();
            }
            base.Dispose(disposing);
        }

        //// PUT: api/Products/5
        //[ResponseType(typeof(void))]
        //public IHttpActionResult PutProduct(Guid id, Product product)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    if (id != product.Id)
        //    {
        //        return BadRequest();
        //    }

        //    db.Entry(product).State = EntityState.Modified;

        //    try
        //    {
        //        db.SaveChanges();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!ProductExists(id))
        //        {
        //            return NotFound();
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }

        //    return StatusCode(HttpStatusCode.NoContent);
        //}

        //// POST: api/Products
        //[ResponseType(typeof(Product))]
        //public IHttpActionResult PostProduct(Product product)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    db.Products.Add(product);

        //    try
        //    {
        //        db.SaveChanges();
        //    }
        //    catch (DbUpdateException)
        //    {
        //        if (ProductExists(product.Id))
        //        {
        //            return Conflict();
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }

        //    return CreatedAtRoute("DefaultApi", new { id = product.Id }, product);
        //}

        //// DELETE: api/Products/5
        //[ResponseType(typeof(Product))]
        //public IHttpActionResult DeleteProduct(Guid id)
        //{
        //    Product product = db.Products.Find(id);
        //    if (product == null)
        //    {
        //        return NotFound();
        //    }

        //    db.Products.Remove(product);
        //    db.SaveChanges();

        //    return Ok(product);
        //}


        //private bool ProductExists(Guid id)
        //{
        //    return db.Products.Count(e => e.Id == id) > 0;
        //}
    }
}