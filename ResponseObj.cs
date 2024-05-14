using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace APIVerve
{
public class weight
{
    [JsonProperty("lowerLbs")]
    public int lowerLbs { get; set; }

    [JsonProperty("upperLbs")]
    public int upperLbs { get; set; }

}

public class height
{
    [JsonProperty("lowerInches")]
    public int lowerInches { get; set; }

    [JsonProperty("upperInches")]
    public int upperInches { get; set; }

}

public class lifespan
{
    [JsonProperty("lowerYears")]
    public int lowerYears { get; set; }

    [JsonProperty("upperYears")]
    public int upperYears { get; set; }

}

public class foundBreeds
{
    [JsonProperty("name")]
    public string name { get; set; }

    [JsonProperty("weight")]
    public weight weight { get; set; }

    [JsonProperty("height")]
    public height height { get; set; }

    [JsonProperty("bredFor")]
    public string bredFor { get; set; }

    [JsonProperty("group")]
    public string group { get; set; }

    [JsonProperty("life_span")]
    public lifespan lifespan { get; set; }

    [JsonProperty("traits")]
    public string[] traits { get; set; }

}

public class data
{
    [JsonProperty("breed")]
    public string breed { get; set; }

    [JsonProperty("foundCount")]
    public int foundCount { get; set; }

    [JsonProperty("foundBreeds")]
    public foundBreeds[] foundBreeds { get; set; }

}

public class ResponseObj
{
    [JsonProperty("status")]
    public string status { get; set; }

    [JsonProperty("error")]
    public object error { get; set; }

    [JsonProperty("data")]
    public data data { get; set; }

}

}
