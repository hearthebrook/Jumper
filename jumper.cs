// game logic 
class Jumper {
    Word GameWord = new Word();
    List <char> GameWordList;
    List <string> DashWord;
    Man player = new Man();

    Man jumpMan = new Man();

    public Jumper () {
        GameWordList = GameWord.SplitWord();
        DashWord = GameWord.WordAsDash();
    }
    
    public void Game () {
        bool game = true;
        while (game == true) {
            Console.WriteLine("");
            GameWord.DisplayDash(DashWord);
            Console.WriteLine("");
            player.DisplayMan();
            Console.WriteLine("");
            if (IsInWord() == false) {
                player.cutString();
            }

            if (player.IsDead() == true) {
                player.DisplayDead();
                Console.WriteLine("You have died. sorry!");
                game = false;
            }
            else if (GameWord.Compleate(DashWord) == true) {
                Console.WriteLine($"The word was...");
                GameWord.DisplayWord();
                Console.WriteLine("Great Job!!");
                game = false;
            }
        }
    }


    public string UserGuess() {
       Console.Write("Guess a letter [a-z]: ");
       string? guess = Console.ReadLine()??"";
       return guess;
    }

    public bool IsInWord() {
        string guess = UserGuess();
        bool input = false;
        // if guess is int word change the letter in the word and return true.
        for(int i=0;i<GameWordList.Count;i++){
            if (GameWordList[i].ToString() == guess) {
                DashWord[i] =  GameWordList[i].ToString();
                input = true;
                }
        }
        return input;
        }
    }