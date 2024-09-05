// Decompiled with JetBrains decompiler
// Type: StaqData.GachaBonusRewardInfo
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using Network.Param;

#nullable disable
namespace StaqData
{
  [Token(Token = "0x200213C")]
  public class GachaBonusRewardInfo
  {
    [Token(Token = "0x17002C7E")]
    public RewardTypeEnum RewardType
    {
      [Token(Token = "0x600CB94"), Address(RVA = "0x1BA9C60", Offset = "0x1BA9C60", VA = "0x1BA9C60")] get
      {
        return new RewardTypeEnum();
      }
      [Token(Token = "0x600CB95"), Address(RVA = "0x1BA9C68", Offset = "0x1BA9C68", VA = "0x1BA9C68")] private set
      {
      }
    }

    [Token(Token = "0x17002C7F")]
    public int RewardId
    {
      [Token(Token = "0x600CB96"), Address(RVA = "0x1BA9C70", Offset = "0x1BA9C70", VA = "0x1BA9C70")] get
      {
        return new int();
      }
      [Token(Token = "0x600CB97"), Address(RVA = "0x1BA9C78", Offset = "0x1BA9C78", VA = "0x1BA9C78")] private set
      {
      }
    }

    [Token(Token = "0x17002C80")]
    public int RewardQuantity
    {
      [Token(Token = "0x600CB98"), Address(RVA = "0x1BA9C80", Offset = "0x1BA9C80", VA = "0x1BA9C80")] get
      {
        return new int();
      }
      [Token(Token = "0x600CB99"), Address(RVA = "0x1BA9C88", Offset = "0x1BA9C88", VA = "0x1BA9C88")] private set
      {
      }
    }

    [Token(Token = "0x17002C81")]
    public bool IsNew
    {
      [Token(Token = "0x600CB9A"), Address(RVA = "0x1BA9C90", Offset = "0x1BA9C90", VA = "0x1BA9C90")] get
      {
        return new bool();
      }
      [Token(Token = "0x600CB9B"), Address(RVA = "0x1BA9C98", Offset = "0x1BA9C98", VA = "0x1BA9C98")] private set
      {
      }
    }

    [Token(Token = "0x600CB9C")]
    [Address(RVA = "0x1BA7BD0", Offset = "0x1BA7BD0", VA = "0x1BA7BD0")]
    public static GachaBonusRewardInfo CreateFromServerData(G0000GachaAdditionType serverData)
    {
      return (GachaBonusRewardInfo) null;
    }

    [Token(Token = "0x600CB9D")]
    [Address(RVA = "0x1BA9CAC", Offset = "0x1BA9CAC", VA = "0x1BA9CAC")]
    public static GachaBonusRewardInfo CreateFromServerData(RewardGiveResultEntityType serverData)
    {
      return (GachaBonusRewardInfo) null;
    }

    [Token(Token = "0x600CB9E")]
    [Address(RVA = "0x1BA9D28", Offset = "0x1BA9D28", VA = "0x1BA9D28")]
    public static GachaBonusRewardInfo Create(GachaBonusRewardInfo info)
    {
      return (GachaBonusRewardInfo) null;
    }

    [Token(Token = "0x600CB9F")]
    [Address(RVA = "0x1BA84CC", Offset = "0x1BA84CC", VA = "0x1BA84CC")]
    public static GachaBonusRewardInfo Create(
      RewardTypeEnum rewardType,
      int rewardId,
      int rewardQuantity,
      bool rewardIsNew)
    {
      return (GachaBonusRewardInfo) null;
    }

    [Token(Token = "0x600CBA0")]
    [Address(RVA = "0x1BA9DA4", Offset = "0x1BA9DA4", VA = "0x1BA9DA4")]
    public void Add(GachaBonusRewardInfo info)
    {
    }

    [Token(Token = "0x600CBA1")]
    [Address(RVA = "0x1BA9CA4", Offset = "0x1BA9CA4", VA = "0x1BA9CA4")]
    public GachaBonusRewardInfo()
    {
    }
  }
}
