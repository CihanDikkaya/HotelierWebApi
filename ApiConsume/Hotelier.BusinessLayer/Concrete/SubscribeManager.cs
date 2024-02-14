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
    public class SubscribeManager : ISubscribeService
    {
        private readonly ISubscribeDal subscribeDal;

        public SubscribeManager(ISubscribeDal subscribeDal)
        {
            this.subscribeDal = subscribeDal;
        }

        public void TDelete(Subscribe t)
        {
            subscribeDal.Delete(t);
        }

        public Subscribe TGetByID(int id)
        {
            return subscribeDal.GetByID(id);
        }

        public List<Subscribe> TGetList()
        {
            return subscribeDal.GetList();
        }

        public void TInsert(Subscribe t)
        {
            subscribeDal.Insert(t);
        }

        public void TUpdate(Subscribe t)
        {
            subscribeDal.Update(t);
        }
    }
}
