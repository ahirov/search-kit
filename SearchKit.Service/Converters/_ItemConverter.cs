// SearchKit (https://github.com/hirov-anton/search-kit)
// See LICENSE file in the solution root for full license information
// Copyright (c) Anton Hirov

using SearchKit.Data.Entities;
using SearchKit.Service.Entities;

namespace SearchKit.Service.Converters
{
    public interface IItemConverter
    {
        Item Convert(ItemData data);
    }

    internal class ItemConverter : IItemConverter
    {
        public Item Convert(ItemData data)
        {
            return new Item
            {
                Id   = data.Id,
                Name = data.Name
            };
        }
    }
}