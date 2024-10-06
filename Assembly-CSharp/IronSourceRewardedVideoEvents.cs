// Decompiled with JetBrains decompiler
// Type: IronSourceRewardedVideoEvents
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
[Token(Token = "0x2000061")]
public class IronSourceRewardedVideoEvents : MonoBehaviour
{
  [Token(Token = "0x40001E7")]
  [FieldOffset(Offset = "0x18")]
  private IUnityLevelPlayRewardedVideo LevelPlayRewardedVideoAndroid;
  [Token(Token = "0x40001E8")]
  [FieldOffset(Offset = "0x20")]
  private IUnityLevelPlayRewardedVideoManual LevelPlayRewardedVideoAndroidManual;

  [Token(Token = "0x14000081")]
  public static event Action<IronSourceError, IronSourceAdInfo> onAdShowFailedEvent
  {
    [Token(Token = "0x600037C"), Address(RVA = "0x44A7720", Offset = "0x44A7720", VA = "0x44A7720")] add
    {
    }
    [Token(Token = "0x600037D"), Address(RVA = "0x44A77EC", Offset = "0x44A77EC", VA = "0x44A77EC")] remove
    {
    }
  }

  [Token(Token = "0x14000082")]
  public static event Action<IronSourceAdInfo> onAdOpenedEvent
  {
    [Token(Token = "0x600037E"), Address(RVA = "0x44A78B8", Offset = "0x44A78B8", VA = "0x44A78B8")] add
    {
    }
    [Token(Token = "0x600037F"), Address(RVA = "0x44A7988", Offset = "0x44A7988", VA = "0x44A7988")] remove
    {
    }
  }

  [Token(Token = "0x14000083")]
  public static event Action<IronSourceAdInfo> onAdClosedEvent
  {
    [Token(Token = "0x6000380"), Address(RVA = "0x44A7A58", Offset = "0x44A7A58", VA = "0x44A7A58")] add
    {
    }
    [Token(Token = "0x6000381"), Address(RVA = "0x44A7B28", Offset = "0x44A7B28", VA = "0x44A7B28")] remove
    {
    }
  }

  [Token(Token = "0x14000084")]
  public static event Action<IronSourcePlacement, IronSourceAdInfo> onAdRewardedEvent
  {
    [Token(Token = "0x6000382"), Address(RVA = "0x44A7BF8", Offset = "0x44A7BF8", VA = "0x44A7BF8")] add
    {
    }
    [Token(Token = "0x6000383"), Address(RVA = "0x44A7CC8", Offset = "0x44A7CC8", VA = "0x44A7CC8")] remove
    {
    }
  }

  [Token(Token = "0x14000085")]
  public static event Action<IronSourcePlacement, IronSourceAdInfo> onAdClickedEvent
  {
    [Token(Token = "0x6000384"), Address(RVA = "0x44A7D98", Offset = "0x44A7D98", VA = "0x44A7D98")] add
    {
    }
    [Token(Token = "0x6000385"), Address(RVA = "0x44A7E68", Offset = "0x44A7E68", VA = "0x44A7E68")] remove
    {
    }
  }

  [Token(Token = "0x14000086")]
  public static event Action<IronSourceAdInfo> onAdAvailableEvent
  {
    [Token(Token = "0x6000386"), Address(RVA = "0x44A7F38", Offset = "0x44A7F38", VA = "0x44A7F38")] add
    {
    }
    [Token(Token = "0x6000387"), Address(RVA = "0x44A8008", Offset = "0x44A8008", VA = "0x44A8008")] remove
    {
    }
  }

  [Token(Token = "0x14000087")]
  public static event Action onAdUnavailableEvent
  {
    [Token(Token = "0x6000388"), Address(RVA = "0x44A80D8", Offset = "0x44A80D8", VA = "0x44A80D8")] add
    {
    }
    [Token(Token = "0x6000389"), Address(RVA = "0x44A8194", Offset = "0x44A8194", VA = "0x44A8194")] remove
    {
    }
  }

  [Token(Token = "0x14000088")]
  public static event Action<IronSourceError> onAdLoadFailedEvent
  {
    [Token(Token = "0x600038A"), Address(RVA = "0x44A8250", Offset = "0x44A8250", VA = "0x44A8250")] add
    {
    }
    [Token(Token = "0x600038B"), Address(RVA = "0x44A8320", Offset = "0x44A8320", VA = "0x44A8320")] remove
    {
    }
  }

  [Token(Token = "0x14000089")]
  public static event Action<IronSourceAdInfo> onAdReadyEvent
  {
    [Token(Token = "0x600038C"), Address(RVA = "0x44A83F0", Offset = "0x44A83F0", VA = "0x44A83F0")] add
    {
    }
    [Token(Token = "0x600038D"), Address(RVA = "0x44A84C0", Offset = "0x44A84C0", VA = "0x44A84C0")] remove
    {
    }
  }

  [Token(Token = "0x600038E")]
  [Address(RVA = "0x44A8590", Offset = "0x44A8590", VA = "0x44A8590")]
  private void Awake()
  {
  }

  [Token(Token = "0x600038F")]
  [Address(RVA = "0x44A8E3C", Offset = "0x44A8E3C", VA = "0x44A8E3C")]
  private void registerRewardedVideoEvents()
  {
  }

  [Token(Token = "0x6000390")]
  [Address(RVA = "0x44A9A2C", Offset = "0x44A9A2C", VA = "0x44A9A2C")]
  public void registerRewardedVideoManualEvents()
  {
  }

  [Token(Token = "0x6000391")]
  [Address(RVA = "0x44A9C6C", Offset = "0x44A9C6C", VA = "0x44A9C6C")]
  private IronSourceError getErrorFromErrorObject(object descriptionObject)
  {
    return (IronSourceError) null;
  }

  [Token(Token = "0x6000392")]
  [Address(RVA = "0x44A9EFC", Offset = "0x44A9EFC", VA = "0x44A9EFC")]
  private IronSourcePlacement getPlacementFromObject(object placementObject)
  {
    return (IronSourcePlacement) null;
  }

  [Token(Token = "0x6000393")]
  [Address(RVA = "0x44AA14C", Offset = "0x44AA14C", VA = "0x44AA14C")]
  public IronSourceRewardedVideoEvents()
  {
  }
}
