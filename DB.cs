namespace ArhiCRMv2
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DB : DbContext
    {
        public DB()
            : base("name=DB")
        {
        }

        public virtual DbSet<Amplasament> Amplasaments { get; set; }
        public virtual DbSet<Aviz> Avizs { get; set; }
        public virtual DbSet<Avizator> Avizators { get; set; }
        public virtual DbSet<AvizToProiectMapping> AvizToProiectMappings { get; set; }
        public virtual DbSet<Beneficiar> Beneficiars { get; set; }
        public virtual DbSet<Colaborator> Colaborators { get; set; }
        public virtual DbSet<Judet> Judets { get; set; }
        public virtual DbSet<Localitate> Localitates { get; set; }
        public virtual DbSet<Observatie> Observaties { get; set; }
        public virtual DbSet<Plata> Platas { get; set; }
        public virtual DbSet<Proiect> Proiects { get; set; }
        public virtual DbSet<ProiectTehnic> ProiectTehnics { get; set; }
        public virtual DbSet<ProiectTehnicToProiectMapping> ProiectTehnicToProiectMappings { get; set; }
        public virtual DbSet<ResponsabilitateBeneficiar> ResponsabilitateBeneficiars { get; set; }
        public virtual DbSet<ResponsabilitateToProiectMapping> ResponsabilitateToProiectMappings { get; set; }
        public virtual DbSet<Status> Status { get; set; }
        public virtual DbSet<Studiu> Studius { get; set; }
        public virtual DbSet<StudiuToProiectMapping> StudiuToProiectMappings { get; set; }
        public virtual DbSet<TipProiect> TipProiects { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Amplasament>()
                .Property(e => e.SuprafataTerenMasurata)
                .HasPrecision(17, 2);

            modelBuilder.Entity<Plata>()
                .Property(e => e.Suma)
                .HasPrecision(17, 2);

            modelBuilder.Entity<ResponsabilitateBeneficiar>()
                .HasMany(e => e.ResponsabilitateToProiectMappings)
                .WithOptional(e => e.ResponsabilitateBeneficiar)
                .HasForeignKey(e => e.ResponsabilitateID);
        }
    }
}
