using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreSharp.SampleBlazor.Data
{
    public class Todo
    {
        public string Owner { get; set; }

        public bool IsDone { get; set; }

        public string Title { get; set; }

        public static ConcurrentBag<Todo> Items { get; } = new();

        public static event Action NewItemsAdded = delegate { };

        public static void AddItem(Todo item)
        {
            Todo.Items.Add(item);
            Todo.NewItemsAdded();
        }
    }
}
