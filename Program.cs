// See https://aka.ms/new-console-template for more information
//string ,int ,float,double,bool;
string yazi1;string yazi2;string yazi3;int ortalama;

yazi1 = "Lütfen Birinci Dersin Notunu Giriniz.";
Console.WriteLine(yazi1);
string ders1 = Console.ReadLine();

yazi2 = "Lütfen İkinci Dersin Notunu Giriniz.";
Console.WriteLine(yazi2);
string ders2 = Console.ReadLine();

yazi3 = "Lütfen Üçüncü Dersin Notunu Giriniz.";
Console.WriteLine(yazi3);
string ders3 = Console.ReadLine();

ortalama = int.Parse(ders1)+int.Parse(ders2)+int.Parse(ders3);
ortalama = ortalama/3;

if(ortalama >= 50){
    Console.WriteLine("---*****---Bu öğrenci geçti. Ortalaması:"+ortalama+"---*****---");
}else{
    Console.WriteLine("---*****---Bu öğrenci kaldı. Ortalaması:"+ortalama+"---*****---");
}

