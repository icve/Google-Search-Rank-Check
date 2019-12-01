using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using SearchRankCheck.Models;

namespace SearchRackCheck.SearchEngine
{
    /// <summary>
    /// Summary description for Class1
    /// </summary>
    public class GoogleSearch
    {
        private string _googleUrl = "https://www.google.com/search";
        int NResult { set; get; }
        string Site { set; get; }

        private const string regStr = "url\\?q=[^\"]*";
        private readonly Regex regex = new Regex(regStr, RegexOptions.Compiled | RegexOptions.IgnoreCase);
        /// <summary>
        /// constructor for GoogleRankChecker
        /// </summary>
        /// <param name="site">web site url for rank checking</param>
        /// <param name="nResults">number of result to retrieve</param>
        public GoogleSearch(string site, int nResults = 100)
        {
            NResult = nResults;
            Site = site;
        }
        private string redirectPrefix2Url(string redirectPrefix){
            return _googleUrl.Replace("search", redirectPrefix);
        }
        private string extractSite(string redirectPrefix){
            return redirectPrefix.Replace("url?q=", "").Split("&", 2)[0];
        }
        /// <summary>
        /// Get rank position
        /// </summary>
        /// <param name="keyword">keyword to google for</param>
        /// <returns>list of rank positions</returns>
        public RankResult search(string keyword)
        {
            string rawHtml = null;
            using (WebClient wc = new WebClient())
            {
                wc.QueryString.Add("q", keyword);
                wc.QueryString.Add("num", NResult.ToString());
                rawHtml = wc.DownloadString(_googleUrl);
            }
            MatchCollection matches = regex.Matches(rawHtml);
            RankResult result = new RankResult(keyword, Site);
            foreach (Match match in matches)
            {
                GroupCollection groups = match.Groups;
                string redirectPrefix = groups[0].ToString();
                bool isTargetSite = redirectPrefix.Contains(Site);
                result.InsertEntry(extractSite(redirectPrefix), redirectPrefix2Url(redirectPrefix), isTargetSite);
            }
            return result;
        }

    }
}