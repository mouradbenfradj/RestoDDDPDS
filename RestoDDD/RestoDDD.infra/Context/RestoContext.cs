using RestoDDD.Domaine.Entities;
using RestoDDD.infra.EntityConfig;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Data.Entity.Validation;

namespace RestoDDD.infra.Context
{
    public class RestoContext : DbContext
    {
        static RestoContext()
        {
            Database.SetInitializer<RestoContext>(null);
        }



        public DbSet<Restaurant> Restaurants { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<Cuisine> Cuisines { get; set; }
        public DbSet<Table> Tables { get; set; }
        public DbSet<Images> Images { get; set; }

        public DbSet<Note> Notes { get; set; }
        public DbSet<Menu> Menus { get; set; }
        public DbSet<GeoCoord> GeoCoords { get; set; }
        public DbSet<Facture> Factures { get; set; }
        public DbSet<Compte> Comptes { get; set; }
        public DbSet<Commentaire> Commentaires { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            //Configure domain classes using Fluent API here
            //toute la configuration de l'entité administrateur se trouve dans AdminEntityConfiguration()
            modelBuilder.Configurations.Add(new CompteEntityConfiguration());
            modelBuilder.Configurations.Add(new RestoEntityConfiguration());
            modelBuilder.Configurations.Add(new ResvEntityConfiguration());
            modelBuilder.Configurations.Add(new CommentEntityConfiguration());
            modelBuilder.Configurations.Add(new NoteEntityConfiguration());
            modelBuilder.Configurations.Add(new MenuEntityConfiguration());
            modelBuilder.Configurations.Add(new CuisineEntityConfiguration());


            base.OnModelCreating(modelBuilder);
        }
    }
}
