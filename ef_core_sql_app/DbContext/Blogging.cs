namespace ef_core_sql_app
{
    using System;
    using System.Data.Entity;
    using ef_core_sql_app.Models;

    public partial class Blogging : DbContext
    {
        public Blogging()
            : base("name=Blogging")
        {
        }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //One to many
            modelBuilder.Entity<Post>()
                .HasRequired(p => p.Blog)
                .WithMany(b => b.Posts)
                .HasForeignKey(p => p.BlogId);

        }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Blog> Blogs { get; set; }
    }
}
