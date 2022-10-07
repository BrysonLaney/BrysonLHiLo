using System;
using System.Collections.Generic;
class deckofcards {
    List<int> deck = new List<int>();
    Random card = new Random();
    private int card1 = 0;
    private int card2 = 0;
    public void newDeck(){
        for(int i = 0; i < 52; i++){
            double temp = i/4;
            deck.Add((int)temp);
        }
    }
    public int draw(int pull){
        int tempcard = 0;
        if(deck.Count == 0){
            return 69;
        }
        if(pull == 1){
            tempcard = this.card.Next(deck.Count);
            deck.RemoveAt(tempcard);
            return (int)(tempcard/4);
        }
        if(pull == 2){
            tempcard = this.card.Next(deck.Count);
            deck.RemoveAt(tempcard);
            return (int)(tempcard/4);
        }
        tempcard = this.card.Next(deck.Count);
        deck.RemoveAt(tempcard);
        return (int)(tempcard/4);
    }
    public char CompareCard(){
        if(card1 > card2){
            return 'l';
        }
        if(card1 < card2){
            return 'h';
        }
        return 'L';
    }
}