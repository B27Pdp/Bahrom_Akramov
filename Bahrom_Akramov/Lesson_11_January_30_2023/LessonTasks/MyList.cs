using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bahrom_Akramov.Lesson_11_January_30_2023.LessonTasks
{
    internal class MyList<T> : IEnumerable, IEnumerator
    {
        public List<T> list= new();

        public T this[int index]
        {
            get { return list[index]; }
            set { list[index] = value; }
        }

        public object Current => throw new NotImplementedException();
        /// <summary>
        /// Qalesan Jiyan
        /// </summary>
        /// <param name="item">Qiymat kirit</param>
        public void Add(T item)
        {
            list.Add(item);
        }


        public IEnumerator GetEnumerator()
        {
            foreach (T item in list)
            {
                yield return item;
            }
        }

        public bool MoveNext()
        {
            throw new NotImplementedException();
        }

        public void Reset()
        {
            throw new NotImplementedException();
        }
    }
}
