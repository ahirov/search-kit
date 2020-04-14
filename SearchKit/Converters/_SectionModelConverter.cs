// SearchKit (https://github.com/hirov-anton/search-kit)
// See LICENSE file in the solution root for full license information
// Copyright (c) Anton Hirov

using System.Linq;
using SearchKit.Entities.Search;
using SearchKit.Service.Entities;

namespace SearchKit.Converters
{
    public interface ISectionModelConverter
    {
        SectionModel Convert(Section section);
    }

    internal class SectionModelConverter : ISectionModelConverter
    {
        private readonly IItemModelConverter itemConverter;

        public SectionModelConverter(IItemModelConverter itemConverter)
        {
            this.itemConverter = itemConverter;
        }

        public SectionModel Convert(Section section)
        {
            var model = new SectionModel
            {
                Id   = section.Id.ToString(),
                Name = section.Name
            };
            model.Items.AddRange(section.Items.Select(itemConverter.Convert));
            model.Children.AddRange(section.Children.Select(Convert));
            model.Children.ForEach(_ => _.Parent = model);
            return model;
        }
    }
}