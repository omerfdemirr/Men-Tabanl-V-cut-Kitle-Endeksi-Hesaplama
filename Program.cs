namespace Menü_Tabanlı_Vücut_Kitle_Endeksi_Hesaplama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Vücut Kitle Endeksi Hesaplama ===\n");
            while (true)
            {
                Console.WriteLine("1. Vücut Kitle Endeksi Hesapla");
                Console.WriteLine("2. Sağlık Önerilerini Görüntüle");
                Console.WriteLine("3. Çıkış Yap\n");
                Console.Write("Seçiminizi yapın (1-3): ");

                string seçim = Console.ReadLine();

                switch (seçim)
                {
                    case "1":
                        VucutKitleEndeksiHesapla();
                        break;
                    case "2":
                        SaglikOnerileri();
                        break;
                    case "3":
                        Console.WriteLine("Programdan çıkılıyor. Sağlıklı günler dileriz!");
                        return;
                    default:
                        Console.WriteLine("Geçersiz seçim! Lütfen 1-3 arasında bir değer girin.\n");
                        break;
                }
            }
        }

        static void VucutKitleEndeksiHesapla()
        {
            Console.WriteLine("\n--- Vücut Kitle Endeksi Hesaplama ---");

            double boy = 0, kilo = 0;

            // Boy girişi
            while (true)
            {
                Console.Write("Boyunuzu metre cinsinden girin (örnek: 1.75): ");
                if (double.TryParse(Console.ReadLine(), out boy) && boy > 0)
                {
                    break;
                }
                Console.WriteLine("Hatalı giriş! Boy sıfırdan büyük ve metre cinsinden olmalıdır.\n");
            }

            // Kilo girişi
            while (true)
            {
                Console.Write("Kilonuzu kilogram cinsinden girin: ");
                if (double.TryParse(Console.ReadLine(), out kilo) && kilo > 0)
                {
                    break;
                }
                Console.WriteLine("Hatalı giriş! Kilo sıfırdan büyük ve kilogram cinsinden olmalıdır.\n");
            }

            // Vücut Kitle Endeksi Hesaplama
            double vke = kilo / (boy * boy);
            Console.WriteLine($"\nVücut Kitle Endeksiniz: {vke:F2}");

            // Sınıflandırma
            if (vke < 18.5)
            {
                Console.WriteLine("Durum: Zayıf - Daha dengeli bir diyetle kilo almayı hedefleyin.");
            }
            else if (vke >= 18.5 && vke < 24.9)
            {
                Console.WriteLine("Durum: Normal kilolu - Harika! Mevcut formunuzu koruyun.");
            }
            else if (vke >= 25 && vke < 29.9)
            {
                Console.WriteLine("Durum: Fazla kilolu - Düzenli egzersiz ve sağlıklı bir diyet önerilir.");
            }
            else
            {
                Console.WriteLine("Durum: Obez - Doktor veya diyetisyen tavsiyesi almayı düşünmelisiniz.");
            }

            Console.WriteLine("\nAna menüye dönmek için bir tuşa basın...");
            Console.ReadKey();
        }

        static void SaglikOnerileri()
        {
            Console.WriteLine("\n--- Sağlık Önerileri ---");
            Console.WriteLine("1. Günde en az 30 dakika yürüyüş yapın.");
            Console.WriteLine("2. Dengeli bir diyet ile beslenmeye dikkat edin.");
            Console.WriteLine("3. Düzenli uyku alışkanlıkları oluşturun (7-8 saat).");
            Console.WriteLine("4. Stres seviyenizi düşük tutmaya çalışın.");
            Console.WriteLine("5. Bol su için (günde yaklaşık 2 litre).\n");
            Console.WriteLine("Ana menüye dönmek için bir tuşa basın...");
            Console.ReadKey();
        }

    }
    }

