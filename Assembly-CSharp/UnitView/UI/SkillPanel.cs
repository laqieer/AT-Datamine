// Decompiled with JetBrains decompiler
// Type: UnitView.UI.SkillPanel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace UnitView.UI
{
  [Token(Token = "0x2000409")]
  [Serializable]
  public class SkillPanel
  {
    [Token(Token = "0x4001708")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private Image basicSkills;
    [Token(Token = "0x4001709")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Image customSkills;

    [Token(Token = "0x60016FE")]
    [Address(RVA = "0x248A124", Offset = "0x248A124", VA = "0x248A124")]
    public void Update(SkillPanel.IProperty property)
    {
    }

    [Token(Token = "0x60016FF")]
    [Address(RVA = "0x248A258", Offset = "0x248A258", VA = "0x248A258")]
    public SkillPanel()
    {
    }

    [Token(Token = "0x200040A")]
    public interface IProperty
    {
      [Token(Token = "0x1700028D")]
      Sprite BasicSkills { [Token(Token = "0x6001700")] get; }

      [Token(Token = "0x1700028E")]
      Sprite CustomSkills { [Token(Token = "0x6001701")] get; }
    }
  }
}
