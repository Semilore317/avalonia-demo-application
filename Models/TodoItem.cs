using System;

namespace SimpleTodoList.Models;

public class TodoItem
{
        // gets or sets the checked status of each item
        public bool isChecked { get; set; }
        // gets or sets the content of the to-do item
        public string? Content { get; set; }
}