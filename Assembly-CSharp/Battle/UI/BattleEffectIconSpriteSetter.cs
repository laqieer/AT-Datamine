// Decompiled with JetBrains decompiler
// Type: Battle.UI.BattleEffectIconSpriteSetter
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
  [Token(Token = "0x200242D")]
  [Serializable]
  internal class BattleEffectIconSpriteSetter : SpriteParamSetter<BattleEffectIconParam>
  {
    [Token(Token = "0x4009AD4")]
    [FieldOffset(Offset = "0x20")]
    [HideInInspector]
    [SerializeField]
    private List<BattleEffectIconParam> spriteParams;

    [Token(Token = "0x17002FA2")]
    protected override string SpriteIdentityToken
    {
      [Token(Token = "0x600DDB1"), Address(RVA = "0x1E2B194", Offset = "0x1E2B194", VA = "0x1E2B194", Slot = "4")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x600DDB2")]
    [Address(RVA = "0x1E2B1DC", Offset = "0x1E2B1DC", VA = "0x1E2B1DC", Slot = "5")]
    public override IReadOnlyList<BattleEffectIconParam> GetParams()
    {
      return (IReadOnlyList<BattleEffectIconParam>) null;
    }

    [Token(Token = "0x600DDB3")]
    [Address(RVA = "0x1E2B1E4", Offset = "0x1E2B1E4", VA = "0x1E2B1E4")]
    public BattleEffectIconSpriteSetter()
    {
    }
  }
}
