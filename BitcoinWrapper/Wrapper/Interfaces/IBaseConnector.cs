using System.Collections.Generic;
using BitcoinWrapper.Data;
using Newtonsoft.Json.Linq;

namespace BitcoinWrapper.Wrapper.Interfaces
{
    public interface IBaseConnector
    {
        JObject RequestServer(MethodName methodName);
        JObject RequestServer(MethodName methodName, object parameter);
        JObject RequestServer(MethodName methodName, List<object> parameters);
        JObject RequestServer(MethodName methodName, object parameter, object parameter2);
    }
}