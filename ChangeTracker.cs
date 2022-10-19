using System.Linq.Expressions;

namespace ChangeTrackerTest;

public class ChangesTracker<T1, T2>
{
    private readonly IEnumerable<T1> oldValues;
    private readonly IEnumerable<T2> newValues;
    private readonly Expression<Func<T1, T2, bool>> areEqual;

    public ChangesTracker(IEnumerable<T1> oldValues, IEnumerable<T2> newValues, Expression<Func<T1, T2, bool>> areEqual)
    {
        this.oldValues = oldValues;
        this.newValues = newValues;
        this.areEqual = areEqual;
    }

    public IEnumerable<T2> AddedItems => newValues.Where(n => oldValues.All(o => !areEqual.Compile().Invoke(o, n)));

    public IEnumerable<T1> RemovedItems => oldValues.Where(n => newValues.All(o => !areEqual.Compile().Invoke(n, o)));

    public IEnumerable<T1> UpdatedItems => oldValues.Where(n => newValues.Any(o => areEqual.Compile().Invoke(n, o)));
}