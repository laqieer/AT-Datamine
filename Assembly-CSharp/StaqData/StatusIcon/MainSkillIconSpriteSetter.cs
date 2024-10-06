// Decompiled with JetBrains decompiler
// Type: StaqData.StatusIcon.MainSkillIconSpriteSetter
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
  [Token(Token = "0x2002165")]
  [Serializable]
  public class MainSkillIconSpriteSetter : SpriteParamSetter<MainSkillIconParam>
  {
    [Token(Token = "0x4008D71")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    [HideInInspector]
    private List<MainSkillIconParam> spriteParams;

    [Token(Token = "0x17002CE0")]
    protected override string SpriteIdentityToken
    {
      [Token(Token = "0x600CCB0"), Address(RVA = "0x1BB15C8", Offset = "0x1BB15C8", VA = "0x1BB15C8", Slot = "4")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x600CCB1")]
    [Address(RVA = "0x1BB1608", Offset = "0x1BB1608", VA = "0x1BB1608", Slot = "5")]
    public override IReadOnlyList<MainSkillIconParam> GetParams()
    {
      return (IReadOnlyList<MainSkillIconParam>) null;
    }

    [Token(Token = "0x600CCB2")]
    [Address(RVA = "0x1BB1610", Offset = "0x1BB1610", VA = "0x1BB1610")]
    public MainSkillIconSpriteSetter()
    {
    }
  }
}
