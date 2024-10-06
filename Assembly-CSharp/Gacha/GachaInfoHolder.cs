// Decompiled with JetBrains decompiler
// Type: Gacha.GachaInfoHolder
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Gacha.API;
using Il2CppDummyDll;
using StaqData;
using System;
using System.Collections.Generic;

#nullable disable
namespace Gacha
{
  [Token(Token = "0x20014FC")]
  internal class GachaInfoHolder : IGachaInfoMaster
  {
    [Token(Token = "0x4006068")]
    [FieldOffset(Offset = "0x18")]
    private Dictionary<string, GachaDetailGroupInfo> gachaDetailGroupInfo;
    [Token(Token = "0x4006069")]
    [FieldOffset(Offset = "0x20")]
    private GachaResultInfo gachaResultInfo;

    [Token(Token = "0x17001259")]
    public GachaListInfo GachaListInfo
    {
      [Token(Token = "0x60076A9"), Address(RVA = "0x44EB4E4", Offset = "0x44EB4E4", VA = "0x44EB4E4")] get
      {
        return (GachaListInfo) null;
      }
      [Token(Token = "0x60076AA"), Address(RVA = "0x44EB4EC", Offset = "0x44EB4EC", VA = "0x44EB4EC")] private set
      {
      }
    }

    [Token(Token = "0x1700125A")]
    public GachaResultInfo GachaResultInfo
    {
      [Token(Token = "0x60076AB"), Address(RVA = "0x44EB4F4", Offset = "0x44EB4F4", VA = "0x44EB4F4")] get
      {
        return (GachaResultInfo) null;
      }
    }

    [Token(Token = "0x60076AC")]
    [Address(RVA = "0x44EB4FC", Offset = "0x44EB4FC", VA = "0x44EB4FC")]
    public GachaListItemInfo GetGachaListItemInfo(int index) => (GachaListItemInfo) null;

    [Token(Token = "0x60076AD")]
    [Address(RVA = "0x44EB518", Offset = "0x44EB518", VA = "0x44EB518")]
    public IGachaModuleInfo FindModuleInfoByGachaName(string gachaName) => (IGachaModuleInfo) null;

    [Token(Token = "0x60076AE")]
    [Address(RVA = "0x44EB534", Offset = "0x44EB534", VA = "0x44EB534")]
    public IGachaModuleInfo FindModuleInfoByNumber(int number) => (IGachaModuleInfo) null;

    [Token(Token = "0x60076AF")]
    [Address(RVA = "0x44EB588", Offset = "0x44EB588", VA = "0x44EB588")]
    public IGachaModuleInfo FindModuleInfoByIndex(int index) => (IGachaModuleInfo) null;

    [Token(Token = "0x60076B0")]
    [Address(RVA = "0x44EB5A4", Offset = "0x44EB5A4", VA = "0x44EB5A4")]
    public IGachaModuleInfo FirstOrDefaultModuleInfo(Func<GachaListItemInfo, bool> predicate)
    {
      return (IGachaModuleInfo) null;
    }

    [Token(Token = "0x60076B1")]
    [Address(RVA = "0x44EB5C0", Offset = "0x44EB5C0", VA = "0x44EB5C0")]
    public IGachaModuleInfo FirstOrDefaultModuleInfo() => (IGachaModuleInfo) null;

    [Token(Token = "0x60076B2")]
    [Address(RVA = "0x44EB5DC", Offset = "0x44EB5DC", VA = "0x44EB5DC", Slot = "4")]
    public List<GachaBackgroundResource> FindBackgroundResources(string gachaName)
    {
      return (List<GachaBackgroundResource>) null;
    }

    [Token(Token = "0x60076B3")]
    [Address(RVA = "0x44EB5F8", Offset = "0x44EB5F8", VA = "0x44EB5F8")]
    public string GetGachaNameByListItemIndex(int listItemIndex) => (string) null;

    [Token(Token = "0x60076B4")]
    [Address(RVA = "0x44EB560", Offset = "0x44EB560", VA = "0x44EB560")]
    public string GetGachaNameByGachaNumber(int gachaNumber) => (string) null;

