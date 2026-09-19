using System.Text.Json.Serialization;
public class FeatureCollection
{
    // TODO Problem 5 - ADD YOUR CODE HERE
    // Create additional classes as necessary
    [JsonPropertyName("features")]
   
public List<Feature> Features { get; set; }

}
public class Feature
{
     [JsonPropertyName("properties")]
    public EarthquakeProperties Properties { get; set; }
}


public class EarthquakeProperties
{
    [JsonPropertyName("mag")]
    public double? Mag { get; set; }

    [JsonPropertyName("place")]
    public string Place { get; set; }
}