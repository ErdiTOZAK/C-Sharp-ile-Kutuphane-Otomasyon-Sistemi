

namespace  CSProjeDemo1.Presentation.VMs  
{
    public class UyeListVM 
    {
        public Guid Id { get; set; }    
        public string UyeNo { get; set; }

        public string? Ad { get; set; }

        public string? Soyad { get; set; }

        //public string FulLAd
        //{
        //    get
        //    { return Ad + " " + Soyad; }

        //    set {; }
        //}

        public bool Cinsiyet { get; set; }
    }
}
