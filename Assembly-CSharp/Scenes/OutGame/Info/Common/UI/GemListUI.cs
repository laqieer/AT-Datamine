// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.Info.Common.UI.GemListUI
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace Scenes.OutGame.Info.Common.UI
{
  [Token(Token = "0x20035EC")]
  [Serializable]
  public class GemListUI
  {
    [Token(Token = "0x400EA8F")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private GameObject deactiveGemRoot;
    [Token(Token = "0x400EA90")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private GameObject activeGemRoot;
    [Token(Token = "0x400EA91")]
    [FieldOffset(Offset = "0x20")]
    private List<GameObject> deactiveGems;
    [Token(Token = "0x400EA92")]
    [FieldOffset(Offset = "0x28")]
    private List<GameObject> activeGems;

    [Token(Token = "0x60153AB")]
    [Address(RVA = "0x4D8CCC0", Offset = "0x4D8CCC0", VA = "0x4D8CCC0")]
    public void Initialize()
    {
    }

    [Token(Token = "0x60153AC")]
    [Address(RVA = "0x4D8D354", Offset = "0x4D8D354", VA = "0x4D8D354")]
    public void Set(int num)
    {
    }

    [Token(Token = "0x60153AD")]
    [Address(RVA = "0x4D8D4B4", Offset = "0x4D8D4B4", VA = "0x4D8D4B4")]
    public void SetMax(int num)
    {
    }

    [Token(Token = "0x60153AE")]
    [Address(RVA = "0x4D8D614", Offset = "0x4D8D614", VA = "0x4D8D614")]
    public GemListUI()
    {
    }
  }
}
