using System;
using System.Windows.Input;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

using Test.Models;

namespace Test.ViewModels
{
    public class ListCurrencyViewModel : BaseViewModel
    {
        private ObservableCollection<CurrencyModel> _currency;

        public ObservableCollection<CurrencyModel> Currency
        {
            get { return _currency; }
            set { _currency = value; OnPropertyChanged("Currency"); }
        }

        public ListCurrencyViewModel()
        {
            Currency = new ObservableCollection<CurrencyModel>();

            Currency.Add(new CurrencyModel() { ID = 1, Coin = "Peso Mexicano", ExchangeRate = 10 });
            Currency.Add(new CurrencyModel() { ID = 2, Coin = "Dolar", ExchangeRate = 15 });
            Currency.Add(new CurrencyModel() { ID = 3, Coin = "Euro", ExchangeRate = 20 });
            Currency.Add(new CurrencyModel() { ID = 4, Coin = "Peso Colombiano", ExchangeRate = 4 });
            Currency.Add(new CurrencyModel() { ID = 5, Coin = "Colones", ExchangeRate = 6 });
        }
    }
}
