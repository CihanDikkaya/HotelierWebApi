using Hotelier.BusinessLayer.Abstract;
using Hotelier.DataAccessLayer.Abstract;
using Hotelier.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotelier.BusinessLayer.Concrete
{
    public class TestimonialManager : ITestimonialService
    {
        private readonly ITestimonialDal _service;

        public TestimonialManager(ITestimonialDal service)
        {
            _service = service;
        }

        public void TDelete(Testimonial t)
        {
            _service.Delete(t);
        }

        public Testimonial TGetByID(int id)
        {
            return _service.GetByID(id);
        }

        public List<Testimonial> TGetList()
        {
            return _service.GetList();
        }

        public void TInsert(Testimonial t)
        {
            _service.Insert(t);
        }

        public void TUpdate(Testimonial t)
        {
           _service.Update(t);
        }
    }
}
