using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace LivraisonWebAPi.Models
{
    public partial class gestion_livraisonContext : DbContext
    {
        public gestion_livraisonContext()
        {
        }

        public gestion_livraisonContext(DbContextOptions<gestion_livraisonContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Agence> Agences { get; set; }
        public virtual DbSet<ClientPar> ClientPars { get; set; }
        public virtual DbSet<ClientPro> ClientProes { get; set; }
        public virtual DbSet<Commande> Commandes { get; set; }
        public virtual DbSet<Livreur> Livreurs { get; set; }
        public virtual DbSet<Responsable> Responsables { get; set; }
        public virtual DbSet<Superadmin> Superadmins { get; set; }
        public virtual DbSet<Ville> Villes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Name=GestionLivraisonDB");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Agence>(entity =>
            {
                entity.HasKey(e => e.IdAgence);

                entity.ToTable("agence");

                entity.Property(e => e.IdAgence).HasColumnName("id_agence");

                entity.Property(e => e.Adresse)
                    .HasColumnName("adresse")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IdResponsable).HasColumnName("id_responsable");

                entity.Property(e => e.IdSuperadmin).HasColumnName("id_superadmin");

                entity.Property(e => e.IdVille).HasColumnName("id_ville");

                entity.Property(e => e.Mdp)
                    .HasColumnName("mdp")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Moyens).HasColumnName("moyens");

                entity.Property(e => e.Nom)
                    .HasColumnName("nom")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Tel)
                    .HasColumnName("tel")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdResponsableNavigation)
                    .WithMany(p => p.Agences)
                    .HasForeignKey(d => d.IdResponsable)
                    .HasConstraintName("FK__agence__id_respo__5535A963");

                entity.HasOne(d => d.IdSuperadminNavigation)
                    .WithMany(p => p.Agences)
                    .HasForeignKey(d => d.IdSuperadmin)
                    .HasConstraintName("FK__agence__id_super__571DF1D5");

                entity.HasOne(d => d.IdVilleNavigation)
                    .WithMany(p => p.Agences)
                    .HasForeignKey(d => d.IdVille)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__agence__id_ville__5629CD9C");
            });

            modelBuilder.Entity<ClientPar>(entity =>
            {
                entity.HasKey(e => e.Idclpar);

                entity.ToTable("client_par");

                entity.Property(e => e.Idclpar).HasColumnName("idclpar");

                entity.Property(e => e.Adresse)
                    .HasColumnName("adresse")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CommandeALivrer)
                    .HasColumnName("commande_a_livrer")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Dtn)
                    .HasColumnName("dtn")
                    .HasColumnType("date");

                entity.Property(e => e.Email)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.IdVille).HasColumnName("id_ville");

                entity.Property(e => e.Mdp)
                    .HasColumnName("mdp")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Nom)
                    .HasColumnName("nom")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Prenom)
                    .HasColumnName("prenom")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Tel)
                    .IsRequired()
                    .HasColumnName("tel")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.TelWtsp)
                    .HasColumnName("Tel_wtsp")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdVilleNavigation)
                    .WithMany(p => p.ClientPars)
                    .HasForeignKey(d => d.IdVille)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__client_pa__id_vi__60A75C0F");
            });

            modelBuilder.Entity<ClientPro>(entity =>
            {
                entity.HasKey(e => e.IdClientpro);

                entity.ToTable("client_pro");

                entity.Property(e => e.IdClientpro).HasColumnName("id_clientpro");

                entity.Property(e => e.Adresse)
                    .HasColumnName("adresse")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Cin)
                    .HasColumnName("cin")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CommandeALivrer)
                    .HasColumnName("commande_a_livrer")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Dtn)
                    .HasColumnName("dtn")
                    .HasColumnType("date");

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ice)
                    .HasColumnName("ice")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.IdVille).HasColumnName("id_ville");

                entity.Property(e => e.Mdp)
                    .HasColumnName("mdp")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Nom)
                    .HasColumnName("nom")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NomEntreprise)
                    .HasColumnName("nom_entreprise")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Prenom)
                    .HasColumnName("prenom")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Rc)
                    .HasColumnName("rc")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SecteurActivite)
                    .HasColumnName("secteur_activite")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SiteWeb)
                    .HasColumnName("site_web")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Tel)
                    .IsRequired()
                    .HasColumnName("tel")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.TelWtsp)
                    .HasColumnName("Tel_wtsp")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Tp)
                    .HasColumnName("tp")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdVilleNavigation)
                    .WithMany(p => p.ClientProes)
                    .HasForeignKey(d => d.IdVille)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__client_pr__id_vi__4D94879B");
            });

            modelBuilder.Entity<Commande>(entity =>
            {
                entity.HasKey(e => e.IdCommande);

                entity.ToTable("commande");

                entity.Property(e => e.IdCommande).HasColumnName("id_commande");

                entity.Property(e => e.Categorie)
                    .HasColumnName("categorie")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DateLivraison)
                    .HasColumnName("date_livraison")
                    .HasColumnType("date");

                entity.Property(e => e.DateSaisie)
                    .HasColumnName("date_saisie")
                    .HasColumnType("date");

                entity.Property(e => e.IdAgence).HasColumnName("id_agence");

                entity.Property(e => e.IdClientpar).HasColumnName("id_clientpar");

                entity.Property(e => e.IdClientpro).HasColumnName("id_clientpro");

                entity.Property(e => e.IdLivreur).HasColumnName("id_livreur");

                entity.Property(e => e.Prix).HasColumnName("prix");

                entity.Property(e => e.Produit)
                    .HasColumnName("produit")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Statue)
                    .HasColumnName("statue")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.VilleSortie)
                    .HasColumnName("ville_sortie")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdAgenceNavigation)
                    .WithMany(p => p.Commandes)
                    .HasForeignKey(d => d.IdAgence)
                    .HasConstraintName("FK__commande__id_age__656C112C");

                entity.HasOne(d => d.IdClientparNavigation)
                    .WithMany(p => p.Commandes)
                    .HasForeignKey(d => d.IdClientpar)
                    .HasConstraintName("FK__commande__id_cli__6383C8BA");

                entity.HasOne(d => d.IdClientproNavigation)
                    .WithMany(p => p.Commandes)
                    .HasForeignKey(d => d.IdClientpro)
                    .HasConstraintName("FK__commande__id_cli__6477ECF3");

                entity.HasOne(d => d.IdLivreurNavigation)
                    .WithMany(p => p.Commandes)
                    .HasForeignKey(d => d.IdLivreur)
                    .HasConstraintName("FK__commande__id_liv__66603565");
            });

            modelBuilder.Entity<Livreur>(entity =>
            {
                entity.HasKey(e => e.IdLivreur);

                entity.ToTable("livreur");

                entity.Property(e => e.IdLivreur).HasColumnName("id_livreur");

                entity.Property(e => e.Adresse)
                    .HasColumnName("adresse")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.IdAgence).HasColumnName("id_agence");

                entity.Property(e => e.IdVille).HasColumnName("id_ville");

                entity.Property(e => e.Mdp)
                    .HasColumnName("mdp")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NomLivreur)
                    .HasColumnName("nom_livreur")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Permis)
                    .HasColumnName("permis")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PrenomLivreur)
                    .HasColumnName("prenom_livreur")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Tel)
                    .HasColumnName("tel")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Vehicule)
                    .HasColumnName("vehicule")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdAgenceNavigation)
                    .WithMany(p => p.Livreurs)
                    .HasForeignKey(d => d.IdAgence)
                    .HasConstraintName("FK__livreur__id_agen__5AEE82B9");

                entity.HasOne(d => d.IdVilleNavigation)
                    .WithMany(p => p.Livreurs)
                    .HasForeignKey(d => d.IdVille)
                    .HasConstraintName("FK__livreur__id_vill__59FA5E80");
            });

            modelBuilder.Entity<Responsable>(entity =>
            {
                entity.HasKey(e => e.IdResponsable);

                entity.ToTable("responsable");

                entity.Property(e => e.IdResponsable).HasColumnName("id_responsable");

                entity.Property(e => e.LoginResponsable)
                    .HasColumnName("login_responsable")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.MdpResponsable)
                    .HasColumnName("mdp_responsable")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NomResponsable)
                    .HasColumnName("nom_responsable")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PrenomResponsable)
                    .HasColumnName("prenom_responsable")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ville).HasColumnName("ville");

                entity.HasOne(d => d.VilleNavigation)
                    .WithMany(p => p.Responsables)
                    .HasForeignKey(d => d.Ville)
                    .HasConstraintName("FK__responsab__ville__52593CB8");
            });

            modelBuilder.Entity<Superadmin>(entity =>
            {
                entity.ToTable("superadmin");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Mdp)
                    .HasColumnName("mdp")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Ville>(entity =>
            {
                entity.ToTable("ville");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.NomVille)
                    .HasColumnName("nom_ville")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });
        }
    }
}
