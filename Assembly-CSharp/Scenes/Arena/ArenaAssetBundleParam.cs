// Decompiled with JetBrains decompiler
// Type: Scenes.Arena.ArenaAssetBundleParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace Scenes.Arena
{
  [Token(Token = "0x2003106")]
  public static class ArenaAssetBundleParam
  {
    [Token(Token = "0x400D0B5")]
    [FieldOffset(Offset = "0x0")]
    public static readonly Dictionary<string, Dictionary<ArenaAssetBundleParam.ArenaScreenType, string>> dicScreenBundle;
    [Token(Token = "0x400D0B6")]
    [FieldOffset(Offset = "0x8")]
    public static readonly Dictionary<string, Dictionary<ArenaAssetBundleParam.TimelineSettingType, string>> dicTimelineBundle;
    [Token(Token = "0x400D0B7")]
    [FieldOffset(Offset = "0x10")]
    public static readonly Dictionary<string, Dictionary<ArenaAssetBundleParam.ArenaPopupType, string>> dicPopupBundle;

    [Token(Token = "0x6013273")]
    [Address(RVA = "0x45DEE20", Offset = "0x45DEE20", VA = "0x45DEE20")]
    public static (string, string) GetAssetBundleParam(ArenaAssetBundleParam.ArenaScreenType type)
    {
      return ();
    }

    [Token(Token = "0x6013274")]
    [Address(RVA = "0x45DF188", Offset = "0x45DF188", VA = "0x45DF188")]
    public static (string, string) GetAssetBundleParam(
      ArenaAssetBundleParam.TimelineSettingType type)
    {
      return ();
    }

    [Token(Token = "0x6013275")]
    [Address(RVA = "0x45DF4F0", Offset = "0x45DF4F0", VA = "0x45DF4F0")]
    public static (string, string) GetAssetBundleParam(ArenaAssetBundleParam.ArenaPopupType type)
    {
      return ();
    }

    [Token(Token = "0x6013276")]
    [Address(RVA = "0x45DF784", Offset = "0x45DF784", VA = "0x45DF784")]
    static ArenaAssetBundleParam()
    {
    }

    [Token(Token = "0x2003107")]
    public enum ArenaScreenType
    {
      [Token(Token = "0x400D0B9")] ArenaTop,
      [Token(Token = "0x400D0BA")] ArenaSotie,
    }

    [Token(Token = "0x2003108")]
    public enum TimelineSettingType
    {
      [Token(Token = "0x400D0BC")] ArenaTop,
      [Token(Token = "0x400D0BD")] ArenaTopSortie,
    }

    [Token(Token = "0x2003109")]
    public enum ArenaPopupType
    {
      [Token(Token = "0x400D0BF")] RewardConfirm,
      [Token(Token = "0x400D0C0")] DefenseResult,
      [Token(Token = "0x400D0C1")] Settings,
      [Token(Token = "0x400D0C2")] BattleHistory,
      [Token(Token = "0x400D0C3")] BattleHistoryDetail,
      [Token(Token = "0x400D0C4")] Recovery,
      [Token(Token = "0x400D0C5")] PeriodReward,
      [Token(Token = "0x400D0C6")] TutorialSummary,
    }
  }
}
