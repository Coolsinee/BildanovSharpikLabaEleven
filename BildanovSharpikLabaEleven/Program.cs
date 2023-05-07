using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BildanovSharpikLabaEleven.Class1;

namespace BildanovSharpikLabaEleven
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////Первый тест
            //int[] intArray = { 1, 2, 3, 4, 5 };
            //ArrayUtils.Swap(intArray, 1, 3);
            //Console.WriteLine(string.Join(", ", intArray));

            //double[] doubleArray = { 1.0, 2.0, 3.0, 4.0, 5.0 };
            //ArrayUtils.Swap(doubleArray, 2, 4);
            //Console.WriteLine(string.Join(", ", doubleArray));

            //string[] stringArray = { "one", "two", "three", "four", "five" };
            //ArrayUtils.Swap(stringArray, 0, 4);
            //Console.WriteLine(string.Join(", ", stringArray));

            //Person[] personArray = new Person[]
            //{
            //    new Person("Doe", "John", new DateTime(1990, 5, 7), 'M'),
            //    new Person("Smith", "Jane", new DateTime(1995, 2, 14), 'F'),
            //    new Person("Johnson", "Bobson", new DateTime(1985, 11, 23), 'M')
            //};
            //ArrayUtils.Swap(personArray, 0, 2);
            //foreach (Person p in personArray)
            //{
            //    Console.WriteLine(p);
            //}

            //int[] numbers = { 1, 2, 3, 4, 5 };
            //numbers = ArrayUtils.DeleteAtIndex(numbers, 2);
            //Console.WriteLine(string.Join(", ", numbers)); 

            //string[] names = { "John", "Jane", "Bobson", "Alice" };
            //names = ArrayUtils.DeleteAtIndex(names, 1);
            //Console.WriteLine(string.Join(", ", names)); 

            //Person[] persons = new Person[]
            //{
            //    new Person("Doe", "John", new DateTime(1990, 5, 7), 'M'),
            //    new Person("Smith", "Jane", new DateTime(1995, 2, 14), 'F'),
            //    new Person("Johnson", "Bobson", new DateTime(1985, 11, 23), 'M')
            //};
            //persons = ArrayUtils.DeleteAtIndex(persons, 2);
            //foreach (Person p in persons)
            //{
            //    Console.WriteLine(p);
            //}
            ////Второй тест
            //Person[] persons = new Person[]
            //{
            //    new Person("Doe", "John", new DateTime(1990, 5, 7), 'M'),
            //    new Person("Smith", "Jane", new DateTime(1995, 2, 14), 'F'),
            //    new Person("Johnson", "Bobson", new DateTime(1985, 11, 23), 'M')
            //};
            //Array.Sort(persons);
            //foreach (Person p in persons)
            //{
            //    Console.WriteLine(p);
            //}

            //Person maxPerson = GetMax(persons);
            //Console.WriteLine($"Max person: {maxPerson}");

            //Array.Sort(persons, new AgeComparer());
            //foreach (Person p in persons)
            //{
            //    Console.WriteLine(p);
            //}

            //Array.Sort(persons, new GenderComparer());
            //foreach (Person p in persons)
            //{
            //    Console.WriteLine(p);
            //}

            //static Person GetMax(Person[] array)
            //{
            //    Person max = array[0];
            //    for (int i = 1; i < array.Length; i++)
            //    {
            //        if (array[i].CompareTo(max) > 0)
            //        { 
            //            max = array[i];
            //        }
            //    }
            //    return max;
            //}
            ////Третий тест
            //MyPair<int, string> pair = new MyPair<int, string>(1, "one");
            //Console.WriteLine(pair);
            //Console.WriteLine(pair[0]);
            //Console.WriteLine(pair[1]);
            //pair[0] = 2;
            //pair[1] = "two";
            //Console.WriteLine(pair);

            //MyTriple<double, string, bool> triple = new MyTriple<double, string, bool>(1.0, "one", true);
            //Console.WriteLine(triple);
            //Console.WriteLine(triple[0]);
            //Console.WriteLine(triple[1]);
            //Console.WriteLine(triple[2]);
            //triple[0] = 2.0;
            //triple[1] = "two";
            //triple[2] = false;
            //Console.WriteLine(triple);
            ////Четвёртый тест
            //DoublyLinkedList<int> list = new DoublyLinkedList<int>();
            //Console.WriteLine($"Count: {list.Count}");
            //list.AddFirst(1);
            //Console.WriteLine($"Count: {list.Count}, First: {list.First}, Last: {list.Last}");
            //list.AddFirst(2);
            //Console.WriteLine($"Count: {list.Count}, First: {list.First}, Last: {list.Last}");
            //list.AddLast(3);
            //Console.WriteLine($"Count: {list.Count}, First: {list.First}, Last: {list.Last}");
            //Console.WriteLine(list);
        }
    }
}
