// Decompiled with JetBrains decompiler
// Type: Battle.Data.Board.UnitFactory
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Expedition.Data;
using Battle.Stage;
using Battle.Unit;
using GameCore.MasterData;
using Il2CppDummyDll;
using StaqData;
using System.Collections.Generic;
using TeamOrganization;
using UnityEngine;

#nullable disable
namespace Battle.Data.Board
{
  [Token(Token = "0x2002809")]
  public static class UnitFactory
  {
    [Token(Token = "0x400AA98")]
    [FieldOffset(Offset = "0x0")]
    private static readonly Quaternion UnitRotationOffset;

    [Token(Token = "0x600FB0C")]
    [Address(RVA = "0x44CC454", Offset = "0x44CC454", VA = "0x44CC454")]
    private static UnitData CreateFromDeckSlot(
      int id,
      DeckSlot slot,
      int lp,
      Dictionary<int, StaqData.BasicParameter> lvUpInfo,
      StaqData.BattleParameter styleMasterBonus,
      StaqData.BattleParameter baseRateOffset,
      Dictionary<int, WeaponMasterBonus> weaponMasterBonus,
      Dictionary<int, CommunicationSkill> communitySkills,
      ForceTypeEnum force,
      IBattleDataHandler handler)
    {
      return (UnitData) null;
    }

    [Token(Token = "0x600FB0D")]
    [Address(RVA = "0x44CE064", Offset = "0x44CE064", VA = "0x44CE064")]
    private static UnitData CreateForExpedition(
      int id,
      Style style,
      IBattleParameter masterBonus,
      IBattleDataHandler handler)
    {
      return (UnitData) null;
    }

    [Token(Token = "0x600FB0E")]
    [Address(RVA = "0x44CEC40", Offset = "0x44CEC40", VA = "0x44CEC40")]
    private static UnitData CreateFromNpc(
      int id,
      NpcUnitDataData npcData,
      QuestCorrection correction,
      int troops,
      int baseExp,
      int damage,
      ForceTypeEnum force,
      IBattleDataHandler handler)
    {
      return (UnitData) null;
    }

    [Token(Token = "0x600FB0F")]
    [Address(RVA = "0x44D1454", Offset = "0x44D1454", VA = "0x44D1454")]
    private static UnitData CreateFromOrganizationPartySlot(
      int id,
      OrganizationPartySlot slot,
      IBattleDataHandler handler)
    {
      return (UnitData) null;
    }

    [Token(Token = "0x600FB10")]
    [Address(RVA = "0x44D28A0", Offset = "0x44D28A0", VA = "0x44D28A0")]
    public static UnitData CreateFromSchema(staq.SaveSchema.UnitData schema, IBattleDataHandler handler)
    {
      return (UnitData) null;
    }

    [Token(Token = "0x600FB11")]
    [Address(RVA = "0x44D3B74", Offset = "0x44D3B74", VA = "0x44D3B74")]
    public static UnitParameterData CreateParameterFromDeckSlot(
      int id,
      DeckSlot slot,
      int lp,
      Dictionary<int, StaqData.BasicParameter> lvUpInfo,
      StaqData.BattleParameter totalOffset,
      StaqData.BattleParameter baseRateOffset,
      Dictionary<int, WeaponMasterBonus> weaponMasterBonus,
      Dictionary<int, CommunicationSkill> communitySkills,
      ForceTypeEnum force,
      IBattleDataHandler battleDataHandler,
      IBoardDataHandler boardDataHandler)
    {
      return (UnitParameterData) null;
    }

    [Token(Token = "0x600FB12")]
    [Address(RVA = "0x44D4764", Offset = "0x44D4764", VA = "0x44D4764")]
    public static UnitParameterData CreateParameterFromOrganizationPartySlot(
      int id,
      OrganizationPartySlot slot,
      IBattleDataHandler battleDataHandler,
      IBoardDataHandler boardDataHandler)
    {
      return (UnitParameterData) null;
    }

    [Token(Token = "0x600FB13")]
    [Address(RVA = "0x44D3CA0", Offset = "0x44D3CA0", VA = "0x44D3CA0")]
    public static UnitParameterData CreateParameterFromEntityStyle(
      UnitData unit,
      Style style,
      IBattleDataHandler battleDataHandler,
      IBoardDataHandler boardDataHandler)
    {
      return (UnitParameterData) null;
    }

    [Token(Token = "0x600FB14")]
    [Address(RVA = "0x44D0FAC", Offset = "0x44D0FAC", VA = "0x44D0FAC")]
    private static StaqData.BasicParameter CreateBasicParameterFromNpcData(
      NpcUnitDataData npc,
      QuestCorrection correction = null)
    {
      return (StaqData.BasicParameter) null;
    }

    [Token(Token = "0x600FB15")]
    [Address(RVA = "0x44D47F0", Offset = "0x44D47F0", VA = "0x44D47F0")]
    public static UnitParameterData CreateParameterFromNpcData(
      int id,
      NpcUnitDataData npc,
      int troops,
      int baseExp,
      int barrierId,
      int barrierMaxHp,
      ForceTypeEnum force,
      IBattleDataHandler battleDataHandler,
      IBoardDataHandler boardDataHandler)
    {
      return (UnitParameterData) null;
    }

