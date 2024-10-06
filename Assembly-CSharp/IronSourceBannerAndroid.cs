// Decompiled with JetBrains decompiler
// Type: IronSourceBannerAndroid
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
[Token(Token = "0x2000013")]
public class IronSourceBannerAndroid : AndroidJavaProxy, IUnityBanner
{
  [Token(Token = "0x14000001")]
  public event Action OnBannerAdLoaded
  {
    [Token(Token = "0x60000C1"), Address(RVA = "0x2044FA0", Offset = "0x2044FA0", VA = "0x2044FA0", Slot = "9")] add
    {
    }
    [Token(Token = "0x60000C2"), Address(RVA = "0x204503C", Offset = "0x204503C", VA = "0x204503C", Slot = "10")] remove
    {
    }
  }

  [Token(Token = "0x14000002")]
  public event Action OnBannerAdLeftApplication
  {
    [Token(Token = "0x60000C3"), Address(RVA = "0x20450D8", Offset = "0x20450D8", VA = "0x20450D8", Slot = "11")] add
    {
    }
    [Token(Token = "0x60000C4"), Address(RVA = "0x2045174", Offset = "0x2045174", VA = "0x2045174", Slot = "12")] remove
    {
    }
  }

  [Token(Token = "0x14000003")]
  public event Action OnBannerAdScreenDismissed
  {
    [Token(Token = "0x60000C5"), Address(RVA = "0x2045210", Offset = "0x2045210", VA = "0x2045210", Slot = "13")] add
    {
    }
    [Token(Token = "0x60000C6"), Address(RVA = "0x20452AC", Offset = "0x20452AC", VA = "0x20452AC", Slot = "14")] remove
    {
    }
  }

  [Token(Token = "0x14000004")]
  public event Action OnBannerAdScreenPresented
  {
    [Token(Token = "0x60000C7"), Address(RVA = "0x2045348", Offset = "0x2045348", VA = "0x2045348", Slot = "15")] add
    {
    }
    [Token(Token = "0x60000C8"), Address(RVA = "0x20453E4", Offset = "0x20453E4", VA = "0x20453E4", Slot = "16")] remove
    {
    }
  }

  [Token(Token = "0x14000005")]
  public event Action OnBannerAdClicked
  {
    [Token(Token = "0x60000C9"), Address(RVA = "0x2045480", Offset = "0x2045480", VA = "0x2045480", Slot = "17")] add
    {
    }
    [Token(Token = "0x60000CA"), Address(RVA = "0x204551C", Offset = "0x204551C", VA = "0x204551C", Slot = "18")] remove
    {
    }
  }

  [Token(Token = "0x14000006")]
  public event Action<IronSourceError> OnBannerAdLoadFailed
  {
    [Token(Token = "0x60000CB"), Address(RVA = "0x20455B8", Offset = "0x20455B8", VA = "0x20455B8", Slot = "19")] add
    {
    }
    [Token(Token = "0x60000CC"), Address(RVA = "0x2045668", Offset = "0x2045668", VA = "0x2045668", Slot = "20")] remove
    {
    }
  }

  [Token(Token = "0x60000CD")]
  [Address(RVA = "0x2045718", Offset = "0x2045718", VA = "0x2045718")]
  public IronSourceBannerAndroid()
  {
  }

  [Token(Token = "0x60000CE")]
  [Address(RVA = "0x2045E10", Offset = "0x2045E10", VA = "0x2045E10")]
  private void onBannerAdLoaded()
  {
  }

  [Token(Token = "0x60000CF")]
  [Address(RVA = "0x2045E2C", Offset = "0x2045E2C", VA = "0x2045E2C")]
  private void onBannerAdLoadFailed(string args)
  {
  }

  [Token(Token = "0x60000D0")]
  [Address(RVA = "0x2045E74", Offset = "0x2045E74", VA = "0x2045E74")]
  private void onBannerAdClicked()
  {
  }

  [Token(Token = "0x60000D1")]
  [Address(RVA = "0x2045E90", Offset = "0x2045E90", VA = "0x2045E90")]
  private void onBannerAdScreenPresented()
  {
  }

  [Token(Token = "0x60000D2")]
  [Address(RVA = "0x2045EAC", Offset = "0x2045EAC", VA = "0x2045EAC")]
  private void onBannerAdScreenDismissed()
  {
  }

  [Token(Token = "0x60000D3")]
  [Address(RVA = "0x2045EC8", Offset = "0x2045EC8", VA = "0x2045EC8")]
  private void onBannerAdLeftApplication()
  {
  }
}
