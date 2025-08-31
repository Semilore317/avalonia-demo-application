using System;
using CommunityToolkit.Mvvm.ComponentModel;
using SimpleTodoList.Models;

namespace SimpleTodoList.ViewModels
{
    /// <summary>
    ///  this is a viewModel which represents a <see cref="Models.Todoitem"/>
    /// </summary>
    public partial class TodoItemViewModel : ViewModelBase
    {
        /// <inheritdoc/>

        public TodoItemViewModel()
        {
            // empty
        }
        
        // create a new TodoItemViewModel for the given TodoItem
        public TodoItemViewModel(TodoItem item)
        {
            // init the properties with the given values
            IsChecked = item.isChecked;
            Content = item.Content; 
        }
        // gets or sets the checked status of each item
        [ObservableProperty]
        private bool _isChecked;
        
        // gets or sets the content of the to-do item
        [ObservableProperty]
        private String? _content;

        public TodoItem GetTodoItem()
        {
            return new TodoItem()
            {
                isChecked = this.IsChecked,
                Content = this.Content
            };
        }
    }
}