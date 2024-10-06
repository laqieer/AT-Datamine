// Decompiled with JetBrains decompiler
// Type: IUnityLevelPlayRewardedVideoManual
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
[Token(Token = "0x200007D")]
public interface IUnityLevelPlayRewardedVideoManual
{
  [Token(Token = "0x140000C1")]
  event Action<IronSourceAdInfo> OnAdReady;

  [Token(Token = "0x140000C2")]
  event Action<IronSourceError> OnAdLoadFailed;
}
