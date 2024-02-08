namespace MauiApp1;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	private void OnCounterClicked(object sender, EventArgs e)
{
    // Increment the counter
    count++;

    // Update the text of the button based on the counter value
    if (count == 1)
        CounterBtn.Text = "Something awesome will happen";
    else
        CounterBtn.Text = "A bit of patience... Incoming";

    // Use SemanticScreenReader to announce the updated text for accessibility
    SemanticScreenReader.Announce(CounterBtn.Text);}
}

