﻿using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using OsuSharp.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OsuSharp.Models.Beatmaps;

/// <summary>
/// Represents a beatmapset.
/// <br/><br/>
/// API docs: <a href="https://osu.ppy.sh/docs/index.html#beatmapset"/><br/>
/// Source: <a href="https://github.com/ppy/osu-web/blob/master/resources/js/interfaces/beatmapset-json.ts"/>
/// </summary>
public class BeatmapSet
{
  #region Default Attributes

  /// <summary>
  /// The artist of the song this beatmapset is made for.
  /// </summary>
  [JsonProperty("artist")]
  public string Artist { get; private set; } = default!;

  /// <summary>
  /// The unicode representation of the artist of the song this beatmapset is made for.
  /// </summary>
  [JsonProperty("artist_unicode")]
  public string ArtistUnicode { get; private set; } = default!;

  /// <summary>
  /// The URLs for the cover texture assets of this beatmapset.
  /// </summary>
  public BeatmapSetCovers Covers { get; private set; } = default!;

  /// <summary>
  /// The name of the creator of this beatmapset.
  /// </summary>
  [JsonProperty("creator")]
  public string Creator { get; private set; } = default!;

  /// <summary>
  /// The amount of favourites this beatmapset has.
  /// </summary>
  [JsonProperty("favorite_count")]
  public int FavouriteCount { get; private set; }

  /// <summary>
  /// Info about the hype progress of this beatmapset.
  /// </summary>
  [JsonProperty("hype")]
  public BeatmapSetHypes Hypes { get; private set; } = default!;

  /// <summary>
  /// The ID of this beatmapset.
  /// </summary>
  [JsonProperty("id")]
  public int Id { get; private set; }

  /// <summary>
  /// Bool whether the beatmapset contains explicit content.
  /// </summary>
  public bool IsNsfw { get; private set; }

  /// <summary>
  /// The global milliseconds offset for all the beatmaps in this beatmapset.
  /// </summary>
  [JsonProperty("offset")]
  public int Offset { get; private set; }

  /// <summary>
  /// The amount of plays this beatmapset has.
  /// </summary>
  [JsonProperty("play_count")]
  public int PlayCount { get; private set; }

  /// <summary>
  /// The URL for the audio preview of this beatmapset.
  /// </summary>
  [JsonProperty("preview_url")]
  public string PreviewUrl { get; private set; } = default!;

  /// <summary>
  /// The source of the song this beatmapset is made for.
  /// </summary>
  [JsonProperty("source")]
  public string Source { get; private set; } = default!;

  /// <summary>
  /// Bool whether this beatmapset is spotlighted.
  /// </summary>
  [JsonProperty("spotlight")]
  public bool IsSpotlighted { get; private set; }

  /// <summary>
  /// The ranked status of this beatmapset.
  /// </summary>
  [JsonProperty("status")]
  [JsonConverter(typeof(StringEnumConverter))]
  public RankedStatus Status { get; private set; }

  /// <summary>
  /// The title of the song this beatmapset is made for.
  /// </summary>
  [JsonProperty("title")]
  public string Title { get; private set; } = default!;

  /// <summary>
  /// The unicode representation of the title of the song this beatmapset is made for.
  /// </summary>
  [JsonProperty("title_unicode")]
  public string TitleUnicode { get; private set; } = default!;

  /// <summary>
  /// TODO: what is this?
  /// </summary>
  [JsonProperty("track_id")]
  public int? TrackId { get; private set; }

  /// <summary>
  /// The user ID of the creator of this beatmapset.
  /// </summary>
  [JsonProperty("user_id")]
  public int UserId { get; private set; }

  /// <summary>
  /// Bool whether this beatmapset contains a background video.
  /// </summary>
  [JsonProperty("video")]
  public bool HasVideo { get; private set; }

  #endregion

  #region Available Attributes

  /// <summary>
  /// Info about the availability of this beatmapset. This is an optional property and may be null.
  /// </summary>
  [JsonProperty("availability")]
  public BeatmapSetAvailability? Availability { get; private set; }

  /// <summary>
  /// The beatmaps belonging to this beatmapset. This is an optional property and may be null.
  /// </summary>
  [JsonProperty("beatmaps")]
  public Beatmap[]? Beatmaps { get; private set; }

  /// <summary>
  /// The mode-converted version of the beatmaps belonging to this beatmapset. This is an optional property and may be null.
  /// </summary>
  [JsonProperty("converts")]
  public BeatmapExtended[]? Converts { get; private set; }

  /// <summary>
  /// The nominations on this beatmapset. This is an optional property and may be null.
  /// </summary>
  [JsonProperty("current_nominations")]
  public BeatmapSetNomination[]? Nominations { get; private set; }

  /// <summary>
  /// The description of this beatmapset. This is an optional property and may be null.
  /// </summary>
  [JsonProperty("description")]
  public BeatmapSetDescription? Description { get; private set; }

  #endregion
}
