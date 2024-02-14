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
        private readonly ITestimonialDal testimonialDal;

        public TestimonialManager(ITestimonialDal testimonialDal)
        {
            this.testimonialDal = testimonialDal;
        }

        public void TDelete(Testimonial t)
        {
            testimonialDal.Delete(t);
        }

        public Testimonial TGetByID(int id)
        {
            return testimonialDal.GetByID(id);
        }

        public List<Testimonial> TGetList()
        {
            return testimonialDal.GetList();
        }

        public void TInsert(Testimonial t)
        {
            testimonialDal.Insert(t);
        }

        public void TUpdate(Testimonial t)
        {
            testimonialDal.Update(t);
        }
    }
}
