using Calculate.Common;

namespace Calculate.Common;

public class Operation
{
    private int _value;
    private OperationType _type;

    public Operation(int value, OperationType type)
    {
        _value = value;
        _type = type;
    }

    public Value Zero => new Value(PerformOperation(0));
    public Value One => new Value(PerformOperation(1));
    public Value Two => new Value(PerformOperation(2));
    public Value Three => new Value(PerformOperation(3));
    public Value Four => new Value(PerformOperation(4));
    public Value Five => new Value(PerformOperation(5));
    public Value Six => new Value(PerformOperation(6));
    public Value Seven => new Value(PerformOperation(7));
    public Value Eight => new Value(PerformOperation(8));
    public Value Nine => new Value(PerformOperation(9));
    public Value Ten => new Value(PerformOperation(10));

    private int PerformOperation(int operand)
    {
        switch (_type)
        {
            case OperationType.Plus:
                return _value + operand;
            case OperationType.Minus:
                return _value - operand;
            case OperationType.Multiply:
                return _value * operand;
            case OperationType.Divide:
                return _value / operand;
            default:
                throw new InvalidOperationException();
        }
    }
}