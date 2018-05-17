using System.Collections.Generic;
using Lykke.Service.Neo.Core.Domain.Health;

namespace Lykke.Service.Neo.Core.Services
{
    
    public interface INeoService
    {
        bool IsValidPrivateKey(string privateKey);
        byte[] GetPrivateKey();
        string GetPublicAddress(byte[] privateKey);
    }
}
