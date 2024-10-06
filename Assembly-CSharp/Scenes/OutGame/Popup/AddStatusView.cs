// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.Popup.AddStatusView
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace Scenes.OutGame.Popup
{
  [Token(Token = "0x2003436")]
  public class AddStatusView : MonoBehaviour
  {
    [Token(Token = "0x400E314")]
    [FieldOffset(Offset = "0x0")]
    private static Func<string, string> GetText;
    [Token(Token = "0x400E315")]
    [FieldOffset(Offset = "0x18")]
    protected Func<string> ATTACK_ENHANCEMENT_NAME;
    [Token(Token = "0x400E316")]
    [FieldOffset(Offset = "0x20")]
    protected Func<string> ENHSNCED_RESISTANCE_NAME;
    [Token(Token = "0x400E317")]
    [FieldOffset(Offset = "0x28")]
    protected Func<string> REINFORCE_NAME;
    [Token(Token = "0x400E318")]
    [FieldOffset(Offset = "0x30")]
    protected Func<string> RESIST_NAME;
    [Token(Token = "0x400E319")]
    [FieldOffset(Offset = "0x38")]
    protected Func<string> SLAY_ELEMENT;
    [Token(Token = "0x400E31A")]
    [FieldOffset(Offset = "0x40")]
    protected Func<string> SPECIAL_ATTACK_NAME;
    [Token(Token = "0x400E31B")]
    [FieldOffset(Offset = "0x48")]
    protected Dictionary<int, Func<string>> titleMap;
    [Token(Token = "0x400E31C")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private RectTransform parent;
    [Token(Token = "0x400E31D")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private AddStatusContent baseContent;
    [Token(Token = "0x400E31E")]
    [FieldOffset(Offset = "0x60")]
    private List<AddStatusContent> createdList;
    [Token(Token = "0x400E31F")]
    [FieldOffset(Offset = "0x68")]
    private int skillId;
    [Token(Token = "0x400E320")]
    [FieldOffset(Offset = "0x70")]
    private IEquipmentAddStatus iEquipmentAddStatus;

    [Token(Token = "0x6014840")]
    [Address(RVA = "0x189B8D8", Offset = "0x189B8D8", VA = "0x189B8D8")]
    protected void SetMasterData(RewardTypeEnum rewardType, int rewardId)
    {
    }

    [Token(Token = "0x6014841")]
    [Address(RVA = "0x189BB08", Offset = "0x189BB08", VA = "0x189BB08")]
    private int GetElementReinforceValue(ElementTypeEnum elementType) => new int();

    [Token(Token = "0x6014842")]
    [Address(RVA = "0x189BBB4", Offset = "0x189BBB4", VA = "0x189BBB4")]
    private bool IsAddedStatusElementReinforceValue(ElementTypeEnum elementType) => new bool();

    [Token(Token = "0x6014843")]
    [Address(RVA = "0x189BC60", Offset = "0x189BC60", VA = "0x189BC60")]
    private int GetElementResistValue(ElementTypeEnum elementType) => new int();

    [Token(Token = "0x6014844")]
    [Address(RVA = "0x189BD10", Offset = "0x189BD10", VA = "0x189BD10")]
    private bool IsAddedStatusElementResistValue(ElementTypeEnum elementType) => new bool();

    [Token(Token = "0x6014845")]
    [Address(RVA = "0x189BDBC", Offset = "0x189BDBC", VA = "0x189BDBC")]
    private int GetAttackReinforceValue(AttackTypeEnum attackType) => new int();

    [Token(Token = "0x6014846")]
    [Address(RVA = "0x189BE6C", Offset = "0x189BE6C", VA = "0x189BE6C")]
    private bool IsAddedStatusAttackReinforceValue(AttackTypeEnum attackType) => new bool();

    [Token(Token = "0x6014847")]
    [Address(RVA = "0x189BF18", Offset = "0x189BF18", VA = "0x189BF18")]
    private int GetAttackResistValue(AttackTypeEnum attackType) => new int();

    [Token(Token = "0x6014848")]
    [Address(RVA = "0x189BFC8", Offset = "0x189BFC8", VA = "0x189BFC8")]
    private bool IsAddedStatusAttackResistValue(AttackTypeEnum attackType) => new bool();

    [Token(Token = "0x6014849")]
    [Address(RVA = "0x189C074", Offset = "0x189C074", VA = "0x189C074")]
    private int GetBadStatusReinforceValue(BattleBadStatusTypeEnum battleBadStatusType)
    {
      return new int();
    }

    [Token(Token = "0x601484A")]
    [Address(RVA = "0x189C124", Offset = "0x189C124", VA = "0x189C124")]
    private bool IsAddedStatusBadStatusReinforceValue(BattleBadStatusTypeEnum battleBadStatusType)
    {
      return new bool();
    }

    [Token(Token = "0x601484B")]
    [Address(RVA = "0x189C1D0", Offset = "0x189C1D0", VA = "0x189C1D0")]
    private int GetBadStatusResistValue(BattleBadStatusTypeEnum battleBadStatusType) => new int();

    [Token(Token = "0x601484C")]
    [Address(RVA = "0x189C280", Offset = "0x189C280", VA = "0x189C280")]
    private bool IsAddedStatusBadStatusResistValue(BattleBadStatusTypeEnum battleBadStatusType)
    {
      return new bool();
    }

    [Token(Token = "0x601484D")]
    [Address(RVA = "0x189C32C", Offset = "0x189C32C", VA = "0x189C32C")]
    private Tuple<string, int>[] GetReinforceDatas() => (Tuple<string, int>[]) null;

    [Token(Token = "0x601484E")]
    [Address(RVA = "0x189C738", Offset = "0x189C738", VA = "0x189C738")]
    private Tuple<string, int>[] GetResistDatas() => (Tuple<string, int>[]) null;

    [Token(Token = "0x601484F")]
    [Address(RVA = "0x189CB44", Offset = "0x189CB44", VA = "0x189CB44")]
    private Tuple<string, int>[] GetSpecialAttackDatas() => (Tuple<string, int>[]) null;

    [Token(Token = "0x6014850")]
    [Address(RVA = "0x189E918", Offset = "0x189E918", VA = "0x189E918")]
    private Tuple<string, int>[] GetSpecialDefenceDatas() => (Tuple<string, int>[]) null;

    [Token(Token = "0x6014851")]
    [Address(RVA = "0x18A06EC", Offset = "0x18A06EC", VA = "0x18A06EC")]
    private bool GetSpecialAttackLoopIndex(
      BattleEffectTypeEnum battleEffectType,
      out int start,
      out int length)
    {
      return new bool();
    }

    [Token(Token = "0x6014852")]
    [Address(RVA = "0x18A0764", Offset = "0x18A0764", VA = "0x18A0764")]
    private bool GetSpecialDefenceLoopIndex(
      BattleEffectTypeEnum battleEffectType,
      out int start,
      out int length)
    {
      return new bool();
    }

    [Token(Token = "0x6014853")]
    [Address(RVA = "0x189CC88", Offset = "0x189CC88", VA = "0x189CC88")]
    protected Dictionary<int, Dictionary<int, int>> GetSpecialAttackMappingDatas(
      List<Tuple<int, int>> skillIdLevelDatas)
    {
      return (Dictionary<int, Dictionary<int, int>>) null;
    }

    [Token(Token = "0x6014854")]
    [Address(RVA = "0x189D838", Offset = "0x189D838", VA = "0x189D838")]
    protected Tuple<string, int>[] GetSpecialAttackTextMappingDatas(
      Dictionary<int, Dictionary<int, int>> allMap)
    {
      return (Tuple<string, int>[]) null;
    }

    [Token(Token = "0x6014855")]
    [Address(RVA = "0x189EA5C", Offset = "0x189EA5C", VA = "0x189EA5C")]
    protected Dictionary<int, Dictionary<int, int>> GetSpecialDefenceMappingDatas(
      List<Tuple<int, int>> skillIdLevelDatas)
    {
      return (Dictionary<int, Dictionary<int, int>>) null;
    }

    [Token(Token = "0x6014856")]
    [Address(RVA = "0x189F60C", Offset = "0x189F60C", VA = "0x189F60C")]
    protected Tuple<string, int>[] GetSpecialDefenceTextMappingDatas(
      Dictionary<int, Dictionary<int, int>> allMap)
    {
      return (Tuple<string, int>[]) null;
    }

    [Token(Token = "0x6014857")]
    [Address(RVA = "0x18A07DC", Offset = "0x18A07DC", VA = "0x18A07DC")]
    public void Set(RewardTypeEnum rewardType, int rewardId)
    {
    }

    [Token(Token = "0x6014858")]
    [Address(RVA = "0x18A0928", Offset = "0x18A0928", VA = "0x18A0928")]
    private void CreateItem(Dictionary<int, Tuple<string, int>[]> dataMap)
    {
    }

    [Token(Token = "0x6014859")]
    [Address(RVA = "0x18A0D1C", Offset = "0x18A0D1C", VA = "0x18A0D1C")]
    public AddStatusView()
    {
    }

    [Token(Token = "0x601485A")]
    [Address(RVA = "0x18A1330", Offset = "0x18A1330", VA = "0x18A1330")]
    static AddStatusView()
    {
    }

    [Token(Token = "0x2003437")]
    public enum ViewType
    {
      [Token(Token = "0x400E322")] Reinforce,
      [Token(Token = "0x400E323")] Resist,
      [Token(Token = "0x400E324")] SpecialReinforce,
      [Token(Token = "0x400E325")] SpecialResist,
    }
  }
}
