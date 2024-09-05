// Decompiled with JetBrains decompiler
// Type: Battle.UI.UnitPanelViewModel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using Scenes.OutGame.Info.Common;
using Scenes.OutGame.Info.Skill;
using Scenes.OutGame.Info.Unit;
using System;
using System.Collections.Generic;
using TeamOrganization;
using UnityEngine;

#nullable disable
namespace Battle.UI
{
  [Token(Token = "0x20023AB")]
  public class UnitPanelViewModel
  {
    [Token(Token = "0x40097F7")]
    [FieldOffset(Offset = "0x48")]
    private List<GameObject> addedInstances;
    [Token(Token = "0x40097F8")]
    [FieldOffset(Offset = "0x50")]
    private List<SkillView> addedSkills;
    [Token(Token = "0x40097F9")]
    [FieldOffset(Offset = "0x58")]
    private int skillSiblingIndex;
    [Token(Token = "0x40097FA")]
    private const int MaxTypeIconNum = 3;

    [Token(Token = "0x17002F10")]
    public UnitPanelModel Model
    {
      [Token(Token = "0x600DA33"), Address(RVA = "0x22D5398", Offset = "0x22D5398", VA = "0x22D5398")] private get
      {
        return (UnitPanelModel) null;
      }
      [Token(Token = "0x600DA34"), Address(RVA = "0x22D53A0", Offset = "0x22D53A0", VA = "0x22D53A0")] set
      {
      }
    }

    [Token(Token = "0x17002F11")]
    public UnitPanelUI.UnitPanelView View
    {
      [Token(Token = "0x600DA35"), Address(RVA = "0x22D53A8", Offset = "0x22D53A8", VA = "0x22D53A8")] private get
      {
        return (UnitPanelUI.UnitPanelView) null;
      }
      [Token(Token = "0x600DA36"), Address(RVA = "0x22D53B0", Offset = "0x22D53B0", VA = "0x22D53B0")] set
      {
      }
    }

    [Token(Token = "0x17002F12")]
    public Action<StyleModel> OnClickStyle
    {
      [Token(Token = "0x600DA37"), Address(RVA = "0x22D53B8", Offset = "0x22D53B8", VA = "0x22D53B8")] private get
      {
        return (Action<StyleModel>) null;
      }
      [Token(Token = "0x600DA38"), Address(RVA = "0x22D53C0", Offset = "0x22D53C0", VA = "0x22D53C0")] set
      {
      }
    }

    [Token(Token = "0x17002F13")]
    public Action<IEquipmentModel> OnClickEquipment
    {
      [Token(Token = "0x600DA39"), Address(RVA = "0x22D53C8", Offset = "0x22D53C8", VA = "0x22D53C8")] private get
      {
        return (Action<IEquipmentModel>) null;
      }
      [Token(Token = "0x600DA3A"), Address(RVA = "0x22D53D0", Offset = "0x22D53D0", VA = "0x22D53D0")] set
      {
      }
    }

    [Token(Token = "0x17002F14")]
    public Action<SkillModelBase> OnClickSkill
    {
      [Token(Token = "0x600DA3B"), Address(RVA = "0x22D53D8", Offset = "0x22D53D8", VA = "0x22D53D8")] private get
      {
        return (Action<SkillModelBase>) null;
      }
      [Token(Token = "0x600DA3C"), Address(RVA = "0x22D53E0", Offset = "0x22D53E0", VA = "0x22D53E0")] set
      {
      }
    }

    [Token(Token = "0x17002F15")]
    public Action<int> OnClickSelectUnit
    {
      [Token(Token = "0x600DA3D"), Address(RVA = "0x22D53E8", Offset = "0x22D53E8", VA = "0x22D53E8")] private get
      {
        return (Action<int>) null;
      }
      [Token(Token = "0x600DA3E"), Address(RVA = "0x22D53F0", Offset = "0x22D53F0", VA = "0x22D53F0")] set
      {
      }
    }

    [Token(Token = "0x17002F16")]
    public Action<StatusConditionModel[]> OnClickConditionDetail
    {
      [Token(Token = "0x600DA3F"), Address(RVA = "0x22D53F8", Offset = "0x22D53F8", VA = "0x22D53F8")] private get
      {
        return (Action<StatusConditionModel[]>) null;
      }
      [Token(Token = "0x600DA40"), Address(RVA = "0x22D5400", Offset = "0x22D5400", VA = "0x22D5400")] set
      {
      }
    }

    [Token(Token = "0x600DA41")]
    [Address(RVA = "0x22D5408", Offset = "0x22D5408", VA = "0x22D5408")]
    public void OnChange()
    {
    }

    [Token(Token = "0x600DA42")]
    [Address(RVA = "0x22D6204", Offset = "0x22D6204", VA = "0x22D6204")]
    private void SetKillersIcon(UnitPanelUI.UnitPanelView view, Sprite obj)
    {
    }

    [Token(Token = "0x600DA43")]
    [Address(RVA = "0x22D629C", Offset = "0x22D629C", VA = "0x22D629C")]
    private void SetAllParameter(ParameterView view, ParameterModelBase param)
    {
    }

    [Token(Token = "0x600DA44")]
    [Address(RVA = "0x22D687C", Offset = "0x22D687C", VA = "0x22D687C")]
    private void SetAdditionalParameter(UnitModelBase model)
    {
    }

    [Token(Token = "0x600DA45")]
    [Address(RVA = "0x22D7480", Offset = "0x22D7480", VA = "0x22D7480")]
    private void SetAdditionalParameters(
      AdditionalParameterView view,
      AdditionalParameterType additionalParameterType,
      int index)
    {
    }

    [Token(Token = "0x600DA46")]
    [Address(RVA = "0x22D697C", Offset = "0x22D697C", VA = "0x22D697C")]
    private void SetSkills(UnitPanelUI.UnitPanelView view, UnitModelBase model)
    {
    }

    [Token(Token = "0x600DA47")]
    [Address(RVA = "0x22D7D20", Offset = "0x22D7D20", VA = "0x22D7D20")]
    private void SetSkill(SkillView skillView, SkillModelBase skillModel)
    {
    }

    [Token(Token = "0x600DA48")]
    [Address(RVA = "0x22D7910", Offset = "0x22D7910", VA = "0x22D7910")]
    private void SetSkills(UnitPanelUI.UnitPanelView panelView, IEnumerable<SkillModelBase> models)
    {
    }

    [Token(Token = "0x600DA49")]
    [Address(RVA = "0x22D7F1C", Offset = "0x22D7F1C", VA = "0x22D7F1C")]
    private void OnClickEquipmentInternal(OrganizationEquipmentSlot.EquipmentSlotType slot)
    {
    }

    [Token(Token = "0x600DA4A")]
    [Address(RVA = "0x22D812C", Offset = "0x22D812C", VA = "0x22D812C")]
    public UnitPanelViewModel()
    {
    }
  }
}
