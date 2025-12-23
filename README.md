# GymManagementSystem
Bu proje, bir spor salonunun üye kayıtlarını dijital ortamda tutmak, ödemeleri takip etmek ve üye bilgilerini yönetmek amacıyla geliştirilmiş bir C# Windows Form uygulamasıdır.
Tam CRUD İşlemleri: Üye ekleme, silme, güncelleme ve listeleme fonksiyonları eksiksiz çalışmaktadır.


Gelişmiş Sorgulama: İsim bazlı dinamik üye arama ve ödeme tutarına göre filtreleme seçenekleri mevcuttur.


Güvenli Veritabanı Mimarisi: SQL Injection saldırılarını önlemek amacıyla Parametreli Sorgular (Prepared Statements) kullanılmıştır.


Hafif Veritabanı: Kurulum gerektirmeyen, dosya tabanlı SQLite veritabanı entegre edilmiştir.
Kullanılan Teknolojiler

Dil: C# (.NET Framework/Core) 


Arayüz: Windows Forms (WinForms) 


Veritabanı: SQLite 


Kütüphane: System.Data.SQLite

proje Yapısı ve Güvenlik
Projeyi geliştirirken kodun sürdürülebilir ve güvenli olmasına dikkat edilmiştir:


Bağlantı Yönetimi: Veritabanı bağlantıları using blokları ile yönetilerek bellek sızıntıları engellenmiştir.


Veri Güvenliği: Kullanıcıdan alınan girdiler doğrudan SQL cümlelerine eklenmek yerine @parametre yöntemiyle işlenmiştir.
