Single Responsibility Principle (SRP)
	Her classın tek bir sorumluluğu olması durumudur.
	Bunu file ve customer diye 2 sınıf oluşturarak sağladım.

Open Closed Principle (OSP)
	Her class geliştirmeye açık olmalı fakat değişime kapalı olmalıdır.
	Bunu IFile adında bir interface oluşturarak sağladım. Çünkü yarın başka bir dosya türünde kaydetme işlemi gerektiğinde hemen yeni bir class oluşturup sağlayabiliriz.

Liskov Substitution Principle (LSP)
	Türetilen sınıflar, ana sınıfın tüm özelliklerini kullanmak zorundadır.
