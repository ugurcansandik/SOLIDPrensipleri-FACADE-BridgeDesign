Single Responsibility Principle (SRP):
	Her classın tek bir sorumluluğu olması durumudur.
	Bunu file ve customer diye 2 sınıf oluşturarak sağladım.

Open Closed Principle (OSP):
	Her class geliştirmeye açık olmalı fakat değişime kapalı olmalıdır.
	Bunu IFile adında bir interface oluşturarak sağladım. Çünkü yarın başka bir dosya türünde kaydetme işlemi gerektiğinde hemen yeni bir class oluşturup sağlayabiliriz.

Liskov Substitution Principle (LSP):
	Türetilen sınıflar, ana sınıfın tüm özelliklerini kullanmak zorundadır.
	ICustomer interfaceini, GoldCustomer ve SilverCustomer classlarını oluşturup ICustomer'ı implement etmesini sağladım. Ancak eğer ki INoPay diye bir interface oluşturmasaydım SilverCustomer ICustomer'ı implement ettiği için NoPay fonksiyonunda exception fırlatmam gerekecekti ve gereksiz bir kod kalabalığı oluşacaktı.

Interface Segregation Principle (ISP)
	Her interface'in belirli bir amacı olmalıdır. Her şeyi kaplayan çatı bir interface olmamalıdır. Bunu IFileRead ve IFileSave adında 2 farklı interface oluşturarak sağladım.

Dependency Inversion Principle (DIP)
	Üst seviye sınıflar alt seviye sınıflara bağlı olmamalıdır. Abstraction veya interface kullanarak ilişki sağlanmalıdır. Bunu projemde gösteremedim ancak üst sınıf bir nesnenin constructorında alt sınıf bir nesne oluşturuluyorsa bu durumu çiğnemiş oluyoruz. Bir interface oluşturup alt sınıfın onu implement etmesini sağlayarak önüne geçebiliriz.
