// Decompiled with JetBrains decompiler
// Type: Battle.UI.UnitStatusSkillFactor
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data.Board;
using Il2CppDummyDll;
using System;
using System.Text;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Battle.UI
{
  [Token(Token = "0x200235B")]
  public sealed class UnitStatusSkillFactor : UnitStatusFactorBase
  {
    [Token(Token = "0x400963B")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private UnitStatusSkillFactor.UnitStatusSkillUISet[] activeSkills;
    [Token(Token = "0x400963C")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private UnitStatusSkillFactor.UnitStatusSkillUISet stratagem;
    [Token(Token = "0x400963D")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private Color defaultColor;
    [Token(Token = "0x400963E")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    private Color disableColor;
    [Token(Token = "0x400963F")]
    [FieldOffset(Offset = "0x78")]
    private StringBuilder descBuilder;

    [Token(Token = "0x600D7E1")]
    [Address(RVA = "0x1B8D574", Offset = "0x1B8D574", VA = "0x1B8D574", Slot = "4")]
    public override void Initialize(UnitStatusFactorBase.Context context)
    {
    }

    [Token(Token = "0x600D7E2")]
    [Address(RVA = "0x1B8D6A0", Offset = "0x1B8D6A0", VA = "0x1B8D6A0", Slot = "5")]
    public override void Set(UnitParameterData unit, BattlePlayerData owner)
    {
    }

    [Token(Token = "0x600D7E3")]
    [Address(RVA = "0x1B8D798", Offset = "0x1B8D798", VA = "0x1B8D798")]
    private void SetTo(
      UnitStatusSkillFactor.UnitStatusSkillUISet ui,
      UnitParameterData unit,
      SkillParameterData skill)
    {
    }

    [Token(Token = "0x600D7E4")]
    [Address(RVA = "0x1B8DB58", Offset = "0x1B8DB58", VA = "0x1B8DB58")]
    public UnitStatusSkillFactor()
    {
    }

    [Token(Token = "0x200235C")]
    [Serializable]
    private class UnitStatusSkillUISet
    {
      [Token(Token = "0x4009640")]
      [FieldOffset(Offset = "0x10")]
      public GameObject root;
      [Token(Token = "0x4009641")]
      [FieldOffset(Offset = "0x18")]
      public Image skillColorImage;
      [Token(Token = "0x4009642")]
      [FieldOffset(Offset = "0x20")]
      public UnityEngine.UI.Text name;
      [Token(Token = "0x4009643")]
      [FieldOffset(Offset = "0x28")]
      public UnityEngine.UI.Text description;

      [Token(Token = "0x600D7E5")]
      [Address(RVA = "0x1B8DBD8", Offset = "0x1B8DBD8", VA = "0x1B8DBD8")]
      public UnitStatusSkillUISet()
      {
      }
    }
  }
}
