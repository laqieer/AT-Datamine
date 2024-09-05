// Decompiled with JetBrains decompiler
// Type: StaqData.GachaListInfo
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Gacha.API;
using Il2CppDummyDll;
using Network.API;
using System;
using System.Collections.Generic;

#nullable disable
namespace StaqData
{
  [Token(Token = "0x2002130")]
  internal class GachaListInfo
  {
    [Token(Token = "0x4008CD5")]
    [FieldOffset(Offset = "0x10")]
    private List<GachaListItemInfo> gachaListItemInfos;
    [Token(Token = "0x4008CD6")]
    [FieldOffset(Offset = "0x18")]
    public List<StoryGachaInfo> storyGachaInfos;
    [Token(Token = "0x4008CD7")]
    [FieldOffset(Offset = "0x20")]
    private Dictionary<string, string> apiSchemaVersions;

    [Token(Token = "0x17002C63")]
    public List<GachaListItemInfo> Items
    {
      [Token(Token = "0x600CB3A"), Address(RVA = "0x1BA88F8", Offset = "0x1BA88F8", VA = "0x1BA88F8")] get
      {
        return (List<GachaListItemInfo>) null;
      }
    }

    [Token(Token = "0x17002C64")]
    public List<StoryGachaInfo> StoryGachaInfos
    {
      [Token(Token = "0x600CB3B"), Address(RVA = "0x1BA8900", Offset = "0x1BA8900", VA = "0x1BA8900")] get
      {
        return (List<StoryGachaInfo>) null;
      }
    }

    [Token(Token = "0x600CB3C")]
    [Address(RVA = "0x1BA8908", Offset = "0x1BA8908", VA = "0x1BA8908")]
    public GachaListItemInfo FirstOrDefaultItem(Func<GachaListItemInfo, bool> predicate)
    {
      return (GachaListItemInfo) null;
    }

    [Token(Token = "0x600CB3D")]
    [Address(RVA = "0x1BA8960", Offset = "0x1BA8960", VA = "0x1BA8960")]
    public GachaListItemInfo FirstOrDefaultItem() => (GachaListItemInfo) null;

    [Token(Token = "0x600CB3E")]
    [Address(RVA = "0x1BA89A8", Offset = "0x1BA89A8", VA = "0x1BA89A8")]
    public GachaListItemInfo FindListItemByGachaName(string gachaName) => (GachaListItemInfo) null;

    [Token(Token = "0x600CB3F")]
    [Address(RVA = "0x1BA8A8C", Offset = "0x1BA8A8C", VA = "0x1BA8A8C")]
    public StoryGachaInfo FindStoryGachaInfoByGroupId(int groupId) => (StoryGachaInfo) null;

    [Token(Token = "0x600CB40")]
    [Address(RVA = "0x1BA8B70", Offset = "0x1BA8B70", VA = "0x1BA8B70")]
    public GachaListItemInfo FindListItemByGachaNumber(int gachaNumber) => (GachaListItemInfo) null;

    [Token(Token = "0x600CB41")]
    [Address(RVA = "0x1BA8C54", Offset = "0x1BA8C54", VA = "0x1BA8C54")]
    public GachaListItemInfo GetByIndex(int index) => (GachaListItemInfo) null;

    [Token(Token = "0x600CB42")]
    [Address(RVA = "0x1BA8CAC", Offset = "0x1BA8CAC", VA = "0x1BA8CAC")]
    private int GetStandardGachaId(string gachaName) => new int();

    [Token(Token = "0x600CB43")]
    [Address(RVA = "0x1BA8CC4", Offset = "0x1BA8CC4", VA = "0x1BA8CC4")]
    private int GetStoryGachaId(int groupId) => new int();

    [Token(Token = "0x600CB44")]
    [Address(RVA = "0x1BA8CDC", Offset = "0x1BA8CDC", VA = "0x1BA8CDC")]
    public int GetGachaId(string gachaName, int groupId, GachaTypeEnum gachaType) => new int();

    [Token(Token = "0x600CB45")]
    [Address(RVA = "0x1BA8D1C", Offset = "0x1BA8D1C", VA = "0x1BA8D1C")]
    public List<GachaBackgroundResource> FindResources(string gachaName)
    {
      return (List<GachaBackgroundResource>) null;
    }

    [Token(Token = "0x600CB46")]
    [Address(RVA = "0x1BA8E0C", Offset = "0x1BA8E0C", VA = "0x1BA8E0C")]
    public static GachaListInfo CreateFromServerData(APIGachaResponse response)
    {
      return (GachaListInfo) null;
    }

    [Token(Token = "0x600CB47")]
    [Address(RVA = "0x1BA9174", Offset = "0x1BA9174", VA = "0x1BA9174")]
    public bool FindReleasedStoryGachas(out List<StoryGachaInfo> storyGachaInfo) => new bool();

    [Token(Token = "0x600CB48")]
    [Address(RVA = "0x1BA92B4", Offset = "0x1BA92B4", VA = "0x1BA92B4")]
    public IGachaModuleInfo FindModuleInfoByNumber(int number) => (IGachaModuleInfo) null;

    [Token(Token = "0x600CB49")]
    [Address(RVA = "0x1BA916C", Offset = "0x1BA916C", VA = "0x1BA916C")]
    public GachaListInfo()
    {
    }
  }
}
