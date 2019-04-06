// SearchKit (https://github.com/hirov-anton/search-kit)
// See LICENSE file in the solution root for full license information
// Copyright (c) 2018 Anton Hirov

using System;
using System.Collections.Generic;
using System.Linq;
using SearchKit.Entities.Search;

namespace SearchKit.Entities.Seed
{
    public class DataInitializer
    {
        private int id;
        private int dataCount;
        private int sectionsDepth;

        private Random random;
        private List<string> papers;
        private List<string> sections;
        private List<(string FirstName, string LastName)> names;


        public SectionOverview Init()
        {
            InitData();
            var section = CreateSection(null, "Root");
            return section;
        }

        private SectionOverview CreateSection(SectionOverview parent, string name = null)
        {
            var section = new SectionOverview
            {
                Id = Id,
                IsActivated = true,
                Name = name ?? sections[RandomData],
                Author = CreateAuthor(),
                Parent = parent
            };
            if (sectionsDepth > 0)
            {
                sectionsDepth--;
                section.Children.AddRange(Enumerable.Range(0, RandomCount)
                                                    .Select(_ => CreateSection(section)));
                section.Papers.AddRange(Enumerable.Range(0, RandomCount)
                                                  .Select(_ => CreatePaper()));
            }
            return section;
        }

        private PaperOverview CreatePaper()
        {
            var paper = new PaperOverview
            {
                Id = Id,
                IsActivated = true,
                Name = papers[RandomData],
                DateCreated = DateTime.Now,
                DateModified = DateTime.Now,
                Owner = CreateAuthor()
            };
            var authors = Enumerable.Range(0, RandomData).Select(_ => CreateAuthor());
            paper.Authors.AddRange(authors);
            return paper;
        }

        private AuthorOverview CreateAuthor()
        {
            return new AuthorOverview
            {
                Id = Id,
                FirstName = names[RandomData].FirstName,
                LastName = names[RandomData].LastName
            };
        }

        private string Id => (++id).ToString();
        private int RandomData => random.Next(0, dataCount);
        private int RandomCount => random.Next(1, dataCount);
        private void InitData()
        {
            dataCount = 4;
            sectionsDepth = 3;
            random = new Random();
            papers = new List<string>
            {
                "The Mysterious Affair at Styles",
                "The Murder on the Links",
                "Poirot Investigates",
                "The Murder of Roger Ackroyd"
            };
            sections = new List<string>
            {
                "Business",
                "Transport",
                "Education",
                "Communication"
            };
            names = new List<(string, string)>
            {
                ("Joe", "Davidson"),
                ("DeeDee", "Elias"),
                ("Mark", "Smith"),
                ("Oggy", "Wells")
            };
        }
    }
}