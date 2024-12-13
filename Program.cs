// See https://aka.ms/new-console-template for more information

//Šādi izskatās komentāri
//Funkcija neko neatgriež, bet kaut ko dara...
void MyFunctionName(string myVariableName)
{
    Console.Write("Hello, World!");
}

//Šeit rakstam funkciju kas saskaitīs 2 skaitļus
int FunkcijaKasSaskaita2CiparusUnAtgriežVērtību(int pirmaisSkaitlis, int otraisSkaitlis)
{
    int rezultāts = 0;
    return rezultāts;
}

//Šeit funkcija jāizlabo lai tā darīto to ko mēs gribam
int FunkcijaKasAtņem2VērtībuNoPirmāsUnAtgriežVētību(int pirmaisSkaitlis, int otraisSkaitlis)
{
    return 1+1;
}

//Šeit funkcija jāizlabo lai tā darīto to ko mēs gribam
void FunkcijaKasSaskaita3SkaitļusUnAtgriežVētību(int pirmaisSkaitlis, int otraisSkaitlis, int trešaisSkaitlis)
{

}

//šeit funkcijai jāatgriež skaitlis nevis teksts
string FunkcijaKasAtgriežToPašuSkaitliKoTaiPadodKāSkaitli(int skaitlis)
{
    //dolārzīme pirms pēdiņām + spicās iekavas ļauj gandrīz visas vērtības pārvērst par tekstu
    return $"{skaitlis}";
}


//Loģiskās funkcijas

bool vienmērPatiess = true;
bool vienmērNepatiess = false;

if (vienmērPatiess)
{
    Console.WriteLine($"1. If funkcija atgriež {vienmērPatiess}");
}
// else pasaka ko darīt ja iepriekšējais nosacījums neizpildās
else
{
    Console.WriteLine($"1. If funkcija atgriež {vienmērNepatiess}");
}

if (vienmērNepatiess)
{
    Console.WriteLine("2 Uzd ar If ir pareizi izpildīts");
}
else
{
    Console.WriteLine("2. uzd Jāpabeidz");
}














/*
try
{
    string result = "result variable";
    MyFunctionName("");
    result = Console.ReadLine();

    if (result.Contains("Hello, World!"))
    {
        Console.WriteLine("1.Uzd. DONE");
    }
    else
    {
        Console.WriteLine("1.uzd. FAIL");
    }
}
catch (Exception e)
{
    Console.WriteLine(e);
	
}

MyFunctionName("");
*/