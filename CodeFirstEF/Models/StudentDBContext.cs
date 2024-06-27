using Microsoft.EntityFrameworkCore;

namespace CodeFirstEF.Models
{
    public class StudentDBContext : DbContext
    {
        public StudentDBContext(DbContextOptions options) : base(options)
        {
            //base is used to call parent class constructor which is dbcontext 
            //in this case
               
        }

        public DbSet<Student> Students { get; set; }
        //in db, the name will be same as the dbset name which is declared above
        //name of the table in db will be Students
    }
}
