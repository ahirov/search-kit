// SearchKit (https://github.com/hirov-anton/search-kit)
// See LICENSE file in the solution root for full license information
// Copyright (c) Anton Hirov

using SearchKit.Data;
using SearchKit.Service.Converters;
using SearchKit.Service.Entities;

namespace SearchKit.Service
{
    public interface ISectionLoader
    {
        Section Load();
    }

    public class SectionLoader : ISectionLoader
    {
        private readonly IDataProvider dataProvider;
        private readonly ISectionConverter sectionConverter;

        public SectionLoader(IDataProvider dataProvider,
                             ISectionConverter sectionConverter)
        {
            this.dataProvider = dataProvider;
            this.sectionConverter = sectionConverter;
        }

        public Section Load()
        {
            var data = dataProvider.GetSection();
            return sectionConverter.Convert(data);
        }
    }
}