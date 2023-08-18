using System.ComponentModel.DataAnnotations.Schema;

namespace N27_T1;

[Table("person")]
public class Person
{
    public int id { get; set; }
    
    public string? login { get; set; }
    public string? email { get; set; }
    public int age { get; set; }
}