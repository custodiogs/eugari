using EuGari.Domain;
using EuGari.Infra.Mappings;
using System.Data.Entity;

namespace EuGari.Infra.DataContext
{
    public class MyDataContext:DbContext
    {
        public MyDataContext():base("StringConexao")
        {
            Database.SetInitializer<MyDataContext>(null);//Disable initializer
        }
        public DbSet<Pessoa> Pessoa { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new PessoaMap());
            base.OnModelCreating(modelBuilder);
        }
    }
}
