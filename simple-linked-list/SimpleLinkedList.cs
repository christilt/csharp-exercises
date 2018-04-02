using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class SimpleLinkedList<T> : IEnumerable<T>
{
    public T Value { get; private set; }
    public SimpleLinkedList<T> Next { get; private set; }

    public SimpleLinkedList(T value) : this(value, null) { }

    public SimpleLinkedList(T value, SimpleLinkedList<T> next)
    {
        Value = value;
        Next = next;
    }

    public SimpleLinkedList(IEnumerable<T> values)
    {
        Value = values.FirstOrDefault();
        Next = values.Count() > 1 
             ? new SimpleLinkedList<T>(values.Skip(1)) 
             : null;
    }

    public SimpleLinkedList<T> Add(T value)
    {
        if (value == null) return this;
        if (Value == null)
        {
            return new SimpleLinkedList<T>(value);
        }
        if (Next == null)
        {
            var next = new SimpleLinkedList<T>(value);
            return new SimpleLinkedList<T>(Value, next);
        }
        else
        {
            var next = Next.Add(value);
            return new SimpleLinkedList<T>(Value, next);
        }
    }

    public IEnumerator<T> GetEnumerator()
    {
        if (Value != null) yield return Value;
        if (Next != null)
            foreach(T t in Next)
            {
                yield return t;
            }
    }

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}