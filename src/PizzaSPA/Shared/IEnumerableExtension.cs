using System.Collections;

namespace PizzaSPA.Shared
{
    public static  class IEnumerableExtension
    {
        public static bool Any(this IEnumerable enumerable) => enumerable.GetEnumerator().MoveNext()==true;
    }
}