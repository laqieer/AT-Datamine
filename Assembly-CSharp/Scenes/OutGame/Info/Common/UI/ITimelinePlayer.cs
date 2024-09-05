// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.Info.Common.UI.ITimelinePlayer
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace Scenes.OutGame.Info.Common.UI
{
  [Token(Token = "0x20035DE")]
  public interface ITimelinePlayer
  {
    [Token(Token = "0x6015377")]
    void Open(Action onFinish);

    [Token(Token = "0x6015378")]
    void Close(Action onFinish);
  }
}