    [Token(Token = "0x600FB16")]
    [Address(RVA = "0x44D48B4", Offset = "0x44D48B4", VA = "0x44D48B4")]
    public static UnitParameterData CreateParameterFromNpcData(
      int id,
      NpcUnitDataData npcData,
      QuestCorrection correction,
      int troops,
      int baseExp,
      int damage,
      int barrierId,
      int barrierMaxHp,
      ForceTypeEnum force,
      IBattleDataHandler battleDataHandler,
      IBoardDataHandler boardDataHandler)
    {
      return (UnitParameterData) null;
    }

    [Token(Token = "0x600FB17")]
    [Address(RVA = "0x44D5BE8", Offset = "0x44D5BE8", VA = "0x44D5BE8")]
    public static UnitParameterData CreateParameterForExpeditionAlly(
      int id,
      ExpeditionBattleData.CreateAllyData unitData,
      IBattleParameter masterBonus,
      bool isBossBattle,
      IBattleDataHandler battleDataHandler,
      IBoardDataHandler boardDataHandler)
    {
      return (UnitParameterData) null;
    }

    [Token(Token = "0x600FB18")]
    [Address(RVA = "0x44D5D3C", Offset = "0x44D5D3C", VA = "0x44D5D3C")]
    public static UnitParameterData CreateParameterFromExpeditionEnemy(
      int id,
      NpcUnitDataData npc,
      IBasicParameter basicParam,
      int barrierId,
      int barrierMaxHp,
      int troopsId,
      IBattleDataHandler battleDataHandler,
      IBoardDataHandler boardDataHandler)
    {
      return (UnitParameterData) null;
    }

    [Token(Token = "0x600FB19")]
    [Address(RVA = "0x44D5E6C", Offset = "0x44D5E6C", VA = "0x44D5E6C")]
    public static UnitParameterData CreateParameterFromSchema(
      staq.SaveSchema.UnitParameterData schema,
      IBattleDataHandler battleDataHandler,
      IBoardDataHandler boardDataHandler)
    {
      return (UnitParameterData) null;
    }

    [Token(Token = "0x600FB1A")]
    private static UnitParameterData SingleClone<THandler>(UnitParameterData src, THandler handler) where THandler : IUnitParameterDataHandler, ISkillParameterDataHandler
    {
      return (UnitParameterData) null;
    }

    [Token(Token = "0x600FB1B")]
    public static UnitParameterData Clone<THandler>(UnitParameterData src, THandler handler) where THandler : IUnitParameterDataHandler, ISkillParameterDataHandler
    {
      return (UnitParameterData) null;
    }

    [Token(Token = "0x600FB1C")]
    [Address(RVA = "0x44CDA80", Offset = "0x44CDA80", VA = "0x44CDA80")]
    private static void GetReinforceAndResist(
      StyleParameter styleParam,
      out int[] atkTypeReinforce,
      out int[] atkTypeResist,
      out int[] elementReinforce,
      out int[] elementResist)
    {
    }

    [Token(Token = "0x600FB1D")]
    [Address(RVA = "0x44D072C", Offset = "0x44D072C", VA = "0x44D072C")]
    private static void GetReinforceAndResist(
      StyleData style,
      out int[] atkTypeReinforce,
      out int[] atkTypeResist,
      out int[] elementReinforce,
      out int[] elementResist)
    {
    }

    [Token(Token = "0x600FB1E")]
    [Address(RVA = "0x44D7AD0", Offset = "0x44D7AD0", VA = "0x44D7AD0")]
    public static void SetupUnitView(
      UnitParameterData param,
      BattleStage stage,
      Actor.Direction defaultDir,
      ISystemFlags sys,
      IDirector mainDirector,
      bool isExpeditionBossBattle = false)
    {
    }

    [Token(Token = "0x600FB1F")]
    [Address(RVA = "0x44D8310", Offset = "0x44D8310", VA = "0x44D8310")]
    private static List<IBarrier> CreateUnitBarrier(IActor actor, BarrierContainer data)
    {
      return (List<IBarrier>) null;
    }

    [Token(Token = "0x600FB20")]
    [Address(RVA = "0x44D87C4", Offset = "0x44D87C4", VA = "0x44D87C4")]
    public static Sprite LoadFullImage(UnitParameterData unitParam) => (Sprite) null;

    [Token(Token = "0x600FB21")]
    [Address(RVA = "0x44D887C", Offset = "0x44D887C", VA = "0x44D887C")]
    public static Sprite LoadThumbImage(UnitParameterData unitParam) => (Sprite) null;

    [Token(Token = "0x600FB22")]
    [Address(RVA = "0x44D8934", Offset = "0x44D8934", VA = "0x44D8934")]
    static UnitFactory()
    {
    }
  }
}
