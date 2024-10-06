// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.SkillCell
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data.Board;
using GameCore.MasterData;
using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using TeamOrganization;
using TMPro;
using UnityEngine;

#nullable disable
namespace Scenes.OutGame
{
  [Token(Token = "0x20032B2")]
  public class SkillCell : MonoBehaviour
  {
    [Token(Token = "0x400D989")]
    public const string EquipmentSlotPartsAssetBundleName = "ui_page_partylist_partyformation";
    [Token(Token = "0x400D98A")]
    public const string MnemnographPartsPrefabName = "MindequipmentSlotThumb";
    [Token(Token = "0x400D98B")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private SkillEffectCell[] skillEffectCells;
    [Token(Token = "0x400D98C")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private GameObject[] supportDisableObject;
    [Token(Token = "0x400D98D")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private GameObject[] nonSupportDisableObject;
    [Token(Token = "0x400D98E")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private RectTransform thumbParent;
    [Token(Token = "0x400D98F")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private TextMeshProUGUI skillName;
    [Token(Token = "0x400D990")]
    [FieldOffset(Offset = "0x40")]
    private MindequipmentSlotThumb mindequipmentSlotThumb;

    [Token(Token = "0x170041A4")]
    public List<SkillEffectCell> SkillEffectCells
    {
      [Token(Token = "0x6013CAF"), Address(RVA = "0x1ADF6B8", Offset = "0x1ADF6B8", VA = "0x1ADF6B8")] get
      {
        return (List<SkillEffectCell>) null;
      }
      [Token(Token = "0x6013CB0"), Address(RVA = "0x1ADF6C0", Offset = "0x1ADF6C0", VA = "0x1ADF6C0")] private set
      {
      }
    }

    [Token(Token = "0x6013CB1")]
    [Address(RVA = "0x1ADF6C8", Offset = "0x1ADF6C8", VA = "0x1ADF6C8")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x6013CB2")]
    [Address(RVA = "0x1ADF83C", Offset = "0x1ADF83C", VA = "0x1ADF83C")]
    public void SetData(
      bool isSupport,
      OrganizationEquipmentSlot mindEquipmentSlot,
      bool isEquipDuplication,
      OrganizationPartySlot[] partySlots,
      EffectFactory effectFactory,
      Battle.Data.Board.BattleData battleData,
      BoardData boardData)
    {
    }

    [Token(Token = "0x6013CB3")]
    [Address(RVA = "0x1AE1074", Offset = "0x1AE1074", VA = "0x1AE1074")]
    public void SetEquipmentDuplication(bool isEquipDuplication)
    {
    }

    [Token(Token = "0x6013CB4")]
    [Address(RVA = "0x1AE11FC", Offset = "0x1AE11FC", VA = "0x1AE11FC")]
    public void DuplicationCheck(SkillCell other, OrganizationPartySlot[] partySlots)
    {
    }

    [Token(Token = "0x6013CB5")]
    [Address(RVA = "0x1AE03A4", Offset = "0x1AE03A4", VA = "0x1AE03A4")]
    private Tuple<int, string, BattleEffectValueTypeEnum, int>[] GetParamAndText(
      ModifierEffectData modifierEffectData)
    {
      return (Tuple<int, string, BattleEffectValueTypeEnum, int>[]) null;
    }

    [Token(Token = "0x6013CB6")]
    [Address(RVA = "0x1AE14E0", Offset = "0x1AE14E0", VA = "0x1AE14E0")]
    private void GetTextMap(
      ModifierEffectData modifierEffectData,
      out Dictionary<int, string> textMap,
      out string paramDetailText,
      out string sameAllValueText)
    {
    }

    [Token(Token = "0x6013CB7")]
    [Address(RVA = "0x1AE17D4", Offset = "0x1AE17D4", VA = "0x1AE17D4")]
    private Dictionary<int, string> GetElementParameterTextMap() => (Dictionary<int, string>) null;

    [Token(Token = "0x6013CB8")]
    [Address(RVA = "0x1AE1B64", Offset = "0x1AE1B64", VA = "0x1AE1B64")]
    private Dictionary<int, string> GetAttackTypeParameterTextMap()
    {
      return (Dictionary<int, string>) null;
    }

    [Token(Token = "0x6013CB9")]
    [Address(RVA = "0x1AE1E80", Offset = "0x1AE1E80", VA = "0x1AE1E80")]
    public SkillCell()
    {
    }
  }
}
