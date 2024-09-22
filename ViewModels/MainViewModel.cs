using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using PocketFinansistWPF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace PocketFinansistWPF.ViewModels
{
    internal partial class MainViewModel : ObservableObject
    {
        [ObservableProperty]
        private Account _currentAccount;

        public MainViewModel()
        {
            CurrentAccount = new Account();
        }

        [RelayCommand]
        private void ActivateAccount()
        {
            if (CurrentAccount == null)
            {
                MessageBox.Show("Аккаунт не создан!");
                return;
            }

            if (CurrentAccount.GetAccountName() != null)
            {
                CurrentAccount.UnlockAccount();
            }
        }

        [RelayCommand]
        public void CreateAccount(string accountName)
        {
            if(string.IsNullOrWhiteSpace(accountName))
            {
                MessageBox.Show("Введите корректное имя для аккаунта!");
                return;
            }
            CurrentAccount = new Account();
        }


    }
}
