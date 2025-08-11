using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace RickMortyApi.Models
{
    public class RickAndMortyDbContext : DbContext
    {
        public RickAndMortyDbContext(DbContextOptions<RickAndMortyDbContext> options)
            : base(options)
        {
        }


        public DbSet<AccountDb> Accounts { get; set; }

        public DbSet<FavoriteDb> Favorites { get; set; }
    }

    public class AccountDb
    {
        [Key]
        public int Id { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
    }

    public class FavoriteDb
    {
        public int Id { get; set; }
        public string Email { get; set; }
    }
}