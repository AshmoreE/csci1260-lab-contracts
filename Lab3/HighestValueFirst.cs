namespace ContractsLab3;

// Sorts shelf counts from highest value to lowest value.
public class HighestValueFirst : IComparer<ShelfCount>
{
    public int Compare(ShelfCount a, ShelfCount b)
    {
        int valueComparison = b.ValueOnHand.CompareTo(a.ValueOnHand);

        if (valueComparison != 0)
        {
            return valueComparison;
        }

        return a.CompareTo(b);
    }
}