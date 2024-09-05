// Decompiled with JetBrains decompiler
// Type: IronSourceBannerEvents
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
[Token(Token = "0x2000015")]
public class IronSourceBannerEvents : MonoBehaviour
{
  [Token(Token = "0x400004D")]
  [FieldOffset(Offset = "0x18")]
  private IUnityLevelPlayBanner LevelPlaybannerAndroid;

  [Token(Token = "0x14000007")]
  public static event Action<IronSourceAdInfo> onAdLoadedEvent
  {
    [Token(Token = "0x60000DC"), Address(RVA = "0x2045F68", Offset = "0x2045F68", VA = "0x2045F68")] add
    {
    }
    [Token(Token = "0x60000DD"), Address(RVA = "0x2046034", Offset = "0x2046034", VA = "0x2046034")] remove
    {
    }
  }

  [Token(Token = "0x14000008")]
  public static event Action<IronSourceAdInfo> onAdLeftApplicationEvent
  {
    [Token(Token = "0x60000DE"), Address(RVA = "0x2046100", Offset = "0x2046100", VA = "0x2046100")] add
    {
    }
    [Token(Token = "0x60000DF"), Address(RVA = "0x20461D0", Offset = "0x20461D0", VA = "0x20461D0")] remove
    {
    }
  }

  [Token(Token = "0x14000009")]
  public static event Action<IronSourceAdInfo> onAdScreenDismissedEvent
  {
    [Token(Token = "0x60000E0"), Address(RVA = "0x20462A0", Offset = "0x20462A0", VA = "0x20462A0")] add
    {
    }
    [Token(Token = "0x60000E1"), Address(RVA = "0x2046370", Offset = "0x2046370", VA = "0x2046370")] remove
    {
    }
  }

  [Token(Token = "0x1400000A")]
  public static event Action<IronSourceAdInfo> onAdScreenPresentedEvent
  {
    [Token(Token = "0x60000E2"), Address(RVA = "0x2046440", Offset = "0x2046440", VA = "0x2046440")] add
    {
    }
    [Token(Token = "0x60000E3"), Address(RVA = "0x2046510", Offset = "0x2046510", VA = "0x2046510")] remove
    {
    }
  }

  [Token(Token = "0x1400000B")]
  public static event Action<IronSourceAdInfo> onAdClickedEvent
  {
    [Token(Token = "0x60000E4"), Address(RVA = "0x20465E0", Offset = "0x20465E0", VA = "0x20465E0")] add
    {
    }
    [Token(Token = "0x60000E5"), Address(RVA = "0x20466B0", Offset = "0x20466B0", VA = "0x20466B0")] remove
    {
    }
  }

  [Token(Token = "0x1400000C")]
  public static event Action<IronSourceError> onAdLoadFailedEvent
  {
    [Token(Token = "0x60000E6"), Address(RVA = "0x2046780", Offset = "0x2046780", VA = "0x2046780")] add
    {
    }
    [Token(Token = "0x60000E7"), Address(RVA = "0x2046850", Offset = "0x2046850", VA = "0x2046850")] remove
    {
    }
  }

  [Token(Token = "0x60000E8")]
  [Address(RVA = "0x2046920", Offset = "0x2046920", VA = "0x2046920")]
  private void Awake()
  {
  }

  [Token(Token = "0x60000E9")]
  [Address(RVA = "0x20470EC", Offset = "0x20470EC", VA = "0x20470EC")]
  private void registerBannerEvents()
  {
  }

  [Token(Token = "0x60000EA")]
  [Address(RVA = "0x20476B4", Offset = "0x20476B4", VA = "0x20476B4")]
  private IronSourceError getErrorFromErrorObject(object descriptionObject)
  {
    return (IronSourceError) null;
  }

  [Token(Token = "0x60000EB")]
  [Address(RVA = "0x204797C", Offset = "0x204797C", VA = "0x204797C")]
  private IronSourcePlacement getPlacementFromObject(object placementObject)
  {
    return (IronSourcePlacement) null;
  }

  [Token(Token = "0x60000EC")]
  [Address(RVA = "0x2047BCC", Offset = "0x2047BCC", VA = "0x2047BCC")]
  public IronSourceBannerEvents()
  {
  }
}
