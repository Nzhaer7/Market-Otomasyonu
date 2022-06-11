using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MarketOtomasyonu.Classes;

namespace MarketOtomasyonu.Data
{
	public class MOContext : DbContext
	{
		public DbSet<UrunDb> Urunler { get; set; }






		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer(@"Data Source=.; Database=MODataBase; Integrated Security=yes");
		}
		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{	
			/*urun tablosu olusturulması */

			modelBuilder.Entity<UrunDb>().Property(Urun => Urun.adi)
											  .HasColumnName("Adı")
											  .IsRequired()
											  .HasMaxLength(30);
			modelBuilder.Entity<UrunDb>().Property(Urun => Urun.girisTarihi)
										  .HasColumnName("Giriş Tarihi")
										  .IsRequired();
			modelBuilder.Entity<UrunDb>().Property(Urun => Urun.cikisTarihi)
										  .HasColumnName("Çıkış Tarihi")
										  .IsRequired();
			modelBuilder.Entity<UrunDb>().Property(Urun => Urun.kodu)
										 .HasColumnName("Kodu")
										  .IsRequired()
										  .HasMaxLength(30);
			modelBuilder.Entity<UrunDb>().Property(Urun => Urun.sonKullanimTarihi)
										 .HasColumnName("Son Kullanma Tarihi")
										 .IsRequired();
			modelBuilder.Entity<UrunDb>().Property(Urun => Urun.fiyat)
										 .HasColumnName("Fiyatı")
										 .IsRequired()
										 .HasMaxLength(30);
			modelBuilder.Entity<UrunDb>().Property(Urun => Urun.durumu)
										 .HasColumnName("Stok Durumu")
										 .IsRequired()
										 .HasMaxLength(30);


			/*personel tablosu olusturulması */


			modelBuilder.Entity<PersonelDb>().Property(Personel => Personel.adi)
											  .HasColumnName("Adı")
											  .IsRequired()
											  .HasMaxLength(30);
			modelBuilder.Entity<PersonelDb>().Property(Personel => Personel.girisTarihi)
											  .HasColumnName("Giriş Tarihi")
											  .IsRequired();
			modelBuilder.Entity<PersonelDb>().Property(Personel => Personel.cikisTarihi)
											  .HasColumnName("Çıkış Tarihi")
											  .IsRequired();
			modelBuilder.Entity<PersonelDb>().Property(Personel => Personel.maas)
											 .HasColumnName("Maaş")
									         .IsRequired()
									         .HasMaxLength(30);
			modelBuilder.Entity<PersonelDb>().Property(Personel => Personel.gorev)
											 .HasColumnName("Görevi")
											 .IsRequired()
											 .HasMaxLength(30);
			modelBuilder.Entity<PersonelDb>().Property(Personel => Personel.durumu)
											.HasColumnName("izin Durumu")
										    .IsRequired()
										    .HasMaxLength(30);
			modelBuilder.Entity<PersonelDb>().Property(Personel => Personel.girisid)
											.HasColumnName("Kullanıcı adı")
											.IsRequired()
											.HasMaxLength(30);






		}
	}
}
