# RssWebTest

This test project creates a website readin Keskisuomalainen rss feed.

I used hot tips for creating a web project from https://www.youtube.com/watch?v=M8SvfsmSeZA
How to use SyndicationFeed reader I found answer from http://stackoverflow.com/questions/10399400/best-way-to-read-rss-feed-in-net-using-c-sharp

Project was created with Visual Studio 2015.

Main functionality lies in classes Default.aspx and its code behind. Data class for Rss feed is RssFeeds.cs.

It took me few tries to consume the feed. After looping several items it throws an error. That's why I use take(5).
