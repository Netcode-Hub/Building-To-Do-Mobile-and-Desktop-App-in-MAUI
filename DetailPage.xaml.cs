using Maui.ToDoList.ViewModels;

namespace Maui.ToDoList;

public partial class DetailPage : ContentPage
{
	public DetailPage(DetailPageViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}