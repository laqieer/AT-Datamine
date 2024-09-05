// Decompiled with JetBrains decompiler
// Type: IronSourceInterstitialAndroid
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
[Token(Token = "0x200004E")]
public class IronSourceInterstitialAndroid : AndroidJavaProxy, IUnityInterstitial
{
  [Token(Token = "0x6000297")]
  [Address(RVA = "0x204FB8C", Offset = "0x204FB8C", VA = "0x204FB8C")]
  public IronSourceInterstitialAndroid()
  {
  }

  [Token(Token = "0x14000050")]
  public event Action<IronSourceError> OnInterstitialAdShowFailed
  {
    [Token(Token = "0x6000298"), Address(RVA = "0x205A4B4", Offset = "0x205A4B4", VA = "0x205A4B4", Slot = "9")] add
    {
    }
    [Token(Token = "0x6000299"), Address(RVA = "0x205A564", Offset = "0x205A564", VA = "0x205A564", Slot = "10")] remove
    {
    }
  }

  [Token(Token = "0x14000051")]
  public event Action<IronSourceError> OnInterstitialAdLoadFailed
  {
    [Token(Token = "0x600029A"), Address(RVA = "0x205A614", Offset = "0x205A614", VA = "0x205A614", Slot = "11")] add
    {
    }
    [Token(Token = "0x600029B"), Address(RVA = "0x205A6C4", Offset = "0x205A6C4", VA = "0x205A6C4", Slot = "12")] remove
    {
    }
  }

  [Token(Token = "0x14000052")]
  public event Action OnInterstitialAdReady
  {
    [Token(Token = "0x600029C"), Address(RVA = "0x205A774", Offset = "0x205A774", VA = "0x205A774", Slot = "13")] add
    {
    }
    [Token(Token = "0x600029D"), Address(RVA = "0x205A810", Offset = "0x205A810", VA = "0x205A810", Slot = "14")] remove
    {
    }
  }

  [Token(Token = "0x14000053")]
  public event Action OnInterstitialAdOpened
  {
    [Token(Token = "0x600029E"), Address(RVA = "0x205A8AC", Offset = "0x205A8AC", VA = "0x205A8AC", Slot = "15")] add
    {
    }
    [Token(Token = "0x600029F"), Address(RVA = "0x205A948", Offset = "0x205A948", VA = "0x205A948", Slot = "16")] remove
    {
    }
  }

  [Token(Token = "0x14000054")]
  public event Action OnInterstitialAdClosed
  {
    [Token(Token = "0x60002A0"), Address(RVA = "0x205A9E4", Offset = "0x205A9E4", VA = "0x205A9E4", Slot = "17")] add
    {
    }
    [Token(Token = "0x60002A1"), Address(RVA = "0x205AA80", Offset = "0x205AA80", VA = "0x205AA80", Slot = "18")] remove
    {
    }
  }

  [Token(Token = "0x14000055")]
  public event Action OnInterstitialAdShowSucceeded
  {
    [Token(Token = "0x60002A2"), Address(RVA = "0x205AB1C", Offset = "0x205AB1C", VA = "0x205AB1C", Slot = "19")] add
    {
    }
    [Token(Token = "0x60002A3"), Address(RVA = "0x205ABB8", Offset = "0x205ABB8", VA = "0x205ABB8", Slot = "20")] remove
    {
    }
  }

  [Token(Token = "0x14000056")]
  public event Action OnInterstitialAdClicked
  {
    [Token(Token = "0x60002A4"), Address(RVA = "0x205AC54", Offset = "0x205AC54", VA = "0x205AC54", Slot = "21")] add
    {
    }
    [Token(Token = "0x60002A5"), Address(RVA = "0x205ACF0", Offset = "0x205ACF0", VA = "0x205ACF0", Slot = "22")] remove
    {
    }
  }

  [Token(Token = "0x14000057")]
  public event Action OnInterstitialAdRewarded
  {
    [Token(Token = "0x60002A6"), Address(RVA = "0x205AD8C", Offset = "0x205AD8C", VA = "0x205AD8C", Slot = "23")] add
    {
    }
    [Token(Token = "0x60002A7"), Address(RVA = "0x205AE28", Offset = "0x205AE28", VA = "0x205AE28", Slot = "24")] remove
    {
    }
  }

  [Token(Token = "0x14000058")]
  public event Action<string> OnInterstitialAdReadyDemandOnly
  {
    [Token(Token = "0x60002A8"), Address(RVA = "0x205AEC4", Offset = "0x205AEC4", VA = "0x205AEC4", Slot = "25")] add
    {
    }
    [Token(Token = "0x60002A9"), Address(RVA = "0x205AF74", Offset = "0x205AF74", VA = "0x205AF74", Slot = "26")] remove
    {
    }
  }

  [Token(Token = "0x14000059")]
  public event Action<string> OnInterstitialAdOpenedDemandOnly
  {
    [Token(Token = "0x60002AA"), Address(RVA = "0x205B024", Offset = "0x205B024", VA = "0x205B024", Slot = "27")] add
    {
    }
    [Token(Token = "0x60002AB"), Address(RVA = "0x205B0D4", Offset = "0x205B0D4", VA = "0x205B0D4", Slot = "28")] remove
    {
    }
  }

