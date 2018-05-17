using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;
using Common.Log;
using Lykke.Service.Neo.Core.Services;
using Neo.Implementations.Wallets.EntityFramework;
using Neo.Network;
using Neo.Wallets;

namespace Lykke.Service.Neo.Services
{
    public class NeoService: INeoService
    {
        private readonly ILog _log; 
        
        public NeoService(ILog log)
        {
            _log = log; 
        }

        public bool IsValidPrivateKey(string privateKey)
        {
            throw new NotImplementedException();
        }

        public byte[] GetPrivateKey()
        {
            byte[] privateKey = new byte[32];
            using (RandomNumberGenerator rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(privateKey);
            }

            return privateKey;
            //var key = new KeyPair(privateKey);
            //var has = key.PublicKeyHash;

            //throw new NotImplementedException();
        }

        public string GetPublicAddress(byte[] privateKey)
        {
            //new MainService().Run();
            var wallet = UserWallet.Create(@"C:\GitHub\LykkeCity\Lykke.Service.Neo.Sign\src\Lykke.Service.Neo", "test");
            var account = wallet.CreateAccount(privateKey);
            return account.Address;
        }
    }
}
