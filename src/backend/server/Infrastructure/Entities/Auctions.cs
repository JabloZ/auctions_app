namespace auctions_models{
    public class Auctions{
        public int auction_id { get; set; }
        public int owner_id{ get; set; }
        public string? start_date{ get; set; }
        public string? end_date{ get; set; }
        public int last_bidder{ get; set; }
        public int last_bid{ get; set; }
        public int start_bid{ get; set; }
        public int next_bid_change{ get; set; }
    }
}