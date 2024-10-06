// Decompiled with JetBrains decompiler
// Type: StaqData.GachaDetailGroupInfo
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Gacha;
using Gacha.API;
using Il2CppDummyDll;
using Network.Param;
using System;
using System.Collections.Generic;

#nullable disable
namespace StaqData
{
  [Token(Token = "0x200211B")]
  public class GachaDetailGroupInfo
  {
    [Token(Token = "0x4008C82")]
    [FieldOffset(Offset = "0x10")]
    public GachaInfo gachaInfo;
    [Token(Token = "0x4008C83")]
    [FieldOffset(Offset = "0x18")]
    public List<GachaDetailInfo> details;
    [Token(Token = "0x4008C84")]
    [FieldOffset(Offset = "0x20")]
    public List<GachaGroupInfo> groups;
    [Token(Token = "0x4008C85")]
    [FieldOffset(Offset = "0x28")]
    public List<GachaPickupInfo> pickups;
    [Token(Token = "0x4008C86")]
    [FieldOffset(Offset = "0x30")]
    public List<GachaStepUpInfo> stepups;
    [Token(Token = "0x4008C87")]
    [FieldOffset(Offset = "0x38")]
    public List<SelectGachaTargetInfo> selectGachaTargets;
    [Token(Token = "0x4008C89")]
    [FieldOffset(Offset = "0x48")]
    private SortedDictionary<int, GachaGroupInfo> Groups;
    [Token(Token = "0x4008C8A")]
    [FieldOffset(Offset = "0x50")]
    private SortedDictionary<int, List<GachaPickupInfo>> Pickups;
    [Token(Token = "0x4008C8B")]
    [FieldOffset(Offset = "0x58")]
    private SortedDictionary<int, List<GachaStepUpInfo>> Stepups;
    [Token(Token = "0x4008C8C")]
    [FieldOffset(Offset = "0x60")]
    private IGachaInfoMaster gachaInfoMaster;

    [Token(Token = "0x17002C18")]
    public int GachaId
    {
      [Token(Token = "0x600CA6C"), Address(RVA = "0x1BA3EAC", Offset = "0x1BA3EAC", VA = "0x1BA3EAC")] get
      {
        return new int();
      }
      [Token(Token = "0x600CA6D"), Address(RVA = "0x1BA3EB4", Offset = "0x1BA3EB4", VA = "0x1BA3EB4")] private set
      {
      }
    }

    [Token(Token = "0x17002C19")]
    public GachaTypeEnum GachaType
    {
      [Token(Token = "0x600CA6E"), Address(RVA = "0x1BA3EBC", Offset = "0x1BA3EBC", VA = "0x1BA3EBC")] get
      {
        return new GachaTypeEnum();
      }
    }

    [Token(Token = "0x600CA6F")]
    [Address(RVA = "0x1BA3F78", Offset = "0x1BA3F78", VA = "0x1BA3F78")]
    public List<GachaDetailInfo> GetDetails(string gachaName, int groupId)
    {
      return (List<GachaDetailInfo>) null;
    }

    [Token(Token = "0x600CA70")]
    [Address(RVA = "0x1BA407C", Offset = "0x1BA407C", VA = "0x1BA407C")]
    public List<GachaBackgroundResource> GetBackgroundResources()
    {
      return (List<GachaBackgroundResource>) null;
    }

    [Token(Token = "0x600CA71")]
    [Address(RVA = "0x1BA41D0", Offset = "0x1BA41D0", VA = "0x1BA41D0")]
    private static SortedDictionary<int, List<GachaPickupInfo>> ToPickupDictionary(
      IEnumerable<GachaPickupInfo> pickupInfos)
    {
      return (SortedDictionary<int, List<GachaPickupInfo>>) null;
    }

    [Token(Token = "0x600CA72")]
    [Address(RVA = "0x1BA4640", Offset = "0x1BA4640", VA = "0x1BA4640")]
    private static SortedDictionary<int, List<GachaStepUpInfo>> ToStepupDictionary(
      IEnumerable<GachaStepUpInfo> stepUpInfos)
    {
      return (SortedDictionary<int, List<GachaStepUpInfo>>) null;
    }

    [Token(Token = "0x600CA73")]
    [Address(RVA = "0x1BA4AB0", Offset = "0x1BA4AB0", VA = "0x1BA4AB0")]
    public static GachaDetailGroupInfo CreateFromServerData(
      IGachaModuleInfo moduleInfo,
      G0000GachaDetailType serverData)
    {
      return (GachaDetailGroupInfo) null;
    }

