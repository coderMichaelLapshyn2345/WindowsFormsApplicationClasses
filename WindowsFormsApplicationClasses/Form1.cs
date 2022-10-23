using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplicationClasses
{
    public partial class Form1 : Form
    {
        public List<Product> PRODUCT_LIST = new List<Product>(); // список куди будуть додаватися продукти
        public List<Book> BOOK_LIST = new List<Book>(); // список куди будуть додаватися книжки 
        

        // абстрактний клас товар із іменем Item(ім'я абстрактного класу)

        // Модифікатор доступу: public 
        // Тип: interface 
        // Ім'я: Item 
        // Методи: 
        //     + Name {get; set;} Назва товару 
        //     + Price {get; set;} Ціна товару 
        //     + Country {get; set;} Країна походження 
        //     + DatePackage {get; set;} Дата пакування 
        //     + Description {get; set;} Опис товару  
            

        public abstract class Item
        {
            protected Item(string name, double price, string country, string description, string datePackage)
            {
                Name = name;
                Price = price;
                Country = country;
                Description = description;
                DatePackage = datePackage;
            }

            string Name { get; set; }
            double Price { get; set; }
            string Country { get; set; }
            string Description { get; set; }

            string DatePackage { get; set; }
        }

        // Публічний клас продукт з іменем Product
        // Тип: клас
        // Позначення модификаторів: 
        //      + -> public 
        //      - -> private 
        //      # -> protected 



        // Ім'я: Product 
        // Модифікатор доступу: public 
        // Атрибути: 
        //     - name -> string       
        //     - price -> double/decimal  
        //     - country -> string       
        //     - description -> string    
        //     - date_package -> DateTime  
        //     - amount -> int  (+ -- public)
        //     - expiration_date -> int  
        //     - units -> string  



        // Методи: 
        //    + Name {get; set;}    Назва товару  -> string 
        //    + Price {get; set;}   Ціна товару   -> double/decimal 
        //    + Country {get; set;} Країна походження  -> string 
        //    + Description {get; set;} Опис -> string 
        //    + DatePackage {get; set;} Дата пакування -> DateTime 
        //    + Amount {get; set;}  Кількість -> int 
        //    + ExpirationDate {get; set; } Термін придатності -> int 
        //    + Units {get; set;}   Одиниця виміру  -> string



        // Оголошення класу Product
        public class Product: Item 
        {
           
            public int amount; // приватна змінна кількість продукту  
            public int expiration_date; // приватна змінна термін придатності 
            public string units; // приватна змінна одиниця виміру 

            public Product(string name, double price, string country, string description, string datePackage, int amount, int expiration_date, string units) : base(name, price, country, description, datePackage)
            {
                this.amount = amount;
                this.expiration_date = expiration_date;
                this.units = units;
            }



          


        }

        // Оголошення класу Book 
        public class Book : Item
        {
            
            public Book(string name, double price, string country, string description, string datePackage, int pages, string publish_house, string authors) : base(name, price, country, description, datePackage)
            {
                this.NoOfPages = pages;
                this.PublishHouse = publish_house;
                this.Authors = authors;
            }

            public int NoOfPages { get; set; }
            public string PublishHouse { get; set; }
            public string Authors { get; set; }

            
        }







        public Form1()
        {
            InitializeComponent();

           


            
        }

        // Кнопка додавання продукту в DataGriedView1 із назвою AddProductBtn 
        private void AddProductBtn_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(NameTextBox.Text, PriceTextBox.Text, CountryTextBox.Text, DescriptionTextBox.Text, PackageDateTextBox.Text, AmountTextBox.Text, ExpirationDateTextBox.Text, UnitTextBox.Text);
            PRODUCT_LIST.Add(new Product(NameTextBox.Text, double.Parse(PriceTextBox.Text), CountryTextBox.Text, DescriptionTextBox.Text, PackageDateTextBox.Text, int.Parse(AmountTextBox.Text), int.Parse(ExpirationDateTextBox.Text), UnitTextBox.Text));
        }

        // Кнопка видалення продукту із dataGriedView1 із назвою DeleteProductBtn  
        private void DeleteProductBtn_Click(object sender, EventArgs e)
        {
            foreach(DataGridViewRow row in dataGridView1.SelectedRows)
            {
                dataGridView1.Rows.Remove(row);
            }
        }

        // Кнопка додавання книжки в dataGriedView2 із назвою AddBookBtn 
        private void AddBookBtn_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Add(BookNameTextBox.Text, double.Parse(BookPriceTextBox.Text), BookCountry.Text, BookDescriptionTextBox.Text, BookDatePackageTextBox.Text, int.Parse(BookPagesTextBox.Text), BookPublishHouseTextBox.Text, BookContributorsTextBox.Text);
            BOOK_LIST.Add(new Book(BookNameTextBox.Text, double.Parse(BookPriceTextBox.Text), BookCountry.Text, BookDatePackageTextBox.Text, BookDescriptionTextBox.Text, int.Parse(BookPagesTextBox.Text), BookPublishHouseTextBox.Text, BookContributorsTextBox.Text));
        }

        // Кнопка видалення книжки із dataGriedView2 із назвою DeleteBookBtn 
        private void DeleteBookBtn_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView2.SelectedRows)
            {
                dataGridView2.Rows.Remove(row);
            }
        }
    }
}
