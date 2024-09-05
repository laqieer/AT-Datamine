// Decompiled with JetBrains decompiler
// Type: Home.Guild.IShowToaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace Home.Guild
{
  [Token(Token = "0x2000B62")]
  internal interface IShowToaster
  {
    [Token(Token = "0x60040CE")]
    void Show(Action onFinish = null);
  }
}
