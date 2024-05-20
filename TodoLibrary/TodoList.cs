using System.Collections.Generic;

namespace TodoLibrary
{
    public class TodoList
    {
        private List<TodoItem> items = new List<TodoItem>();

        public void AddItem(TodoItem item)
        {
            items.Add(item);
        }

        public void RemoveItem(int index)
        {
            if (index >= 0 && index < items.Count)
            {
                items.RemoveAt(index);
            }
        }

        public List<TodoItem> GetItems()
        {
            return items;
        }
    }
}
