using InventoryBussnisesLogic.SpecificRepository;
using InventoryBussnisesLogicCore.GenericRepository;
using InventoryDataAccessCore.Context;
using InventoryDataAccessCore.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryBussnisesLogicCore.SpecificRepository
{
 public   class CategoryService :ICategoryService
    {
        private readonly InventoryyContext context;
        private readonly IGeneric<Category> genericService;

        public CategoryService(InventoryyContext _context, IGeneric<Category> _generic)
        {
            context = _context;
            genericService = _generic;
        }

        public void Insert(Category category)
        {
            genericService.Insert(category);
        }


        public List<Category> LoadAll()
        {
            return genericService.LoadAll();
        }

        public List<Category> loadbyname(string name)
        {
            return context.categories.Where(p => p.Name == name).ToList();
        }

        public void dellet(int id)
        {
            genericService.deletee(id);
        }

        public void Update(Category ca)
        {
            genericService.Update(ca);
        }
    }
}
