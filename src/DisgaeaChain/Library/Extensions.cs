using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisgaeaChain
{
  public static class Extensions
  {
    public static IEnumerable<T> Minus<T>(this IEnumerable<T> self, T value)
    {
      foreach (T t in self)
      {
        if (t.Equals(value)) continue;
        yield return t;
      }
    }
  }
}
