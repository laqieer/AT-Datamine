// Decompiled with JetBrains decompiler
// Type: IronSourceOfferwallAndroid
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
[Token(Token = "0x200005C")]
public class IronSourceOfferwallAndroid : AndroidJavaProxy, IUnityOfferwall
{
  [Token(Token = "0x600031D")]
  [Address(RVA = "0x44A3A0C", Offset = "0x44A3A0C", VA = "0x44A3A0C")]
  public IronSourceOfferwallAndroid()
  {
  }

  [Token(Token = "0x1400006C")]
  public event Action<IronSourceError> OnOfferwallShowFailed
  {
    [Token(Token = "0x600031E"), Address(RVA = "0x44A4138", Offset = "0x44A4138", VA = "0x44A4138", Slot = "9")] add
    {
    }
    [Token(Token = "0x600031F"), Address(RVA = "0x44A41E8", Offset = "0x44A41E8", VA = "0x44A41E8", Slot = "10")] remove
    {
    }
  }

  [Token(Token = "0x1400006D")]
  public event Action OnOfferwallOpened
  {
    [Token(Token = "0x6000320"), Address(RVA = "0x44A4298", Offset = "0x44A4298", VA = "0x44A4298", Slot = "11")] add
    {
    }
    [Token(Token = "0x6000321"), Address(RVA = "0x44A4334", Offset = "0x44A4334", VA = "0x44A4334", Slot = "12")] remove
    {
    }
  }

  [Token(Token = "0x1400006E")]
  public event Action OnOfferwallClosed
  {
    [Token(Token = "0x6000322"), Address(RVA = "0x44A43D0", Offset = "0x44A43D0", VA = "0x44A43D0", Slot = "13")] add
    {
    }
    [Token(Token = "0x6000323"), Address(RVA = "0x44A446C", Offset = "0x44A446C", VA = "0x44A446C", Slot = "14")] remove
    {
    }
  }

  [Token(Token = "0x1400006F")]
  public event Action<IronSourceError> OnGetOfferwallCreditsFailed
  {
    [Token(Token = "0x6000324"), Address(RVA = "0x44A4508", Offset = "0x44A4508", VA = "0x44A4508", Slot = "15")] add
    {
    }
    [Token(Token = "0x6000325"), Address(RVA = "0x44A45B8", Offset = "0x44A45B8", VA = "0x44A45B8", Slot = "16")] remove
    {
    }
  }

  [Token(Token = "0x14000070")]
  public event Action<Dictionary<string, object>> OnOfferwallAdCredited
  {
    [Token(Token = "0x6000326"), Address(RVA = "0x44A4668", Offset = "0x44A4668", VA = "0x44A4668", Slot = "17")] add
    {
    }
    [Token(Token = "0x6000327"), Address(RVA = "0x44A4718", Offset = "0x44A4718", VA = "0x44A4718", Slot = "18")] remove
    {
    }
  }

  [Token(Token = "0x14000071")]
  public event Action<bool> OnOfferwallAvailable
  {
    [Token(Token = "0x6000328"), Address(RVA = "0x44A47C8", Offset = "0x44A47C8", VA = "0x44A47C8", Slot = "19")] add
    {
    }
    [Token(Token = "0x6000329"), Address(RVA = "0x44A4878", Offset = "0x44A4878", VA = "0x44A4878", Slot = "20")] remove
    {
    }
  }

  [Token(Token = "0x600032A")]
  [Address(RVA = "0x44A4928", Offset = "0x44A4928", VA = "0x44A4928")]
  public void onOfferwallOpened()
  {
  }

  [Token(Token = "0x600032B")]
  [Address(RVA = "0x44A4944", Offset = "0x44A4944", VA = "0x44A4944")]
  public void onOfferwallShowFailed(string description)
  {
  }

  [Token(Token = "0x600032C")]
  [Address(RVA = "0x44A4C18", Offset = "0x44A4C18", VA = "0x44A4C18")]
  public void onOfferwallClosed()
  {
  }

  [Token(Token = "0x600032D")]
  [Address(RVA = "0x44A4C34", Offset = "0x44A4C34", VA = "0x44A4C34")]
  public void onGetOfferwallCreditsFailed(string description)
  {
  }

  [Token(Token = "0x600032E")]
  [Address(RVA = "0x44A4C78", Offset = "0x44A4C78", VA = "0x44A4C78")]
  public void onOfferwallAdCredited(string json)
  {
  }

  [Token(Token = "0x600032F")]
  [Address(RVA = "0x44A4D20", Offset = "0x44A4D20", VA = "0x44A4D20")]
  public void onOfferwallAvailable(string stringAvailable)
  {
  }
}
