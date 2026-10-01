namespace ContractsLab3;

// Sorts shelf counts by aisle, then value, and finally by slot.
public class GroupedByKey : IComparer<ShelfCount>
{
    public int Compare(ShelfCount a, ShelfCount b)
    {
        int aisleComparison = string.Compare(
            a.Aisle,
            b.Aisle,
            StringComparison.Ordinal
            );

        if (aisleComparison != 0)
        {
            return aisleComparison;
        }

        int valueComparison = b.ValueOnHand.CompareTo(a.ValueOnHand);

        if (valueComparison != 0)
        {
            return valueComparison;
        }

        return a.Slot.CompareTo(b.Slot);
    }
}