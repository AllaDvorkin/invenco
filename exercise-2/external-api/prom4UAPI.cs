﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace external_api
{
    public class prom4UAPI : IProvider
    {
        // item-id -> dicount percent
        private readonly Dictionary<int, int> _db = new Dictionary<int, int>();

        private const int _maxDiscountPercent = 20;
        private const int _latencyInMs = 100;

        public string Name
        {
            get { return "prom4UAPI"; }
        }

        public prom4UAPI()
        {
            Thread.Sleep(_latencyInMs);
            _db = PopulateDB(numberOfProducts: 10_000);
        }

        public async Task<List<int>> GetDiscountableItemIds()
        {
            await Util.SimulateRemoteHttpCall();
            return _db.Keys.ToList();
        }

        public async Task<double?> CalculateDiscount(int itemId, double price)
        {
            if(itemId == 27)
                throw new NullReferenceException("sorry for that");

            await Util.SimulateRemoteHttpCall();
            if (_db.ContainsKey(itemId))
                return price * _db[itemId] / 100;
            else return null;
        }

        public async Task<bool> IsDiscountable(int itemId)
        {
            await Util.SimulateRemoteHttpCall();
            return _db.ContainsKey(itemId);
        }

        private static Dictionary<int, int> PopulateDB(int numberOfProducts)
        {
            var random = new Random();
            var dictionary = new Dictionary<int, int>();

            for (int i = 0; i < numberOfProducts; i++)
                dictionary[random.Next(1, 101)] = random.Next(0, _maxDiscountPercent + 1);

            return dictionary;
        }
    }
}