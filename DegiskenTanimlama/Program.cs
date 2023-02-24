// See https://aka.ms/new-console-template for more information
//Console.BackgroundColor = ConsoleColor.DarkMagenta;
Console.WriteLine("Değişken Tanımlama");

//Tamsayı değişken tipleri

byte degiskenByte = 2;
short degiskenShort = 5;
ushort degiskenUShort = 4;
int degiskenInt = 0;
uint degiskenUInt = 0;
long degiskenLong = 0;
ulong degiskenULong = 0;

//Ondalık değişken tipleri

double degiskenDouble = 0.5;
float degiskenFloat = 0.5f;
decimal degiskenDecimal = 0.5m;

degiskenInt = 1_999_999;
degiskenInt = 0b101010110;
degiskenInt = 0x123af21c;

////////////////////////////////////////

int sonuc = 9 / 3;
sonuc = Convert.ToInt32(5 / 2d);
sonuc = (int)(5 / 2d);
Console.WriteLine(sonuc);
Console.Write("abcdef");

// Aritmetik operatörler
// + - * / %

int a = 5;
int b = 10;
//b++
a = ++b; 
Console.WriteLine(a);
Console.WriteLine(b);

// Karakter tipleri

char karakter = 'g';
string kelime = "Merhaba Dünya";
char[] kelimeDizi = new[] { 'M', 'e', 'r' };
Console.WriteLine(kelimeDizi[2]);
Console.WriteLine(kelime[2]);

//Mantıksal tip

bool dogruMu = true;

// Mantıksal operatörler

// > < >= <= = =! İşlem && ||
dogruMu = degiskenInt > degiskenDouble;
Console.WriteLine(dogruMu);
dogruMu = degiskenUShort < degiskenInt && kelime.Length > 10;

for (int i = 0; i < 30; i++)
{
    DateTime simdi = DateTime.Now;
    string format = "HH:mm:ss";
    Console.WriteLine(simdi.ToString(format));
    /*Console.WriteLine(simdi.Hour + ":" + simdi.Minute + ":" + simdi.Second);
    Console.WriteLine(simdi.Hour.ToString("00") + ":" + simdi.Minute.ToString("00") + ":" + simdi.Second.ToString("00"));*/
    Console.WriteLine($"{simdi:dd:MM:yyyy - HH:mm:ss}");
    Thread.Sleep(1000);
    Console.Clear();
}



