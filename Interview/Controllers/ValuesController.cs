using Interview.Model;
using Interview.Repository;
using System;

using System.Web.Http;

namespace Interview.Controllers
{
    public class ValuesController : ApiController
    {
        private readonly IPaymentRepository _paymentRepository;

        public ValuesController(IPaymentRepository paymentRepository)
        {
            _paymentRepository = paymentRepository;
        }

        // GET api/values
        public IHttpActionResult Get()
        {
            return Ok(_paymentRepository.GetAllPayments());
        }

        // GET api/values/5
        public IHttpActionResult Get(Guid id)
        {
            return Ok(_paymentRepository.GetPaymentById(id));
        }

        // POST api/values
        public IHttpActionResult Post([FromBody]Payment value)
        {
            var result = false;
            try
            {
                result = _paymentRepository.AddPayment(value);
                return Ok(result);
            } 
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
            //TODO 
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
            //TODO
        }
    }
}
