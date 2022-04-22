using System.Collections.Generic;
using System.Linq;
using InventoryDataAccessCore.Context;




namespace InventoryBussnisesLogicCore.GenericRepository
{
    public   class Generic <T> : IGeneric<T> where T:class
    {
        InventoryyContext context;
       public Generic(InventoryyContext _Contect)
        {
            context = _Contect;
        }

        public void Insert (T obj)
        {
            context.Set<T>().Add(obj);
            context.SaveChanges();

        }

        public List<T> LoadAll()
        {
            List<T> x= context.Set<T>().ToList();
            return x;
        }

        public void deletee (int id)
        {
            T obj = context.Set<T>().Find(id);
            context.Set<T>().Remove(obj);
            context.SaveChanges();
        }

        public void Update (T obj)
        {
            context.Set<T>().Attach(obj);
            context.Entry(obj).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();


        }
        public T edit(int id)
        {
            return context.Set<T>().Find(id);
        }

    

    }
}
