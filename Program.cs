﻿// See https://aka.ms/new-console-template for more information

//-------------------------------------hardcoded info--------------------------------------

string titolo = "Trainspotting";
string autore = "Irvine Welsh";
string isbn = "978-8850257973";
int pagine = 368;
float peso = 330;
float larghezza = 13.5f;
float altezza = 20.5f;
double profondità = 2.4;  //perchè?
float valutazioneMedia = 4.5f;
int numeroRecensioni = 46;
bool kindle = true;
bool copertinaFlessibile = true;

//------------------------------------------------------------------------------------------







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


