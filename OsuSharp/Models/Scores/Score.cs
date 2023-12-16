﻿using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using OsuSharp.Enums;
using OsuSharp.Models.Beatmaps;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OsuSharp.Models.Scores;

/// <summary>
/// Represents a score, as returned by the osu! API v2.
/// 
/// https://osu.ppy.sh/docs/index.html#score
/// </summary>
public class Score
{
  /// <summary>
  /// The accuracy of this score.
  /// </summary>
  [JsonProperty("accuracy")]
  public float Accuracy { get; internal set; }

  /// <summary>
  /// The ID of the best score the player of this score achieved on the beatmap.
  /// </summary>
  [JsonProperty("best_id")]
  public int BestId { get; internal set; }

  /// <summary>
  /// The datetime at which this score was submitted to the osu! servers.
  /// </summary>
  [JsonProperty("created_at")]
  public DateTimeOffset CreatedAt { get; private set; }

  /// <summary>
  /// The ID of this score.
  /// </summary>
  [JsonProperty("id")]
  public int Id { get; internal set; }

  /// <summary>
  /// The maximum combo achieved in this score.
  /// </summary>
  [JsonProperty("max_combo")]
  public int MaxCombo { get; internal set; }

  /// <summary>
  /// The ruleset this score was achieved in.
  /// </summary>
  [JsonProperty("mode")]
  [JsonConverter(typeof(StringEnumConverter))]
  public Ruleset Ruleset { get; internal set; }

  /// <summary>
  /// The mods used for this score.
  /// </summary>
  [JsonProperty("mods")]
  public string[] Mods { get; internal set; } = default!;

  /// <summary>
  /// Bool whether this score passed the map.
  /// </summary>
  [JsonProperty("passed")]
  public bool IsPass { get; internal set; }

  /// <summary>
  /// Bool whether this score has a perfect combo.
  /// </summary>
  [JsonProperty("perfect")]
  public bool IsPerfect { get; internal set; }

  /// <summary>
  /// The amount of performance points the score is worth. This will be null if the score is not ranked.
  /// </summary>
  [JsonProperty("pp")]
  public float TotalPP { get; internal set; }

  /// <summary>
  /// The rank of this score. (XH, X, SH, S, A, B, C, D)
  /// </summary>
  [JsonProperty("rank")]
  [JsonConverter(typeof(StringEnumConverter))]
  public Rank Rank { get; internal set; }

  /// <summary>
  /// Bool whether the replay of this score is available on the osu! servers.
  /// </summary>
  [JsonProperty("replay")]
  public bool IsReplayAvailable { get; internal set; }

  /// <summary>
  /// The total score points for this score.
  /// </summary>
  [JsonProperty("score")]
  public int TotalScore { get; internal set; }

  /// <summary>
  /// Bool whether this score is the player's best score on the beatmap.
  /// </summary>
  public bool IsBest { get; internal set; }

  /// <summary>
  /// The statistics (hit judgments) of this score.
  /// </summary>
  [JsonProperty("statistics")]
  public ScoreStatistics Statistics { get; internal set; } = default!;

  /// <summary>
  /// The ID of the player of this score.
  /// </summary>
  [JsonProperty("user_id")]
  public int UserId { get; internal set; }

  /// <summary>
  /// The beatmap this score was achieved on. This may be null.
  /// </summary>
  [JsonProperty("beatmap")]
  public BeatmapExtended? Beatmap { get; internal set; }

  /// <summary>
  /// The beatmapset the beatmap this score was achieved on belongs to. This may be null.
  /// </summary>
  [JsonProperty("beatmapset")]
  public BeatmapSet? BeatmapSet { get; internal set; }

  /// <summary>
  /// The placement of the score on the beatmap's leaderboard in the player's country. This may be null.
  /// </summary>
  [JsonProperty("rank_country")]
  public int RankCountry { get; internal set; }

  /// <summary>
  /// The placement of the score on the beatmap's leaderboard. This may be null.
  /// </summary>
  [JsonProperty("rank_global")]
  public int RankGlobal { get; internal set; }
}
