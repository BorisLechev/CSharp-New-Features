public class NumberAttribute : Attribute
{
    public NumberAttribute(int number)
    {
        this.Number = number;
    }

    public int Number { get; }
}
