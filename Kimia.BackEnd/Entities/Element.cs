using System.ComponentModel.DataAnnotations;

namespace Kimia.BackEnd.Entities;

public class Element
{
    [Key]
    public int Number { get; set; }
    public string Name { get; set; } = default!;
    public string Sign { get; set; } = default!;
    public string Group { get; set; } = default!;
    public double Molar { get; set; }
}
