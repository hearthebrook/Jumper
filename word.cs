class Word {
    string GameWord;
    public Word() {
        wordBank dictionary = new wordBank();
        GameWord = dictionary.randomWord();
        }

    public void DisplayWord() {
        Console.WriteLine(GameWord.ToUpper());
    }

    public List<char> SplitWord () {
        char[] wordCharacters = GameWord.ToCharArray();
        List<char> wordAsChar = new List<char> (wordCharacters);
        return wordAsChar;
    }

    public List<string> WordAsDash () {
        var newWord = SplitWord();
        List<string> dashList = new List<string> ();
        for(int i=0;i<newWord.Count;i++){
            dashList.Add("_ ");
            }
        return dashList;
    }

    public void DisplayDash (List<string> dashList) {
        for(int i=0;i<dashList.Count;i++){
            Console.Write(dashList[i]);
            };
        Console.WriteLine("");
    }

    public bool Compleate (List<string> Dashes) {
        if (Dashes.Contains("_ ")) {
            return false;
        }
        else return true;
    }
}








