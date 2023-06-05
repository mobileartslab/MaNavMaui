using System;
using MaNavMaui.Models;
using Newtonsoft.Json;

namespace MaNavMaui.Models
{
  public class LoginResult
  {
    public LoginResult()
    {
    }

    public string error { get; set; }
    [JsonProperty("result")]
    public LoginUser user { get; set; }
  }
}

