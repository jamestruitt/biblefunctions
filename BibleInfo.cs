using System;
using System.Collections.Generic;

namespace CommonDataService
{
    

    public  class BibleInfo
    {
        private static IList<BibleChapterInfo> _bibleChapterList = new List<BibleChapterInfo>();

        public BibleInfo() {
            if(_bibleChapterList.Count==0)
                LoadInfo();
        }

        public IList<BibleChapterInfo> GetBibleInfo()
        {
            return _bibleChapterList;
        }

        private void LoadInfo()
        {
            _bibleChapterList = new List<BibleChapterInfo>
            {
                new BibleChapterInfo
                {
                    Name = "Genesis",
                    NumberofChapter = 50,
                    BookTestament = BibleChapterInfo.Testament.Old

                },
                new BibleChapterInfo
                {
                    Name = "Exodus",
                    NumberofChapter = 40,
                    BookTestament = BibleChapterInfo.Testament.Old
                },
                new BibleChapterInfo
                {
                    Name = "Leviticus",
                    NumberofChapter = 27,
                    BookTestament = BibleChapterInfo.Testament.Old
                },
                new BibleChapterInfo
                {
                    Name = "Numbers",
                    NumberofChapter = 36,
                    BookTestament = BibleChapterInfo.Testament.Old
                },
                new BibleChapterInfo
                {
                    Name = "Deuteronomy",
                    NumberofChapter = 34,
                    BookTestament = BibleChapterInfo.Testament.Old
                },
                new BibleChapterInfo
                {
                    Name = "Joshua",
                    NumberofChapter = 24,
                    BookTestament = BibleChapterInfo.Testament.Old
                },
                new BibleChapterInfo
                {
                    Name = "Judges",
                    NumberofChapter = 21,
                    BookTestament = BibleChapterInfo.Testament.Old
                },
                new BibleChapterInfo
                {
                    Name = "Ruth",
                    NumberofChapter = 4,
                    BookTestament = BibleChapterInfo.Testament.Old
                },
                new BibleChapterInfo
                {
                    Name = "1 Samuel",
                    NumberofChapter = 31,
                    BookTestament = BibleChapterInfo.Testament.Old
                },
                new BibleChapterInfo
                {
                    Name = "2 Samuel",
                    NumberofChapter = 24,
                    BookTestament = BibleChapterInfo.Testament.Old
                },
                new BibleChapterInfo
                {
                    Name = "1 Kings",
                    NumberofChapter = 22,
                    BookTestament = BibleChapterInfo.Testament.Old
                },
                new BibleChapterInfo
                {
                    Name = "1 Chronicles",
                    NumberofChapter = 29,
                    BookTestament = BibleChapterInfo.Testament.Old
                },
                new BibleChapterInfo
                {
                    Name = "2 Chronicles",
                    NumberofChapter = 36,
                    BookTestament = BibleChapterInfo.Testament.Old
                },
                new BibleChapterInfo
                {
                    Name = "Ezra",
                    NumberofChapter = 10,
                    BookTestament = BibleChapterInfo.Testament.Old
                },
                new BibleChapterInfo
                {
                    Name = "Nehemiah",
                    NumberofChapter = 13,
                    BookTestament = BibleChapterInfo.Testament.Old
                },
                new BibleChapterInfo
                {
                    Name = "Esther",
                    NumberofChapter = 10,
                    BookTestament = BibleChapterInfo.Testament.Old
                },
                new BibleChapterInfo
                {
                    Name = "Job",
                    NumberofChapter = 42,
                    BookTestament = BibleChapterInfo.Testament.Old
                },
                new BibleChapterInfo
                {
                Name = "Psalms",
                NumberofChapter = 150,
                BookTestament = BibleChapterInfo.Testament.Old
                },
                new BibleChapterInfo
                {
                    Name = "Proverbs",
                    NumberofChapter = 31,
                    BookTestament = BibleChapterInfo.Testament.Old
                },
                new BibleChapterInfo
                {
                    Name = "Ecclesiastes",
                    NumberofChapter = 12,
                    BookTestament = BibleChapterInfo.Testament.Old
                },
                new BibleChapterInfo
                {
                    Name = "Song of Solomon",
                    NumberofChapter = 8,
                    BookTestament = BibleChapterInfo.Testament.Old
                },
                new BibleChapterInfo
                {
                    Name = "Isaiah",
                    NumberofChapter = 66,
                    BookTestament = BibleChapterInfo.Testament.Old
                },
                new BibleChapterInfo
                {
                    Name = "Jeremiah",
                    NumberofChapter = 52,
                    BookTestament = BibleChapterInfo.Testament.Old
                },
                new BibleChapterInfo
                {
                    Name = "Lamentations",
                    NumberofChapter = 5,
                    BookTestament = BibleChapterInfo.Testament.Old
                },
                new BibleChapterInfo
                {
                    Name = "Ezekiel",
                    NumberofChapter = 48,
                    BookTestament = BibleChapterInfo.Testament.Old
                },
                new BibleChapterInfo
                {
                    Name = "Daniel",
                    NumberofChapter = 12,
                    BookTestament = BibleChapterInfo.Testament.Old
                },
                new BibleChapterInfo
                {
                    Name = "Hosea",
                    NumberofChapter = 14,
                    BookTestament = BibleChapterInfo.Testament.Old
                },
                new BibleChapterInfo
                {
                    Name = "Joel",
                    NumberofChapter = 3,
                    BookTestament = BibleChapterInfo.Testament.Old
                },
                new BibleChapterInfo
                {
                    Name = "Amos",
                    NumberofChapter = 9,
                    BookTestament = BibleChapterInfo.Testament.Old
                },
                new BibleChapterInfo
                {
                    Name = "Obadiah",
                    NumberofChapter = 1,
                    BookTestament = BibleChapterInfo.Testament.Old
                },
                new BibleChapterInfo
                {
                    Name = "Jonah",
                    NumberofChapter = 4,
                    BookTestament = BibleChapterInfo.Testament.Old
                },
                new BibleChapterInfo
                {
                    Name = "Micah",
                    NumberofChapter = 7,
                    BookTestament = BibleChapterInfo.Testament.Old
                },
                new BibleChapterInfo
                {
                    Name = "Nahum",
                    NumberofChapter = 3,
                    BookTestament = BibleChapterInfo.Testament.Old
                },
                new BibleChapterInfo
                {
                    Name = "Habakkuk",
                    NumberofChapter = 3,
                    BookTestament = BibleChapterInfo.Testament.Old
                },
                new BibleChapterInfo
                {
                    Name = "Zephaniah",
                    NumberofChapter = 3,
                    BookTestament = BibleChapterInfo.Testament.Old
                },
                new BibleChapterInfo
                {
                    Name = "Haggai",
                    NumberofChapter = 2,
                    BookTestament = BibleChapterInfo.Testament.Old
                },
                new BibleChapterInfo
                {
                    Name = "Zechariah",
                    NumberofChapter = 14,
                    BookTestament = BibleChapterInfo.Testament.Old
                },
                new BibleChapterInfo
                {
                    Name = "Malachi",
                    NumberofChapter = 4,
                    BookTestament = BibleChapterInfo.Testament.Old
                }

            };

        }

    }
}
