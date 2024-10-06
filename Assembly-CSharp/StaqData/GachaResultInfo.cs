// Decompiled with JetBrains decompiler
// Type: StaqData.GachaResultInfo
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Network.API;
using Network.Param;
using System.Collections.Generic;

#nullable disable
namespace StaqData
{
  [Token(Token = "0x200213D")]
  public class GachaResultInfo
  {
    [Token(Token = "0x4008D07")]
    [FieldOffset(Offset = "0x38")]
    public GachaDetailInfo GachaDetailInfo;

    [Token(Token = "0x17002C82")]
    public string GachaName
    {
      [Token(Token = "0x600CBA2"), Address(RVA = "0x1BA9DC8", Offset = "0x1BA9DC8", VA = "0x1BA9DC8")] get
      {
        return (string) null;
      }
      [Token(Token = "0x600CBA3"), Address(RVA = "0x1BA9DD0", Offset = "0x1BA9DD0", VA = "0x1BA9DD0")] private set
      {
      }
    }

    [Token(Token = "0x17002C83")]
    public int GachaDetailId
    {
      [Token(Token = "0x600CBA4"), Address(RVA = "0x1BA9DD8", Offset = "0x1BA9DD8", VA = "0x1BA9DD8")] get
      {
        return new int();
      }
      [Token(Token = "0x600CBA5"), Address(RVA = "0x1BA9DE0", Offset = "0x1BA9DE0", VA = "0x1BA9DE0")] private set
      {
      }
    }

    [Token(Token = "0x17002C84")]
    public IReadOnlyList<GachaResultDetailInfo> RewardItems
    {
      [Token(Token = "0x600CBA6"), Address(RVA = "0x1BA9DE8", Offset = "0x1BA9DE8", VA = "0x1BA9DE8")] get
      {
        return (IReadOnlyList<GachaResultDetailInfo>) null;
      }
      [Token(Token = "0x600CBA7"), Address(RVA = "0x1BA9DF0", Offset = "0x1BA9DF0", VA = "0x1BA9DF0")] private set
      {
      }
    }

    [Token(Token = "0x17002C85")]
    public IReadOnlyList<GachaBonusRewardInfo> BonusRewardItems
    {
      [Token(Token = "0x600CBA8"), Address(RVA = "0x1BA9DF8", Offset = "0x1BA9DF8", VA = "0x1BA9DF8")] get
      {
        return (IReadOnlyList<GachaBonusRewardInfo>) null;
      }
      [Token(Token = "0x600CBA9"), Address(RVA = "0x1BA9E00", Offset = "0x1BA9E00", VA = "0x1BA9E00")] private set
      {
      }
    }

    [Token(Token = "0x17002C86")]
    public IReadOnlyList<int> NewCharacterIds
    {
      [Token(Token = "0x600CBAA"), Address(RVA = "0x1BA9E08", Offset = "0x1BA9E08", VA = "0x1BA9E08")] get
      {
        return (IReadOnlyList<int>) null;
      }
      [Token(Token = "0x600CBAB"), Address(RVA = "0x1BA9E10", Offset = "0x1BA9E10", VA = "0x1BA9E10")] private set
      {
      }
    }

    [Token(Token = "0x17002C87")]
    public bool HasBonus
    {
      [Token(Token = "0x600CBAC"), Address(RVA = "0x1BA9E18", Offset = "0x1BA9E18", VA = "0x1BA9E18")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17002C88")]
    public List<Reward> UnreceivedRewards
    {
      [Token(Token = "0x600CBAD"), Address(RVA = "0x1BA9EC4", Offset = "0x1BA9EC4", VA = "0x1BA9EC4")] get
      {
        return (List<Reward>) null;
      }
      [Token(Token = "0x600CBAE"), Address(RVA = "0x1BA9ECC", Offset = "0x1BA9ECC", VA = "0x1BA9ECC")] private set
      {
      }
    }

    [Token(Token = "0x17002C89")]
    public int ExecuteCount
    {
      [Token(Token = "0x600CBAF"), Address(RVA = "0x1BA9ED4", Offset = "0x1BA9ED4", VA = "0x1BA9ED4")] get
      {
        return new int();
      }
      [Token(Token = "0x600CBB0"), Address(RVA = "0x1BA9EDC", Offset = "0x1BA9EDC", VA = "0x1BA9EDC")] set
      {
      }
    }

    [Token(Token = "0x600CBB1")]
    [Address(RVA = "0x1BA6AA0", Offset = "0x1BA6AA0", VA = "0x1BA6AA0")]
    public static GachaResultInfo CreateFromServerData(
      string gachaName,
      int gachaDetailId,
      APIG0000PayResponse serverData)
    {
      return (GachaResultInfo) null;
    }

    [Token(Token = "0x600CBB2")]
    [Address(RVA = "0x1BA6D98", Offset = "0x1BA6D98", VA = "0x1BA6D98")]
    public static GachaResultInfo CreateFromServerData(
      string gachaName,
      int gachaDetailId,
      APIG0001PayResponse serverData)
    {
      return (GachaResultInfo) null;
    }

    [Token(Token = "0x600CBB3")]
    [Address(RVA = "0x1BA9EEC", Offset = "0x1BA9EEC", VA = "0x1BA9EEC")]
    private static List<int> GetNewCharacterIds(IPostApiResult postApiResult) => (List<int>) null;

    [Token(Token = "0x600CBB4")]
    [Address(RVA = "0x1BA9EE4", Offset = "0x1BA9EE4", VA = "0x1BA9EE4")]
    public GachaResultInfo()
    {
    }
  }
}
