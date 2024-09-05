// Decompiled with JetBrains decompiler
// Type: IUnityOfferwall
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
[Token(Token = "0x200007E")]
public interface IUnityOfferwall
{
  [Token(Token = "0x140000C3")]
  event Action<IronSourceError> OnOfferwallShowFailed;

  [Token(Token = "0x140000C4")]
  event Action OnOfferwallOpened;

  [Token(Token = "0x140000C5")]
  event Action OnOfferwallClosed;

  [Token(Token = "0x140000C6")]
  event Action<IronSourceError> OnGetOfferwallCreditsFailed;

  [Token(Token = "0x140000C7")]
  event Action<Dictionary<string, object>> OnOfferwallAdCredited;

  [Token(Token = "0x140000C8")]
  event Action<bool> OnOfferwallAvailable;
}
