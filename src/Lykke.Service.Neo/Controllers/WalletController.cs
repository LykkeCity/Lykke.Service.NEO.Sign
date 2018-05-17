using System;
using System.Linq;
using System.Net;
using Lykke.Service.Neo.Core.Services;
using Lykke.Service.Neo.Models;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace Lykke.Service.Neo.Controllers
{
    // NOTE: See https://lykkex.atlassian.net/wiki/spaces/LKEWALLET/pages/35755585/Add+your+app+to+Monitoring
    [Route("api/[controller]")]
    public class WalletController : Controller
    {
        private readonly INeoService _neoService;

        public WalletController(INeoService neoService)
        {
            _neoService = neoService;
        }

        [HttpPost]
        public WalletResponse Post(string addressContext)
        {
            var privateKey = _neoService.GetPrivateKey();
            var publicAddress = _neoService.GetPublicAddress(privateKey);

            return new WalletResponse()
            {
                PrivateKey = privateKey,
                PublicAddress = publicAddress,
                FromAddressContext = addressContext
            };
        }
    }
}
