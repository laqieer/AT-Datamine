// Decompiled with JetBrains decompiler
// Type: IronSourceInterstitialLevelPlayAndroid
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
[Token(Token = "0x2000059")]
public class IronSourceInterstitialLevelPlayAndroid : AndroidJavaProxy, IUnityLevelPlayInterstitial
{
  [Token(Token = "0x60002FC")]
  [Address(RVA = "0x205C78C", Offset = "0x205C78C", VA = "0x205C78C")]
  public IronSourceInterstitialLevelPlayAndroid()
  {
  }

  [Token(Token = "0x14000065")]
  public event Action<IronSourceError, IronSourceAdInfo> OnAdShowFailed
  {
    [Token(Token = "0x60002FD"), Address(RVA = "0x205E564", Offset = "0x205E564", VA = "0x205E564", Slot = "9")] add
    {
    }
    [Token(Token = "0x60002FE"), Address(RVA = "0x205E614", Offset = "0x205E614", VA = "0x205E614", Slot = "10")] remove
    {
    }
  }

  [Token(Token = "0x14000066")]
  public event Action<IronSourceError> OnAdLoadFailed
  {
    [Token(Token = "0x60002FF"), Address(RVA = "0x205E6C4", Offset = "0x205E6C4", VA = "0x205E6C4", Slot = "11")] add
    {
    }
    [Token(Token = "0x6000300"), Address(RVA = "0x205E774", Offset = "0x205E774", VA = "0x205E774", Slot = "12")] remove
    {
    }
  }

  [Token(Token = "0x14000067")]
  public event Action<IronSourceAdInfo> OnAdReady
  {
    [Token(Token = "0x6000301"), Address(RVA = "0x205E824", Offset = "0x205E824", VA = "0x205E824", Slot = "13")] add
    {
    }
    [Token(Token = "0x6000302"), Address(RVA = "0x205E8D4", Offset = "0x205E8D4", VA = "0x205E8D4", Slot = "14")] remove
    {
    }
  }

  [Token(Token = "0x14000068")]
  public event Action<IronSourceAdInfo> OnAdOpened
  {
    [Token(Token = "0x6000303"), Address(RVA = "0x205E984", Offset = "0x205E984", VA = "0x205E984", Slot = "15")] add
    {
    }
    [Token(Token = "0x6000304"), Address(RVA = "0x205EA34", Offset = "0x205EA34", VA = "0x205EA34", Slot = "16")] remove
    {
    }
  }

  [Token(Token = "0x14000069")]
  public event Action<IronSourceAdInfo> OnAdClosed
  {
    [Token(Token = "0x6000305"), Address(RVA = "0x205EAE4", Offset = "0x205EAE4", VA = "0x205EAE4", Slot = "17")] add
    {
    }
    [Token(Token = "0x6000306"), Address(RVA = "0x205EB94", Offset = "0x205EB94", VA = "0x205EB94", Slot = "18")] remove
    {
    }
  }

  [Token(Token = "0x1400006A")]
  public event Action<IronSourceAdInfo> OnAdShowSucceeded
  {
    [Token(Token = "0x6000307"), Address(RVA = "0x205EC44", Offset = "0x205EC44", VA = "0x205EC44", Slot = "19")] add
    {
    }
    [Token(Token = "0x6000308"), Address(RVA = "0x205ECF4", Offset = "0x205ECF4", VA = "0x205ECF4", Slot = "20")] remove
    {
    }
  }

  [Token(Token = "0x1400006B")]
  public event Action<IronSourceAdInfo> OnAdClicked
  {
    [Token(Token = "0x6000309"), Address(RVA = "0x205EDA4", Offset = "0x205EDA4", VA = "0x205EDA4", Slot = "21")] add
    {
    }
    [Token(Token = "0x600030A"), Address(RVA = "0x205EE54", Offset = "0x205EE54", VA = "0x205EE54", Slot = "22")] remove
    {
    }
  }

  [Token(Token = "0x600030B")]
  [Address(RVA = "0x205EF04", Offset = "0x205EF04", VA = "0x205EF04")]
  private void onAdShowFailed(string description, string data)
  {
  }

  [Token(Token = "0x600030C")]
  [Address(RVA = "0x205EFB8", Offset = "0x205EFB8", VA = "0x205EFB8")]
  private void onAdReady(string data)
  {
  }

  [Token(Token = "0x600030D")]
  [Address(RVA = "0x205F044", Offset = "0x205F044", VA = "0x205F044")]
  private void onAdOpened(string data)
  {
  }

  [Token(Token = "0x600030E")]
  [Address(RVA = "0x205F0D0", Offset = "0x205F0D0", VA = "0x205F0D0")]
  private void onAdClosed(string data)
  {
  }

  [Token(Token = "0x600030F")]
  [Address(RVA = "0x205F15C", Offset = "0x205F15C", VA = "0x205F15C")]
  private void onAdShowSucceeded(string data)
  {
  }

  [Token(Token = "0x6000310")]
  [Address(RVA = "0x205F1E8", Offset = "0x205F1E8", VA = "0x205F1E8")]
  private void onAdClicked(string data)
  {
  }

  [Token(Token = "0x6000311")]
  [Address(RVA = "0x205F274", Offset = "0x205F274", VA = "0x205F274")]
  private void onAdLoadFailed(string args)
  {
  }
}
