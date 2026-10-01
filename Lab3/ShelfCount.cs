namespace ContractsLab3;

// Represents a shelf count and provides equality and natural sorting behavior.
public class ShelfCount : IEquatable<ShelfCount>, IComparable<ShelfCount>
{
    private string _aisle;
    private int _slot;
    private double _valueOnHand;

    public string Aisle
    {
        get { return _aisle; }
    }

    public int Slot
    {
        get { return _slot; }
    }

    public double ValueOnHand
    {
        get { return _valueOnHand; }
    }

    public ShelfCount(string aisle, int slot, double valueOnHand)
    {
        _aisle = aisle;
        _slot = slot;
        _valueOnHand = valueOnHand;
    }

    public bool Equals(ShelfCount other)
    {
        if (other == null)
        { 
            return false;
        }

        return string.Equals(Aisle, other.Aisle, StringComparison.Ordinal)
            && Slot == other.Slot;
    }

    public override bool Equals(object obj)
    {
        return Equals(obj as ShelfCount);
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(Aisle, Slot);
    }

    public int CompareTo(ShelfCount other)
    {
        if (other == null)
        {
            return 1;
        }

        int aisleComparison = string.Compare(
            Aisle,
            other.Aisle,
            StringComparison.Ordinal
            );

        if (aisleComparison != 0)
        {
            return aisleComparison;
        }

        return Slot.CompareTo(other.Slot);
    }

    public override string ToString()
    {
        return String.Format(
            "{0,-6} #{1} {2,8:N2}",
            Aisle,
            Slot,
            ValueOnHand
            );
    }
}