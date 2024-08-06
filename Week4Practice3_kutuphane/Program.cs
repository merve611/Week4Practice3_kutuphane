using Week4Practice3_kutuphane;

internal class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("-------Parametresiz ctor----------");

        Books book1 = new Books();
        book1.AuthorName = "Merve";
        book1.AuthorLastName = "Çakıroğlu";
        book1.BookName = "Alaca Geyik";
        book1.NumberOfPages = 450;
        book1.Publiser = "Kültür yayınları";
        book1.AddBooks();



        Console.WriteLine("-------Parametreli ctor-----------");
        Books book2 = new Books("Adı Aylin","Ayşe","Kulin",398,"Remzi Kitapevi");
        book2.AddBooks();
    }
}


//Class ; OOP'nin temel yapıtaşlarından olan class,nesnelerin özelliklerini ve davranışlarını tanımlayan bir şablondur. 
//Property ; Bir sınıfın alanlarına (fields) erişim sağlamak ve bu alanları korumak için kullanılan üyeleridir.
//New ; Bir sınıftan yeni bir nesne oluşturmak için kullanılır. 
//Constructor ; Sınıftan yeni bir nesne oluşturulduğunda çağrılan özel bir metottur. Constructor'lar, nesne oluşturulurken gerekli başlangıç değerlerini ayarlamak için kullanılır. 