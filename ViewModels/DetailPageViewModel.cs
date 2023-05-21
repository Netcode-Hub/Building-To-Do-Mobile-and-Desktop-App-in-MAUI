using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace Maui.ToDoList.ViewModels;

[QueryProperty("Text", "TextString")]
public partial class DetailPageViewModel : ObservableObject
{
    [ObservableProperty]
    string text;

    [RelayCommand]
    async void GoHome()
    {
        await Shell.Current.GoToAsync("..");
    }

    [RelayCommand]
    async void GoBack()
    {
        await Shell.Current.GoToAsync($"//{nameof(MainPage)}");
    }

}

