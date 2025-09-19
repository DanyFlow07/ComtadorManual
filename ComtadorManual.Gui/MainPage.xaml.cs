//using Android.Telephony;

namespace ComtadorManual.Gui
{
    //conteo  del contador de esta tarea
    public partial class MainPage : ContentPage
    {
        private int conteo;
        public MainPage()
        {
            InitializeComponent();
                    conteo = 0;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            conteo++;
            ContadorL.Text = conteo.ToString();

        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            conteo = 0;
            ContadorL.Text = conteo.ToString();

        }
    }
}
