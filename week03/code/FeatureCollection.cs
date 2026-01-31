using System.Text.Json.Serialization;

public class FeatureCollection
{
    // TODO Problem 5 - ADD YOUR CODE HERE
    // Create additional classes as necessary
    [JsonPropertyName("features")]
    public Feature[]? Features { get; set; }
}

public class Feature
{
    [JsonPropertyName("properties")]
    public FeatureProperties? Properties { get; set; }
}

public class FeatureProperties
{
    [JsonPropertyName("mag")]
    public double? Mag { get; set; }

    [JsonPropertyName("place")]
    public string? Place { get; set; }
}