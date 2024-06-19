using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BMC_baithi2324.Models;
[Table("Persons")]
public class Person

{
    [Key]
    public string Hovaten { get; set; }

    public string Masinhvien { get; set; }
    public string Lop { get; set; }
}
