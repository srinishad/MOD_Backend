using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Mod.PaymentService.Context;
using Mod.PaymentService.Models;

namespace Mod.PaymentService.Repository
{
    public class PaymentRepository : IPaymentRepository
    {
        private readonly PaymentContext _context;
        public PaymentRepository(PaymentContext context)
        {
            _context = context;
        }

        public void Add(Payment item)
        {
            _context.Payment.Add(item);
            _context.SaveChanges();
        }

        public List<Payment> GetAll()
        {
            return _context.Payment.ToList();
        }

        public Payment GetById(int id)
        {
            return _context.Payment.Find(id);
        }
        public void Delete(int id)
        {
            var item = _context.Payment.Find(id);
            _context.Payment.Remove(item);
            _context.SaveChanges();
        }
        public void Update(Payment item)
        {
            _context.Entry(item).State = EntityState.Modified;
            _context.SaveChanges();
        }
    }
}
