// Decompiled with JetBrains decompiler
// Type: IronSourceRewardedVideoManualAndroid
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
[Token(Token = "0x200006F")]
public class IronSourceRewardedVideoManualAndroid : AndroidJavaProxy, IUnityRewardedVideoManual
{
  [Token(Token = "0x60003DA")]
  [Address(RVA = "0x44AC14C", Offset = "0x44AC14C", VA = "0x44AC14C")]
  public IronSourceRewardedVideoManualAndroid()
  {
  }

  [Token(Token = "0x14000093")]
  public event Action<IronSourceError> OnRewardedVideoAdLoadFailed
  {
    [Token(Token = "0x60003DB"), Address(RVA = "0x44AC664", Offset = "0x44AC664", VA = "0x44AC664", Slot = "11")] add
    {
    }
    [Token(Token = "0x60003DC"), Address(RVA = "0x44AC714", Offset = "0x44AC714", VA = "0x44AC714", Slot = "12")] remove
    {
    }
  }

  [Token(Token = "0x14000094")]
  public event Action OnRewardedVideoAdReady
  {
    [Token(Token = "0x60003DD"), Address(RVA = "0x44AC7C4", Offset = "0x44AC7C4", VA = "0x44AC7C4", Slot = "9")] add
    {
    }
    [Token(Token = "0x60003DE"), Address(RVA = "0x44AC860", Offset = "0x44AC860", VA = "0x44AC860", Slot = "10")] remove
    {
    }
  }

  [Token(Token = "0x60003DF")]
  [Address(RVA = "0x44AC8FC", Offset = "0x44AC8FC", VA = "0x44AC8FC")]
  private void onRewardedVideoAdReady()
  {
  }

  [Token(Token = "0x60003E0")]
  [Address(RVA = "0x44AC918", Offset = "0x44AC918", VA = "0x44AC918")]
  private void onRewardedVideoAdLoadFailed(string args)
  {
  }
}
