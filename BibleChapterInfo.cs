namespace CommonDataService
{
    public class BibleChapterInfo
    {
        public enum Testament
        {
            Old,
            New
        }
        public string Name;
        public int NumberofChapter;
        public Testament BookTestament;
    }
}