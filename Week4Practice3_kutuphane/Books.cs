using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4Practice3_kutuphane
{
    public class Books
    {
        private string _bookName;
        private string _authorName;                  //yazar ismi
        private string _authorLastname;              //yazar soyismi
        private int _numberofPages;                  //sayfa sayısı
        private string _publiser;                    //yayınevi
        private DateTime _dateofRegistration;       //kayıt tarihi

        public Books()                          //Parametre almayan ctor
        {
            DateRegistration();

        }
        
        public Books(string bookName, string authorName,string authorLastname, int numberofPages, string publiser )               //Parametreli ctor
        {
            _bookName = bookName;
            _authorName = authorName;
            _authorLastname = authorLastname;
            _numberofPages = numberofPages;
            _publiser = publiser;
            
            DateRegistration();

        }

        public void DateRegistration()                                          //Kayıt tarihinin oluşturulması için metot
        {
            _dateofRegistration = DateTime.Now;
            Console.WriteLine("Kayıt tarihi : "+ _dateofRegistration);
        }

        public void AddBooks()                                                  //Kitap kaydetme metodu
        {
            Console.WriteLine(_authorName + " "+ _authorLastname +  " 'in " + _numberofPages + " sayfalık, " + _publiser + " yayınevinden çıkan " + _bookName + " kitabi kaydedildi.");
        }


        public string BookName { get { return _bookName; } set { _bookName = value; } }
        public string AuthorName { get { return _authorName; } set { _authorName = value; } }
        public string AuthorLastName { get { return _authorLastname; } set { _authorLastname = value; } }
        public int NumberOfPages { get { return _numberofPages; } set { _numberofPages = value; } }
        public string Publiser { get { return _publiser; } set { _publiser = value; } }
        public DateTime DateOfRegistration { get { return _dateofRegistration; } set { _dateofRegistration = value; } }




    }
}
