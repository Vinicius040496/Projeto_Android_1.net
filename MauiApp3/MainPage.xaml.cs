namespace MauiApp3
{
    public partial class MainPage : TabbedPage
    {
        string Nome;

        public MainPage()
        {
            InitializeComponent();
        }

        private async void btn_Clicked(object sender, EventArgs e)
        {
            Nome = await DisplayPromptAsync("Nome","Digite seu nome",Nome, "Fechar");
           await DisplayAlert("Aviso!","Ola, " + Nome,"Fechar");
        }
    }

}
