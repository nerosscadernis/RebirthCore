using Rebirth.Common.Extensions;
using Rebirth.World.Datas.Clients;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Rebirth.World.Managers
{
    public class AccountManager : DataManager<AccountManager>
    {
        private List<Account> _accounts = new List<Account>();

        public void UpdateAccount(Account acc)
        {
            var account = _accounts.FirstOrDefault(x => x.Id == acc.Id);
            if (account != null)
                _accounts.Remove(account);
            _accounts.Add(acc);
        }

        public Account GetAccount(string key)
        {
            return _accounts.FirstOrDefault(x => x.Key == key);
        }
    }
}