    [Token(Token = "0x600CA74")]
    [Address(RVA = "0x1BA51E0", Offset = "0x1BA51E0", VA = "0x1BA51E0")]
    public static GachaDetailGroupInfo CreateFromServerData(
      IGachaModuleInfo moduleInfo,
      G0001GachaDetailType serverData)
    {
      return (GachaDetailGroupInfo) null;
    }

    [Token(Token = "0x600CA75")]
    [Address(RVA = "0x1BA56EC", Offset = "0x1BA56EC", VA = "0x1BA56EC")]
    public (DateTime, DateTime) GetSchedule() => ();

    [Token(Token = "0x600CA76")]
    [Address(RVA = "0x1BA5944", Offset = "0x1BA5944", VA = "0x1BA5944")]
    public void OnInitialize(IGachaInfoMaster gachaInfoMaster)
    {
    }

    [Token(Token = "0x600CA77")]
    [Address(RVA = "0x1BA5B08", Offset = "0x1BA5B08", VA = "0x1BA5B08")]
    public GachaGroupInfo GetGroupInfo(int groupId) => (GachaGroupInfo) null;

    [Token(Token = "0x600CA78")]
    [Address(RVA = "0x1BA5B78", Offset = "0x1BA5B78", VA = "0x1BA5B78")]
    public List<GachaPickupInfo> GetPickupInfo(int groupId) => (List<GachaPickupInfo>) null;

    [Token(Token = "0x600CA79")]
    [Address(RVA = "0x1BA5BE8", Offset = "0x1BA5BE8", VA = "0x1BA5BE8")]
    public GachaStepUpInfo GetSetpupInfo(int groupId) => (GachaStepUpInfo) null;

    [Token(Token = "0x600CA7A")]
    [Address(RVA = "0x1BA5C78", Offset = "0x1BA5C78", VA = "0x1BA5C78")]
    public bool HasTicketGacha(int groupId) => new bool();

    [Token(Token = "0x600CA7B")]
    [Address(RVA = "0x1BA5DC8", Offset = "0x1BA5DC8", VA = "0x1BA5DC8")]
    public bool HasFreeCoinGacha(int groupId) => new bool();

    [Token(Token = "0x600CA7C")]
    [Address(RVA = "0x1BA5F18", Offset = "0x1BA5F18", VA = "0x1BA5F18")]
    public bool HasPaidCoinGacha(int groupId) => new bool();

    [Token(Token = "0x600CA7D")]
    [Address(RVA = "0x1BA6068", Offset = "0x1BA6068", VA = "0x1BA6068")]
    public bool HasFreeGacha(int groupId) => new bool();

    [Token(Token = "0x600CA7E")]
    [Address(RVA = "0x1BA6238", Offset = "0x1BA6238", VA = "0x1BA6238")]
    public bool HasAdvertisementGacha(int groupId) => new bool();

    [Token(Token = "0x600CA7F")]
    [Address(RVA = "0x1BA61D0", Offset = "0x1BA61D0", VA = "0x1BA61D0")]
    public bool IsAdvertisementOnly(int groupId) => new bool();

    [Token(Token = "0x600CA80")]
    [Address(RVA = "0x1BA5CD4", Offset = "0x1BA5CD4", VA = "0x1BA5CD4")]
    public List<GachaDetailInfo> GetTicketGachas(int groupId) => (List<GachaDetailInfo>) null;

    [Token(Token = "0x600CA81")]
    [Address(RVA = "0x1BA5E24", Offset = "0x1BA5E24", VA = "0x1BA5E24")]
    public List<GachaDetailInfo> GetFreeCoinGachas(int groupId) => (List<GachaDetailInfo>) null;

    [Token(Token = "0x600CA82")]
    [Address(RVA = "0x1BA5F74", Offset = "0x1BA5F74", VA = "0x1BA5F74")]
    public List<GachaDetailInfo> GetPaidCoinGachas(int groupId) => (List<GachaDetailInfo>) null;

    [Token(Token = "0x600CA83")]
    [Address(RVA = "0x1BA60DC", Offset = "0x1BA60DC", VA = "0x1BA60DC")]
    public List<GachaDetailInfo> GetFreeGachas(int groupId) => (List<GachaDetailInfo>) null;

    [Token(Token = "0x600CA84")]
    [Address(RVA = "0x1BA6294", Offset = "0x1BA6294", VA = "0x1BA6294")]
    public List<GachaDetailInfo> GetAdvertisementGachas(int groupId)
    {
      return (List<GachaDetailInfo>) null;
    }

    [Token(Token = "0x600CA85")]
    [Address(RVA = "0x1BA4D30", Offset = "0x1BA4D30", VA = "0x1BA4D30")]
    public GachaDetailGroupInfo()
    {
    }
  }
}
