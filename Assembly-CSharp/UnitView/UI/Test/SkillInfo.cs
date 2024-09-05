// Decompiled with JetBrains decompiler
// Type: UnitView.UI.Test.SkillInfo
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace UnitView.UI.Test
{
  [Token(Token = "0x200040B")]
  [Serializable]
  public class SkillInfo : SkillPanel.IProperty
  {
    [Token(Token = "0x400170A")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private Sprite basicSkills;
    [Token(Token = "0x400170B")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Sprite customSkills;

    [Token(Token = "0x1700028F")]
    public Sprite BasicSkills
    {
      [Token(Token = "0x6001702"), Address(RVA = "0x248A260", Offset = "0x248A260", VA = "0x248A260", Slot = "4")] get
      {
        return (Sprite) null;
      }
    }

    [Token(Token = "0x17000290")]
    public Sprite CustomSkills
    {
      [Token(Token = "0x6001703"), Address(RVA = "0x248A268", Offset = "0x248A268", VA = "0x248A268", Slot = "5")] get
      {
        return (Sprite) null;
      }
    }

    [Token(Token = "0x6001704")]
    [Address(RVA = "0x248A270", Offset = "0x248A270", VA = "0x248A270")]
    public SkillInfo()
    {
    }
  }
}
