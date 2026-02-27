# Boratav-94 YKI Kontrol Uygulaması

![.NET Framework](https://img.shields.io/badge/.NET_Framework-4.5-512BD4?logo=.net&logoColor=white)
![C#](https://img.shields.io/badge/C%23-9.0-239120?logo=c-sharp&logoColor=white)
![Windows Forms](https://img.shields.io/badge/Windows_Forms-Desktop_App-0078D6?logo=windows&logoColor=white)
![Lisans](https://img.shields.io/badge/Lisans-MIT-green)

## Neden Bu Proje?

Boratav-94 YKI, operatörün tek bir masaüstü arayüzü üzerinden yön, kamera ve görsel durum bileşenlerini yönetmesini hedefleyen bir Windows Forms kontrol uygulamasıdır; proje, saha benzeri kullanım senaryolarında hızlı erişilebilirlik ve sade kontrol deneyimi sağlayarak operasyonel karar verme sürecini hızlandırmayı amaçlar.

## Mimari / Özellikler

- .NET Framework 4.5 tabanlı Windows Forms mimarisi
- `ControlForm` üzerinden merkezi kontrol ekranı
- Yeniden kullanılabilir kullanıcı kontrolleri (`Bilesenler/360DrcKontBtn`)
- Resource tabanlı görsel yönetimi (`.resx` + `Resources/`)
- MIT lisansı ile açık kaynak kullanıma uygun yapı

## Güvenlik Denetimi Özeti

- Kod tabanı hardcoded şifre, API anahtarı, token ve yerel kullanıcı yolu desenleri için tarandı.
- Bu sürümde doğrudan gömülü gizli bilgiye rastlanmadı.
- İleride gizli bilgi eklenmesi gerekirse `App.config` içine yazmak yerine ortam değişkenleri kullanılmalıdır.

Örnek (C#):

```csharp
var apiKey = Environment.GetEnvironmentVariable("BORATAV_API_KEY");
if (string.IsNullOrWhiteSpace(apiKey))
{
    throw new InvalidOperationException("BORATAV_API_KEY ortam değişkeni tanımlı değil.");
}
```

## Refactoring Öncelikleri (İlk 3 Adım)

1. `ControlForm` içindeki olay yönetimini ayrı servis sınıflarına bölerek UI ve iş mantığını ayrıştırın.
2. `Bilesenler/360DrcKontBtn` altında yön/kamera kontrol davranışlarını ortak bir arayüzle standardize ederek modülerliği artırın.
3. Uygulama davranışını doğrulamak için en azından temel presenter/service katmanında birim test altyapısı ekleyin.

## Hızlı Başlangıç

> Bu proje Windows ve .NET Framework hedefler. Linux/macOS üzerinde doğrudan derleme desteklenmez.

```bash
git clone https://github.com/furkanisikay/Boratav-94.YKI.git
cd Boratav-94.YKI
msbuild Boratav-94.App.sln /p:Configuration=Release
```

Visual Studio ile çalıştırmak için:

1. `Boratav-94.App.sln` dosyasını açın.
2. Başlangıç projesi olarak `Boratav-94.App` seçin.
3. `F5` ile uygulamayı başlatın.

## Ortam Kurulumu

- Windows 10/11
- Visual Studio 2019+ (Windows Desktop Development bileşeni)
- .NET Framework 4.5 Targeting Pack

Gizli bilgiler için önerilen ortam değişkeni tanımlama (PowerShell):

```powershell
setx BORATAV_API_KEY "ornek-deger"
```

## Katkı

Katkı süreci için lütfen [CONTRIBUTING.md](./CONTRIBUTING.md) dosyasını inceleyin.

## Lisans

Bu proje [MIT Lisansı](./LICENSE) ile lisanslanmıştır.
