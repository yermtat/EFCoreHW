using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace homework02_imdbAPI.DataModels;

public class Rootobject
{
    [JsonPropertyName("meta")]
    public Meta Meta { get; set; }

    [JsonPropertyName("type")]
    public string Type { get; set; }

    [JsonPropertyName("query")]
    public string Query { get; set; }

    [JsonPropertyName("results")]
    public Result[] Results { get; set; }

    [JsonPropertyName("types")]
    public string[] Types { get; set; }
}

public class Meta
{
    [JsonPropertyName("operation")]
    public string Operation { get; set; }

    [JsonPropertyName("requestId")]
    public string RequestId { get; set; }

    [JsonPropertyName("serviceTimeMs")]
    public float ServiceTimeMs { get; set; }
}

public class Result
{
    [JsonPropertyName("id")]
    [Key]
    public string Id { get; set; }

    [ForeignKey("Image")]
    public string ImageId { get; set; }
    [JsonPropertyName("image")]
    public Image Image { get; set; }

    [JsonPropertyName("runningTimeInMinutes")]
    public int RunningTimeInMinutes { get; set; }

    [JsonPropertyName("nextEpisode")]
    public string NextEpisode { get; set; }

    [JsonPropertyName("numberOfEpisodes")]
    public int NumberOfEpisodes { get; set; }

    [JsonPropertyName("seriesEndYear")]
    public int SeriesEndYear { get; set; }

    [JsonPropertyName("seriesStartYear")]
    public int SeriesStartYear { get; set; }

    [JsonPropertyName("title")]
    public string Title { get; set; }

    [JsonPropertyName("titleType")]
    public string TitleType { get; set; }

    [JsonPropertyName("year")]
    public int Year { get; set; }

    [JsonPropertyName("principals")]
    //public Principal[] Principals { get; set; }
    public ICollection<Principal> Principals { get; set; }

    [JsonPropertyName("episode")]
    public int Episode { get; set; }

    [JsonPropertyName("season")]
    public int Season { get; set; }

    [JsonPropertyName("parentTitle")]
    public Parenttitle ParentTitle { get; set; }

    [JsonPropertyName("previousEpisode")]
    public string PreviousEpisode { get; set; }

    public override string ToString()
    {
        return $"{Title} — {Year} — {TitleType}";
    }
}

public class Image
{

    [JsonPropertyName("height")]
    public int Height { get; set; }

    [JsonPropertyName("id")]
    [Key]
    public string Id { get; set; }

    [JsonPropertyName("url")]
    public string Url { get; set; }

    [JsonPropertyName("width")]
    public int Width { get; set; }
    public ICollection<Result> Results { get; set; }
}

public class Parenttitle
{

    [JsonPropertyName("id")]
    public string Id { get; set; }

    [JsonPropertyName("image")]
    public Image1 Image { get; set; }

    [JsonPropertyName("title")]
    public string Title { get; set; }

    [JsonPropertyName("titleType")]
    public string TitleType { get; set; }

    [JsonPropertyName("year")]
    public int Year { get; set; }
}

public class Image1
{
    [JsonPropertyName("height")]
    public int Height { get; set; }

    [JsonPropertyName("id")]
    public string Id { get; set; }

    [JsonPropertyName("url")]
    public string Url { get; set; }

    [JsonPropertyName("width")]
    public int Width { get; set; }
}

public class Principal
{
    [Key]
    [JsonPropertyName("id")]
    public string Id { get; set; }

    [JsonPropertyName("legacyNameText")]
    public string LegacyNameText { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("category")]
    public string Category { get; set; }

    [JsonPropertyName("characters")]
    public string[] Characters { get; set; }

    [JsonPropertyName("endYear")]
    public int EndYear { get; set; }

    [JsonPropertyName("episodeCount")]
    public int EpisodeCount { get; set; }

    [JsonPropertyName("roles")]
    //public Role[] Roles { get; set; }
    public ICollection<Role> Roles { get; set; }

    [JsonPropertyName("startYear")]
    public int StartYear { get; set; }

    [JsonPropertyName("attr")]
    public string[] Attr { get; set; }

    [JsonPropertyName("billing")]
    public int Billing { get; set; }

    [JsonPropertyName("disambiguation")]
    public string Disambiguation { get; set; }

    [JsonPropertyName("_as")]
    public string As { get; set; }

    public override string ToString()
    {
        return $"{Name} as {Characters[0]}";
    }

    [ForeignKey("Result")]
    public string ResultId { get; set; }
    public Result Result { get; set; }
}

public class Role
{
    [Key]
    public int RoleId { get; set; }

    [JsonPropertyName("character")]
    public string Character { get; set; }

    [JsonPropertyName("characterId")]
    public string CharacterId { get; set; }

    [ForeignKey("Principal")]
    public string PrincipalId { get; set; }
    public Principal Principal { get; set; }
}

