
using Microsoft.EntityFrameworkCore;

namespace Christian_Resume_Web_API.models
{
    public class Data_Context : DbContext
    {

        public Data_Context(DbContextOptions<Data_Context> options) : base(options) { }


        public DbSet<Client_Info> Client_Messages { get; set; }
        public DbSet<projects> projects { get; set; }


    }
}
