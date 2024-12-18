namespace SpanEnumerable;

public static class SpanEnumerableExtensions
{
    public static IEnumerable<T> Where<T>(this IEnumerable<T> sequence, [GenerateStructPredicate] Predicate<T> predicate)
    {
        //MyCode
    }
}