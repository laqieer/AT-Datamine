// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.Common.SafeObjectCallback
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace Scenes.OutGame.Common
{
  [Token(Token = "0x2003704")]
  public class SafeObjectCallback
  {
    [Token(Token = "0x400F03A")]
    [FieldOffset(Offset = "0x10")]
    private readonly GameObject gameObject;
    [Token(Token = "0x400F03B")]
    [FieldOffset(Offset = "0x18")]
    private readonly Action callback;

    [Token(Token = "0x6015AB1")]
    [Address(RVA = "0x1D85108", Offset = "0x1D85108", VA = "0x1D85108")]
    public SafeObjectCallback(GameObject target, Action callback)
    {
    }

    [Token(Token = "0x6015AB2")]
    [Address(RVA = "0x1D85134", Offset = "0x1D85134", VA = "0x1D85134")]
    public SafeObjectCallback(MonoBehaviour target, Action callback)
    {
    }

    [Token(Token = "0x6015AB3")]
    [Address(RVA = "0x1D85174", Offset = "0x1D85174", VA = "0x1D85174")]
    public void Invoke()
    {
    }
  }
}
