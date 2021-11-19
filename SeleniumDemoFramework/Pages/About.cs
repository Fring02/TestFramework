namespace SeleniumDemoFramework
{
    public class AboutPage
    {

        public void Goto()
        {
            Browser.Goto("About");
        }

        public bool IsAt()
        {
            return Browser.Title.Contains("About");
        }

    }
}
