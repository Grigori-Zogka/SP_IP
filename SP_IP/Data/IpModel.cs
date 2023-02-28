namespace SP_IP.Data
{
    //created in order to reflec the data returned from the Stored procedure in thr DB
    public class IpModel
    {
        public string CountryName { get; set; }
        public int AddressesCount { get; set; }
        public string LastAddressUpdated { get; set; }
    }
}
