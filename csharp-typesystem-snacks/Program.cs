namespace csharp_typesystem_snacks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            //Snack 1: 1 L’utente inserisce due numeri in successione. Il software stampa il maggiore.
            Console.WriteLine("Inserisci due numeri");
            int firstNumber;
            int secondNumber;

            firstNumber = int.Parse(Console.ReadLine());
            secondNumber = int.Parse(Console.ReadLine());   

            if (firstNumber > secondNumber) 
            {
                Console.WriteLine("Il numero più grande è: " + firstNumber);
            }
            else if (secondNumber > firstNumber)
            {
                Console.WriteLine("Il numero più grande è: " + secondNumber);
            }
            else
            {
                Console.WriteLine("I numeri sono uguali.");
            }


            Console.WriteLine("---------------------------------------------------------------------------------------------");


            //Snack 2 : L’utente inserisce due parole in successione.Il software stampa prima la parola più corta, poi la parola più lunga.

            string firstWord;
            string secondWord;

            Console.WriteLine("Inserisci due parole");
            firstWord = Console.ReadLine();
            secondWord = Console.ReadLine();

            if (firstWord.Length < secondWord.Length) 
            {
                Console.WriteLine("La parola più corta è:" + firstWord);
                Console.WriteLine("La parola più lunga è:" + secondWord);
            } else if (secondWord.Length < firstWord.Length)
            {
                Console.WriteLine("La parola più corta è:" + secondWord);
                Console.WriteLine("La parola più lunga è:" + firstWord);
            } else 
            {
                Console.WriteLine("Le due parole inserite sono lunghe uguali " + firstWord + secondWord);
            }

            Console.WriteLine("---------------------------------------------------------------------------------------------");

            //Snack 3: Il software deve chiedere per 10 volte all’utente di inserire un numero.Il programma stampa la somma di tutti i numeri inseriti.

            int sumResult = 0;

           
            Console.WriteLine("Inserisci 10 numeri, per ottenerne la somma");

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Digitare il {i + 1}° numero");
                sumResult = sumResult + int.Parse(Console.ReadLine());
            }

            Console.WriteLine("La somma di tutti i numeri è: " + sumResult);

            Console.WriteLine("---------------------------------------------------------------------------------------------");


            //Snack 4: Calcola la somma e la media dei numeri da 2 a 10.
            float averageResult;
            int sum = 0;
            int minNumber = 2;
            int maxNumber = 10;
            int divisonNumber = 1;

           
            for (int i = minNumber; i <= maxNumber; i++)
            {
                sum = sum + i;
                divisonNumber++;
            }
            averageResult = (float)sum / (float)divisonNumber;
            Console.WriteLine($"La somma dei numeri è: {sum}");
            Console.WriteLine($"La media dei numeri è: {MathF.Round(averageResult, 2)}");


            Console.WriteLine("---------------------------------------------------------------------------------------------");

            //Snack 5: Il software chiede all’utente di inserire un numero.Se il numero inserito è pari, stampa il numero, se è dispari, stampa il numero successivo.
            int userNumber;
            int numberToPrint;

            Console.WriteLine("Inserisci un numero ");
            userNumber = int.Parse(Console.ReadLine());

            if (userNumber % 2 == 0) 
            { 
                Console.WriteLine(userNumber); 
            } else 
            { 
                Console.WriteLine(userNumber + 1); 
            }


            Console.WriteLine("---------------------------------------------------------------------------------------------");

            //Snack 6: In un array sono contenuti i nomi degli invitati alla festa del grande Gatsby. Chiedi all’utente il suo nome e comunicagli se può partecipare o meno alla festa.

            string[] invitedGuest = { "Aldo", "Giovanni", "Giacomo", "Davide", "Golia", "Hansel", "Gretel", };
            string userName;
            string message = "Mi dispiace non sei nella lista";
            

            
            Console.WriteLine("Dimmi il tuo nome  e ti dirò se sei invitato/a alla festa");
           
            userName = Console.ReadLine();

            for (int i = 0; i < invitedGuest.Length; i++)
            {
                if (invitedGuest[i] == userName)
                {
                    message = "Benvenuto/a " + userName;
                }
            }

            Console.WriteLine(message);

            Console.WriteLine("---------------------------------------------------------------------------------------------");

            //Snack 7: Crea un array vuoto. Chiedi per 6 volte all’utente di inserire un numero, se è dispari inseriscilo nell’array.

            int[] numbersArray = new int[6];
            int positionCounter = 0;


            for (int i = 0; i < numbersArray.Length; i++)
            {
                Console.WriteLine($"Inserisci {numbersArray.Length} numeri. {i + 1}°:  ");
                int number = int.Parse(Console.ReadLine());

                
                if (number % 2 == 1)
                {
                    numbersArray[positionCounter] = number;
                    positionCounter++;
                }

            }

            Console.WriteLine("Ecco i tuoi numeri.");
            for (int i = 0; i < numbersArray.Length; i++)
            {
                Console.WriteLine(numbersArray[i]);
            }

            Console.WriteLine("---------------------------------------------------------------------------------------------");

            //Snack 8: Crea un array di numeri interi e fai la somma di tutti gli elementi che sono in posizione dispari.
            

            Console.WriteLine("---------------------------------------------------------------------------------------------");

            //Snack 9: Crea un array vuoto e chiedi all’utente un numero da inserire nell’array.Continua a chiedere i numeri all’utente e a inserirli nell’array, fino a quando la somma degli elementi è minore di 50.
            
            Console.WriteLine("---------------------------------------------------------------------------------------------");

            //Snack 10: Fai inserire un numero, che chiameremo N, all’utente.Genera N array, ognuno formato da 10 numeri casuali tra 1 e 100.Ogni volta che ne crei uno, stampalo a schermo.

        }
    }
}