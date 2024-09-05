// Decompiled with JetBrains decompiler
// Type: Battle.UI.WeaponTypeIconSpriteSetter
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
  [Token(Token = "0x2002431")]
  [Serializable]
  internal class WeaponTypeIconSpriteSetter : SpriteParamSetter<WeaponTypeIconParam>
  {
    [Token(Token = "0x4009ADA")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    [HideInInspector]
    private List<WeaponTypeIconParam> spriteParams;

    [Token(Token = "0x17002FA8")]
    protected override string SpriteIdentityToken
    {
      [Token(Token = "0x600DDBD"), Address(RVA = "0x1E2B2F4", Offset = "0x1E2B2F4", VA = "0x1E2B2F4", Slot = "4")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x600DDBE")]
    [Address(RVA = "0x1E2B33C", Offset = "0x1E2B33C", VA = "0x1E2B33C", Slot = "5")]
    public override IReadOnlyList<WeaponTypeIconParam> GetParams()
    {
      return (IReadOnlyList<WeaponTypeIconParam>) null;
    }

    [Token(Token = "0x600DDBF")]
    [Address(RVA = "0x1E2B344", Offset = "0x1E2B344", VA = "0x1E2B344")]
    public WeaponTypeIconSpriteSetter()
    {
    }
  }
}
