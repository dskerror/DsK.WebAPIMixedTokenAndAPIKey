using System.ComponentModel.DataAnnotations;

namespace DsK.WebAPIMixedTokenAndAPIKey.Entity;
public class ApiKey
{
    [Key]
    public int Id { get; set; }

    [Required]
    public string Key { get; set; }
}