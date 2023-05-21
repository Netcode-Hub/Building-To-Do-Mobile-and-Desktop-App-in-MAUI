using Maui.ToDoList.ViewModels;

namespace Maui.ToDoList;

public partial class MainPage : ContentPage
{
	public MainPage(MainPageViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}


}

