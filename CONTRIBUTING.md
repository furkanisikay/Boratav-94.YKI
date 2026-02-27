# Katkı Rehberi

Bu projeye katkı sağlamak istediğiniz için teşekkürler.

## Geliştirme Akışı

1. Depoyu fork'layın ve yeni bir dal oluşturun.
2. Değişikliklerinizi küçük ve odaklı tutun.
3. Commit mesajlarını açıklayıcı yazın.
4. Pull Request açarken yapılan değişikliği ve amacını net şekilde belirtin.

## Kodlama Kuralları

- Mevcut proje yapısını ve adlandırma düzenini koruyun.
- Değişken, sınıf ve fonksiyon adlarını İngilizce kullanın.
- Kod içi açıklama eklemeniz gerekiyorsa Türkçe yazın.
- Güvenlik açısından gizli bilgileri koda gömmeyin; ortam değişkeni kullanın.

## Doğrulama

- Mümkünse değişiklikten sonra çözümü derleyin:

```bash
msbuild Boratav-94.App.sln /p:Configuration=Release
```

- Yeni davranış ekliyorsanız kapsamı dar testler ile doğrulayın.

## Davranış İlkesi

Katkı yapan herkesin saygılı, kapsayıcı ve yapıcı bir iletişim kurması beklenir.
