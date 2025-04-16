using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Timers;
using CryptoViewer.Models;
using CryptoViewer.Services;

namespace CryptoViewer.ViewModels;

public class MainViewModel : INotifyPropertyChanged
{
    private readonly CryptoService _service = new();
    private readonly Timer _timer;

    public ObservableCollection<CryptoCurrency> Currencies { get; set; } = [];

    public MainViewModel()
    {
        _ = LoadDataAsync();

        _timer = new Timer(60000);
        _timer.Elapsed += async (_, _) => await LoadDataAsync();
        _timer.Start();
    }

    private async Task LoadDataAsync()
    {
        var data = await _service.GetPricesAsync();
        App.Current.Dispatcher.Invoke(() =>
        {
            Currencies.Clear();
            foreach (var item in data)
            {
                Currencies.Add(item);
            }
        });
    }

    public event PropertyChangedEventHandler PropertyChanged;

    protected void OnPropertyChanged([CallerMemberName] string name = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }
}