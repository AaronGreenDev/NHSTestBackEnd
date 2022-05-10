using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CWPT.Interviews.Test
{
    public class Practice
    {
        [Key, Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [MaxLength(200)]
        public string Name { get; set; }
        [MaxLength(200)]
        public string AddressLine1 { get; set; }
        [MaxLength(200)]
        public string AddressLine2 { get; set; }
        [MaxLength(200)]
        public string AddressLine3 { get; set; }
        [MaxLength(12)]
        public string Postcode { get; set; }
        [MaxLength(15)]
        public string Longitude { get; set; }
        [MaxLength(15)]
        public string Latitude { get; set; }
    }
}
