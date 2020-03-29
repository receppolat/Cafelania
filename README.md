# Cafelania
 cafeOtomation with EntityCodeFirst
Giriş Formu
•	Formu sadece kapatabilir. Formu büyütüp küçültemez, aşağıya indiremez.
•	Kafe adı bilgisi görünebilir, şifresi ‘*’ ile şifrelenmiştir.
•	Eğer kafe adı “Admin”, şifresi “pass” ise Yönetici olarak giriş yapılmıştır.
        1.	Ürün İşlemleri
        2.	Kategori İşlemleri
        3.	Kafe ve Personel İşlemleri
        ‘ni yapabilir.
•	Veri tabanından çekilen bilgiler ile giriş yapılan bilgiler aynı ise sisteme yetkilendirme olmadan giriş yapılır. Bu durumda sadece masa işlemlerini yapabilmektedir.
•	Eğer Admin değilse ve veri tabanındaki bilgilerle eşleşmiyorsa “Böyle bir kullanıcı yoktur.” mesajını verir.
Main Form
•	Formu sadece kapatabilir. Formu büyütüp küçültemez, aşağıya indiremez.
•	Butonlar dinamik yapı ile Flow Layout Panel içerisine ekleniyor. Her buton arasına panel ve her 16 butonda bir panel ekleniyor. 
•	Eklenen buton sayısı veri tabanından çekiliyor. Böylelikle istediğimiz kadar buton ekleyebilir.
•	Butonlar masaları temsil eder.
•	Eğer masaya ait sipariş varsa ve güncelse butonun arka plan rengi koyu kırmızı, sipariş yoksa arka planına gri rengi atanır.
•	Admin yetkilendirilmişse menü gelir ve bu menüden 
        1.	Ürün İşlemleri
        2.	Kategori İşlemleri
        3.	Kafe ve Personel İşlemleri
        sayfalarına geçiş yapılabilir.
•	Masaların renkleri hakkında bilgilendirme metinleri formun içinde yazmaktadır.
•	MasaOlustur() fonksiyonu vardır ve bu fonksiyon ile: 
        	Masa sayısı dinamik gelir.
        	Butonların renklendirilmesi yapılır.
        	Butonların konumları ayarlanır.
        	İstenildiği kadar buton oluşturulur.
        	Butona tıklandığında eğer masada sipariş varsa yani doluysa direkt TableForm()’u açar eğer sipariş yoksa yani boşsa direkt             LoadingForm()’u yani kuver formunu açar.





Ürün Formu
•	Listview1’e veri tabanından ürünleri çeker ve listeler.
•	Listview1 içinde yani ürünlerde filtreleyerek arama yapabiliriz. Sadece Ürün adına göre.
•	Yeni bir ürün eklenebilir lakin aynı isme sahip bir ürün yoksa. Varsa mesaj verir: “Böyle bir ürün zaten vardır.”. Ve en önemlisi küçük-büyük harf duyarlılığı vardır. Örn: Çay var ise çay eklenemez.
•	 Yeni ürün eklenirken ürün adı, kategori adı ve ürün fiyatı istenir. Hepsini doldurmak mecburidir ve kategori adı “cbtur” isimli ComboBox’a veri tabanında kayıtlı olan tür isimleri getirilir.
•	Ürün silinebilir ve ürün ismi, fiyatı, kategori adı düzenlenebilir.

Kategori İşlemleri
•	Listview1’e veri tabanından kategorileri çeker ve listeler.
•	Yeni kategori eklenebilir lakin aynı isme ait kategori yoksa. Varsa mesaj verir: “Böyle bir kategori zaten vardır.”. Ve en önemlisi küçük-büyük harf duyarlılığı vardır. Örn: Sıcak İçecekler var ise sıcak içecekler eklenemez.
•	Yeni ürün eklerken tbadi adlı TextBox’a kategori adını yazarken aynı zamanda ListView1 içinde de filtreleyerek arama yapılır. 
•	Kategori silinebilir ve kategori ismi düzenlenebilir. 

Kafe ve Personel İşlemleri
•	Listview1’e veri tabanından personel bilgilerini çeker ve listeler (TC, Adı, Soyadı, Telefon Numarası, Görevi).
•	Yeni personel eklenebilir. Aynı TC kimlik numarasına sahip personeller eklenemez.
•	Personeller silinebilir ve düzenlenebilir. Düzenlenirken de var olan TC kimlik numaraları içinde arama yapar ve aynıysa düzenlemeye izin vermez.
•	Masa sayısı burada ayarlanabilir. İlk değer 10’dur.
•	Kafeye ait giriş bilgileri burada düzenlenebilmektir. Varsayılan kafe adı = “3434” parolası = “4356”’dır.

TableForm()
•	Listview1’e veri tabanından aktif olan ve masa numaraları aynı olan bütün siparişleri çeker ve listeler.
•	Dinamik yapıda kategoriler ve bu kategorilere bağlı ürünler gelir. Tasarım asla bozulmaz.
•	Seçili olan sipariş silinebilir. Seçili sipariş yoksa hata mesajı verir.
•	Ara toplam alınmadan ödeme yapılmamalı. Ara toplam alıp fiş detaylarını bir .pdf uzantılı dosyaya kaydeder, dosya adı fiş numarası ile aynıdır. Eğer ara toplam alındıktan sonra ödeme işlemi yapılırsa fisNo.pdf dosyası açılır ve Müşteri isteğine bağlı bir şekilde yazdırılabilir veya mail yolu ile fişi anında iletebiliriz.
•	Sipariş eklendikten hemen sonra o siparişe ait açıklama ekleyebiliriz. Böylelikle o açıklamayı varsa diğer cihazlardan kafe barına veya mutfağa sipariş gönderebilir.
Genel olarak proje okunabilirliği ve yazılabilirliği açıktır. Açık kaynak koduna sahiptir.

Recep Polat
Kastamonu Üniversitesi 
Bilgisayar Mühendisliği | 2.Sınıf
@8269676980
