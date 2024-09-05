// Decompiled with JetBrains decompiler
// Type: StaqData.LoginBonusInfoHolder
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using Network.Param;
using System.Collections.Generic;

#nullable disable
namespace StaqData
{
  [Token(Token = "0x2002045")]
  public class LoginBonusInfoHolder
  {
    [Token(Token = "0x4008941")]
    [FieldOffset(Offset = "0x10")]
    private List<LoginBonusInfo> loginBonuses;
    [Token(Token = "0x4008942")]
    [FieldOffset(Offset = "0x18")]
    private bool isEffectPlayed;
    [Token(Token = "0x4008943")]
    [FieldOffset(Offset = "0x19")]
    public bool isPassBenefit;
    [Token(Token = "0x4008944")]
    [FieldOffset(Offset = "0x1A")]
    public bool isAnnouncePassBenefit;
    [Token(Token = "0x4008945")]
    [FieldOffset(Offset = "0x0")]
    private static readonly Dictionary<LoginBonusTypeEnum, int> LoginBonusTypeEnumPriority;

    [Token(Token = "0x170028AF")]
    public List<LoginBonusInfo> LoginBonuses
    {
      [Token(Token = "0x600C1A6"), Address(RVA = "0x193D740", Offset = "0x193D740", VA = "0x193D740")] get
      {
        return (List<LoginBonusInfo>) null;
      }
    }

    [Token(Token = "0x170028B0")]
    public bool IsEffectPlayed
    {
      [Token(Token = "0x600C1A7"), Address(RVA = "0x193D748", Offset = "0x193D748", VA = "0x193D748")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x600C1A8")]
    [Address(RVA = "0x193D750", Offset = "0x193D750", VA = "0x193D750")]
    public void Setup(List<LoginBonusInfoType> loginBonusInfoTypes)
    {
    }

    [Token(Token = "0x600C1A9")]
    [Address(RVA = "0x193DA8C", Offset = "0x193DA8C", VA = "0x193DA8C")]
    private static int ComparerLoginBonusInfo(LoginBonusInfo a, LoginBonusInfo b) => new int();

    [Token(Token = "0x600C1AA")]
    [Address(RVA = "0x193DB38", Offset = "0x193DB38", VA = "0x193DB38")]
    private static int ComparerLoginBonusType(LoginBonusTypeEnum a, LoginBonusTypeEnum b)
    {
      return new int();
    }

    [Token(Token = "0x600C1AB")]
    [Address(RVA = "0x193DBF0", Offset = "0x193DBF0", VA = "0x193DBF0")]
    public void ApplyEffectPlayed(bool effectPlayed)
    {
    }

    [Token(Token = "0x600C1AC")]
    [Address(RVA = "0x193DBFC", Offset = "0x193DBFC", VA = "0x193DBFC")]
    public bool HasLoginBonusInfo() => new bool();

    [Token(Token = "0x600C1AD")]
    [Address(RVA = "0x193DC4C", Offset = "0x193DC4C", VA = "0x193DC4C")]
    public bool HasAlwaysLoginBonus() => new bool();

    [Token(Token = "0x600C1AE")]
    [Address(RVA = "0x193DDCC", Offset = "0x193DDCC", VA = "0x193DDCC")]
    public LoginBonusInfoHolder()
    {
    }

    [Token(Token = "0x600C1AF")]
    [Address(RVA = "0x193DDD4", Offset = "0x193DDD4", VA = "0x193DDD4")]
    static LoginBonusInfoHolder()
    {
    }
  }
}
