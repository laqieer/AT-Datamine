// Decompiled with JetBrains decompiler
// Type: IronSourceRewardedVideoLevelPlayManualAndroid
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
[Token(Token = "0x200006D")]
public class IronSourceRewardedVideoLevelPlayManualAndroid : 
  AndroidJavaProxy,
  IUnityLevelPlayRewardedVideoManual
{
  [Token(Token = "0x60003CF")]
  [Address(RVA = "0x44A9514", Offset = "0x44A9514", VA = "0x44A9514")]
  public IronSourceRewardedVideoLevelPlayManualAndroid()
  {
  }

  [Token(Token = "0x14000091")]
  public event Action<IronSourceError> OnAdLoadFailed
  {
    [Token(Token = "0x60003D0"), Address(RVA = "0x44ABD44", Offset = "0x44ABD44", VA = "0x44ABD44", Slot = "11")] add
    {
    }
    [Token(Token = "0x60003D1"), Address(RVA = "0x44ABDF4", Offset = "0x44ABDF4", VA = "0x44ABDF4", Slot = "12")] remove
    {
    }
  }

  [Token(Token = "0x14000092")]
  public event Action<IronSourceAdInfo> OnAdReady
  {
    [Token(Token = "0x60003D2"), Address(RVA = "0x44ABEA4", Offset = "0x44ABEA4", VA = "0x44ABEA4", Slot = "9")] add
    {
    }
    [Token(Token = "0x60003D3"), Address(RVA = "0x44ABF54", Offset = "0x44ABF54", VA = "0x44ABF54", Slot = "10")] remove
    {
    }
  }

  [Token(Token = "0x60003D4")]
  [Address(RVA = "0x44AC004", Offset = "0x44AC004", VA = "0x44AC004")]
  private void onAdReady(string data)
  {
  }

  [Token(Token = "0x60003D5")]
  [Address(RVA = "0x44AC094", Offset = "0x44AC094", VA = "0x44AC094")]
  private void onAdLoadFailed(string args)
  {
  }
}
