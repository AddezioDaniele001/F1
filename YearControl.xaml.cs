namespace F1App;

public partial class YearControl : ContentPage
{
	public int value {  get; set; }
	public YearControl()
	{
		InitializeComponent();
	}
	
	public void MinusButton(object sender, EventArgs e)
	{
		if(value > 1980) 
		{
			value--;
			
		}
	}

	public void PlusButton(object sender, EventArgs e)
	{
		if(value < 2024)
		{
			value++;
			
		}
	}
}