
namespace com.boutique.Entity
{
    public class StitchingDetail : Audit
    {
        public int Id { get; set; }
        public int SerialNumber { get; set; }
        public int ItemCount { get; set; }
        public string Price { get; set; }
        public string Color { get; set; }        
        //public virtual Image Image { get; set; }
        public string StitchingDetails { get; set; }
        public string EmbroideryDetails { get; set; }
    }
}
