// Decompiled with JetBrains decompiler
// Type: UnitDetail.Viewer.IPlayableViewerAnimation
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace UnitDetail.Viewer
{
  [Token(Token = "0x20004B4")]
  public interface IPlayableViewerAnimation
  {
    [Token(Token = "0x1700033D")]
    string IdleStateName { [Token(Token = "0x6001A82")] get; }

    [Token(Token = "0x6001A83")]
    void PlayAnimation(string stateName, Action endAnimationCallback);

    [Token(Token = "0x6001A84")]
    void CrossFade(string stateName);
  }
}
