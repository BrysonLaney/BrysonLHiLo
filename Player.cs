class Player{
    private char guess;
    private int points = 300;
    public char PlayerChoice(){
        guess = (Console.ReadLine()[0]);
        char choice = guess;
        return guess;
    }
    public char getChoice(){
        return guess;
    }
    public bool continu(){
        Console.WriteLine("Play again? [y/n] ");
            char choice = Console.ReadLine()[0];
            if(choice == 'y'){
                return true;
            }
            if(choice == 'n'){
                return  false;
            }
        return false;
    }
    
    public int Points(){
        return points;
    }
    public void Pointadd(int add){
        points += add;
    }
    public void Pointsubtract(int subtract){
        points -= subtract;
    }
    public bool ContineGame(char choice){
        if(choice =='y'){
            return true;
        }
        if(choice == 'n'){
            return false;
        }
        return false;
    }
    public void restart(){
        points = 300;
    }
}