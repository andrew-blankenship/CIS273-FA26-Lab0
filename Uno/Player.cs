namespace Uno;

public class Player
{
    public string Name { get; set; } = "";

    public List<Card> Hand { get; set; } = new();

    public bool HasPlayableCard(Card card)
    {
        foreach (Card thing in Hand)
        {
            if (Card.PlaysOn(thing, card))
                return true;
        }
        return false;
    }

    public Card GetFirstPlayableCard(Card card)
    {
        foreach (Card thing in Hand)
        {
            if (Card.PlaysOn(thing, card))
                return thing;
        }
        return null;
    }

    public Color MostCommonColor()
    {
        int red = 0;
        int yellow = 0;
        int blue = 0;
        int green = 0;
        foreach (Card card in Hand)
        {
            if (card.Color == Color.Red)
            {
                red++;
            }
            if (card.Color == Color.Yellow)
            {
                yellow++;
            }
            if (card.Color == Color.Blue)
            {
                blue++;
            }
            if (card.Color == Color.Green)
            {
                green++;
            }
        }
        List<int> numbers = new List<int> { red, yellow, green, blue };

        int winner = numbers.Max();       
 

         if (winner == red)
        {
            return Color.Red;
        }
        if (winner == yellow)
        {
            return Color.Yellow;
        }
        if (winner == blue)
        {
            return Color.Blue;
        }
        if (winner == green)
        {
            return Color.Green;
        }
        return Color.Blue;
        
       
    }



}