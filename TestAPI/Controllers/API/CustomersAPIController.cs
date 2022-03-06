using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TestAPI.Models;

namespace TestAPI.Controllers
{
    public class CustomersAPIController : ApiController
    {
        private CustomerDBContext _context;
        public CustomersAPIController()
        {
            _context = new CustomerDBContext();
        }

        public IEnumerable<CustomerDetails> GetCustomerDetails()
        {
            return _context.CustomerDetails.ToList();
        }
       public CustomerDetails GetCustomerDetails(int Id)
        {
            var detailsInDb = _context.CustomerDetails.SingleOrDefault(cd => cd.Id == Id);
            if (detailsInDb == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);
            return detailsInDb;
        }
        [HttpPost]
        public CustomerDetails AddCustomerDetails(CustomerDetails customerDetails)
        {
            if (!ModelState.IsValid)
                throw new HttpResponseException(HttpStatusCode.BadRequest);
            _context.CustomerDetails.Add(customerDetails);
            _context.SaveChanges();
            return customerDetails;
        }
        [HttpPut]
        public CustomerDetails UpdateCustomerDetails(int Id, CustomerDetails customerDetails)
        {
            var detailsInDb = _context.CustomerDetails.SingleOrDefault(cd => cd.Id == Id);
            if (detailsInDb == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);
            if (!ModelState.IsValid)
                throw new HttpResponseException(HttpStatusCode.BadRequest);
            detailsInDb.Age = customerDetails.Age;
            detailsInDb.Phone = customerDetails.Phone;
            detailsInDb.Address = customerDetails.Address;
            _context.SaveChanges();
            return customerDetails;
        }
        [HttpDelete]
        public CustomerDetails DeleteCustomerDetails(int Id)
        {
            var detailsInDb = _context.CustomerDetails.SingleOrDefault(cd => cd.Id == Id);
            if (detailsInDb == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);
            _context.CustomerDetails.Remove(detailsInDb);
            _context.SaveChanges();
            return detailsInDb;
        }
    }
}
