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
		public DbSet<PersonelDb> Personeller { get; set; }
		public DbSet<malzemeDb> Malzemeler { get; set; }
		public DbSet<KullaniciDb> Kullanici { get; set; }
		public DbSet<MarketCiroDb> Ciro { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer(@"Data Source=.; Database=MODataBase; Integrated Security=yes");
		}
		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{	
			/*urun tablosu olusturulması */

			modelBuilder.Entity<UrunDb>().Property(Urun => Urun.adi)
											.HasColumnName("Adı")
										    .HasMaxLength(30);

            modelBuilder.Entity<UrunDb>().Property(Urun => Urun.girisTarihi)
                                          .HasColumnName("Giriş Tarihi");

			modelBuilder.Entity<UrunDb>().Property(Urun => Urun.kodu)
										 .HasColumnName("Kodu")
										  .HasMaxLength(30);


            modelBuilder.Entity<UrunDb>().Property(Urun => Urun.cikisTarihi)
                                          .HasColumnName("Çıkış Tarihi");

            modelBuilder.Entity<UrunDb>().Property(Urun => Urun.sonKullanimTarihi)
                                         .HasColumnName("Son Kullanma Tarihi");

			modelBuilder.Entity<UrunDb>().Property(Urun => Urun.fiyat)
										 .HasColumnName("Fiyatı")
										 .HasMaxLength(30);

            modelBuilder.Entity<UrunDb>().Property(Urun => Urun.sinifi)
                                         .HasColumnName("Sınıfı")
                                         .HasMaxLength(30);

            modelBuilder.Entity<UrunDb>().Property(Urun => Urun.durumu)
										 .HasColumnName("Stok Durumu")
										 .HasMaxLength(30);

			DateTime dt = new DateTime(2022, 06, 10);
            DateTime dt2 = new DateTime(2022, 06, 18);
            DateTime dt3 = new DateTime(2023, 06, 18);

			modelBuilder.Entity<UrunDb>().HasData(new UrunDb { id = 1, adi = "dido", girisTarihi = dt,cikisTarihi=dt2, kodu = "1500abc", sonKullanimTarihi = dt3, fiyat ="15,5",sinifi="gofret", durumu = 1 });
			


			/*personel tablosu olusturulması */


			modelBuilder.Entity<PersonelDb>().Property(Personel => Personel.adi)
											  .HasColumnName("Adı")
											  .HasMaxLength(30);

            modelBuilder.Entity<PersonelDb>().Property(Personel => Personel.girisTarihi)
                                              .HasColumnName("Giriş Tarihi");

            modelBuilder.Entity<PersonelDb>().Property(Personel => Personel.cikisTarihi)
                                              .HasColumnName("Çıkış Tarihi");

            modelBuilder.Entity<PersonelDb>().Property(Personel => Personel.maas)
											 .HasColumnName("Maaş")
									         .HasMaxLength(30);

			modelBuilder.Entity<PersonelDb>().Property(Personel => Personel.gorev)
											 .HasColumnName("Görevi")
											 .HasMaxLength(30);

			modelBuilder.Entity<PersonelDb>().Property(Personel => Personel.durumu)
											.HasColumnName("izin Durumu")
										    .HasMaxLength(30);

			modelBuilder.Entity<PersonelDb>().Property(Personel => Personel.girisid)
											.HasColumnName("Kullanıcı adı")
											.HasMaxLength(30);

			modelBuilder.Entity<PersonelDb>().HasData(new PersonelDb { id = 1, adi = "kamil", girisTarihi = dt, cikisTarihi = dt2, maas = 2750.75f, gorev = "kasiyer", girisid = "kartal123", durumu = "izinli" });
			/*malzeme tablosu olusturulması */


			modelBuilder.Entity<malzemeDb>().Property(malzeme => malzeme.durumu)
											.HasColumnName("Malzeme Durumu")
											.HasMaxLength(30);

			modelBuilder.Entity<malzemeDb>().Property(malzeme => malzeme.turu)
											.HasColumnName("Malzeme turu")
											.HasMaxLength(30);

			modelBuilder.Entity<malzemeDb>().Property(malzeme => malzeme.adedi)
											.HasColumnName("Malzeme Adedi")
											.HasMaxLength(30);

			modelBuilder.Entity<malzemeDb>().Property(malzeme => malzeme.bildiren)
											.HasColumnName("Bildiren Personel :")
											.HasMaxLength(30);

			modelBuilder.Entity<malzemeDb>().HasData(new malzemeDb { id = 1, durumu = "sağlam", turu = "dolap", adedi = 5, bildiren="feyyaz" });

            /*musteri sepet oluşturulması*/


            modelBuilder.Entity<musteriSepetDb>().Property(musteriSepet => musteriSepet.adedi)
                                            .HasColumnName("Ürün Adedi :");
											
			modelBuilder.Entity<musteriSepetDb>().Property(musteriSepet => musteriSepet.adi)
											.HasColumnName("Ürün Adı :")
											.HasMaxLength(30);

			modelBuilder.Entity<musteriSepetDb>().Property(musteriSepet => musteriSepet.fiyat)
										.HasColumnName("Ürün fiyatı :")
										.HasMaxLength(30);

            modelBuilder.Entity<musteriSepetDb>().Property(musteriSepet => musteriSepet.toplam)
                                        .HasColumnName("Sepet Toplam   :");

            modelBuilder.Entity<musteriSepetDb>().Property(musteriSepet => musteriSepet.giderid)
                                        .HasColumnName("Gider id :");

            modelBuilder.Entity<musteriSepetDb>().Property(musteriSepet => musteriSepet.gelirid)
                                        .HasColumnName("Gelir id :");

            modelBuilder.Entity<musteriSepetDb>().Property(musteriSepet => musteriSepet.urunid)
                                        .HasColumnName("Ürün id :");

			modelBuilder.Entity<musteriSepetDb>().Property(musteriSepet => musteriSepet.urunKodu)
										.HasColumnName("Ürün Kodu :")
										.HasMaxLength(30);

			modelBuilder.Entity<musteriSepetDb>().HasData(new musteriSepetDb { id = 1, adedi = 5, adi = "goflet", fiyat = 2.75f, giderid = "asas", gelirid = "safas", urunid = "atıştırmalık", urunKodu = "356asd" });

			/*Kullanici oluşturulması*/

			modelBuilder.Entity<KullaniciDb>().Property(Kullanici => Kullanici.kullaniciAdi)
										.HasColumnName("Kullanıcı Adı :")
										.HasMaxLength(30);

			modelBuilder.Entity<KullaniciDb>().Property(Kullanici => Kullanici.mail)
										   .HasColumnName("Mail :")
												.HasMaxLength(30);
		
			modelBuilder.Entity<KullaniciDb>().Property(Kullanici => Kullanici.sifre)
											.HasColumnName("sifre :")
											.HasMaxLength(30);

			modelBuilder.Entity<KullaniciDb>().HasData(new KullaniciDb { id = 1, kullaniciAdi ="deneme", mail = "deneme@mail", sifre = "Deneme123." });


			/*ciro oluşturulması*/

			modelBuilder.Entity<MarketCiroDb>().Property(Ciro => Ciro.gider)
											.HasColumnName("Haftalık Gider :")
											.HasMaxLength(30);
			modelBuilder.Entity<MarketCiroDb>().Property(Ciro => Ciro.gelir)
											.HasColumnName("Haftalık Gelir :")
											.HasMaxLength(30);
			modelBuilder.Entity<MarketCiroDb>().Property(Ciro => Ciro.ciro)
											.HasColumnName("Haftalık Ciro :")
											.HasMaxLength(30);
			modelBuilder.Entity<MarketCiroDb>().HasData(new MarketCiroDb { id = 1, gider = "0", gelir = "0", ciro = "0" });
		}
	}
}
