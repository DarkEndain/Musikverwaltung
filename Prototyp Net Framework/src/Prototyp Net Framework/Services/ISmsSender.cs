using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Prototyp_Net_Framework.Services
{
    public interface ISmsSender
    {
        Task SendSmsAsync(string number, string message);
    }
}
