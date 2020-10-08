namespace StarCitizenAPIWrapper.Library
{
    class StarCitizenClientConfig
    {
        public const string StarCitizenClient = "StarCitizenClient";

        public string ApiRequestUrl { get; set; }
        public string ApiLiveRequestUrl { get; set; }
        public string ApiCacheRequestUrl { get; set; }
        public string ApiKey { get; set; }
    }

}
