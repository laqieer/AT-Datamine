// Decompiled with JetBrains decompiler
// Type: ISAdQualityAndroidInitHandler
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;
using UnityEngine.Scripting;

#nullable disable
[Token(Token = "0x2000087")]
[Preserve]
public class ISAdQualityAndroidInitHandler : AndroidJavaProxy
{
  [Token(Token = "0x4000240")]
  private const string IRON_SOURCE_AD_QUALITY_CLASS = "com.ironsource.adqualitysdk.sdk.unity.IronSourceAdQuality";
  [Token(Token = "0x4000241")]
  private const string UNITY_IS_AD_QUALITY_INIT_LISTENER = "com.ironsource.adqualitysdk.sdk.unity.UnityISAdQualityInitListener";

  [Token(Token = "0x140000DB")]
  public event Action OnAdQualitySdkInitSuccess
  {
    [Token(Token = "0x60004CE"), Address(RVA = "0x44AF7E4", Offset = "0x44AF7E4", VA = "0x44AF7E4")] add
    {
    }
    [Token(Token = "0x60004CF"), Address(RVA = "0x44AF880", Offset = "0x44AF880", VA = "0x44AF880")] remove
    {
    }
  }

  [Token(Token = "0x140000DC")]
  public event Action<ISAdQualityInitError, string> OnAdQualitySdkInitFailed
  {
    [Token(Token = "0x60004D0"), Address(RVA = "0x44AF91C", Offset = "0x44AF91C", VA = "0x44AF91C")] add
    {
    }
    [Token(Token = "0x60004D1"), Address(RVA = "0x44AF9CC", Offset = "0x44AF9CC", VA = "0x44AF9CC")] remove
    {
    }
  }

  [Token(Token = "0x60004D2")]
  [Address(RVA = "0x44AFA7C", Offset = "0x44AFA7C", VA = "0x44AFA7C")]
  public ISAdQualityAndroidInitHandler()
  {
  }

  [Token(Token = "0x60004D3")]
  [Address(RVA = "0x44AFEF4", Offset = "0x44AFEF4", VA = "0x44AFEF4")]
  [Preserve]
  public void adQualitySdkInitSuccess()
  {
  }

  [Token(Token = "0x60004D4")]
  [Address(RVA = "0x44AFF10", Offset = "0x44AFF10", VA = "0x44AFF10")]
  [Preserve]
  public void adQualitySdkInitFailed(int adQualitySdkInitError, string errorMessage)
  {
  }
}
