// Decompiled with JetBrains decompiler
// Type: StaqData.PassData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Network.Param;
using System;

#nullable disable
namespace StaqData
{
  [Token(Token = "0x2002085")]
  public class PassData
  {
    [Token(Token = "0x170029FD")]
    public int PassID
    {
      [Token(Token = "0x600C4CA"), Address(RVA = "0x19FDB64", Offset = "0x19FDB64", VA = "0x19FDB64")] get
      {
        return new int();
      }
      [Token(Token = "0x600C4CB"), Address(RVA = "0x19FDB6C", Offset = "0x19FDB6C", VA = "0x19FDB6C")] private set
      {
      }
    }

    [Token(Token = "0x170029FE")]
    public DateTime EndAt
    {
      [Token(Token = "0x600C4CC"), Address(RVA = "0x19FDB74", Offset = "0x19FDB74", VA = "0x19FDB74")] get
      {
        return new DateTime();
      }
      [Token(Token = "0x600C4CD"), Address(RVA = "0x19FDB7C", Offset = "0x19FDB7C", VA = "0x19FDB7C")] private set
      {
      }
    }

    [Token(Token = "0x170029FF")]
    public TimeSpan LimitDate
    {
      [Token(Token = "0x600C4CE"), Address(RVA = "0x19FDB84", Offset = "0x19FDB84", VA = "0x19FDB84")] get
      {
        return new TimeSpan();
      }
    }

    [Token(Token = "0x600C4CF")]
    [Address(RVA = "0x19FDC18", Offset = "0x19FDC18", VA = "0x19FDC18")]
    public void Apply(PlayerRewardPassType rewardPassType)
    {
    }

    [Token(Token = "0x600C4D0")]
    [Address(RVA = "0x19FDC90", Offset = "0x19FDC90", VA = "0x19FDC90")]
    public PassData()
    {
    }
  }
}
