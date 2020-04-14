// SearchKit (https://github.com/hirov-anton/search-kit)
// See LICENSE file in the solution root for full license information
// Copyright (c) Anton Hirov

using System.Linq;
using SearchKit.Data.Entities;
using SearchKit.Service.Entities;

namespace SearchKit.Service.Converters
{
    public interface ISectionConverter
    {
        Section Convert(SectionData data);
    }

    internal class SectionConverter : ISectionConverter
    {
        private readonly IItemConverter itemConverter;

        public SectionConverter(IItemConverter itemConverter)
        {
            this.itemConverter = itemConverter;
        }

        public Section Convert(SectionData data)
        {
            var section = new Section
            {
                Id   = data.Id,
                Name = data.Name
            };
            section.Items.AddRange(data.Items.Select(itemConverter.Convert));
            section.Children.AddRange(data.Children.Select(Convert));
            section.Children.ForEach(_ => _.Parent = section);
            return section;
        }
    }
}