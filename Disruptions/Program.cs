using HtmlAgilityPack;

var url = "https://tfl.gov.uk/tube-dlr-overground/status/";
var web = new HtmlWeb();
var doc = web.Load(url);

var lizzie = doc.DocumentNode.SelectNodes("//div[@class='rainbow-list-content']").Where(x => x.OuterHtml.Contains("elizabeth"));
var disruptions = doc.DocumentNode.SelectNodes("//div[@class='rainbow-list-content']").Where(x => x.OuterHtml.Contains("disruption"));
var delays = doc.DocumentNode.SelectNodes("//div[@class='rainbow-list-content']").Where(x => x.OuterHtml.Contains("delay"));
