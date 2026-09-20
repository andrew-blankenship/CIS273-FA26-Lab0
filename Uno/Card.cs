namespace Uno;

public enum CardType
{
    Number, Wild, Draw2, WildDraw4, Skip, Reverse
}

public enum Color
{
    Red, Yellow, Blue, Green, Wild
}

public class Card
{

    public CardType Type { get; set; }
    public Color Color { get; set; }
    public int? Number { get; set; }

    


    public static bool PlaysOn(Card card1, Card card2, Color? currentColor = null)
    {

        switch (card1.Type)
        {

            case CardType.Number:
                if (card2.Type == CardType.Number)
                {
                    return card1.Number == card2.Number || card1.Color == card2.Color;
                }
                else if (card2.Type == CardType.Wild || card2.Type == CardType.WildDraw4)
                {
                    // TODO, check current color
                    if (currentColor == null)
                    {
                        return true;
                    }
                    return card1.Color == currentColor;
                }
                else if (card2.Type == CardType.Skip)
                {
                    return card1.Color == card2.Color;
                    
                    
                    // SKIP, REVERSE, DRAW2
                    //TODO, check color
                }
                else if (card2.Type == CardType.Reverse)
                {
                    return card1.Color == card2.Color;
                }
                else if (card2.Type == CardType.Draw2)
                {
                    return card1.Color == card2.Color;
                }
                else
                {
                    break;
                }

            case CardType.Skip:
                if (card2.Type == CardType.Number)
                {
                    return card1.Color == card2.Color;
                }
                else if (card2.Type == CardType.Wild || card2.Type == CardType.WildDraw4)
                {
                    // TODO, check current color
                    return card1.Color == currentColor;
                }
                else if (card2.Type == CardType.Skip)
                {
                    return true;
                    
                }
                else if (card2.Type == CardType.Reverse)
                {
                    return card1.Color == card2.Color;
                }
                else if (card2.Type == CardType.Draw2)
                {
                    return card1.Color == card2.Color;
                }
                else
                {
                    break;
                }
            case CardType.Draw2:
                if (card2.Type == CardType.Number)
                {
                    return card1.Color == card2.Color;
                }
                else if (card2.Type == CardType.Wild || card2.Type == CardType.WildDraw4)
                {
                    // TODO, check current color
                    return card1.Color == currentColor;
                }
                else if (card2.Type == CardType.Skip)
                {
                    return card1.Color == card2.Color;
                    
                }
                else if (card2.Type == CardType.Reverse)
                {
                    return card1.Color == card2.Color;
                }
                else if (card2.Type == CardType.Draw2)
                {
                    return true;
                }
                else
                {
                    break;
                }

            case CardType.Reverse:
                if (card2.Type == CardType.Number)
                {
                    return card1.Color == card2.Color;
                }
                else if (card2.Type == CardType.Wild || card2.Type == CardType.WildDraw4)
                {
                    // TODO, check current color
                    return card1.Color == currentColor;
                }
                else if (card2.Type == CardType.Skip)
                {
                    return card1.Color == card2.Color;
                    
                }
                else if (card2.Type == CardType.Reverse)
                {
                    return true;
                }
                else if (card2.Type == CardType.Draw2)
                {
                    return card1.Color == card2.Color;
                }
                else
                {
                    break;
                }


            case CardType.Wild:
                return true;

            case CardType.WildDraw4:
                return true;



                default:
                    return false;




        }

        return false;
    }
    public override string ToString()
    {
        //TODO handle other card types
        if (Type == CardType.Number)
        {
            return $"{Color} {Number}";
        }

        if (Type == CardType.Wild)
        {
            return $"Wild";
        }

        if (Type == CardType.WildDraw4)
        {
            return $"WildDraw4";
        }

        if (Type == CardType.Skip)
        {
            return $"{Color} Skip";
        }

        if (Type == CardType.Draw2)
        {
            return $"{Color} Draw2";
        }
        if (Type == CardType.Reverse)
        {
            return $"{Color} Reverse";
        }
        else return "";

    }

}