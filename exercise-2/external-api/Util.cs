using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System;

namespace external_api
{
    internal class Util
    {
        private static readonly Random _random = new Random();
        private const double _networkProblemProbability = 0.01;
        private const int _latencyInMs = 100;

        internal static async Task SimulateRemoteHttpCall()
        {
            var isNetworkProblemHappened = _random.NextDouble() < _networkProblemProbability;

            if (isNetworkProblemHappened)
            {
                var exceptions = new List<Exception>
                {
                    new TimeoutException(),
                    new HttpRequestException("internal server error")
                };

                var exception = exceptions[_random.Next(0, exceptions.Count)];

                throw exception;
            }

            await Task.Delay(_latencyInMs);

        }
    }

}
