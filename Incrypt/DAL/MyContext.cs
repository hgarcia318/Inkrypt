using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Npgsql;
using System.Data.Entity.Infrastructure;
using Incrypt.BusinessObjects;


namespace Incrypt
{
    public class MyContext : DbContext
    {
        public DbSet<ACE> ACEs { get; set; }
        public DbSet<ACL> ACLs { get; set; }
        public DbSet<AuditLog> AuditLogs { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Credentials> Credentials { get; set; }
        public DbSet<Folder> Folders { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserGroup> UserGroups { get; set; }


        /*public MyContext() : base("name= MyConn")
        {
            if (Database.Exists("MyConn"))
            {
                Database.SetInitializer<MyContext>(null);
            } 
                     
            else
            {
                Database.SetInitializer(new MyDatabaseInitializer());


            }      
        }*/



        /*  public class MyDatabaseInitializer : CreateDatabaseIfNotExists<MyContext>
          {
              protected override void Seed(MyContext context)
              {             
                  base.Seed(context);
              }
          }*/
    }
}
