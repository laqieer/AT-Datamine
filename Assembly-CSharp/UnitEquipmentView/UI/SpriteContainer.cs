// Decompiled with JetBrains decompiler
// Type: UnitEquipmentView.UI.SpriteContainer
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace UnitEquipmentView.UI
{
  [Token(Token = "0x2000455")]
  [Serializable]
  public class SpriteContainer
  {
    [Token(Token = "0x40017E5")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private List<Sprite> sprites;

    [Token(Token = "0x6001896")]
    [Address(RVA = "0x248FF0C", Offset = "0x248FF0C", VA = "0x248FF0C")]
    public Sprite Random() => (Sprite) null;

    [Token(Token = "0x6001897")]
    [Address(RVA = "0x24913F0", Offset = "0x24913F0", VA = "0x24913F0")]
    public SpriteContainer()
    {
    }
  }
}
