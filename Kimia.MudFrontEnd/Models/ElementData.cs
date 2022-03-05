namespace Kimia.MudFrontEnd.Models;

public class ElementData
{
    public int Number { get; set; }
    public string Name { get; set; } = default!;
    public string Sign { get; set; } = default!;
    public string Group { get; set; } = default!;
    public double Molar { get; set; }
}
