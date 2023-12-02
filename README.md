# NEXT VPN

`` ObservableObject``

`ObservableObject class implements the INotifyPropertyChanged interface,
which is commonly used in the MVVM pattern to notify subscribers when a 
property changes.`

`ObservableObject` is a base class that implements the `INotifyPropertyChanged` interface. It is commonly used in the MVVM (Model-View-ViewModel) pattern to notify subscribers when a property changes.

## Key Features

1. **INotifyPropertyChanged Interface:**
   - `ObservableObject` implements the `INotifyPropertyChanged` interface, which provides a standard mechanism for objects to notify subscribers that one of their properties has changed.

2. **PropertyChanged Event:**
   - The class declares a non-nullable `PropertyChanged` event of type `PropertyChangedEventHandler`. This event is raised when a property changes.

3. **OnPropertyChanged Method:**
   - The `OnPropertyChanged` method is used to raise the `PropertyChanged` event. It takes the property name as a parameter (automatically filled using the `CallerMemberName` attribute).

## Usage

```csharp
// Example usage of ObservableObject
class YourViewModel : ObservableObject
{
    private string _Property;

    public string Property
    {
        get { return _Property; }
        set
        {
            if (_Property != value)
            {
                _Property = value;
                OnPropertyChanged();
                
                // Notify subscribers that the property has changed
            }
        }
    }
}
```

# RelayCommand

`RelayCommand` is a commonly used implementation of the ICommand interface in WPF (Windows Presentation Foundation) and other XAML-based frameworks. It is used to represent an action that can be executed and provides a way to determine if the action can be executed.

## Key Components and Concepts

1. **ICommand Interface:**
   - `RelayCommand` implements the `ICommand` interface, which defines methods (`CanExecute` and `Execute`) that represent actions that can be executed by a command.

2. **Action and Func:**
   - `Action<object>` is a delegate that represents a method that takes a single parameter of type `object` and does not return a value. It's used for the action that should be executed when the command is triggered.
   - `Func<object, bool>` is a delegate that represents a method that takes a single parameter of type `object` and returns a boolean. It's used to determine whether the command can be executed.

3. **Events:**
   - `CanExecuteChanged` is an event that is raised when the result of the `CanExecute` method changes. It is part of the ICommand interface and is used to notify the system that the ability to execute the command has changed.

4. **CommandManager.RequerySuggested:**
   - The `RequerySuggested` event is part of the `CommandManager` class in WPF. It is a global event that suggests that the command manager should query the commands to check whether they can be executed.

5. **Constructor:**
   - The constructor of `RelayCommand` takes two parameters: `Action<object> execute` (the action to be executed) and `Func<object, bool> canExecute` (a function to determine if the action can be executed). The `canExecute` parameter has a default value of `null`, meaning the command can always be executed if this parameter is not provided.

6. **Execute Method:**
   - The `Execute` method is called when the command is triggered. It, in turn, calls the provided `execute` action.

7. **CanExecute Method:**
   - The `CanExecute` method is used to determine whether the command can be executed. It checks whether the provided `canExecute` function is `null` or evaluates to `true` for the given parameter.

8. **Event Subscription:**
   - The `CanExecuteChanged` event is subscribed to the `CommandManager.RequerySuggested` event. This ensures that the `CanExecuteChanged` event is raised when the system suggests that the command manager should reevaluate the ability to execute commands.

## Usage

```csharp
// Example usage of RelayCommand
var myCommand = new RelayCommand(
    execute: obj => 
    {
        // logic
    },
    canExecute: obj => 
    {
        // canExecute logic
        return true;
        // Change this based on your conditions
    }
);

```


# Apply Headter Action Button 
as like minimize, maximize, shoutdown




