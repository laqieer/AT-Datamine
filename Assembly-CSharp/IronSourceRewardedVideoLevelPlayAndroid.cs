// Decompiled with JetBrains decompiler
// Type: IronSourceRewardedVideoLevelPlayAndroid
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
[Token(Token = "0x200006B")]
public class IronSourceRewardedVideoLevelPlayAndroid : AndroidJavaProxy, IUnityLevelPlayRewardedVideo
{
  [Token(Token = "0x60003B0")]
  [Address(RVA = "0x44A8698", Offset = "0x44A8698", VA = "0x44A8698")]
  public IronSourceRewardedVideoLevelPlayAndroid()
  {
  }

  [Token(Token = "0x1400008A")]
  public event Action<IronSourceError, IronSourceAdInfo> OnAdShowFailed
  {
    [Token(Token = "0x60003B1"), Address(RVA = "0x44AAF3C", Offset = "0x44AAF3C", VA = "0x44AAF3C", Slot = "9")] add
    {
    }
    [Token(Token = "0x60003B2"), Address(RVA = "0x44AAFEC", Offset = "0x44AAFEC", VA = "0x44AAFEC", Slot = "10")] remove
    {
    }
  }

  [Token(Token = "0x1400008B")]
  public event Action<IronSourceAdInfo> OnAdOpened
  {
    [Token(Token = "0x60003B3"), Address(RVA = "0x44AB09C", Offset = "0x44AB09C", VA = "0x44AB09C", Slot = "11")] add
    {
    }
    [Token(Token = "0x60003B4"), Address(RVA = "0x44AB14C", Offset = "0x44AB14C", VA = "0x44AB14C", Slot = "12")] remove
    {
    }
  }

  [Token(Token = "0x1400008C")]
  public event Action<IronSourceAdInfo> OnAdClosed
  {
    [Token(Token = "0x60003B5"), Address(RVA = "0x44AB1FC", Offset = "0x44AB1FC", VA = "0x44AB1FC", Slot = "13")] add
    {
    }
    [Token(Token = "0x60003B6"), Address(RVA = "0x44AB2AC", Offset = "0x44AB2AC", VA = "0x44AB2AC", Slot = "14")] remove
    {
    }
  }

  [Token(Token = "0x1400008D")]
  public event Action<IronSourcePlacement, IronSourceAdInfo> OnAdRewarded
  {
    [Token(Token = "0x60003B7"), Address(RVA = "0x44AB35C", Offset = "0x44AB35C", VA = "0x44AB35C", Slot = "15")] add
    {
    }
    [Token(Token = "0x60003B8"), Address(RVA = "0x44AB40C", Offset = "0x44AB40C", VA = "0x44AB40C", Slot = "16")] remove
    {
    }
  }

  [Token(Token = "0x1400008E")]
  public event Action<IronSourcePlacement, IronSourceAdInfo> OnAdClicked
  {
    [Token(Token = "0x60003B9"), Address(RVA = "0x44AB4BC", Offset = "0x44AB4BC", VA = "0x44AB4BC", Slot = "17")] add
    {
    }
    [Token(Token = "0x60003BA"), Address(RVA = "0x44AB56C", Offset = "0x44AB56C", VA = "0x44AB56C", Slot = "18")] remove
    {
    }
  }

  [Token(Token = "0x1400008F")]
  public event Action<IronSourceAdInfo> OnAdAvailable
  {
    [Token(Token = "0x60003BB"), Address(RVA = "0x44AB61C", Offset = "0x44AB61C", VA = "0x44AB61C", Slot = "19")] add
    {
    }
    [Token(Token = "0x60003BC"), Address(RVA = "0x44AB6CC", Offset = "0x44AB6CC", VA = "0x44AB6CC", Slot = "20")] remove
    {
    }
  }

  [Token(Token = "0x14000090")]
  public event Action OnAdUnavailable
  {
    [Token(Token = "0x60003BD"), Address(RVA = "0x44AB77C", Offset = "0x44AB77C", VA = "0x44AB77C", Slot = "21")] add
    {
    }
    [Token(Token = "0x60003BE"), Address(RVA = "0x44AB818", Offset = "0x44AB818", VA = "0x44AB818", Slot = "22")] remove
    {
    }
  }

  [Token(Token = "0x60003BF")]
  [Address(RVA = "0x44AB8B4", Offset = "0x44AB8B4", VA = "0x44AB8B4")]
  private void onAdShowFailed(string description, string data)
  {
  }

  [Token(Token = "0x60003C0")]
  [Address(RVA = "0x44AB968", Offset = "0x44AB968", VA = "0x44AB968")]
  private void onAdClosed(string data)
  {
  }

  [Token(Token = "0x60003C1")]
  [Address(RVA = "0x44AB9F8", Offset = "0x44AB9F8", VA = "0x44AB9F8")]
  private void onAdOpened(string data)
  {
  }

  [Token(Token = "0x60003C2")]
  [Address(RVA = "0x44ABA88", Offset = "0x44ABA88", VA = "0x44ABA88")]
  private void onAdRewarded(string description, string data)
  {
  }

  [Token(Token = "0x60003C3")]
  [Address(RVA = "0x44ABB4C", Offset = "0x44ABB4C", VA = "0x44ABB4C")]
  private void onAdClicked(string description, string data)
  {
  }

  [Token(Token = "0x60003C4")]
  [Address(RVA = "0x44ABC10", Offset = "0x44ABC10", VA = "0x44ABC10")]
  private void onAdAvailable(string data)
  {
  }

  [Token(Token = "0x60003C5")]
  [Address(RVA = "0x44ABCA0", Offset = "0x44ABCA0", VA = "0x44ABCA0")]
  private void onAdUnavailable()
  {
  }
}
