using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6.Models;

public class MineSweeperDbContext : DbContext
{
    public DbSet<User> Users => Set<User>();
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
    optionsBuilder.UseSqlServer(ConfigurationManager.ConnectionStrings["MinesweeperDb"].ConnectionString);
    }

    private MineSweeperDbContext() : base() { }

    public static MineSweeperDbContext Instance
    { 
        get
        {
            if (instance == null)
        {
            try
            {
                instance = new();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error connecting to database: {ex.Message}");
            }
        }
        return instance;
        } 
    }
    private static MineSweeperDbContext? instance;
}
