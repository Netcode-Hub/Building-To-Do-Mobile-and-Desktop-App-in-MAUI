using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;

namespace Maui.ToDoList.ViewModels;
public partial class MainPageViewModel : ObservableObject
{
    Private readonly IConnectivity connectivity;
 
    public MainPageViewModel(IConnectivity connectivity)
    {
        Items = new ObservableCollection<string>();
        this.connectivity = connectivity;
  
    }

    [ObservableProperty]
    ObservableCollection<string> items;

    [ObservableProperty]
    string text;

    [RelayCommand]
      async void Add()
    {
          if(connectivity.NetworkAccess != NetworkAccess.Internet)
          {
            await Shell.Current.DisplayAlert("Oops as [Title]", "No Internet as [Message]", "ok as [button]");
            return;
          }
        Items.Add(Text);
        Text = string.Empty;
    }

    [RelayCommand]
    void Delete(string s)
    {
        if (Items.Contains(s))
            Items.Remove(s);
    }

    [RelayCommand]
    async void Tap(string s)
    {
        await Shell.Current.GoToAsync($"{nameof(DetailPage)}?TextString={s}");
    }
}



