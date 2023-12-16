﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OsuSharp.Enums;

/// <summary>
/// An enum containing the existing, official rulesets.
/// <br/><br/>
/// API docs: <a href="https://osu.ppy.sh/docs/index.html#ruleset"/><br/>
/// Source: <a href="https://github.com/ppy/osu-web/blob/master/app/Enums/Ruleset.php"/>
/// </summary>
public enum Ruleset
{
  /// <summary>
  /// The standard ruleset.
  /// </summary>
  Osu,

  /// <summary>
  /// The taiko ruleset.
  /// </summary>
  Taiko,

  /// <summary>
  /// The catch the beat ruleset.
  /// </summary>
  Fruits,

  /// <summary>
  /// The mania ruleset.
  /// </summary>
  /// 
  Mania
}
