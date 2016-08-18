namespace COMP2006_S2016_FinalExamV2.Models
{
    /**Made By Gurpanth Singh
Final Exam
Student No. 200299024
Music Stroe Update
**/

    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class MVCMusicStoreContext : DbContext
    {
        public MVCMusicStoreContext()
            : base("name=MVCMusicStoreContext")
        {
        }

        public virtual DbSet<Album> Albums { get; set; }
        public virtual DbSet<Artist> Artists { get; set; }
        public virtual DbSet<Genre> Genres { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
