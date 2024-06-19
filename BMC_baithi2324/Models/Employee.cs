using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BMC_baithi2324.Models;
[Table("Employees")]
public class Employee : Person

{
    [Key]
    public string Hovaten { get; set; }

    public string Masv { get; set; }
    public string Love { get; set; }
}
