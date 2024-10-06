// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.Utility.IInOutFader
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace Scenes.OutGame.Utility
{
  [Token(Token = "0x20032C0")]
  public interface IInOutFader
  {
    [Token(Token = "0x6013DDD")]
    void Initialize(Action onFinish = null);

    [Token(Token = "0x6013DDE")]
    void Open(Action onFinish = null);

    [Token(Token = "0x6013DDF")]
    void Close(Action onFinish = null);
  }
}
