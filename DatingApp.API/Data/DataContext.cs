using DatingApp.API.Models;
using Microsoft.EntityFrameworkCore;

namespace DatingApp.API.Data
{
    public class DataContext: DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) {}
        
        public DbSet<Value> Values{get;set;}

        public DbSet<tblUser> tblUsers {get;set;}

       public DbSet<tblPhoto> tblPhotos{get;set;}
            
        
    }
}