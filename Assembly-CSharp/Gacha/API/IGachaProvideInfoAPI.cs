// Decompiled with JetBrains decompiler
// Type: Gacha.API.IGachaProvideInfoAPI
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace Gacha.API
{
  [Token(Token = "0x20015AF")]
  public interface IGachaProvideInfoAPI
  {
    [Token(Token = "0x6007AC4")]
    void RequestProvideInfo(GachaProvideInfoRequest request, Action<string, string> onSuccess);
  }
}
