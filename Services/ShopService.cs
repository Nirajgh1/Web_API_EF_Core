using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication1.DbContexts;
using WebApplication1.Entities;

namespace WebApplication1.Services
{
    public class ShopService
    {
        private readonly MyNewContext _newContext;
        public ShopService(MyNewContext newContext)
        {
            _newContext = newContext;
        }
        public void Add(Shop shop)
        {
            _newContext.Shops.Add(shop);
            _newContext.SaveChanges();
        }
        public async Task<List<Shop>>  GetShops()
        {
            var shops = await _newContext.Shops.ToListAsync();
            return shops;
        }
        public Shop? GetShop(int id)
        {
            var result = _newContext.Shops.Find(id);
            return result;
        }
        public Shop? DeleteShop(int id)
        {
            var ShopToDelete = _newContext.Shops.SingleOrDefault(a => a.Id == id);
            _newContext.Shops.Remove(ShopToDelete);
            _newContext.SaveChanges();

            return ShopToDelete;
        }
        public void UpdateShop(Shop shop)
        {
            _newContext.Shops.Update(shop);
            _newContext.SaveChanges();
        }
      
    }
}
