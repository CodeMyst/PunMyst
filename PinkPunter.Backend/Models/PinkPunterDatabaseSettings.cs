namespace PinkPunter.Backend.Models;

public class PinkPunterDatabaseSettings
{
    public string ConnectionString { get; set; } = null!;

    public string DatabaseName { get; set; } = null!;

    public string PunsCollectionName { get; set; } = null!;
    
    public string PunSubmissionsCollectionName { get; set; } = null!;
}