  [Token(Token = "0x1400005A")]
  public event Action<string> OnInterstitialAdClosedDemandOnly
  {
    [Token(Token = "0x60002AC"), Address(RVA = "0x205B184", Offset = "0x205B184", VA = "0x205B184", Slot = "29")] add
    {
    }
    [Token(Token = "0x60002AD"), Address(RVA = "0x205B234", Offset = "0x205B234", VA = "0x205B234", Slot = "30")] remove
    {
    }
  }

  [Token(Token = "0x1400005B")]
  public event Action<string, IronSourceError> OnInterstitialAdLoadFailedDemandOnly
  {
    [Token(Token = "0x60002AE"), Address(RVA = "0x205B2E4", Offset = "0x205B2E4", VA = "0x205B2E4", Slot = "31")] add
    {
    }
    [Token(Token = "0x60002AF"), Address(RVA = "0x205B394", Offset = "0x205B394", VA = "0x205B394", Slot = "32")] remove
    {
    }
  }

  [Token(Token = "0x1400005C")]
  public event Action<string> OnInterstitialAdClickedDemandOnly
  {
    [Token(Token = "0x60002B0"), Address(RVA = "0x205B444", Offset = "0x205B444", VA = "0x205B444", Slot = "33")] add
    {
    }
    [Token(Token = "0x60002B1"), Address(RVA = "0x205B4F4", Offset = "0x205B4F4", VA = "0x205B4F4", Slot = "34")] remove
    {
    }
  }

  [Token(Token = "0x1400005D")]
  public event Action<string, IronSourceError> OnInterstitialAdShowFailedDemandOnly
  {
    [Token(Token = "0x60002B2"), Address(RVA = "0x205B5A4", Offset = "0x205B5A4", VA = "0x205B5A4", Slot = "35")] add
    {
    }
    [Token(Token = "0x60002B3"), Address(RVA = "0x205B654", Offset = "0x205B654", VA = "0x205B654", Slot = "36")] remove
    {
    }
  }

  [Token(Token = "0x60002B4")]
  [Address(RVA = "0x205B704", Offset = "0x205B704", VA = "0x205B704")]
  private void onInterstitialAdShowFailed(string description)
  {
  }

  [Token(Token = "0x60002B5")]
  [Address(RVA = "0x205B74C", Offset = "0x205B74C", VA = "0x205B74C")]
  private void onInterstitialAdReady()
  {
  }

  [Token(Token = "0x60002B6")]
  [Address(RVA = "0x205B768", Offset = "0x205B768", VA = "0x205B768")]
  private void onInterstitialAdOpened()
  {
  }

  [Token(Token = "0x60002B7")]
  [Address(RVA = "0x205B784", Offset = "0x205B784", VA = "0x205B784")]
  private void onInterstitialAdClosed()
  {
  }

  [Token(Token = "0x60002B8")]
  [Address(RVA = "0x205B7A0", Offset = "0x205B7A0", VA = "0x205B7A0")]
  private void onInterstitialAdShowSucceeded()
  {
  }

  [Token(Token = "0x60002B9")]
  [Address(RVA = "0x205B7BC", Offset = "0x205B7BC", VA = "0x205B7BC")]
  private void onInterstitialAdClicked()
  {
  }

  [Token(Token = "0x60002BA")]
  [Address(RVA = "0x205B7D8", Offset = "0x205B7D8", VA = "0x205B7D8")]
  private void onInterstitialAdLoadFailed(string args)
  {
  }

  [Token(Token = "0x60002BB")]
  [Address(RVA = "0x205B820", Offset = "0x205B820", VA = "0x205B820")]
  private void onInterstitialAdRewarded()
  {
  }

  [Token(Token = "0x60002BC")]
  [Address(RVA = "0x205B83C", Offset = "0x205B83C", VA = "0x205B83C")]
  private void onInterstitialAdClickedDemandOnly(string instanceId)
  {
  }

  [Token(Token = "0x60002BD")]
  [Address(RVA = "0x205B858", Offset = "0x205B858", VA = "0x205B858")]
  private void onInterstitialAdClosedDemandOnly(string instanceId)
  {
  }

  [Token(Token = "0x60002BE")]
  [Address(RVA = "0x205B874", Offset = "0x205B874", VA = "0x205B874")]
  private void onInterstitialAdOpenedDemandOnly(string instanceId)
  {
  }

  [Token(Token = "0x60002BF")]
  [Address(RVA = "0x205B890", Offset = "0x205B890", VA = "0x205B890")]
  private void onInterstitialAdReadyDemandOnly(string instanceId)
  {
  }

  [Token(Token = "0x60002C0")]
  [Address(RVA = "0x205B8AC", Offset = "0x205B8AC", VA = "0x205B8AC")]
  private void onInterstitialAdLoadFailedDemandOnly(string args)
  {
  }

  [Token(Token = "0x60002C1")]
  [Address(RVA = "0x205B9B4", Offset = "0x205B9B4", VA = "0x205B9B4")]
  private void onInterstitialAdShowFailedDemandOnly(string args)
  {
  }
}
