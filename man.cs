class Man {
    List<string>  parachute = new List<string> {@" ___ ", @"/___\", @"\   /", @" \ /"};
    List<string>  body = new List<string> {"  O  ", @" /|\ ", @" / \ "};


    public void DisplayMan () {
        for(int i=0;i<parachute.Count;i++){
            Console.WriteLine(parachute[i]);
            }
        for(int i=0;i<body.Count;i++){
            Console.WriteLine(body[i]);
            }
    }

    public void DisplayDead() {
        body.Remove(body[0]);
        body.Insert(0, "  X  ");
        for(int i=0;i<body.Count;i++){
            Console.WriteLine(body[i]);
            }
            }

    //parachute

    public void cutString() {
        parachute.RemoveAt(0);
    }

    public bool IsDead() {
        if(parachute.Count() == 0){
            return true;
        }
        else {
            return false;
        }
    }
}