// See https://aka.ms/new-console-template for more information


using Conproducts;

List<Product> Products = new List<Product>()
{
new Product(){ Pname ="Iphone 11", Pprice="1,20000", Brand="Apple",Mdate=new DateTime (day:12,month:11,year:2022),ExpDate=new DateTime (day:09,month:11,year:2035)},
new Product(){ Pname ="Iphone 12", Pprice="1,20000", Brand="Apple",Mdate=new DateTime (day:11,month:11,year:2021),ExpDate=new DateTime (day:09,month:11,year:2035)},
new Product(){ Pname ="Iphone 13", Pprice="1,20000", Brand="Apple",Mdate=new DateTime (day:12,month:11,year:2021),ExpDate=new DateTime (day:09,month:11,year:2035)},
new Product(){ Pname ="Iphone 13", Pprice="1,20000", Brand="Apple",Mdate=new DateTime (day:12,month:11,year:2022),ExpDate=new DateTime (day:09,month:11,year:2035)},
new Product(){ Pname ="samsung s22",Pprice ="80,000",Brand ="Samsung",Mdate=new DateTime (day:12,month:11,year:2022),ExpDate=new DateTime (day:09,month:11,year:2026)},
new Product(){ Pname ="realme gt",Pprice ="30,0000", Brand="Android",Mdate=new DateTime (day:12,month:11,year:2022),ExpDate=new DateTime (day:09,month:11,year:2025)},



};
Console.WriteLine("Pname \t Pprice\t brand\t brand \t Mdate\t Expdate\t");

foreach (Product pro in Products)
{
    Console.Write(pro.Pname + "\t \t");
    Console.Write(pro.Pprice + "\t \t");
    Console.Write(pro.Brand + "\t \t");
    Console.Write(pro.Mdate.ToLongDateString());
    Console.Write(pro.ExpDate.ToLongDateString());
}