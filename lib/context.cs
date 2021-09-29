using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace lib
{
     public class Context : DbContext
  {
   
    public DbSet<Transaction> Transactions { get; set;}
    public DbSet<Account> Accounts {get; set;}
    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
      var basedir = System.AppContext.BaseDirectory;
      var solndir = Directory.GetParent(basedir).Parent.Parent.Parent.Parent;
      options.UseSqlite($"Data Source={solndir.FullName}/data/checking.db");
      options.UseLoggerFactory(LoggerFactory.Create(builder => builder.AddConsole()));
    }
  }
}
