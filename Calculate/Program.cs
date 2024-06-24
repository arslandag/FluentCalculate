

public class FluentCalculate
{
    public static Value Zero { get; } = new Value(0);
    public static Value One { get; } = new Value(1);
    public static Value Two { get; } = new Value(2);
    public static Value Three { get; } = new Value(3);
    public static Value Four { get; } = new Value(4);
    public static Value Five { get; } = new Value(5);
    public static Value Six { get; } = new Value(6);
    public static Value Seven { get; } = new Value(7);
    public static Value Eight { get; } = new Value(8);
    public static Value Nine { get; } = new Value(9);
    public static Value Ten { get; } = new Value(10);
    
    public class Value
    {
        private int _value;

        public Value(int value)
        {
            _value = value;
        }

        public Operation Plus => new Operation(_value, OperationType.Add);
        public Operation Minus => new Operation(_value, OperationType.Subtract);
        public Operation Times => new Operation(_value, OperationType.Multiply);
        public Operation DividedBy => new Operation(_value, OperationType.Divide);

        public static implicit operator int(Value value) => value._value;
    }

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
                case OperationType.Add:
                    return _value + operand;
                case OperationType.Subtract:
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
    
    public enum OperationType
    {
        Add,
        Subtract,
        Multiply,
        Divide
    }
}