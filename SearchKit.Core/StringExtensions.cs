// SearchKit (https://github.com/hirov-anton/search-kit)
// See LICENSE file in the solution root for full license information
// Copyright (c) 2018 Anton Hirov

using static SearchKit.Core.CodeConstants;

namespace SearchKit.Core
{
    public static class StringExtensions
    {
        public static string GetSearchPattern(this string ext) => $"{Asterisk}{Dot}{ext}";
    }
}