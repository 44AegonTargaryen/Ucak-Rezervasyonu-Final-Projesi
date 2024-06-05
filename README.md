Tabii ki, aşağıda projenizin README dosyasını hazırladım. Bu README dosyasını GitHub'da projenizin ana dizinine koyabilirsiniz.

# Uçak Rezervasyonu Final Projesi

## Proje Açıklaması

Bu proje, bir uçak rezervasyon sistemi geliştirmeyi amaçlamaktadır. Kullanıcılar uçak bileti rezervasyonu yapabilir, uçuş bilgilerini görüntüleyebilir ve rezervasyonlarını yönetebilirler. Proje, Java programlama dili ve SQL veritabanı kullanılarak geliştirilmiştir.

## İçindekiler

- [Kullanılan Teknolojiler](#kullanılan-teknolojiler)
- [Kurulum](#kurulum)
- [Kullanım](#kullanım)
- [Veritabanı Yapısı](#veritabanı-yapısı)

## Kullanılan Teknolojiler

- **Programlama Dili:** Java
- **IDE:** IntelliJ IDEA
- **Veritabanı:** SQL
- **Diğer Araçlar:** Git, GitHub

## Kurulum

Projeyi yerel makinenizde çalıştırmak için aşağıdaki adımları izleyin:

1. **Depoyu Klonlayın:**

   ```sh
   git clone https://github.com/44AegonTargaryen/Ucak-Rezervasyonu-Final-Projesi.git
   ```

2. **Proje Dizinine Geçin:**

   ```sh
   cd Ucak-Rezervasyonu-Final-Projesi
   ```

3. **Gerekli Bağımlılıkları Yükleyin:**

   IntelliJ IDEA kullanarak projeyi açın ve gerekli bağımlılıkların otomatik olarak yüklenmesini sağlayın.

4. **Veritabanını Kurun:**

   SQL dosyasını kullanarak veritabanınızı oluşturun. Veritabanı bağlantı bilgilerini `src/main/resources` dizininde bulunan konfigürasyon dosyasına ekleyin.

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
