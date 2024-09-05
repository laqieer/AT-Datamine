// Decompiled with JetBrains decompiler
// Type: Battle.Unit.IBarrier
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace Battle.Unit
{
  [Token(Token = "0x20022EE")]
  public interface IBarrier : IDisposable
  {
    [Token(Token = "0x600D5A6")]
    void Show();

    [Token(Token = "0x600D5A7")]
    void Hide();

    [Token(Token = "0x600D5A8")]
    void UpdateCrack(float hpRate);

    [Token(Token = "0x600D5A9")]
    void UpdatePosition(Vector3 position);

    [Token(Token = "0x600D5AA")]
    void Revival();
  }
}
