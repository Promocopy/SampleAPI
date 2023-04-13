using Microsoft.EntityFrameworkCore;
using SampleAPI.Entities;

namespace SampleAPI.Data
{
    public class MemberContext:DbContext 
    {
        public MemberContext(DbContextOptions options) : base(options) 
        {
        }
        //mapping your object in c# into what your sql sever can understand
        //Dbset is seen as a table,user is seen as a table and a object in c#
        public DbSet<Appuser> User { get; set; }
        public DbSet<Location> Location { get; set; }
    }
}
