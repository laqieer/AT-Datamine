// Decompiled with JetBrains decompiler
// Type: Scenes.Guild.GuildAssetBundleParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace Scenes.Guild
{
  [Token(Token = "0x2002B7D")]
  public static class GuildAssetBundleParam
  {
    [Token(Token = "0x400B926")]
    [FieldOffset(Offset = "0x0")]
    public static readonly Dictionary<string, int[]> GuildScreenAssetBundleLabelName;
    [Token(Token = "0x400B927")]
    [FieldOffset(Offset = "0x8")]
    public static readonly string[] GuildScreenAssetName;
    [Token(Token = "0x400B928")]
    [FieldOffset(Offset = "0x10")]
    public static readonly Dictionary<string, int[]> TimelineSettingAssetBundleLabelName;
    [Token(Token = "0x400B929")]
    [FieldOffset(Offset = "0x18")]
    public static readonly string[] TimelineSettingAssetName;
    [Token(Token = "0x400B92A")]
    [FieldOffset(Offset = "0x20")]
    public static readonly Dictionary<string, int[]> GuildPopupAssetBundleLabelName;
    [Token(Token = "0x400B92B")]
    [FieldOffset(Offset = "0x28")]
    public static readonly string[] GuildPopupAssetName;

    [Token(Token = "0x6010FF2")]
    [Address(RVA = "0x1C73984", Offset = "0x1C73984", VA = "0x1C73984")]
    public static (string, string) GetAssetBundleParam(GuildAssetBundleParam.GuildScreenType type)
    {
      return ();
    }

    [Token(Token = "0x6010FF3")]
    [Address(RVA = "0x1C73C18", Offset = "0x1C73C18", VA = "0x1C73C18")]
    public static (string, string) GetAssetBundleParam(
      GuildAssetBundleParam.TimelineSettingType type)
    {
      return ();
    }

    [Token(Token = "0x6010FF4")]
    [Address(RVA = "0x1C73EAC", Offset = "0x1C73EAC", VA = "0x1C73EAC")]
    public static (string, string) GetAssetBundleParam(GuildAssetBundleParam.GuildPopupType type)
    {
      return ();
    }

    [Token(Token = "0x6010FF5")]
    [Address(RVA = "0x1C74084", Offset = "0x1C74084", VA = "0x1C74084")]
    static GuildAssetBundleParam()
    {
    }

    [Token(Token = "0x2002B7E")]
    public enum GuildScreenType
    {
      [Token(Token = "0x400B92D")] Top_NotJoined,
      [Token(Token = "0x400B92E")] Top_Joined,
      [Token(Token = "0x400B92F")] Info,
      [Token(Token = "0x400B930")] Facility,
      [Token(Token = "0x400B931")] FacilityDetail,
      [Token(Token = "0x400B932")] FacilityInvest,
      [Token(Token = "0x400B933")] Established,
      [Token(Token = "0x400B934")] Container_Overlay_Production_GuildStoneStatue_LvUp,
      [Token(Token = "0x400B935")] GuildList,
      [Token(Token = "0x400B936")] MemberList,
      [Token(Token = "0x400B937")] Detail,
      [Token(Token = "0x400B938")] GuildChat,
    }

    [Token(Token = "0x2002B7F")]
    public enum TimelineSettingType
    {
      [Token(Token = "0x400B93A")] FromToGlobal,
      [Token(Token = "0x400B93B")] Common,
      [Token(Token = "0x400B93C")] Detail,
    }

    [Token(Token = "0x2002B80")]
    public enum GuildPopupType
    {
      [Token(Token = "0x400B93E")] Menu,
      [Token(Token = "0x400B93F")] Search,
      [Token(Token = "0x400B940")] LevelDetail,
      [Token(Token = "0x400B941")] AttendInfo,
      [Token(Token = "0x400B942")] AttendReward,
    }
  }
}
