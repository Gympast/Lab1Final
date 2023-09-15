//Skapar variabel för att spara slutsumman i.
long sum = 0;

//Frågar användaren efter en sträng
Console.WriteLine("Mata in en sträng: ");

//sparar undan det användaren matade in i en variabel
string input = Console.ReadLine();


//går igenom strängen
for (int i = 0; i < input.Length; i++)
{
    //går igenom strängen igen...
    for (int j = i + 1; j < input.Length; j++)
    {
        //kollar om tecknet på plats "j" inte är en siffra eller om plats "i" och "j" är likadana
        if (!Char.IsDigit(input[j]) || input[i] == input[i + 1])
        {
            break;
        }
        //kollar om siffran på plats "i" och plats "j" är lika
        if (input[j] == input[i])
        {
            //om plats "i" och "j" är lika:
            //Skriver ut alla tecken från start till plats "i"
            Console.Write(input.Substring(0, i));

            //Byter färg på texten till grönt
            Console.ForegroundColor = ConsoleColor.Green;

            //Skriver ut alla siffror mellan plats "i" och plats "j" inklusive plats "j"
            Console.Write(input.Substring(i, j - i + 1));

            //Byter färg på texten till grå
            Console.ForegroundColor = ConsoleColor.Gray;

            //Skriver ut alla tecken efter plats "j"
            Console.WriteLine(input.Substring(j + 1));

            //Lägger till det markerade talet till varibeln "sum"
            sum += long.Parse(input.Substring(i, j - i + 1));

            //bryter loopen
            break;
        }
    }
}
//Skriver ut variabeln "sum"
Console.WriteLine($"\nSumman av de markerade talen: {sum}");