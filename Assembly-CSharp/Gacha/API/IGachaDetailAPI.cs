// Decompiled with JetBrains decompiler
// Type: Gacha.API.IGachaDetailAPI
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using StaqData;
using System;

#nullable disable
namespace Gacha.API
{
  [Token(Token = "0x20015A9")]
  internal interface IGachaDetailAPI
  {
    [Token(Token = "0x6007AAE")]
    void RequestGachaDetail(
      GachaDetailRequest reequest,
      Action<GachaDetailGroupInfo> onSuccess,
      Action onError);
  }
}
