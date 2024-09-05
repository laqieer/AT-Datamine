// Decompiled with JetBrains decompiler
// Type: IronSourceBannerLevelPlayAndroid
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
[Token(Token = "0x200001D")]
public class IronSourceBannerLevelPlayAndroid : AndroidJavaProxy, IUnityLevelPlayBanner
{
  [Token(Token = "0x1400000D")]
  public event Action<IronSourceAdInfo> OnAdLoaded
  {
    [Token(Token = "0x6000101"), Address(RVA = "0x2048638", Offset = "0x2048638", VA = "0x2048638", Slot = "9")] add
    {
    }
    [Token(Token = "0x6000102"), Address(RVA = "0x20486E8", Offset = "0x20486E8", VA = "0x20486E8", Slot = "10")] remove
    {
    }
  }

  [Token(Token = "0x1400000E")]
  public event Action<IronSourceAdInfo> OnAdLeftApplication
  {
    [Token(Token = "0x6000103"), Address(RVA = "0x2048798", Offset = "0x2048798", VA = "0x2048798", Slot = "11")] add
    {
    }
    [Token(Token = "0x6000104"), Address(RVA = "0x2048848", Offset = "0x2048848", VA = "0x2048848", Slot = "12")] remove
    {
    }
  }

  [Token(Token = "0x1400000F")]
  public event Action<IronSourceAdInfo> OnAdScreenDismissed
  {
    [Token(Token = "0x6000105"), Address(RVA = "0x20488F8", Offset = "0x20488F8", VA = "0x20488F8", Slot = "13")] add
    {
    }
    [Token(Token = "0x6000106"), Address(RVA = "0x20489A8", Offset = "0x20489A8", VA = "0x20489A8", Slot = "14")] remove
    {
    }
  }

  [Token(Token = "0x14000010")]
  public event Action<IronSourceAdInfo> OnAdScreenPresented
  {
    [Token(Token = "0x6000107"), Address(RVA = "0x2048A58", Offset = "0x2048A58", VA = "0x2048A58", Slot = "15")] add
    {
    }
    [Token(Token = "0x6000108"), Address(RVA = "0x2048B08", Offset = "0x2048B08", VA = "0x2048B08", Slot = "16")] remove
    {
    }
  }

  [Token(Token = "0x14000011")]
  public event Action<IronSourceAdInfo> OnAdClicked
  {
    [Token(Token = "0x6000109"), Address(RVA = "0x2048BB8", Offset = "0x2048BB8", VA = "0x2048BB8", Slot = "17")] add
    {
    }
    [Token(Token = "0x600010A"), Address(RVA = "0x2048C68", Offset = "0x2048C68", VA = "0x2048C68", Slot = "18")] remove
    {
    }
  }

  [Token(Token = "0x14000012")]
  public event Action<IronSourceError> OnAdLoadFailed
  {
    [Token(Token = "0x600010B"), Address(RVA = "0x2048D18", Offset = "0x2048D18", VA = "0x2048D18", Slot = "19")] add
    {
    }
    [Token(Token = "0x600010C"), Address(RVA = "0x2048DC8", Offset = "0x2048DC8", VA = "0x2048DC8", Slot = "20")] remove
    {
    }
  }

  [Token(Token = "0x600010D")]
  [Address(RVA = "0x20469F4", Offset = "0x20469F4", VA = "0x20469F4")]
  public IronSourceBannerLevelPlayAndroid()
  {
  }

  [Token(Token = "0x600010E")]
  [Address(RVA = "0x2048E78", Offset = "0x2048E78", VA = "0x2048E78")]
  private void onAdLoaded(string data)
  {
  }

  [Token(Token = "0x600010F")]
  [Address(RVA = "0x2048F04", Offset = "0x2048F04", VA = "0x2048F04")]
  private void onAdLoadFailed(string args)
  {
  }

  [Token(Token = "0x6000110")]
  [Address(RVA = "0x2048F4C", Offset = "0x2048F4C", VA = "0x2048F4C")]
  private void onAdClicked(string data)
  {
  }

  [Token(Token = "0x6000111")]
  [Address(RVA = "0x2048FD8", Offset = "0x2048FD8", VA = "0x2048FD8")]
  private void onAdScreenPresented(string data)
  {
  }

  [Token(Token = "0x6000112")]
  [Address(RVA = "0x2049064", Offset = "0x2049064", VA = "0x2049064")]
  private void onAdScreenDismissed(string data)
  {
  }

  [Token(Token = "0x6000113")]
  [Address(RVA = "0x20490F0", Offset = "0x20490F0", VA = "0x20490F0")]
  private void onAdLeftApplication(string data)
  {
  }
}
