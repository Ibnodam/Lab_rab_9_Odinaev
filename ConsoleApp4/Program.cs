try
{
    Console.Write("Введите название книги: ");
    string name = Console.ReadLine();

    Console.Write("Введите количество страниц: ");
    int sheets = int.Parse(Console.ReadLine());

    Console.Write("Введите цену книги: ");
    decimal price = decimal.Parse(Console.ReadLine());

    Book book = new Book(name, sheets, price);
    Console.WriteLine(book.Info());
}
catch(Exception ex)
{ Console.WriteLine(ex.Message); }  
class Book
{
    private string name;
    private int sheets;
    private decimal price;


    public decimal Price
    {
        get { return price; }
        set { if (value >= 0) price = value; }
    }

    public int Sheets
    {
        get { return sheets;}
        set { if (value >= 0) sheets = value;}
    }

    public string GetAverage(int Sheets, decimal Price)
    {
        return $"Средняя стоимость страницы: {(GetPrice(name) / Sheets):F2}.";
    }

    public string Info()
    {
        return $"Книга: {name}; стоимость: {GetPrice(name)}; средняя стоимость страницы: {GetAverage(Sheets, Price)}";
    }
    public decimal GetPrice(string name)
    {
        if (name.IndexOf("Программирование") == 0) return price * 2;
        else return price;
    }


    public Book(string name, int sheets, decimal price)
    {
        this.name = name;
        this.Sheets = sheets;
        this.Price = price;

    }
     



}

