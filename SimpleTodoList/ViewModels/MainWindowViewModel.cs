using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace SimpleTodoList.ViewModels;

public partial class MainWindowViewModel : ViewModelBase
{
    // observable collection TodoItems
    // its read only --> only getter is needed
    public ObservableCollection<TodoItemViewModel> TodoItems { get; } = new ObservableCollection<TodoItemViewModel>();

    /// <summary>
    /// gets or sets the content for new items to add. if string isnt empty, the addItemCommand will be enabled autmatically
    ///  </summary>
    [ObservableProperty] [NotifyCanExecuteChangedFor(nameof(AddItemCommand))] //invalidates the command each time this property changes
    private string? _newItemContent;
    
    // method to regulate whether we can add todoItems
    private bool CanAddItem() => !string.IsNullOrWhiteSpace(NewItemContent); // shorthand return statement
    
    // method to actually add items to the list
    [RelayCommand(CanExecute = nameof(CanAddItem))] 
    //automatically generates a command from the AddItem method that is only executable when the CanAddItem() method returns true
    // allows the UI to enable or disable the command (e.g., a button) based on input validity.
    private void AddItem()
    {
        // Add a new item to the list
        TodoItems.Add(new TodoItemViewModel(){Content = NewItemContent});
        
        // reset the NewItemContent
        NewItemContent = null; // reset the newItemContent -> makes input field clear
    }
}