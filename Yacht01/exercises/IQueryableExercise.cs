using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Yacht01.exercises
{
    class IQueryableExercise
    {
        public static void Run(string[] args)
        {

        }

        private class MyQueryable : IQueryable<string>
        {
            public Expression Expression => throw new NotImplementedException();

            public Type ElementType => throw new NotImplementedException();

            public IQueryProvider Provider => throw new NotImplementedException();

            public IEnumerator<string> GetEnumerator()
            {
                return ((IEnumerable<string>) this.Provider.Execute(this.Expression)).GetEnumerator();
            }

            IEnumerator IEnumerable.GetEnumerator()
            {
                return this.GetEnumerator();
            }
        }
    }
}
