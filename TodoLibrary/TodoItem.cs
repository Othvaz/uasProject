using System;

namespace TodoLibrary
{
    public class TodoItem
    {
        public string Description { get; set; }
        public bool IsCompleted { get; set; }

        public TodoItem(string description)
        {
            Description = description;
            IsCompleted = false;
        }

        public void MarkAsCompleted()
        {
            IsCompleted = true;
        }

        public override string ToString()
        {
            return $"{Description} - {(IsCompleted ? "Completed" : "Pending")}";
        }
    }
}
