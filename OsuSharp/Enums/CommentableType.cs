﻿using System.ComponentModel;

namespace OsuSharp.Enums;

/// <summary>
/// An enum containing the type of commentable objects.
/// <br/><br/>
/// API docs: Not documented, refer to source</br>
/// Source: <a href="https://github.com/ppy/osu-web/blob/master/resources/js/notification-maps/url.ts"/>
/// </summary>
public enum CommentableType
{
  /// <summary>
  /// Indicates that the comment is attached to a beatmapset.
  /// </summary>
  [Description("beatmapset")]
  BeatmapSet,

  /// <summary>
  /// Indicates that the comment is attached to a news post.
  /// </summary>
  [Description("news_post")]
  NewsPost,

  /// <summary>
  /// Indicates that the comment is attached to a build from the changelog.
  /// </summary>
  [Description("build")]
  Build
}
