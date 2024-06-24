namespace Calculate.Common;

public class Value
{
    private int _value;

    public Value(int value)
    {
        _value = value;
    }

    public Operation Plus => new Operation(_value, OperationType.Plus);
    public Operation Minus => new Operation(_value, OperationType.Minus);
    public Operation Times => new Operation(_value, OperationType.Multiply);
    public Operation DividedBy => new Operation(_value, OperationType.Divide);

    public static implicit operator int(Value value) => value._value;
}