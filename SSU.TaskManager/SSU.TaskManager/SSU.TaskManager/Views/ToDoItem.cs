using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using Xamarin.Forms;

namespace SSU.TaskManager.Views
{
    public class ToDoItem
    {
        // Instance members.
        private ToDoItem()
        {
        }

        public string Name { private set; get; }

        private static string[] toDoitems = new string[] { "Поесть", "Покодить", "Поспать" };

        public static List<ToDoItem> All { private set; get; }

        // Static members.
        static ToDoItem()
        {
            List<ToDoItem> all = new List<ToDoItem>();

            // Loop through the public static fields of the Color structure.
            foreach (var name in toDoitems)
            {
                    // Convert the name to a friendly name.

                    ToDoItem toDoItem = new ToDoItem
                    {
                        Name = name,
                    };

                    // Add it to the collection.
                    all.Add(toDoItem);
            }
            All = all;
        }
    }
}
