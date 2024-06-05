Tabii ki, aşağıda projenizin README dosyasını hazırladım. Bu README dosyasını GitHub'da projenizin ana dizinine koyabilirsiniz.

# Uçak Rezervasyonu Final Projesi

## Proje Açıklaması

Bu proje, bir uçak rezervasyon sistemi geliştirmeyi amaçlamaktadır. Kullanıcılar uçak bileti rezervasyonu yapabilir, uçuş bilgilerini görüntüleyebilir ve rezervasyonlarını yönetebilirler. Proje, Java programlama dili ve SQL veritabanı kullanılarak geliştirilmiştir.

## İçindekiler

- [Kullanılan Teknolojiler](#kullanılan-teknolojiler)
- [Kullanım](#kullanım)
- [Veritabanı Yapısı](#veritabanı-yapısı)

## Kullanılan Teknolojiler

- **Programlama Dili:** Java
- **IDE:** IntelliJ IDEA
- **Veritabanı:** SQL
- **Diğer Araçlar:** Git, GitHub

## Kullanım

1. **Uçuşları Görüntüleyin:**
   - Mevcut uçuşları görüntüleyin ve filtreleme seçeneklerini kullanarak arama yapın.

2. **Rezervasyon Yapın:**
   - Seçtiğiniz uçuş için rezervasyon yapın ve bilet bilgilerinizi alın.

3. **Rezervasyonlarınızı Yönetin:**
   - Mevcut rezervasyonlarınızı görüntüleyin, güncelleyin veya iptal edin.

## Veritabanı Yapısı

Projenin veritabanı yapısı aşağıdaki gibidir:

- **Kullanıcılar:**
  - Kullanıcı ID
  - Kullanıcı Adı
  - Şifre
  - Email

- **Uçuşlar:**
  - Uçuş ID
  - Kalkış Yeri
  - Varış Yeri
  - Kalkış Tarihi
  - Varış Tarihi

- **Rezervasyonlar:**
  - Rezervasyon ID
  - Kullanıcı ID
  - Uçuş ID
  - Rezervasyon Tarihi
