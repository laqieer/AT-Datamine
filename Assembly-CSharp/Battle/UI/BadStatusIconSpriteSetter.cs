// Decompiled with JetBrains decompiler
// Type: Battle.UI.BadStatusIconSpriteSetter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using StaqData;
using System;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace Battle.UI
{
  [Token(Token = "0x200242B")]
  [Serializable]
  internal class BadStatusIconSpriteSetter : SpriteParamSetter<BadStatusIconParam>
  {
    [Token(Token = "0x4009AD0")]
    [FieldOffset(Offset = "0x20")]
    [HideInInspector]
    [SerializeField]
    private List<BadStatusIconParam> spriteParams;

    [Token(Token = "0x17002F9E")]
    protected override string SpriteIdentityToken
    {
      [Token(Token = "0x600DDA9"), Address(RVA = "0x1E2B0D4", Offset = "0x1E2B0D4", VA = "0x1E2B0D4", Slot = "4")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x600DDAA")]
    [Address(RVA = "0x1E2B11C", Offset = "0x1E2B11C", VA = "0x1E2B11C", Slot = "5")]
    public override IReadOnlyList<BadStatusIconParam> GetParams()
    {
      return (IReadOnlyList<BadStatusIconParam>) null;
    }

    [Token(Token = "0x600DDAB")]
    [Address(RVA = "0x1E2B124", Offset = "0x1E2B124", VA = "0x1E2B124")]
    public BadStatusIconSpriteSetter()
    {
    }
  }
}
