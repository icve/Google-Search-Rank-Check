using System.Collections.Generic;

namespace SearchRankCheck.Models{
    public class Entry{
        public string Site;
        public string Url;
        public bool IsTargetSite;
    }
    public class RankResult{
        public List<Entry> AllResults;
        public List<int> TargetSiteRank;
        public string Keyword;
        public string TargetSite;
        public RankResult(string keyword, string site){
            TargetSiteRank = new List<int>();
            AllResults = new List<Entry>();
            TargetSite = site;
            Keyword = keyword;
        }
        public void InsertEntry(string Site, string Url, bool isTargetSite){
            if(isTargetSite){
                TargetSiteRank.Add(AllResults.Count);
            }
            AllResults.Add(new Entry{Site=Site, Url=Url, IsTargetSite=isTargetSite});
        }
        
    }
}