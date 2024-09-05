// Decompiled with JetBrains decompiler
// Type: Gacha.API.IGachaListAPI
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using StaqData;
using System;

#nullable disable
namespace Gacha.API
{
  [Token(Token = "0x20015AB")]
  internal interface IGachaListAPI
  {
    [Token(Token = "0x6007AB7")]
    void RequestGachaList(Action<GachaListInfo> onSuccess, Action onError);
  }
}
