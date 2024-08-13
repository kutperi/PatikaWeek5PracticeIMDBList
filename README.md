# IMDB Film Listesi Uygulaması

Bu C# konsol uygulaması, kullanıcıların film isimleri ve IMDb puanlarını içeren bir film listesi oluşturmasına ve yönetmesine olanak tanır. Uygulama, film ekleme, tüm filmleri listeleme, IMDb puanına göre filtreleme ve 'A' harfi ile başlayan filmleri listeleme gibi işlevler sunar.

## İçindekiler

- [Özellikler](#özellikler)
- [Kullanım](#kullanım)
- [Kodun Genel Bakışı](#kodun-genel-bakışı)
- [Gereksinimler](#gereksinimler)

## Özellikler

- **Film Ekleme**: Kullanıcılar, film adlarını ve ilgili IMDb puanlarını girebilirler.
- **Tüm Filmleri Listele**: Koleksiyondaki tüm filmler ve IMDb puanları listelenir.
- **IMDb Puanına Göre Filtreleme**: IMDb puanı 4 ile 9 arasında olan filmleri listeler.
- **Baş Harfe Göre Filtreleme**: Adı 'A' harfi ile başlayan filmleri listeler.

## Kodun Genel Bakışı

### Movie Sınıfı

`Movie` sınıfı, aşağıdaki özelliklere sahip bir filmi temsil etmek için tasarlanmıştır:

- `ImdbRate`: Filmin IMDb puanı.
- `MovieName`: Filmin adı.

Sınıf ayrıca belirli kriterlere göre filmleri görüntülemek için aşağıdaki yöntemleri içerir:

- `DisplayAllMovies()`: Filmin adını ve IMDb puanını görüntüler.
- `DisplayOnly4Between9()`: IMDb puanı 4 ile 9 arasında olan filmleri görüntüler.
- `DisplayStartingLetterA()`: Adı 'A' harfi ile başlayan filmleri görüntüler.

### Ana Program

Ana program şu adımları gerçekleştirir:

1. **Girdi Döngüsü**: Kullanıcı, 'q' yazarak durana kadar sürekli olarak film bilgilerini girmeye teşvik edilir.
2. **Doğrulama**: IMDb puanının 0 ile 10 arasında bir sayı olup olmadığını doğrular.
3. **Film Listesi Yönetimi**: Geçerli filmleri bir listeye ekler.
4. **Görüntüleme İşlevleri**: Tüm filmleri, IMDb puanı 4 ile 9 arasında olan filmleri ve adı 'A' harfi ile başlayan filmleri görüntüler.

## Gereksinimler

- .NET Core SDK

