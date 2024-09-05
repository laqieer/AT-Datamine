// Decompiled with JetBrains decompiler
// Type: Battle.UI.ElementIconSpriteSetter
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
  [Token(Token = "0x200242F")]
  [Serializable]
  internal class ElementIconSpriteSetter : SpriteParamSetter<ElementIconParam>
  {
    [Token(Token = "0x4009AD7")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    [HideInInspector]
    private List<ElementIconParam> spriteParams;

    [Token(Token = "0x17002FA5")]
    protected override string SpriteIdentityToken
    {
      [Token(Token = "0x600DDB7"), Address(RVA = "0x1E2B244", Offset = "0x1E2B244", VA = "0x1E2B244", Slot = "4")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x600DDB8")]
    [Address(RVA = "0x1E2B28C", Offset = "0x1E2B28C", VA = "0x1E2B28C", Slot = "5")]
    public override IReadOnlyList<ElementIconParam> GetParams()
    {
      return (IReadOnlyList<ElementIconParam>) null;
    }

    [Token(Token = "0x600DDB9")]
    [Address(RVA = "0x1E2B294", Offset = "0x1E2B294", VA = "0x1E2B294")]
    public ElementIconSpriteSetter()
    {
    }
  }
}
