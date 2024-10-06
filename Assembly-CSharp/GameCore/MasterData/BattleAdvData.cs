// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.BattleAdvData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data.Board;
using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000DF7")]
  [Serializable]
  public sealed class BattleAdvData : IMasterDataEntity
  {
    [Token(Token = "0x40042AB")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x40042AC")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public int questID;
    [Token(Token = "0x40042AD")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public int advID;
    [Token(Token = "0x40042AE")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    public int priority;
    [Token(Token = "0x40042AF")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public bool cantSkip;
    [Token(Token = "0x40042B0")]
    [FieldOffset(Offset = "0x21")]
    [SerializeField]
    public bool advSkip;
    [Token(Token = "0x40042B1")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    public BattleTimeTypeEnum battleTime;
    [Token(Token = "0x40042B2")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    public BattleWeatherTypeEnum battleWeather;
    [Token(Token = "0x40042B3")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    public BattleEventTimingTypeEnum timing;
    [Token(Token = "0x40042B4")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    public int arg1;
    [Token(Token = "0x40042B5")]
    [FieldOffset(Offset = "0x34")]
    [SerializeField]
    public int arg2;
    [Token(Token = "0x40042B6")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    public int arg3;
    [Token(Token = "0x40042B7")]
    [FieldOffset(Offset = "0x3C")]
    [SerializeField]
    public int unit1;
    [Token(Token = "0x40042B8")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    public int unit2;
    [Token(Token = "0x40042B9")]
    [FieldOffset(Offset = "0x44")]
    [SerializeField]
    public int unit3;
    [Token(Token = "0x40042BA")]
    [FieldOffset(Offset = "0x48")]
    private Dictionary<(int playerIdx, int IdMode, int targetId), List<BattleAdvTriggerData>> condMap;

    [Token(Token = "0x17000C3B")]
    public int Key
    {
      [Token(Token = "0x6005524"), Address(RVA = "0x3AAB4FC", Offset = "0x3AAB4FC", VA = "0x3AAB4FC", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6005525")]
    [Address(RVA = "0x3AAB504", Offset = "0x3AAB504", VA = "0x3AAB504", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6005526")]
    [Address(RVA = "0x3AABAF8", Offset = "0x3AABAF8", VA = "0x3AABAF8", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x6005527")]
    [Address(RVA = "0x3AABC4C", Offset = "0x3AABC4C", VA = "0x3AABC4C")]
    public void Setup()
    {
    }

    [Token(Token = "0x6005528")]
    [Address(RVA = "0x3AAC1A8", Offset = "0x3AAC1A8", VA = "0x3AAC1A8")]
    public void Release()
    {
    }

    [Token(Token = "0x6005529")]
    [Address(RVA = "0x3AAC1B0", Offset = "0x3AAC1B0", VA = "0x3AAC1B0")]
    public bool IsTrigger(int matchCnt) => new bool();

    [Token(Token = "0x600552A")]
    [Address(RVA = "0x3AAC1E4", Offset = "0x3AAC1E4", VA = "0x3AAC1E4")]
    public bool IsMatch(BoardData board) => new bool();

    [Token(Token = "0x600552B")]
    [Address(RVA = "0x3AAD224", Offset = "0x3AAD224", VA = "0x3AAD224")]
    public bool IsMatch(
      BoardData board,
      UnitParameterData actionOwner,
      IReadOnlyList<UnitParameterData> actionTargets,
      SkillParameterData useSkill)
    {
      return new bool();
    }

    [Token(Token = "0x600552C")]
    [Address(RVA = "0x3AAE084", Offset = "0x3AAE084", VA = "0x3AAE084")]
    public bool IsMatch(BoardData board, UnitParameterData actionOwner, FacilityData facility)
    {
      return new bool();
    }

    [Token(Token = "0x600552D")]
    [Address(RVA = "0x3AAC560", Offset = "0x3AAC560", VA = "0x3AAC560")]
    private bool CheckTime(BoardData board) => new bool();

    [Token(Token = "0x600552E")]
    [Address(RVA = "0x3AAC598", Offset = "0x3AAC598", VA = "0x3AAC598")]
    private bool CheckWeather(BoardData board) => new bool();

    [Token(Token = "0x600552F")]
    [Address(RVA = "0x3AAC5D0", Offset = "0x3AAC5D0", VA = "0x3AAC5D0")]
    private bool CheckTiming(BoardData board, SkillParameterData useSkill = null, FacilityData facility = null)
    {
      return new bool();
    }

    [Token(Token = "0x6005530")]
    [Address(RVA = "0x3AACA1C", Offset = "0x3AACA1C", VA = "0x3AACA1C")]
    private bool CheckUnitID(int ownerId, int IdMode, int targetId, UnitParameterData unit)
    {
      return new bool();
    }

    [Token(Token = "0x6005531")]
    [Address(RVA = "0x3AADD7C", Offset = "0x3AADD7C", VA = "0x3AADD7C")]
    private bool CheckActionUnit(
      IReadOnlyList<BattleAdvTriggerData> advTriggerDatas,
      UnitParameterData unit,
      UnitParameterData actionOwner,
      IReadOnlyList<UnitParameterData> actionTargets)
    {
      return new bool();
    }

    [Token(Token = "0x6005532")]
    [Address(RVA = "0x3AACA8C", Offset = "0x3AACA8C", VA = "0x3AACA8C")]
    private bool CheckUnitState(
      IReadOnlyList<BattleAdvTriggerData> advTriggerDatas,
      UnitParameterData unit)
    {
      return new bool();
    }

    [Token(Token = "0x6005533")]
    [Address(RVA = "0x3AACB6C", Offset = "0x3AACB6C", VA = "0x3AACB6C")]
    private bool CheckUnitPosition(
      IReadOnlyList<BattleAdvTriggerData> advTriggerDatas,
      UnitParameterData unit)
    {
      return new bool();
    }

    [Token(Token = "0x6005534")]
    [Address(RVA = "0x3AACD38", Offset = "0x3AACD38", VA = "0x3AACD38")]
    private bool CheckAdjustmentUnit(
      IReadOnlyList<BattleAdvTriggerData> advTriggerDatas,
      BoardData board,
      UnitParameterData unit)
    {
      return new bool();
    }

    [Token(Token = "0x6005535")]
    [Address(RVA = "0x3AAE868", Offset = "0x3AAE868", VA = "0x3AAE868")]
    public BattleAdvData()
    {
    }
  }
}
