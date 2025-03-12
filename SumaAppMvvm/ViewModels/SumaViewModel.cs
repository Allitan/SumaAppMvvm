
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace SumaAppMvvm.ViewModels
{
    public partial class SumaViewModel : ObservableObject
    {
        [ObservableProperty]
        private double numero1;

        [ObservableProperty]
        private double numero2;

        [ObservableProperty]
        private double resultado;

        private void Alerta(string Titulo, string Mensaje)
        {
            MainThread.BeginInvokeOnMainThread(async () => await App.Current!.MainPage!.DisplayAlert(Titulo, Mensaje, "Aceptar"));
        }

        [RelayCommand]
        private void Calcular()
        {
            try
            {
                if(Numero1 == null || Numero2 == null || Numero1== 0 || Numero2== 0)
                {
                    Alerta("Error", "Debe ingresar ambos números");
                    return;
                }
                else
                {
                    Resultado = Numero1 + Numero2;
                }
            }
            catch (Exception ex)
            {
                Alerta("Error", ex.Message);
            }
        }

        [RelayCommand]
        private void Limpiar()
        {
            Numero1 = 0;
            Numero2 = 0;
            Resultado = 0;
        }
    }
}
