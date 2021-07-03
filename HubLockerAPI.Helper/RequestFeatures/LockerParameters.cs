
namespace HubLockerAPI.Helper.RequestFeatures
{
    public class LockerParameters : RequestParameters
    {
        public LockerParameters()
        {
            OrderBy = "name";
        }
        public uint MinAge { get; set; }
        public uint MaxAge { get; set; } = int.MaxValue;
        public bool ValidAgeRange => MaxAge > MinAge;
        public string SearchQuery { get; set; }
    }
}
