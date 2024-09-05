// Decompiled with JetBrains decompiler
// Type: LoginBonus.LoginBonusSingleRewardUIParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using StaqData;

#nullable disable
namespace LoginBonus
{
  [Token(Token = "0x2000AE8")]
  public class LoginBonusSingleRewardUIParam : ILoginBonusRewardUIParam
  {
    [Token(Token = "0x170008F9")]
    public RewardTypeEnum rewardType
    {
      [Token(Token = "0x6003E26"), Address(RVA = "0x2C140B8", Offset = "0x2C140B8", VA = "0x2C140B8", Slot = "4")] get
      {
        return new RewardTypeEnum();
      }
    }

    [Token(Token = "0x170008FA")]
    public int id
    {
      [Token(Token = "0x6003E27"), Address(RVA = "0x2C140C0", Offset = "0x2C140C0", VA = "0x2C140C0", Slot = "5")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x170008FB")]
    public string name
    {
      [Token(Token = "0x6003E28"), Address(RVA = "0x2C0AA40", Offset = "0x2C0AA40", VA = "0x2C0AA40", Slot = "6")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x170008FC")]
    public int quantity
    {
      [Token(Token = "0x6003E29"), Address(RVA = "0x2C140C8", Offset = "0x2C140C8", VA = "0x2C140C8", Slot = "7")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x170008FD")]
    public int rewardNumber
    {
      [Token(Token = "0x6003E2A"), Address(RVA = "0x2C140D0", Offset = "0x2C140D0", VA = "0x2C140D0", Slot = "8")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x170008FE")]
    public bool received
    {
      [Token(Token = "0x6003E2B"), Address(RVA = "0x2C140D8", Offset = "0x2C140D8", VA = "0x2C140D8", Slot = "9")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x170008FF")]
    public bool IsPacked
    {
      [Token(Token = "0x6003E2C"), Address(RVA = "0x2C140E0", Offset = "0x2C140E0", VA = "0x2C140E0", Slot = "10")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17000900")]
    public ItemUtility.Parameter itemParameter
    {
      [Token(Token = "0x6003E2D"), Address(RVA = "0x2C140E8", Offset = "0x2C140E8", VA = "0x2C140E8", Slot = "11")] get
      {
        return new ItemUtility.Parameter();
      }
    }

    [Token(Token = "0x6003E2E")]
    [Address(RVA = "0x2C13560", Offset = "0x2C13560", VA = "0x2C13560")]
    public LoginBonusSingleRewardUIParam(
      RewardTypeEnum rewardType,
      int id,
      ItemUtility.Parameter itemParameter,
      int quantity,
      int rewardNumber,
      bool received)
    {
    }
  }
}
