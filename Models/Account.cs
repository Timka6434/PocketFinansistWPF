using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PocketFinansistWPF.Models
{
    internal class Account
    {
        private string _id {  get; set; }
        private string _accountName { get; set; }
        private decimal _balance { get; set; }
        private bool _isLocked { get; set; }
        private DateTime _DataCreateAccount {  get; set; }

        public Account() 
        {
            _id = Guid.NewGuid().ToString();
            _accountName = "no name";
            _balance = 0;
            _isLocked = true;
            _DataCreateAccount = DateTime.Now;
        }
        public string GetAccountName() => _accountName;
        public void SetAccountName(string SetName) => _accountName = SetName;

        public void SetBalance(decimal  Balance) => _balance = Balance;

        public void UnlockAccount() => _isLocked = false;
    }
}
