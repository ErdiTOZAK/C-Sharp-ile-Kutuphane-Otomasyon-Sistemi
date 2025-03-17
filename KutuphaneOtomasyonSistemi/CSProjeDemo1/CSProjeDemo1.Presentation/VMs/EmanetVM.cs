
namespace CSProjeDemo1.Presentation.VMs
{
    public class EmanetIslemListVM 
    {
        public Guid Id { get; set; }
        public DateTime VerilisTarihi { get; set; } 

        public DateTime? TeslimTarihi { get; set; }

        //public KitapDurum KitapDurum { get; set; }

        public string KitapId { get; set; }
        public string UyeId { get; set; }

    }
}
