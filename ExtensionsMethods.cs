using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace LINQ
{
   static class ExtensionsMethods
    {
       public static IEnumerable<TSource> MyWhere<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate)
        {
            List<TSource> result = new List<TSource>();
            foreach (var x in source)
                if (predicate(x))
                    result.Add(x);
            return result;
        }

       public static IEnumerable<TResult> MySelect<TSource, TResult>(this IEnumerable<TSource> source, Func<TSource, TResult> selector)
        {
            List<TResult> result2 = new List<TResult>();
            foreach (var c in source)
                         result2.Add(selector(c));
            return result2;

        }
        //public static IEnumerable<IGrouping<TKey, TSource>> MyGroupBy<TSource, TKey>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector)
        //{
        //    List <ClassGrouping<TKey, TSource>> result3 = new List<ClassGrouping<TKey, TSource>>();
        //    foreach (var y in source)
        //    {
        //        ClassGrouping<TKey, TSource> x = new ClassGrouping<TKey, TSource>(keySelector(y), y);
        //    }
        //}

        class ClassGrouping <TKey, TResult> : IGrouping<TKey, TResult>
        {
            public TKey Key { get; set; }
            public IEnumerable<TResult> values;
            public ClassGrouping (TKey key, IEnumerable <TResult> values44)
            {
                Key = key;
                values = values44;
            }
            public IEnumerator<TResult> GetEnumerator()
            {
                return values.GetEnumerator();
            }

            IEnumerator IEnumerable.GetEnumerator()
            {
              return  GetEnumerator();
            }
        }

        public static List<TSource> MyToList<TSource>(this IEnumerable<TSource> source)
        {
            List<TSource> result4 = new List<TSource>();
            foreach (var v in source)
                result4.Add(v);
            return result4;

        }
     public static   Dictionary<TKey, TSource> MyToDictionary<TSource, TKey>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector)
        {
            Dictionary <TKey , TSource> result5 = new Dictionary<TKey, TSource>();
            foreach (var v in source)
                result5.Add(keySelector(v), v);
            return result5;
        }


    }
}
