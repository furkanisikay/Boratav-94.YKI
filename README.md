# Boratav-94 YKI Kontrol Uygulaması

![.NET Framework](https://img.shields.io/badge/.NET_Framework-4.5-512BD4?logo=.net&logoColor=white)
![C#](https://img.shields.io/badge/C%23-5.0-239120?logo=c-sharp&logoColor=white)
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

> Kritik Not: .NET Framework 4.5 desteği sona ermiştir ve güvenlik güncellemesi almamaktadır; üretim kullanımı için .NET Framework 4.8'e yükseltme yapılması gereklidir.

## Katkı

Katkı süreci için lütfen [CONTRIBUTING.md](./CONTRIBUTING.md) dosyasını inceleyin.

## Lisans

Bu proje [MIT Lisansı](./LICENSE) ile lisanslanmıştır.
