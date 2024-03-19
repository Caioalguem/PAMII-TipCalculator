namespace TipoCalculator
{
    public partial class MainPage : ContentPage
    {


        public MainPage()
        {
            InitializeComponent();
        }

        public void PercentageSlider_ValueChanged(object sender, EventArgs e)
        {
            TipoPorcentageLabel.Text = $" { PercentageSlider.Value.ToString()} %";
        }

        public void Button15Percent_Clicked(object sender, EventArgs e)
        {

        }

        public void Button30Percent_Clicked(object sender, EventArgs e)
        {

        }

        public void ButtonRoundDown_Clicked(object sender, EventArgs e)
        {

        }

        public void ButtonRoundUp_Clicked(object sender, EventArgs e)
        {

        }
    }

}
