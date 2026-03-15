namespace Auctions.Infrastructure.Entities{
    public class Users{
        public int id{ get; set; }
        public string first_name{ get; set; }
        public string last_name{ get; set; }
        public string email{ get; set; }
        public bool verified{ get; set; }
        public string? password{ get; set; }
        public Users(int i,string fn, string ln, string em, bool v){
            id=i;
            first_name=fn;
            last_name=ln;
            email=em;
            verified=v;
        }
    }
}