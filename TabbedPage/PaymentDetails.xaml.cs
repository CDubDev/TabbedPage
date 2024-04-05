namespace TabbedPage
{
    public partial class PaymentDetails : ContentPage
	{
		public PaymentDetails()
		{
			InitializeComponent();
		}

        private void Button_Clicked(object sender, EventArgs e)
        {
			Navigation.PopAsync();
        }
    }
}