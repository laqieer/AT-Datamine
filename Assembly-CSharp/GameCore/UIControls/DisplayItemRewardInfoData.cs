// Decompiled with JetBrains decompiler
// Type: GameCore.UIControls.DisplayItemRewardInfoData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using StaqData;

#nullable disable
namespace GameCore.UIControls
{
  [Token(Token = "0x2000BF3")]
  public struct DisplayItemRewardInfoData
  {
    [Token(Token = "0x170009EA")]
    public RewardTypeEnum RewardTypeId
    {
      [Token(Token = "0x6004470"), Address(RVA = "0x36494FC", Offset = "0x36494FC", VA = "0x36494FC")] readonly get
      {
        return new RewardTypeEnum();
      }
      [Token(Token = "0x6004471"), Address(RVA = "0x3649504", Offset = "0x3649504", VA = "0x3649504")] set
      {
      }
    }

    [Token(Token = "0x170009EB")]
    public int RewardId
    {
      [Token(Token = "0x6004472"), Address(RVA = "0x364950C", Offset = "0x364950C", VA = "0x364950C")] readonly get
      {
        return new int();
      }
      [Token(Token = "0x6004473"), Address(RVA = "0x3649514", Offset = "0x3649514", VA = "0x3649514")] set
      {
      }
    }

    [Token(Token = "0x170009EC")]
    public int RewardQuantity
    {
      [Token(Token = "0x6004474"), Address(RVA = "0x364951C", Offset = "0x364951C", VA = "0x364951C")] readonly get
      {
        return new int();
      }
      [Token(Token = "0x6004475"), Address(RVA = "0x3649524", Offset = "0x3649524", VA = "0x3649524")] set
      {
      }
    }

    [Token(Token = "0x170009ED")]
    public bool IsPaidCoin
    {
      [Token(Token = "0x6004476"), Address(RVA = "0x364952C", Offset = "0x364952C", VA = "0x364952C")] readonly get
      {
        return new bool();
      }
      [Token(Token = "0x6004477"), Address(RVA = "0x3649534", Offset = "0x3649534", VA = "0x3649534")] set
      {
      }
    }

    [Token(Token = "0x170009EE")]
    public bool IsNew
    {
      [Token(Token = "0x6004478"), Address(RVA = "0x3649540", Offset = "0x3649540", VA = "0x3649540")] readonly get
      {
        return new bool();
      }
      [Token(Token = "0x6004479"), Address(RVA = "0x3649548", Offset = "0x3649548", VA = "0x3649548")] set
      {
      }
    }

    [Token(Token = "0x600447A")]
    [Address(RVA = "0x3649554", Offset = "0x3649554", VA = "0x3649554")]
    public DisplayItemRewardInfoData(
      RewardTypeEnum RewardTypeId,
      int RewardId,
      int RewardQuantity,
      bool isPaidCoin = false,
      bool isNew = false)
    {
    }

    [Token(Token = "0x600447B")]
    [Address(RVA = "0x3649570", Offset = "0x3649570", VA = "0x3649570")]
    public ItemUtility.Parameter GetParam() => new ItemUtility.Parameter();
  }
}
