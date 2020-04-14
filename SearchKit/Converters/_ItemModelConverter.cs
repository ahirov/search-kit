// SearchKit (https://github.com/hirov-anton/search-kit)
// See LICENSE file in the solution root for full license information
// Copyright (c) Anton Hirov

using SearchKit.Entities.Search;
using SearchKit.Service.Entities;

namespace SearchKit.Converters
{
    public interface IItemModelConverter
    {
        ItemModel Convert(Item item);
    }

    internal class ItemModelConverter : IItemModelConverter
    {
        public ItemModel Convert(Item item)
        {
            return new ItemModel
            {
                Id   = item.Id.ToString(),
                Name = item.Name
            };
        }
    }
}