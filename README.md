# MeetingApp

Bu proje, **ASP.NET Core MVC** öğrenmek amacıyla geliştirilmiş basit bir toplantı başvuru uygulamasıdır.

## 📚 Öğrenme Amaçlı Proje

Bu proje, ASP.NET Core MVC temellerini öğrenmek için oluşturulmuş eğitim amaçlı bir uygulamadır. Gerçek bir üretim ortamında kullanılmak üzere tasarlanmamıştır.

## 🎯 Proje Özellikleri

- **ASP.NET Core 7.0 MVC** ile geliştirilmiştir
- Toplantı bilgilerini görüntüleme
- Toplantıya katılım başvurusu yapma
- Başvuru yapan kullanıcıları listeleme
- Kullanıcı detaylarını görüntüleme
- Bootstrap 5.3.0 ile modern arayüz

## 🛠️ Teknolojiler

- **.NET 7.0**
- **ASP.NET Core MVC**
- **Bootstrap 5.3.0**
- **C#**

## 📋 Proje Yapısı

```
MeetingApp/
├── Controllers/          # Controller sınıfları
│   ├── HomeController.cs
│   └── MeetingController.cs
├── Models/              # Model sınıfları
│   ├── MeetingInfo.cs
│   ├── UserInfo.cs
│   └── Repository.cs
├── Views/              # Razor view dosyaları
│   ├── Home/
│   └── Meeting/
└── wwwroot/           # Statik dosyalar (CSS, JS, lib)
```

## 🚀 Çalıştırma

1. Projeyi klonlayın veya indirin
2. Terminal'de proje dizinine gidin
3. Aşağıdaki komutu çalıştırın:

```bash
dotnet restore
dotnet run
```

4. Tarayıcınızda `http://localhost:5083` adresine gidin

## 📝 Notlar

- Bu proje eğitim amaçlıdır ve gerçek bir veritabanı kullanmamaktadır
- Veriler in-memory bir repository'de saklanmaktadır
- Uygulama yeniden başlatıldığında veriler sıfırlanır

## 📄 Lisans

Bu proje eğitim amaçlıdır ve özgürce kullanılabilir.

