// Decompiled with JetBrains decompiler
// Type: StaqData.LoginBonusInfo
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
  [Token(Token = "0x2002044")]
  public class LoginBonusInfo
  {
    [Token(Token = "0x170028AA")]
    public LoginBonusData MasterData
    {
      [Token(Token = "0x600C19A"), Address(RVA = "0x193D5F8", Offset = "0x193D5F8", VA = "0x193D5F8")] get
      {
        return (LoginBonusData) null;
      }
      [Token(Token = "0x600C19B"), Address(RVA = "0x193D600", Offset = "0x193D600", VA = "0x193D600")] private set
      {
      }
    }

    [Token(Token = "0x170028AB")]
    public int ID
    {
      [Token(Token = "0x600C19C"), Address(RVA = "0x193D608", Offset = "0x193D608", VA = "0x193D608")] get
      {
        return new int();
      }
      [Token(Token = "0x600C19D"), Address(RVA = "0x193D610", Offset = "0x193D610", VA = "0x193D610")] private set
      {
      }
    }

    [Token(Token = "0x170028AC")]
    public int TotalLoginDays
    {
      [Token(Token = "0x600C19E"), Address(RVA = "0x193D618", Offset = "0x193D618", VA = "0x193D618")] get
      {
        return new int();
      }
      [Token(Token = "0x600C19F"), Address(RVA = "0x193D620", Offset = "0x193D620", VA = "0x193D620")] private set
      {
      }
    }

    [Token(Token = "0x170028AD")]
    public int LoginbonusRewardId
    {
      [Token(Token = "0x600C1A0"), Address(RVA = "0x193D628", Offset = "0x193D628", VA = "0x193D628")] get
      {
        return new int();
      }
      [Token(Token = "0x600C1A1"), Address(RVA = "0x193D630", Offset = "0x193D630", VA = "0x193D630")] private set
      {
      }
    }

    [Token(Token = "0x170028AE")]
    public List<int> PastLoginbonusRewardIds
    {
      [Token(Token = "0x600C1A2"), Address(RVA = "0x193D638", Offset = "0x193D638", VA = "0x193D638")] get
      {
        return (List<int>) null;
      }
      [Token(Token = "0x600C1A3"), Address(RVA = "0x193D640", Offset = "0x193D640", VA = "0x193D640")] private set
      {
      }
    }

    [Token(Token = "0x600C1A4")]
    [Address(RVA = "0x193D648", Offset = "0x193D648", VA = "0x193D648")]
    public static LoginBonusInfo CreateByServerData(LoginBonusInfoType loginBonusInfoType)
    {
      return (LoginBonusInfo) null;
    }

    [Token(Token = "0x600C1A5")]
    [Address(RVA = "0x193D738", Offset = "0x193D738", VA = "0x193D738")]
    public LoginBonusInfo()
    {
    }
  }
}
