// See https://aka.ms/new-console-template for more information


string inputUtente;

//-------------------------------------------------------------------------------------------
Console.Write("Inserisci il titolo del libro :");
string titolo = Console.ReadLine();

Console.Write("Inserisci l'autore : ");
string autore = Console.ReadLine();

Console.Write("Inserisci il codice ISBN : ");
string isbn = Console.ReadLine();

Console.Write("Inserisci il numero delle pagine : ");
inputUtente = Console.ReadLine();
int pagine = int.Parse(inputUtente);

Console.Write("Inserisci quanto pesa : ");
//inputUtente = Console.ReadLine();
float peso = float.Parse(Console.ReadLine());

Console.Write("Inserisci la larghezza : ");
float larghezza = float.Parse(Console.ReadLine());

Console.Write("Inserisci l'altezza : ");
float altezza = float.Parse(Console.ReadLine());

Console.Write("Inserisci la profondità : ");
float profondità = float.Parse(Console.ReadLine());

Console.Write("Quale è la valutazione media ? : ");
float valutazioneMedia = float.Parse(Console.ReadLine());

Console.Write("Quante sono le recensioni ? : ");
int numeroRecensioni = int.Parse(Console.ReadLine());

Console.Write("E' disponibile il formato kindle ? inserisci true o false : ");
bool kindle = bool.Parse(Console.ReadLine()); ;

Console.Write("E' disponibile la copertina flessibile ? inserisci true o false : ");
bool copertinaFlessibile = bool.Parse(Console.ReadLine());


//-------------------------------------------------
//-------------------------------------------------------------------------------------------


Console.WriteLine("--------------------- LIBRO DI OGGI: " + titolo + " DI " + autore + "------------------------");
Console.WriteLine("Informazioni generiche: ");
Console.WriteLine("ISBN : " + isbn);
Console.WriteLine("Numero delle pagine: " + pagine);
Console.WriteLine("Peso del libro : " + peso);
Console.WriteLine($"Dimensioni del libro : Larghezza :{larghezza}, Altezza: {altezza}, Profondità: {profondità}");
Console.WriteLine("");
Console.WriteLine("Informazioni Amazon");
Console.WriteLine("Numero Recensioni : " + numeroRecensioni);
Console.WriteLine("Valutazione media : " + valutazioneMedia);
Console.WriteLine("Kindle disponibile : " + kindle);
Console.WriteLine($"Copertina flessibile disponibile : {copertinaFlessibile} ");
Console.WriteLine("---------------------------------------------------------------------------------------------");

//------------------------------------------------------------------------------------------
//-------------------------------------------------------------------------------------------
