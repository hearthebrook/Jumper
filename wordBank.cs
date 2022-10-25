class wordBank {
    List<string> wordList = new List<string> {"cow", "camel", "elephant", "black", "data", "card", "jump", "beautiful"};

    public wordBank() {
    }

    public string randomWord() {
        Random rnd = new Random();
        int randIndex = rnd.Next(wordList.Count);
        string random = wordList[randIndex];
        return random;
    }
}
