// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.SkillEffectCell
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data.Board;
using GameCore.MasterData;
using Il2CppDummyDll;
using System;
using TeamOrganization;
using TMPro;
using UnityEngine;

#nullable disable
namespace Scenes.OutGame
{
  [Token(Token = "0x20032B5")]
  public class SkillEffectCell : MonoBehaviour
  {
    [Token(Token = "0x400D997")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private SkillEffectCell.SkillEffectValue[] skillEffectValues;
    [Token(Token = "0x400D998")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private TextMeshProUGUI effectText;

    [Token(Token = "0x170041A5")]
    public SkillEffectCell.SkillEffectValue[] SkillEffectValues
    {
      [Token(Token = "0x6013CC1"), Address(RVA = "0x1AE2124", Offset = "0x1AE2124", VA = "0x1AE2124")] get
      {
        return (SkillEffectCell.SkillEffectValue[]) null;
      }
    }

    [Token(Token = "0x6013CC2")]
    [Address(RVA = "0x1AE0DD8", Offset = "0x1AE0DD8", VA = "0x1AE0DD8")]
    public void SetData(
      Tuple<int, string, BattleEffectValueTypeEnum, int> parameterText,
      EffectDetailData effectDetailData,
      OrganizationPartySlot[] partySlots,
      EffectData effectData,
      Battle.Data.Board.BattleData battleData,
      BoardData boardData)
    {
    }

    [Token(Token = "0x6013CC3")]
    [Address(RVA = "0x1AE143C", Offset = "0x1AE143C", VA = "0x1AE143C")]
    public void DuplicationCheck(OrganizationPartySlot[] partySlots, SkillEffectCell other)
    {
    }

    [Token(Token = "0x6013CC4")]
    [Address(RVA = "0x1AE0300", Offset = "0x1AE0300", VA = "0x1AE0300")]
    public void AllEmpty()
    {
    }

    [Token(Token = "0x6013CC5")]
    [Address(RVA = "0x1AE23B8", Offset = "0x1AE23B8", VA = "0x1AE23B8")]
    public SkillEffectCell()
    {
    }

    [Token(Token = "0x20032B6")]
    [Serializable]
    public class SkillEffectValue
    {
      [Token(Token = "0x400D999")]
      [FieldOffset(Offset = "0x10")]
      [SerializeField]
      private TextMeshProUGUI defaultText;
      [Token(Token = "0x400D99A")]
      [FieldOffset(Offset = "0x18")]
      [SerializeField]
      private TextMeshProUGUI grayOutText;
      [Token(Token = "0x400D99B")]
      [FieldOffset(Offset = "0x20")]
      [SerializeField]
      private GameObject noneText;
      [Token(Token = "0x400D99C")]
      [FieldOffset(Offset = "0x28")]
      [HideInInspector]
      public BattleEffectTypeEnum BattleEffectType;
      [Token(Token = "0x400D99D")]
      [FieldOffset(Offset = "0x30")]
      [HideInInspector]
      public EffectDetailData EffectDetailData;
      [Token(Token = "0x400D99E")]
      [FieldOffset(Offset = "0x38")]
      [HideInInspector]
      public Tuple<int, string, BattleEffectValueTypeEnum, int> TupleData;
      [Token(Token = "0x400D99F")]
      [FieldOffset(Offset = "0x40")]
      public bool IsEqualValue;
      [Token(Token = "0x400D9A0")]
      [FieldOffset(Offset = "0x41")]
      public bool IsDuplication;

      [Token(Token = "0x6013CC6")]
      [Address(RVA = "0x1AE23C0", Offset = "0x1AE23C0", VA = "0x1AE23C0")]
      private string GetText(int effectValue, BattleEffectValueTypeEnum battleEffectValueType)
      {
        return (string) null;
      }

      [Token(Token = "0x6013CC7")]
      [Address(RVA = "0x1AE2194", Offset = "0x1AE2194", VA = "0x1AE2194")]
      public void SetData(int effectValue, BattleEffectValueTypeEnum battleEffectValueType)
      {
      }

      [Token(Token = "0x6013CC8")]
      [Address(RVA = "0x1AE212C", Offset = "0x1AE212C", VA = "0x1AE212C")]
      public void Empty()
      {
      }

      [Token(Token = "0x6013CC9")]
      [Address(RVA = "0x1AE2468", Offset = "0x1AE2468", VA = "0x1AE2468")]
      private void SetDuplicationFlg(bool isDupricate)
      {
      }

      [Token(Token = "0x6013CCA")]
      [Address(RVA = "0x1AE2248", Offset = "0x1AE2248", VA = "0x1AE2248")]
      public void DuplicationCheck(SkillEffectCell.SkillEffectValue other)
      {
      }

      [Token(Token = "0x6013CCB")]
      [Address(RVA = "0x1AE2518", Offset = "0x1AE2518", VA = "0x1AE2518")]
      public SkillEffectValue()
      {
      }
    }
  }
}
