using Hotelier.DataAccessLayer.Abstract;
using Hotelier.DataAccessLayer.Concrete;
using Hotelier.DataAccessLayer.Repos;
using Hotelier.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotelier.DataAccessLayer.EntityFramework
{
    public class EfTestimonialDal:GenericRepo<Testimonial>,ITestimonialDal
    {
        public EfTestimonialDal(Context context):base(context)
        {
            
        }
    }
}
