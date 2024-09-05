// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.Info.Style.StyleModel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Scenes.OutGame.Info.Common;
using Scenes.OutGame.Info.Skill;
using Scenes.OutGame.Info.Unit;
using StaqData;
using System;
using System.Collections.Generic;

#nullable disable
namespace Scenes.OutGame.Info.Style
{
  [Token(Token = "0x2003554")]
  public class StyleModel : StyleModelBase
  {
    [Token(Token = "0x400E7F3")]
    [FieldOffset(Offset = "0x78")]
    private SkillModelList styleSkills;
    [Token(Token = "0x400E7F4")]
    [FieldOffset(Offset = "0x80")]
    private SkillModelList unlockedStyleSkills;
    [Token(Token = "0x400E7F5")]
    [FieldOffset(Offset = "0x88")]
    private SkillModelList commuSkills;
    [Token(Token = "0x400E7F6")]
    [FieldOffset(Offset = "0x90")]
    private SkillModelList unlockedCommuSkills;
    [Token(Token = "0x400E7F9")]
    [FieldOffset(Offset = "0xA8")]
    private AdditionalParameterModel additionalParameterModel;

    [Token(Token = "0x1700457E")]
    public ParameterModel StyleParameterModel
    {
      [Token(Token = "0x6014EFA"), Address(RVA = "0x1B4BF3C", Offset = "0x1B4BF3C", VA = "0x1B4BF3C")] get
      {
        return (ParameterModel) null;
      }
    }

    [Token(Token = "0x1700457F")]
    public ParameterModel EquippedStyleParameter
    {
      [Token(Token = "0x6014EFB"), Address(RVA = "0x1B4BF44", Offset = "0x1B4BF44", VA = "0x1B4BF44")] get
      {
        return (ParameterModel) null;
      }
    }

    [Token(Token = "0x17004580")]
    public override AdditionalParameterModelBase AdditionalParameter
    {
      [Token(Token = "0x6014EFC"), Address(RVA = "0x1B4BF4C", Offset = "0x1B4BF4C", VA = "0x1B4BF4C", Slot = "4")] get
      {
        return (AdditionalParameterModelBase) null;
      }
    }

    [Token(Token = "0x17004581")]
    public override SkillModelListBase StyleSkills
    {
      [Token(Token = "0x6014EFD"), Address(RVA = "0x1B4BF54", Offset = "0x1B4BF54", VA = "0x1B4BF54", Slot = "5")] get
      {
        return (SkillModelListBase) null;
      }
    }

    [Token(Token = "0x17004582")]
    public override SkillModelListBase UnlockedStyleSkills
    {
      [Token(Token = "0x6014EFE"), Address(RVA = "0x1B4BF5C", Offset = "0x1B4BF5C", VA = "0x1B4BF5C", Slot = "6")] get
      {
        return (SkillModelListBase) null;
      }
    }

    [Token(Token = "0x17004583")]
    public override SkillModelListBase CommuSkills
    {
      [Token(Token = "0x6014EFF"), Address(RVA = "0x1B4BF64", Offset = "0x1B4BF64", VA = "0x1B4BF64", Slot = "7")] get
      {
        return (SkillModelListBase) null;
      }
    }

    [Token(Token = "0x17004584")]
    public override SkillModelListBase UnlockedCommuSkills
    {
      [Token(Token = "0x6014F00"), Address(RVA = "0x1B4BF6C", Offset = "0x1B4BF6C", VA = "0x1B4BF6C", Slot = "8")] get
      {
        return (SkillModelListBase) null;
      }
    }

    [Token(Token = "0x1400020D")]
    public override event Action OnChange
    {
      [Token(Token = "0x6014F01"), Address(RVA = "0x1B4BF74", Offset = "0x1B4BF74", VA = "0x1B4BF74", Slot = "9")] add
      {
      }
      [Token(Token = "0x6014F02"), Address(RVA = "0x1B4C010", Offset = "0x1B4C010", VA = "0x1B4C010", Slot = "10")] remove
      {
      }
    }

    [Token(Token = "0x6014F03")]
    [Address(RVA = "0x1B43138", Offset = "0x1B43138", VA = "0x1B43138")]
    public void Set(UniqueID uniqueID, UnitModel unitModel = null)
    {
    }

    [Token(Token = "0x6014F04")]
    [Address(RVA = "0x1B432BC", Offset = "0x1B432BC", VA = "0x1B432BC")]
    public void Set(StaqData.Style style, UnitModel unitModel = null, List<CommunicationSkill> communicationSkills = null)
    {
    }

    [Token(Token = "0x6014F05")]
    [Address(RVA = "0x1B44660", Offset = "0x1B44660", VA = "0x1B44660")]
    public StyleModel()
    {
    }
  }
}
