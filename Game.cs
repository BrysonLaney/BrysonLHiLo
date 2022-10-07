class Game{
    private Player player = new Player();
    private deckofcards deck = new deckofcards();
    public void rungame(){
        deck.newDeck();
        bool continuegame = true;
        while(continuegame){
            Console.WriteLine($"The card is: " + deck.draw(1));
            Console.WriteLine($"Higher or lower? [h/l] ");
            char guess = player.PlayerChoice();
            Console.WriteLine("high");
            Console.WriteLine($"Next card was: " + deck.draw(2));
            if(deck.CompareCard() == guess){
                player.Pointadd(100);
            }
            else{
                player.Pointsubtract(75);
            }
            Console.WriteLine($"Your score is: " + player.Points());
            bool gamestate = player.continu();
            if(gamestate){
                continuegame = true;
            }
            else{
                continuegame = false;
            }
        }
    }
}