    [Token(Token = "0x60076B5")]
    [Address(RVA = "0x44EB620", Offset = "0x44EB620", VA = "0x44EB620")]
    public GachaDetailGroupInfo GetGachaDetailGroupInfo(string gachaName)
    {
      return (GachaDetailGroupInfo) null;
    }

    [Token(Token = "0x60076B6")]
    [Address(RVA = "0x44EB690", Offset = "0x44EB690", VA = "0x44EB690")]
    public GachaInfo GetGachaInfo(string gachaName) => (GachaInfo) null;

    [Token(Token = "0x60076B7")]
    [Address(RVA = "0x44EB714", Offset = "0x44EB714", VA = "0x44EB714")]
    public List<GachaDetailInfo> GetGachaDetails(string gachaName) => (List<GachaDetailInfo>) null;

    [Token(Token = "0x60076B8")]
    [Address(RVA = "0x44EB798", Offset = "0x44EB798", VA = "0x44EB798")]
    public bool HasGachaDetails(string gachaName) => new bool();

    [Token(Token = "0x60076B9")]
    [Address(RVA = "0x44EB7F0", Offset = "0x44EB7F0", VA = "0x44EB7F0")]
    public GachaDetailInfo GetGachaDetailInfoById(string gachaName, int gachaDetailId)
    {
      return (GachaDetailInfo) null;
    }

    [Token(Token = "0x60076BA")]
    [Address(RVA = "0x44EB8E8", Offset = "0x44EB8E8", VA = "0x44EB8E8")]
    public GachaDetailInfo GetNextStepGacha(string gachaName, int groupId, int currentStepCount)
    {
      return (GachaDetailInfo) null;
    }

    [Token(Token = "0x60076BB")]
    [Address(RVA = "0x44EBA18", Offset = "0x44EBA18", VA = "0x44EBA18")]
    public List<GachaPickupInfo> GetPickupInfos(string gachaName) => (List<GachaPickupInfo>) null;

    [Token(Token = "0x60076BC")]
    [Address(RVA = "0x44EBA9C", Offset = "0x44EBA9C", VA = "0x44EBA9C")]
    public List<GachaStepUpInfo> GetStepupInfos(string gachaName) => (List<GachaStepUpInfo>) null;

    [Token(Token = "0x60076BD")]
    [Address(RVA = "0x44EBB20", Offset = "0x44EBB20", VA = "0x44EBB20")]
    public void ApplyGachaListInfo(GachaListInfo gachaListInfo)
    {
    }

    [Token(Token = "0x60076BE")]
    [Address(RVA = "0x44EBB28", Offset = "0x44EBB28", VA = "0x44EBB28")]
    public void ApplyGachaType(GachaDetailGroupInfo gachaDetailGroup)
    {
    }

    [Token(Token = "0x60076BF")]
    [Address(RVA = "0x44EBBAC", Offset = "0x44EBBAC", VA = "0x44EBBAC")]
    public void ApplyGachaPay(GachaResultInfo gachaResultInfo)
    {
    }

    [Token(Token = "0x60076C0")]
    [Address(RVA = "0x44EBBB4", Offset = "0x44EBBB4", VA = "0x44EBBB4", Slot = "5")]
    public int GetGachaId(string gachaName, int groupId, GachaTypeEnum gachaType) => new int();

    [Token(Token = "0x60076C1")]
    [Address(RVA = "0x44EBBD0", Offset = "0x44EBBD0", VA = "0x44EBBD0", Slot = "6")]
    public GachaListItemInfo GetGachaListItemInfo(string gachaName) => (GachaListItemInfo) null;

    [Token(Token = "0x60076C2")]
    [Address(RVA = "0x44EBBEC", Offset = "0x44EBBEC", VA = "0x44EBBEC", Slot = "7")]
    public SelectGachaTargetInfo GetSelectGachaTargetInfo(string gachaName, int selectGachaTargetId)
    {
      return (SelectGachaTargetInfo) null;
    }

    [Token(Token = "0x60076C3")]
    [Address(RVA = "0x44EBD24", Offset = "0x44EBD24", VA = "0x44EBD24")]
    public GachaInfoHolder()
    {
    }
  }
}
