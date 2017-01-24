using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;
using System.Xml.Linq;

namespace RssFeedWebApplication
{
    // Web page from https://www.youtube.com/watch?v=M8SvfsmSeZA
    // Syndicate from http://stackoverflow.com/questions/10399400/best-way-to-read-rss-feed-in-net-using-c-sharp
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                PopulateRssFeed();
            }
        }

        private void PopulateRssFeed()
        {
            string RssFeedUrl = "http://www.jyvaskyla.fi/rss/fi/1/0/ajankohtaista";
            List<RssFeeds> feeds = new List<RssFeeds>();

            try
            {
                XmlReader reader = XmlReader.Create(RssFeedUrl);
                SyndicationFeed sFeed = SyndicationFeed.Load(reader);
                reader.Close();

                foreach (SyndicationItem item in sFeed.Items.Take(5))
                {
                    RssFeeds f = new RssFeeds
                    {
                        Title = item.Title.Text,
                        Link = item.Links[0].Uri.ToString(),
                        PublishDate = item.PublishDate.ToString(),
                        Description = item.Summary.Text
                    };

                    feeds.Add(f);

                }

                gvRss.DataSource = feeds;
                gvRss.DataBind();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}