using System.Collections.Generic;
using System.Linq;
using biblefunctions.Models;

namespace biblefunctions.Services
{
    
    public  class BibleConfigService
    {
        private static IList<BibleConfigInfo> _bibleChapterList = new List<BibleConfigInfo>();

        public BibleConfigService() {
            if(_bibleChapterList.Count==0)
                LoadInfo();
        }

        public IList<BibleConfigInfo> GetBibleInfo()
        {
            return _bibleChapterList;
        }

        public BibleConfigInfo FindBibleConfigInfo(string name)
        {
            var foundBook = _bibleChapterList.SingleOrDefault(book => book.Name == name);
            return  foundBook;
        }

        private void LoadInfo()
        {
            _bibleChapterList = new List<BibleConfigInfo>
            {
                new BibleConfigInfo
                {
                    Name = "Genesis",
                    NumberofChapters = 50,
                    BookTestament = BibleEnums.Testament.Old

                },
                new BibleConfigInfo
                {
                    Name = "Exodus",
                    NumberofChapters = 40,
                    BookTestament = BibleEnums.Testament.Old
                },
                new BibleConfigInfo
                {
                    Name = "Leviticus",
                    NumberofChapters = 27,
                    BookTestament = BibleEnums.Testament.Old
                },
                new BibleConfigInfo
                {
                    Name = "Numbers",
                    NumberofChapters = 36,
                    BookTestament = BibleEnums.Testament.Old
                },
                new BibleConfigInfo
                {
                    Name = "Deuteronomy",
                    NumberofChapters = 34,
                    BookTestament = BibleEnums.Testament.Old
                },
                new BibleConfigInfo
                {
                    Name = "Joshua",
                    NumberofChapters = 24,
                    BookTestament = BibleEnums.Testament.Old
                },
                new BibleConfigInfo
                {
                    Name = "Judges",
                    NumberofChapters = 21,
                    BookTestament = BibleEnums.Testament.Old
                },
                new BibleConfigInfo
                {
                    Name = "Ruth",
                    NumberofChapters = 4,
                    BookTestament = BibleEnums.Testament.Old
                },
                new BibleConfigInfo
                {
                    Name = "1 Samuel",
                    NumberofChapters = 31,
                    BookTestament = BibleEnums.Testament.Old
                },
                new BibleConfigInfo
                {
                    Name = "2 Samuel",
                    NumberofChapters = 24,
                    BookTestament = BibleEnums.Testament.Old
                },
                new BibleConfigInfo
                {
                    Name = "1 Kings",
                    NumberofChapters = 22,
                    BookTestament = BibleEnums.Testament.Old
                },
                new BibleConfigInfo
                {
                    Name = "1 Chronicles",
                    NumberofChapters = 29,
                    BookTestament = BibleEnums.Testament.Old
                },
                new BibleConfigInfo
                {
                    Name = "2 Chronicles",
                    NumberofChapters = 36,
                    BookTestament = BibleEnums.Testament.Old
                },
                new BibleConfigInfo
                {
                    Name = "Ezra",
                    NumberofChapters = 10,
                    BookTestament = BibleEnums.Testament.Old
                },
                new BibleConfigInfo
                {
                    Name = "Nehemiah",
                    NumberofChapters = 13,
                    BookTestament = BibleEnums.Testament.Old
                },
                new BibleConfigInfo
                {
                    Name = "Esther",
                    NumberofChapters = 10,
                    BookTestament = BibleEnums.Testament.Old
                },
                new BibleConfigInfo
                {
                    Name = "Job",
                    NumberofChapters = 42,
                    BookTestament = BibleEnums.Testament.Old
                },
                new BibleConfigInfo
                {
                Name = "Psalms",
                NumberofChapters = 150,
                BookTestament = BibleEnums.Testament.Old
                },
                new BibleConfigInfo
                {
                    Name = "Proverbs",
                    NumberofChapters = 31,
                    BookTestament = BibleEnums.Testament.Old
                },
                new BibleConfigInfo
                {
                    Name = "Ecclesiastes",
                    NumberofChapters = 12,
                    BookTestament = BibleEnums.Testament.Old
                },
                new BibleConfigInfo
                {
                    Name = "Song of Solomon",
                    NumberofChapters = 8,
                    BookTestament = BibleEnums.Testament.Old
                },
                new BibleConfigInfo
                {
                    Name = "Isaiah",
                    NumberofChapters = 66,
                    BookTestament = BibleEnums.Testament.Old
                },
                new BibleConfigInfo
                {
                    Name = "Jeremiah",
                    NumberofChapters = 52,
                    BookTestament = BibleEnums.Testament.Old
                },
                new BibleConfigInfo
                {
                    Name = "Lamentations",
                    NumberofChapters = 5,
                    BookTestament = BibleEnums.Testament.Old
                },
                new BibleConfigInfo
                {
                    Name = "Ezekiel",
                    NumberofChapters = 48,
                    BookTestament = BibleEnums.Testament.Old
                },
                new BibleConfigInfo
                {
                    Name = "Daniel",
                    NumberofChapters = 12,
                    BookTestament = BibleEnums.Testament.Old
                },
                new BibleConfigInfo
                {
                    Name = "Hosea",
                    NumberofChapters = 14,
                    BookTestament = BibleEnums.Testament.Old
                },
                new BibleConfigInfo
                {
                    Name = "Joel",
                    NumberofChapters = 3,
                    BookTestament = BibleEnums.Testament.Old
                },
                new BibleConfigInfo
                {
                    Name = "Amos",
                    NumberofChapters = 9,
                    BookTestament = BibleEnums.Testament.Old
                },
                new BibleConfigInfo
                {
                    Name = "Obadiah",
                    NumberofChapters = 1,
                    BookTestament = BibleEnums.Testament.Old
                },
                new BibleConfigInfo
                {
                    Name = "Jonah",
                    NumberofChapters = 4,
                    BookTestament = BibleEnums.Testament.Old
                },
                new BibleConfigInfo
                {
                    Name = "Micah",
                    NumberofChapters = 7,
                    BookTestament = BibleEnums.Testament.Old
                },
                new BibleConfigInfo
                {
                    Name = "Nahum",
                    NumberofChapters = 3,
                    BookTestament = BibleEnums.Testament.Old
                },
                new BibleConfigInfo
                {
                    Name = "Habakkuk",
                    NumberofChapters = 3,
                    BookTestament = BibleEnums.Testament.Old
                },
                new BibleConfigInfo
                {
                    Name = "Zephaniah",
                    NumberofChapters = 3,
                    BookTestament = BibleEnums.Testament.Old
                },
                new BibleConfigInfo
                {
                    Name = "Haggai",
                    NumberofChapters = 2,
                    BookTestament = BibleEnums.Testament.Old
                },
                new BibleConfigInfo
                {
                    Name = "Zechariah",
                    NumberofChapters = 14,
                    BookTestament = BibleEnums.Testament.Old
                },
                new BibleConfigInfo
                {
                    Name = "Malachi",
                    NumberofChapters = 4,
                    BookTestament = BibleEnums.Testament.Old
                }

            };

        }

    }
}
