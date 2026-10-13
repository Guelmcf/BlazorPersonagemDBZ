using System.Text.Json.Serialization;

namespace BlazorDbzPersonagem.Client.Models;

public class Personagem
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; } = string.Empty;

    [JsonPropertyName("ki")]
    public string Ki { get; set; } = string.Empty;

    [JsonPropertyName("maxKi")]
    public string MaxKi { get; set; } = string.Empty;

    [JsonPropertyName("race")]
    public string Race { get; set; } = string.Empty;

    [JsonPropertyName("gender")]
    public string Gender { get; set; } = string.Empty;

    [JsonPropertyName("description")]
    public string Description { get; set; } = string.Empty;

    [JsonPropertyName("image")]
    public string Image { get; set; } = string.Empty;

    [JsonPropertyName("affiliation")]
    public string Affiliation { get; set; } = string.Empty;

    [JsonPropertyName("originPlanet")]
    public Planeta? OriginPlanet { get; set; }

    [JsonPropertyName("transformations")]
    public List<Transformacao> Transformations { get; set; } = [];
}

public class Planeta
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; } = string.Empty;

    [JsonPropertyName("isDestroyed")]
    public bool IsDestroyed { get; set; }

    [JsonPropertyName("description")]
    public string Description { get; set; } = string.Empty;

    [JsonPropertyName("image")]
    public string Image { get; set; } = string.Empty;
}

public class Transformacao
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; } = string.Empty;

    [JsonPropertyName("image")]
    public string Image { get; set; } = string.Empty;

    [JsonPropertyName("ki")]
    public string Ki { get; set; } = string.Empty;
}
