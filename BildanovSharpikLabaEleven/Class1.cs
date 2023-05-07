using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BildanovSharpikLabaEleven
{
    internal class Class1
    {
        public class Person : IComparable<Person>
        {
            private string lastName;
            private string firstName;
            private DateTime dateOfBirth;
            private char gender;

            public Person(string lastName, string firstName, DateTime dateOfBirth, char gender)
            {
                this.lastName = lastName;
                this.firstName = firstName;
                this.dateOfBirth = dateOfBirth;
                Gender = gender;
            }

            public string LastName
            {
                get { return lastName; }
                set { lastName = value; }
            }

            public string FirstName
            {
                get { return firstName; }
                set { firstName = value; }
            }

            public DateTime DateOfBirth
            {
                get { return dateOfBirth; }
                set { dateOfBirth = value; }
            }

            public char Gender
            {
                get { return gender; }
                set
                {
                    if (value == 'M' || value == 'F')
                        gender = value;
                    else
                        throw new ArgumentException("Invalid gender value.");
                }
            }

            public override string ToString()
            {
                return $"{LastName}, {FirstName} ({Gender}), born on {DateOfBirth.ToShortDateString()}";
            }
            public int CompareTo(Person other)
            {
                return LastName.CompareTo(other.LastName);
            }
            //public static Person GetMax(Person[] people)
            //{
            //    if (people == null || people.Length == 0)
            //    {
            //        throw new ArgumentException("Array is empty or null");
            //    }

            //    Person max = people[0];
            //    for (int i = 1; i < people.Length; i++)
            //    {
            //        if (people[i].CompareTo(max) > 0)
            //        {
            //            max = people[i];
            //        }
            //    }

            //    return max;
            //}
        }

        public class AgeComparer : IComparer<Person>
        {
            public int Compare(Person x, Person y)
            {
                return x.DateOfBirth.CompareTo(y.DateOfBirth);
            }
        }

        public class GenderComparer : IComparer<Person>
        {
            public int Compare(Person x, Person y)
            {
                return x.Gender.CompareTo(y.Gender);
            }
        }
        public static class ArrayUtils
        {
            public static void Swap<T>(T[] array, int i, int j)
            {
                T temp = array[i];
                array[i] = array[j];
                array[j] = temp;
            }

            public static T[] DeleteAtIndex<T>(T[] array, int index)
            {
                T[] result = new T[array.Length - 1];
                Array.Copy(array, 0, result, 0, index);
                Array.Copy(array, index + 1, result, index, array.Length - index - 1);
                return result;
            }
        }
        public class MyGenericClass<T>
        {
            private T value;

            public MyGenericClass(T value)
            {
                this.value = value;
            }

            public T GetValue()
            {
                return value;
            }
        }
        public class MyPair<T1, T2>
        {
            private T1 first;
            private T2 second;

            public MyPair(T1 first, T2 second)
            {
                this.first = first;
                this.second = second;
            }
            public T1 First
            {
                get { return first; }
                set { first = value; }
            }
            public T2 Second
            {
                get { return second; }
                set { second = value; }
            }
            public object this[int index]
            {
                get
                {
                    if (index == 0)
                    {
                        return first;
                    }
                    else if (index == 1)
                    {
                        return second;
                    }
                    else
                    {
                        throw new ArgumentOutOfRangeException();
                    }
                }
                set
                {
                    if (index == 0)
                    {
                        first = (T1)value;
                    }
                    else if (index == 1)
                    {
                        second = (T2)value;
                    }
                    else
                    {
                        throw new ArgumentOutOfRangeException();
                    }
                }
            }
            public override string ToString()
            {
                return $"({First}, {Second})";
            }
        }
        public class MyTriple<T1, T2, T3> : MyPair<T1, T2>
        {
            private T3 third;

            public MyTriple(T1 first, T2 second, T3 third) : base(first, second)
            {
                this.third = third;
            }
            public T3 Third
            {
                get { return third; }
                set { third = value; }
            }
            public new object this[int index]
            {
                get
                {
                    if (index == 0)
                    {
                        return First;
                    }
                    else if (index == 1)
                    {
                        return Second;
                    }
                    else if (index == 2)
                    {
                        return Third;
                    }
                    else
                    {
                        throw new ArgumentOutOfRangeException();
                    }
                }
                set
                {
                    if (index == 0)
                    {
                        First = (T1)value;
                    }
                    else if (index == 1)
                    {
                        Second = (T2)value;
                    }
                    else if (index == 2)
                    {
                        Third = (T3)value;
                    }
                    else
                    {
                        throw new ArgumentOutOfRangeException();
                    }
                }
            }
            public override string ToString()
            {
                return $"({First}, {Second}, {Third})";
            }
        }
        class DoublyLinkedList<T>
        {
            class Node
            {
                public T Value { get; set; }
                public Node Next { get; set; }
                public Node Previous { get; set; }

                public Node(T value, Node next = null, Node previous = null)
                {
                    Value = value;
                    Next = next;
                    Previous = previous;
                }
            }
            private Node head;
            private Node tail;
            private int count;

            public int Count { get { return count; } }

            public T First
            {
                get
                {
                    if (head == null) throw new InvalidOperationException("List is empty.");
                    return head.Value;
                }
            }
            public T Last
            {
                get
                {
                    if (tail == null) throw new InvalidOperationException("List is empty.");
                    return tail.Value;
                }
            }
            public void AddFirst(T value)
            {
                Node newNode = new Node(value, head);
                if (head != null)
                {
                    head.Previous = newNode;
                }
                else
                {
                    tail = newNode;
                }
                head = newNode;
                count++;
            }
            public void AddLast(T value)
            {
                Node newNode = new Node(value, null, tail);
                if (tail != null)
                {
                    tail.Next = newNode;
                }
                else
                {
                    head = newNode;
                }
                tail = newNode;
                count++;
            }
            public override string ToString()
            {
                Node current = head;
                string result = "";
                while (current != null)
                {
                    result += current.Value.ToString() + " ";
                    current = current.Next;
                }
                return result.TrimEnd();
            }
        }
    }
}
