using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using Interview.Model;
using Newtonsoft.Json;

namespace Interview.Repository
{
    public class PaymentRepository : IPaymentRepository
    {
        private readonly string data = File.ReadAllText(Path.Combine(
                HttpContext.Current.Request.PhysicalApplicationPath, @"App_Data/data.json"));

        private bool PaymentsUpdateAndSave(string newData)
        {
            try
            {
                File.WriteAllText(Path.Combine(
                HttpContext.Current.Request.PhysicalApplicationPath, @"App_Data/data.json"), newData);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public List<Payment> GetAllPayments()
        {
            return JsonConvert.DeserializeObject<List<Payment>>(data);
        }

        public Payment GetPaymentById(Guid id)
        {
            return JsonConvert.DeserializeObject<List<Payment>>(data).Where(p => p.Id.Equals(id)).FirstOrDefault();
        }

        public bool AddPayment(Payment payment)
        {
            var payments = GetAllPayments();
            payments.Add(payment);
            return PaymentsUpdateAndSave(JsonConvert.SerializeObject(payments));
        }
    }
}