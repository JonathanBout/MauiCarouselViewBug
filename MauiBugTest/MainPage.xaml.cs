using System.Collections.ObjectModel;

namespace MauiBugTest;

public partial class MainPage : ContentPage
{
	ObservableCollection<string> Data { get; set; } = new ObservableCollection<string>();

	public MainPage()
	{
		InitializeComponent();
		DataView.ItemsSource = Data;
		DataView.EmptyView = "Empty";
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
		if (Data.Count == 0)
		{
			for (int i = 0; i < Random.Shared.Next(2, 10); i++)
			{
				Data.Add($"{i:X}");
			}
		}
		else
		{
			Data.Clear();
		}
	}

	private void ReloadButton_Clicked(object sender, EventArgs e)
	{
		App.Current.MainPage = new AppShell();
	}
}

