using KalitimLib;

Kare yeniKare = new Kare();
yeniKare.X = 5;
Console.WriteLine($"Karenin alanı: {yeniKare.AlanHesapla()}");

Dikdortgen yeniDikdortgen = new Dikdortgen();
yeniDikdortgen.X = 4;
yeniDikdortgen.Y = 5;
Console.WriteLine($"Dikdörtgenin alanı: {yeniDikdortgen.AlanHesapla()}");