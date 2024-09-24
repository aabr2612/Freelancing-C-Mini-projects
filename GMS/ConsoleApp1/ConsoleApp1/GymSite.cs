using System.Collections.Generic;

namespace ConsoleApp1
{
    public class GymSite
    {
        private string siteId;
        private string location;
        public GymSite(string siteId, string location)
        {
            this.siteId = siteId;
            this.location = location;
        }
        public GymSite(GymSite site)
        {
            this.siteId=site.siteId;
            this.location=site.location;
        }
        public string GetSiteId()
        {
            return siteId;
        }
        public void SetSiteId(string siteId)
        {
            this.siteId = siteId;
        }
        public string GetLocation()
        {
            return location;
        }
        public void SetLocation(string location)
        {
            this.location = location;
        }
    }
}
