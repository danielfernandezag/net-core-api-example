using Microsoft.EntityFrameworkCore;
using GameCollectionAPI.Models;

namespace GameCollectionAPI.Persistence.Contexts
{
    public class GameCollectionDbContext : DbContext
    {
        public DbSet<GameModel> Games { get; set; }
        public DbSet<UserModel> Users { get; set; }
        public DbSet<CollectionModel> Collections { get; set; }

        public GameCollectionDbContext(DbContextOptions<GameCollectionDbContext> options) :  base(options)
        {
           
            

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

           
            builder.Entity<UserModel>().ToTable("USERS");
            builder.Entity<UserModel>().HasKey(user => user.id);
            builder.Entity<UserModel>().Property(user => user.id).IsRequired().ValueGeneratedOnAdd();
            builder.Entity<UserModel>().Property(user => user.firstname).IsRequired();
            builder.Entity<UserModel>().Property(user => user.lastname);
            builder.Entity<UserModel>().Property(user => user.password).IsRequired();

            builder.Entity<UserModel>().HasMany(user => user.collections).WithOne(collection => collection.user).HasForeignKey(collection => collection.userid);

            //builder.Entity<UserModel>().HasData
            //(
            //    new UserModel { id = 1, firstname = "Daniel", lastname = "Fernandez", password = "1234Abc."},
            //    new UserModel { id = 2, firstname = "Michael", lastname = "Kiske", password = "1234Abc." }
            //);

            builder.Entity<CollectionModel>().ToTable("COLLECTIONS");
            builder.Entity<CollectionModel>().HasKey(collection => collection.id);
            builder.Entity<CollectionModel>().Property(collection => collection.id).IsRequired().ValueGeneratedOnAdd();
            builder.Entity<CollectionModel>().Property(collection => collection.name).IsRequired();
            builder.Entity<CollectionModel>().Property(collection => collection.total).IsRequired();

            builder.Entity<CollectionModel>().HasMany(collection => collection.games).WithOne(game => game.collection).HasForeignKey(game => game.collectionid);

            //builder.Entity<CollectionModel>().HasData
            //(
            //  new CollectionModel { id = 1, name = "PS3", total = 12 },
            //  new CollectionModel { id = 2, name = "PS4", total = 21 }
            //);

            builder.Entity<GameModel>().ToTable("GAMES");
            builder.Entity<GameModel>().HasKey(game => game.id);
            builder.Entity<GameModel>().Property(game => game.id).IsRequired().ValueGeneratedOnAdd();
            builder.Entity<GameModel>().Property(game => game.name).IsRequired();
            builder.Entity<GameModel>().Property(game => game.year);
            builder.Entity<GameModel>().Property(game => game.genre).IsRequired().HasMaxLength(50);
            builder.Entity<GameModel>().Property(game => game.platform).IsRequired().HasMaxLength(50);
            builder.Entity<GameModel>().Property(game => game.developer).HasMaxLength(100);
            builder.Entity<GameModel>().Property(game => game.publisher).HasMaxLength(100);
            builder.Entity<GameModel>().Property(game => game.obtained).IsRequired();

            //builder.Entity<GameModel>().HasData
            //(
            //  new GameModel { id = 1, name = "RE5", year = 2005, platform = "X360", genre = "Survival horror", developer = "Capcom", publisher = "Survival horror" },
            //  new GameModel { id = 2, name = "RE0", year = 2003, platform = "PS3", genre = "Survival horror", developer = "Capcom", publisher = "Survival horror" }
            //);

        }
    }
}
