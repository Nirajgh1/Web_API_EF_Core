using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication1;
using WebApplication1.DbContexts;
using WebApplication1.Entities;
using WebApplication1.Services;


namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ShopsController : ControllerBase
    {
        private ShopService _shopService;

        public ShopsController(ShopService shopService)
        {
            _shopService = shopService;
        }

        


        [HttpPost("Add")]
        public IActionResult Add(Shop shop)
        {
            _shopService.Add(shop);
            return Ok();
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            var shops = await _shopService.GetShops();
            return Ok(shops);
        }



        [HttpGet("Get")]
        public IActionResult Get(int id)
        {
            return Ok(_shopService.GetShop(id));
        }



        [HttpDelete("Delete")]
        public IActionResult Delete(int id)
        {
            var deletedShop = _shopService.DeleteShop(id);
            return Ok(deletedShop);
        }

        [HttpPut("Update")]
        
        public IActionResult Put(Shop shop)
        {
            _shopService.UpdateShop(shop);
            return Ok();
        }




        //private readonly DBConnect _dBconnect;
        //public ShopsController(DBConnect dBConnect)
        //{
        //    _dBconnect = dBConnect;
        //}

        //[HttpPost("CreateShop")]
        //public void CreateShop(int ShopID,string ShopName,int taxID,int OwnerID)
        //{
        //    Console.WriteLine($"the shop with{ShopID} name{ShopName} is creteds{taxID}{OwnerID}");
        //    var dbconnect = new DBConnect();
        //    dbconnect.InsertShop(ShopID,ShopName,taxID,OwnerID);
        //}
        //[HttpPost("CreateLOcation")]
        //public void CreateShopLocation(int locID,int shopID,string Sname,string address,float lat,float lng) 
        //{
        //     var dbconnect = new DBConnect();
        //    dbconnect.InsertShopLocation( locID,  shopID, Sname,  address,  lat,  lng);

        //}
        //[HttpGet("GetLocations")]
        //public List<ShopLocationsResults> GetShopLocation() 
        //{ 
        //  var dbconnect=new DBConnect();
        //    var locfromdb=dbconnect.ReadLocation();
        //    return locfromdb;
        //}

        //[HttpPost("CreateOwner")]
        //public void InsertOwner(int OwnerID,string OName,string email) 
        //{
        //    Console.WriteLine($"new owner is added {OwnerID} wit name {OName}");
        //    var dbconnect2=new DBConnect();
        //    dbconnect2.InsertOwner(OwnerID,OName,email);
        //}
        //[HttpGet]
        //public List<OwnerResult> GetOwners() 
        //{ 
        //  var dbconnect = new DBConnect();
        //   var ownersFromDb = dbconnect.Read();
        //    return ownersFromDb;
        //}

        //[HttpPut("upOwner")]
        //public int updateOwner(int owID) {
        //    var dbconnect = new DBConnect();
        //    var upfromdb=dbconnect.Update(owID);


        //    return owID;
        //}
        //[HttpDelete("deleteshop")]
        //public int deleteShop(int shopID)
        //{
        //    var dbconnect=new DBConnect();
        //    var delfromdb=dbconnect.Delete(shopID);
        //    return delfromdb;
        //}   


    } 
}
