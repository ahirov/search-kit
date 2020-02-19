// SearchKit (https://github.com/hirov-anton/search-kit)
// See LICENSE file in the solution root for full license information
// Copyright (c) Anton Hirov

using System.Linq;
using SearchKit.Entities.Search;
using SearchKit.Service.Entities;

namespace SearchKit.Converters
{
    public class SectionModelConverter
    {
        public SectionModel Convert(Section section)
        {
            var model = new SectionModel
            {
                Id   = section.Id.ToString(),
                Name = section.Name
            };
            model.Items.AddRange(section.Items.Select(new ItemModelConverter().Convert));
            model.Children.AddRange(section.Children.Select(Convert));
            model.Children.ForEach(_ => _.Parent = model);
            return model;
        }
    }
}