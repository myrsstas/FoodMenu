/*
 * Άσκηση 1.12
    Δημιουργήστε ένα Console Application το οποίο θα δείχνει στον χρήστη ένα μενού με 
    τουλάχιστον 2 επιλογές φαγητού και μία επιλογή για έξοδο από το πρόγραμμα, η οποία 
    θα έχει τιμή “0” (μηδέν) και θα είναι τελευταία στη λίστα. Όταν ο χρήστης επιλέγει 
    κάποια από τις επιλογές, το Application πρέπει να δείχνει στην κονσόλα ποιο φαγητό 
    επέλεξε και μετά απλά να τερματίζει.
        Υποχρεωτικά specs:
            -Οι επιλογές που θα δείχνει το Application, πρέπει να είναι αποθηκευμένες σε ένα Array.
            -Οι επιλογές πρέπει να προβάλλονται στην κονσόλα με κάποιο loop.
            -Σε περίπτωση που ο χρήστης δεν επιλέξει κάποια επιλογή από το μενού, αλλά ούτε και “Έξοδο” 
            από το application, το application πρέπει να δείξει το μήνυμα “Wrong selection!” 
            και να τερματίζει.
 */

Console.WriteLine("Hello, welcome to out Menu!");

int[] selectionArray = 
{
    1,
    2,
    0
};

string[] foodSelection = 
{
    "Spaghetti",
    "Pizza",
    "Exit"
};

for (int i = 0; i < selectionArray.Length; i++)
{
    Console.WriteLine($"Selection {selectionArray[i]} is {foodSelection[i]}");
}

Console.WriteLine("Please select an option");
string userSelection = Console.ReadLine();
int selection = -1;

if (int.TryParse(userSelection, out selection))
{
    switch (selection)
    {
        case 1:
            Console.WriteLine($"You selected {foodSelection[0]}");
            break;
        case 2:
            Console.WriteLine($"You selected {foodSelection[1]}");
            break;
        case 0:
            Console.WriteLine($"You selected {foodSelection[2]}. Bye bye!");
            break;
        default:
            Console.WriteLine("That's not a valid selection");
            break;
            
    }
}
