// Decompiled with JetBrains decompiler
// Type: IronSourceInterstitialEvents
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
[Token(Token = "0x2000050")]
public class IronSourceInterstitialEvents : MonoBehaviour
{
  [Token(Token = "0x4000187")]
  [FieldOffset(Offset = "0x18")]
  private IUnityLevelPlayInterstitial LevelPlayInterstitialAndroid;

  [Token(Token = "0x1400005E")]
  public static event Action<IronSourceAdInfo> onAdReadyEvent
  {
    [Token(Token = "0x60002D2"), Address(RVA = "0x205BB60", Offset = "0x205BB60", VA = "0x205BB60")] add
    {
    }
    [Token(Token = "0x60002D3"), Address(RVA = "0x205BC2C", Offset = "0x205BC2C", VA = "0x205BC2C")] remove
    {
    }
  }

  [Token(Token = "0x1400005F")]
  public static event Action<IronSourceError> onAdLoadFailedEvent
  {
    [Token(Token = "0x60002D4"), Address(RVA = "0x205BCF8", Offset = "0x205BCF8", VA = "0x205BCF8")] add
    {
    }
    [Token(Token = "0x60002D5"), Address(RVA = "0x205BDC8", Offset = "0x205BDC8", VA = "0x205BDC8")] remove
    {
    }
  }

  [Token(Token = "0x14000060")]
  public static event Action<IronSourceAdInfo> onAdOpenedEvent
  {
    [Token(Token = "0x60002D6"), Address(RVA = "0x205BE98", Offset = "0x205BE98", VA = "0x205BE98")] add
    {
    }
    [Token(Token = "0x60002D7"), Address(RVA = "0x205BF68", Offset = "0x205BF68", VA = "0x205BF68")] remove
    {
    }
  }

  [Token(Token = "0x14000061")]
  public static event Action<IronSourceAdInfo> onAdClosedEvent
  {
    [Token(Token = "0x60002D8"), Address(RVA = "0x205C038", Offset = "0x205C038", VA = "0x205C038")] add
    {
    }
    [Token(Token = "0x60002D9"), Address(RVA = "0x205C108", Offset = "0x205C108", VA = "0x205C108")] remove
    {
    }
  }

  [Token(Token = "0x14000062")]
  public static event Action<IronSourceAdInfo> onAdShowSucceededEvent
  {
    [Token(Token = "0x60002DA"), Address(RVA = "0x205C1D8", Offset = "0x205C1D8", VA = "0x205C1D8")] add
    {
    }
    [Token(Token = "0x60002DB"), Address(RVA = "0x205C2A8", Offset = "0x205C2A8", VA = "0x205C2A8")] remove
    {
    }
  }

  [Token(Token = "0x14000063")]
  public static event Action<IronSourceError, IronSourceAdInfo> onAdShowFailedEvent
  {
    [Token(Token = "0x60002DC"), Address(RVA = "0x205C378", Offset = "0x205C378", VA = "0x205C378")] add
    {
    }
    [Token(Token = "0x60002DD"), Address(RVA = "0x205C448", Offset = "0x205C448", VA = "0x205C448")] remove
    {
    }
  }

  [Token(Token = "0x14000064")]
  public static event Action<IronSourceAdInfo> onAdClickedEvent
  {
    [Token(Token = "0x60002DE"), Address(RVA = "0x205C518", Offset = "0x205C518", VA = "0x205C518")] add
    {
    }
    [Token(Token = "0x60002DF"), Address(RVA = "0x205C5E8", Offset = "0x205C5E8", VA = "0x205C5E8")] remove
    {
    }
  }

  [Token(Token = "0x60002E0")]
  [Address(RVA = "0x205C6B8", Offset = "0x205C6B8", VA = "0x205C6B8")]
  private void Awake()
  {
  }

  [Token(Token = "0x60002E1")]
  [Address(RVA = "0x205CF10", Offset = "0x205CF10", VA = "0x205CF10")]
  private void registerInterstitialEvents()
  {
  }

  [Token(Token = "0x60002E2")]
  [Address(RVA = "0x205D5CC", Offset = "0x205D5CC", VA = "0x205D5CC")]
  private IronSourceError getErrorFromErrorObject(object descriptionObject)
  {
    return (IronSourceError) null;
  }

  [Token(Token = "0x60002E3")]
  [Address(RVA = "0x205D864", Offset = "0x205D864", VA = "0x205D864")]
  private IronSourcePlacement getPlacementFromObject(object placementObject)
  {
    return (IronSourcePlacement) null;
  }

  [Token(Token = "0x60002E4")]
  [Address(RVA = "0x205DAB4", Offset = "0x205DAB4", VA = "0x205DAB4")]
  public IronSourceInterstitialEvents()
  {
  }
}
