// Decompiled with JetBrains decompiler
// Type: LoginBonus.LoginBonusMultipleRewardUIParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using StaqData;
using System.Collections.Generic;

#nullable disable
namespace LoginBonus
{
  [Token(Token = "0x2000AE9")]
  public class LoginBonusMultipleRewardUIParam : ILoginBonusRewardUIParam
  {
    [Token(Token = "0x4003211")]
    [FieldOffset(Offset = "0x80")]
    public IReadOnlyList<LoginBonusSingleRewardUIParam> rewards;

    [Token(Token = "0x17000901")]
    public RewardTypeEnum rewardType
    {
      [Token(Token = "0x6003E2F"), Address(RVA = "0x2C140F8", Offset = "0x2C140F8", VA = "0x2C140F8", Slot = "4")] get
      {
        return new RewardTypeEnum();
      }
    }

    [Token(Token = "0x17000902")]
    public int id
    {
      [Token(Token = "0x6003E30"), Address(RVA = "0x2C14100", Offset = "0x2C14100", VA = "0x2C14100", Slot = "5")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000903")]
    public string name
    {
      [Token(Token = "0x6003E31"), Address(RVA = "0x2C14108", Offset = "0x2C14108", VA = "0x2C14108", Slot = "6")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000904")]
    public int quantity
    {
      [Token(Token = "0x6003E32"), Address(RVA = "0x2C14110", Offset = "0x2C14110", VA = "0x2C14110", Slot = "7")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000905")]
    public int rewardNumber
    {
      [Token(Token = "0x6003E33"), Address(RVA = "0x2C14118", Offset = "0x2C14118", VA = "0x2C14118", Slot = "8")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000906")]
    public bool received
    {
      [Token(Token = "0x6003E34"), Address(RVA = "0x2C14120", Offset = "0x2C14120", VA = "0x2C14120", Slot = "9")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17000907")]
    public bool IsPacked
    {
      [Token(Token = "0x6003E35"), Address(RVA = "0x2C14128", Offset = "0x2C14128", VA = "0x2C14128", Slot = "10")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17000908")]
    public ItemUtility.Parameter itemParameter
    {
      [Token(Token = "0x6003E36"), Address(RVA = "0x2C14130", Offset = "0x2C14130", VA = "0x2C14130", Slot = "11")] get
      {
        return new ItemUtility.Parameter();
      }
    }

    [Token(Token = "0x6003E37")]
    [Address(RVA = "0x2C1350C", Offset = "0x2C1350C", VA = "0x2C1350C")]
    public LoginBonusMultipleRewardUIParam(
      ItemUtility.Parameter itemParameter,
      int rewardNumber,
      List<LoginBonusSingleRewardUIParam> rewards,
      bool received)
    {
    }
  }
}
