using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApi.Models;

namespace WebApi.Controllers
{
    public class GetContentController : ApiController
    {
        ApplicationDbContext _context;
        public GetContentController()
        {
            _context = new ApplicationDbContext();
        }
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        public IEnumerable<CContent> Get()
        {
            //return _context.Contents;
            _context.Configuration.ProxyCreationEnabled = false;

            //var returnVal = _context.Contents.Include("Informations").ToList();
            //var returnVal = _context.Contents.Include("Informations").ToList();
            var returnVal = _context.Contents.Include(c => c.ContentID);
            //var customersQuery = _context.Customers
            //    .Include(c => c.MembershipType);

            return returnVal;
        }
    }
}
