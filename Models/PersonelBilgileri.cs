using System.ComponentModel.DataAnnotations;

namespace Personel.Models;

public class PersonelBilgileri
{
    [Key]

    public int Id { get; set; }
    public string Ad { get; set; } = string.Empty;
    public string Soyad { get; set; } = string.Empty;
    public string Sehir { get; set; } = string.Empty;
    public double Maas{ get; set; }
}