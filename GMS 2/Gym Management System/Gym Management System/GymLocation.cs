namespace Gym_Management_System
{
    public class GymLocation
    {
        private string siteNumber;
        private string siteLocation;
        public GymLocation(string siteNumber, string siteLocation)
        {
            this.siteNumber = siteNumber;
            this.siteLocation = siteLocation;
        }
        public string GetSiteNumber()
        {
            return siteNumber;
        }
        public void SetSiteNumber(string siteNumber)
        {
            this.siteNumber = siteNumber;
        }
        public string GetSiteLocation()
        {
            return siteLocation;
        }
        public void SetSiteLocation(string siteLocation)
        {
            this.siteLocation = siteLocation;
        }
    }
}
