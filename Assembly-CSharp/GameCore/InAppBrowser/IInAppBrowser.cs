// Decompiled with JetBrains decompiler
// Type: GameCore.InAppBrowser.IInAppBrowser
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace GameCore.InAppBrowser
{
  [Token(Token = "0x2001459")]
  public interface IInAppBrowser : IDisposable
  {
    [Token(Token = "0x60072C2")]
    void Open(in string url, in string callbackUrlScheme);
  }
}
