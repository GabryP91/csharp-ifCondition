/*
    1. Creare un metodo che data una variabile che contenga l’età di una persona stampi un messaggio
       se la persona in questione è maggiorenne.

    2. Creare un metodo che controlli se un numero è positivo o negativo.

    3. Creare un programma che, a partire da due variabili numeriche, stampi il minore tra due numeri.

    4. Creare un metodo che, a partire da due variabili, controlli se il primo numero è maggiore del
       secondo e stampi l’esito del controllo.

    5. Creare un metodo che, a partire da 3 variabili, stampi a schermo se i numeri sono in ordine
       dal più piccolo al più grande, oppure no.

    6. Creare un programma che stampi se la somma tra due numeri è maggiore 100, oppure no.

    7. Creare un metodo che, con l’aiuto di una variabile numerica, stampi un numero se questo
       compreso tra 0 e 10, o altrimenti stampi a schermo “errore”.

    8. Creare un metodo che controlli se un numero è maggiore, uguale, o minore di 26.
*/

using static System.Runtime.InteropServices.JavaScript.JSType;

namespace csharp_ifCondition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ESERCIZIO 1
            Console.WriteLine("---------------------------------------------------\n");
            Console.WriteLine("ESERCIZIO 1\n");
            
            RicercaIndividuo();

            // ESERCIZIO 2
            Console.WriteLine("---------------------------------------------------\n");
            Console.WriteLine("ESERCIZIO 2\n");

            ControlloValore();

            // ESERCIZIO 3
            Console.WriteLine("---------------------------------------------------\n");
            Console.WriteLine("ESERCIZIO 3\n");

            StampaMinore();

            // ESERCIZIO 4
            Console.WriteLine("---------------------------------------------------\n");
            Console.WriteLine("ESERCIZIO 4\n");

            StampaMaggiore();

            // ESERCIZIO 5
            Console.WriteLine("---------------------------------------------------\n");
            Console.WriteLine("ESERCIZIO 5\n");

            OrdineNum();

            // ESERCIZIO 6
            Console.WriteLine("---------------------------------------------------\n");
            Console.WriteLine("ESERCIZIO 6\n");

            StampaSommaCento();

            // ESERCIZIO 7
            Console.WriteLine("---------------------------------------------------\n");
            Console.WriteLine("ESERCIZIO 7\n");

            StampaNumeroCompreso();

            // ESERCIZIO 8
            Console.WriteLine("---------------------------------------------------\n");
            Console.WriteLine("ESERCIZIO 8\n");

            Chek26();
        }

        static void RicercaIndividuo()
        {
            int num1;

            Console.WriteLine("\nDigitare l'età della persona:\n");

            //Controllo
            while (!int.TryParse(Console.ReadLine(), out num1))
            {
                Console.WriteLine("Sintassi errata. Inserisci un numero");
            }

            //operatore ternario
            Console.WriteLine(num1 < 18 ? "Attenzione questa persona non è maggiorenne" : "La persona è maggiorenne");

        }

        static void ControlloValore()
        {
            int num1;

            Console.WriteLine("\nDigitare un numero:\n");

            //Controllo
            while (!int.TryParse(Console.ReadLine(), out num1))
            {
                Console.WriteLine("Sintassi errata. Inserisci un numero");
            }

            //operatore ternario
            Console.WriteLine(num1 < 0 ? "Numero negativo" : "Numero positivo");

        }

        static void StampaMinore()
        {
            int num1,num2;

            Console.WriteLine("\nDigitare primo numero:\n");

            //Controllo
            while (!int.TryParse(Console.ReadLine(), out num1))
            {
                Console.WriteLine("Sintassi errata. Inserisci un numero");
            }

            Console.WriteLine("\nDigitare secondo numero:\n");

            //Controllo
            while (!int.TryParse(Console.ReadLine(), out num2))
            {
                Console.WriteLine("Sintassi errata. Inserisci un numero");
            }

            // Operatore ternario
            Console.WriteLine(num1 < num2 ? $"Il minore è: {num1}" : $"Il minore è: {num2}");

        }

        static void StampaMaggiore()
        {
            int num1, num2;

            Console.WriteLine("\nDigitare primo numero:\n");

            //Controllo
            while (!int.TryParse(Console.ReadLine(), out num1))
            {
                Console.WriteLine("Sintassi errata. Inserisci un numero");
            }

            Console.WriteLine("\nDigitare secondo numero:\n");

            //Controllo
            while (!int.TryParse(Console.ReadLine(), out num2))
            {
                Console.WriteLine("Sintassi errata. Inserisci un numero");
            }

            // Operatore ternario
            Console.WriteLine(num1 > num2 ? $"Il maggiore è: {num1}" : $"Il maggiore è: {num2}");

        }

        static void OrdineNum()
        {
            int num1, num2 , num3;

            Console.WriteLine("\nDigitare primo numero:\n");

            //Controllo
            while (!int.TryParse(Console.ReadLine(), out num1))
            {
                Console.WriteLine("Sintassi errata. Inserisci un numero");
            }

            Console.WriteLine("\nDigitare secondo numero:\n");

            //Controllo
            while (!int.TryParse(Console.ReadLine(), out num2))
            {
                Console.WriteLine("Sintassi errata. Inserisci un numero");
            }

            Console.WriteLine("\nDigitare terzo numero:\n");

            //Controllo
            while (!int.TryParse(Console.ReadLine(), out num3))
            {
                Console.WriteLine("Sintassi errata. Inserisci un numero");
            }

            // Operatore ternario
            Console.WriteLine(num1 <= num2 && num2 <= num3 ? "I numeri sono in ordine crescente" : "I numeri non sono in ordine crescente");

        }

        static void StampaSommaCento()
        {
            int num1, num2;

            Console.WriteLine("\nDigitare primo numero:\n");

            //Controllo
            while (!int.TryParse(Console.ReadLine(), out num1))
            {
                Console.WriteLine("Sintassi errata. Inserisci un numero");
            }

            Console.WriteLine("\nDigitare secondo numero:\n");

            //Controllo
            while (!int.TryParse(Console.ReadLine(), out num2))
            {
                Console.WriteLine("Sintassi errata. Inserisci un numero");
            }

            // Operatore ternario
            Console.WriteLine(num1 + num2 > 100 ? $"La somma dei due numeri è superiore a 100" : $"la somma dei due numeri non è superiore a 100");

        }

        static void StampaNumeroCompreso()
        {
            int num1;

            Console.WriteLine("\nDigitare primo numero:\n");

            //Controllo
            while (!int.TryParse(Console.ReadLine(), out num1))
            {
                Console.WriteLine("Sintassi errata. Inserisci un numero");
            }

            // Operatore ternario
            Console.WriteLine(num1 >= 0 && num1 <= 10 ? "Il numero è compreso tra 0 e 10": "Il numero NON è compreso tra 0 e 10");

        }

        static void Chek26()
        {
            int num1;

            Console.WriteLine("\nDigitare primo numero:\n");

            //Controllo
            while (!int.TryParse(Console.ReadLine(), out num1))
            {
                Console.WriteLine("Sintassi errata. Inserisci un numero");
            }

            // Operatore ternario
            Console.WriteLine(num1 > 26 ? "Il numero è maggiore di 26." : (num1 == 26 ? "Il numero è uguale a 26." : "Il numero è minore di 26."));
        }
    }
}
