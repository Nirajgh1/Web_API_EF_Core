using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication1.DbContexts;
using WebApplication1.Entities;

namespace WebApplication1.Services
{
    public class OwnerService
    {
        private MyNewContext _newContext;

        public OwnerService(MyNewContext newContext) {
         _newContext=newContext;
        
        }
        public async void Add(Owner owner)
        {
            _newContext.Owners.Add(owner);
            await _newContext.SaveChangesAsync();
        }
        public async Task<List<Owner>> GetOwners()
        {
            var owners = await _newContext.Owners.ToListAsync();
            return owners;
        }
        public Owner UpdateOwner(Owner owner)
        {

            _newContext.Owners.Update(owner);
            _newContext.SaveChanges();
            return owner;
        }
        public Owner? DeleteOwner(Owner owner)
        {
            var OwnerToDel = _newContext.Owners.SingleOrDefault(o => o.Id == 1);
            _newContext.Owners.Remove(OwnerToDel);
            _newContext.SaveChanges();
            return OwnerToDel;
        }
    }
}
