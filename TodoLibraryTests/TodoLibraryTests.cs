using System;
using Xunit;
using TodoLibrary;

namespace TodoLibraryTests
{
    public class TodoItemTests
    {
        [Fact]
        public void CanCreateTodoItem()
        {
            var item = new TodoItem("Test item");
            Assert.Equal("Test item", item.Description);
            Assert.False(item.IsCompleted);
        }

        [Fact]
        public void CanMarkItemAsCompleted()
        {
            var item = new TodoItem("Test item");
            item.MarkAsCompleted();
            Assert.True(item.IsCompleted);
        }
    }

    public class TodoListTests
    {
        [Fact]
        public void CanAddItemToList()
        {
            var list = new TodoList();
            var item = new TodoItem("Test item");
            list.AddItem(item);
            Assert.Contains(item, list.GetItems());
        }

        [Fact]
        public void CanRemoveItemFromList()
        {
            var list = new TodoList();
            var item = new TodoItem("Test item");
            list.AddItem(item);
            list.RemoveItem(0);
            Assert.DoesNotContain(item, list.GetItems());
        }

        [Fact]
        public void GetItemsReturnsAllItems()
        {
            var list = new TodoList();
            var item1 = new TodoItem("Test item 1");
            var item2 = new TodoItem("Test item 2");
            list.AddItem(item1);
            list.AddItem(item2);
            var items = list.GetItems();
            Assert.Equal(2, items.Count);
            Assert.Contains(item1, items);
            Assert.Contains(item2, items);
        }
    }
}
