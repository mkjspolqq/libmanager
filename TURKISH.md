# libmanager_kutuphane-otomasyon
#### For the English version, check README.md
## Açıklama
Kütüphane otomasyonu programı. C# ile yapılmıştır. Access veri tabanı kullanılmıştır. Yorum satırları türkçedir.

## Yapabildikleri
- Katmanlı Mimari kullanılmıştır.
- Kullanıcı ve Kitap ekleme, silme, güncelleme özellikleri bulunur.
- Kitap ödünç verme ve kabul etme özellikleri vardır.
- Öğrencinin şimdiye kadar aldığı verdiği ve şuan elinde olan kitap görüntülenebilir.
- Öğrencinin geciktirdiği kitaplar, listesinde kırmızı olarak işaretlenir.
- Kitabın teslim süresine iki gün kaldığında uyarı amaçlı sarı işaretlenir.
- Teslim edilmiş kitaplar yeşil renkte işaretlenir.
- Teslim edilmesine 2 gün kalana kadar turkuazla işaretlenir.
- Kitap alma ve iade işlemleri tarihsel düzeyde gerçekleşir.
- Kitap kodu ve adına göre kitap bilgilerine ulaşılabilir.
- Kitabın geciktirildiği her gün için 1 birimlik ceza yazılır.
- Kütüphanedeki tüm kitaplar, öğrenciye verilmiş olan kitaplar ve verilmeye hazır olan kitaplar Zedgrapgh grafik ile gösterilir.

## Katmanlar
### Varlık Katmanı
Access tablolarımızı kodda tek tek oluşturup içindeki sütunları oluşturduğumuz yer. Kod bu sütunlara gelecek değişkenleri oluşturup kapsüllemelerini yapar. Diğer katmanlardan erişimi sağlamak için sınıflar erişilebilirdir.
### Cephe Katmanı
SQL işlemlerinin yapıldığı katman. Bu katman Varlık Katmanı ile beraber çalışmaktadır. Bunu yapabilmesi için başvurulardan Varlık Katmanını eklenmiş ve kullanılan yerlerin tamamında çağırılmıştır. 
### İş Mantık Katmanı
Sunum Katmanından alınan değerlerin kontrolu yapılıp edip Cephe Katmanına yollanır. Sınıflar erişilebilirdir, Varlık Katmanı ile Cephe Katmanı referanslanır, ardından çağırılır.
### Sunum Katmanı
Kullanıcının gördüğü katmandır. Buradan alınan değerler İş Mantık Katmanına yollanır. Diğer katmanlar tekrar burada referanslanır ve çağırılır.
