// Decompiled with JetBrains decompiler
// Type: IronSourceConfig
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
[Token(Token = "0x200001F")]
public class IronSourceConfig
{
  [Token(Token = "0x4000068")]
  private const string unsupportedPlatformStr = "Unsupported Platform";
  [Token(Token = "0x4000069")]
  [FieldOffset(Offset = "0x0")]
  private static IronSourceConfig _instance;
  [Token(Token = "0x400006A")]
  [FieldOffset(Offset = "0x8")]
  private static AndroidJavaObject _androidBridge;
  [Token(Token = "0x400006B")]
  [FieldOffset(Offset = "0x10")]
  private static readonly string AndroidBridge;

  [Token(Token = "0x17000016")]
  public static IronSourceConfig Instance
  {
    [Token(Token = "0x600011C"), Address(RVA = "0x2049200", Offset = "0x2049200", VA = "0x2049200")] get
    {
      return (IronSourceConfig) null;
    }
  }

  [Token(Token = "0x600011D")]
  [Address(RVA = "0x20492A8", Offset = "0x20492A8", VA = "0x20492A8")]
  public IronSourceConfig()
  {
  }

  [Token(Token = "0x600011E")]
  [Address(RVA = "0x2049514", Offset = "0x2049514", VA = "0x2049514")]
  public void setLanguage(string language)
  {
  }

  [Token(Token = "0x600011F")]
  [Address(RVA = "0x20495F8", Offset = "0x20495F8", VA = "0x20495F8")]
  public void setClientSideCallbacks(bool status)
  {
  }

  [Token(Token = "0x6000120")]
  [Address(RVA = "0x2049710", Offset = "0x2049710", VA = "0x2049710")]
  public void setRewardedVideoCustomParams(
    Dictionary<string, string> rewardedVideoCustomParams)
  {
  }

  [Token(Token = "0x6000121")]
  [Address(RVA = "0x2049808", Offset = "0x2049808", VA = "0x2049808")]
  public void setOfferwallCustomParams(Dictionary<string, string> offerwallCustomParams)
  {
  }

  [Token(Token = "0x6000122")]
  [Address(RVA = "0x2049900", Offset = "0x2049900", VA = "0x2049900")]
  static IronSourceConfig()
  {
  }
}
