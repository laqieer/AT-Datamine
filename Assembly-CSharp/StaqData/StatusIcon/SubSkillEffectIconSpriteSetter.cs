// Decompiled with JetBrains decompiler
// Type: StaqData.StatusIcon.SubSkillEffectIconSpriteSetter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace StaqData.StatusIcon
{
  [Token(Token = "0x200216A")]
  [Serializable]
  public class SubSkillEffectIconSpriteSetter : SpriteParamSetter<SubSkillEffectIconParam>
  {
    [Token(Token = "0x4008D79")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    [HideInInspector]
    private List<SubSkillEffectIconParam> spriteParams;

    [Token(Token = "0x17002CE6")]
    protected override string SpriteIdentityToken
    {
      [Token(Token = "0x600CCBE"), Address(RVA = "0x1BB16C4", Offset = "0x1BB16C4", VA = "0x1BB16C4", Slot = "4")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x600CCBF")]
    [Address(RVA = "0x1BB1704", Offset = "0x1BB1704", VA = "0x1BB1704", Slot = "5")]
    public override IReadOnlyList<SubSkillEffectIconParam> GetParams()
    {
      return (IReadOnlyList<SubSkillEffectIconParam>) null;
    }

    [Token(Token = "0x600CCC0")]
    [Address(RVA = "0x1BB170C", Offset = "0x1BB170C", VA = "0x1BB170C")]
    public SubSkillEffectIconSpriteSetter()
    {
    }
  }
}
