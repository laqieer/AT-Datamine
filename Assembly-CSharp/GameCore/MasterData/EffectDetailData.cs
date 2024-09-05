// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.EffectDetailData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x20011AF")]
  [Serializable]
  public sealed class EffectDetailData : IMasterDataEntity
  {
    [Token(Token = "0x4005509")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x400550A")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public int baseID;
    [Token(Token = "0x400550B")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public int level;
    [Token(Token = "0x400550C")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public string iconName;
    [Token(Token = "0x400550D")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    public int effectGroup;
    [Token(Token = "0x400550E")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    public SkillTriggerTimingTypeEnum triggerTiming;
    [Token(Token = "0x400550F")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    public TargettableUnitTypeEnum targettableUnit;
    [Token(Token = "0x4005510")]
    [FieldOffset(Offset = "0x34")]
    [SerializeField]
    public ConditionOpTypeEnum op1;
    [Token(Token = "0x4005511")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    public int requiredConditionID1;
    [Token(Token = "0x4005512")]
    [FieldOffset(Offset = "0x3C")]
    [SerializeField]
    public ConditionTargetTypeEnum conditionTarget1;
    [Token(Token = "0x4005513")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    public ConditionOpTypeEnum op2;
    [Token(Token = "0x4005514")]
    [FieldOffset(Offset = "0x44")]
    [SerializeField]
    public int requiredConditionID2;
    [Token(Token = "0x4005515")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    public ConditionTargetTypeEnum conditionTarget2;
    [Token(Token = "0x4005516")]
    [FieldOffset(Offset = "0x4C")]
    [SerializeField]
    public int requiredConditionID3;
    [Token(Token = "0x4005517")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    public ConditionTargetTypeEnum conditionTarget3;
    [Token(Token = "0x4005518")]
    [FieldOffset(Offset = "0x54")]
    [SerializeField]
    public EffectiveLengthTypeEnum effectiveLengthType;
    [Token(Token = "0x4005519")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    public int effectiveLengthValue;
    [Token(Token = "0x400551A")]
    [FieldOffset(Offset = "0x5C")]
    [SerializeField]
    public bool hitCheck;
    [Token(Token = "0x400551B")]
    [FieldOffset(Offset = "0x5D")]
    [SerializeField]
    public bool dependedHit;
    [Token(Token = "0x400551C")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    public ConditionTargetTypeEnum effectiveBase;
    [Token(Token = "0x400551D")]
    [FieldOffset(Offset = "0x64")]
    [SerializeField]
    public int effectiveRangeID;
    [Token(Token = "0x400551E")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    public BattleEffectTypeEnum effectType;
    [Token(Token = "0x400551F")]
    [FieldOffset(Offset = "0x6C")]
    [SerializeField]
    public int effectParam1;
    [Token(Token = "0x4005520")]
    [FieldOffset(Offset = "0x70")]
    [SerializeField]
    public int effectParam2;
    [Token(Token = "0x4005521")]
    [FieldOffset(Offset = "0x74")]
    [SerializeField]
    public int effectParam3;
    [Token(Token = "0x4005522")]
    [FieldOffset(Offset = "0x78")]
    [SerializeField]
    public int effectParam4;
    [Token(Token = "0x4005523")]
    [FieldOffset(Offset = "0x7C")]
    [SerializeField]
    public int effectParam5;
    [Token(Token = "0x4005524")]
    [FieldOffset(Offset = "0x80")]
    [SerializeField]
    public int effectParam6;
    [Token(Token = "0x4005525")]
    [FieldOffset(Offset = "0x84")]
    [SerializeField]
    public int effectParam7;
    [Token(Token = "0x4005526")]
    [FieldOffset(Offset = "0x88")]
    [SerializeField]
    public int effectParam8;
    [Token(Token = "0x4005527")]
    [FieldOffset(Offset = "0x8C")]
    [SerializeField]
    public int effectParam9;
    [Token(Token = "0x4005528")]
    [FieldOffset(Offset = "0x90")]
    [SerializeField]
    public int effectParam10;
    [Token(Token = "0x4005529")]
    [FieldOffset(Offset = "0x94")]
    [SerializeField]
    public int effectParam11;
    [Token(Token = "0x400552A")]
    [FieldOffset(Offset = "0x98")]
    [SerializeField]
    public int effectParam12;
    [Token(Token = "0x400552B")]
    [FieldOffset(Offset = "0x9C")]
    [SerializeField]
    public int effectParam13;
    [Token(Token = "0x400552C")]
    [FieldOffset(Offset = "0xA0")]
    [SerializeField]
    public int effectParam14;
    [Token(Token = "0x400552D")]
    [FieldOffset(Offset = "0xA4")]
    [SerializeField]
    public int effectParam15;
    [Token(Token = "0x400552E")]
    [FieldOffset(Offset = "0xA8")]
    [SerializeField]
    public int effectParam16;
    [Token(Token = "0x400552F")]
    [FieldOffset(Offset = "0xB0")]
    private int[] effectParams;

    [Token(Token = "0x17000F4B")]
    public int Key
    {
      [Token(Token = "0x600654E"), Address(RVA = "0x4AF7DFC", Offset = "0x4AF7DFC", VA = "0x4AF7DFC", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x600654F")]
    [Address(RVA = "0x4AF7E04", Offset = "0x4AF7E04", VA = "0x4AF7E04", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6006550")]
    [Address(RVA = "0x4AF8C98", Offset = "0x4AF8C98", VA = "0x4AF8C98", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x17000F4C")]
    public IReadOnlyList<int> EffectParams
    {
      [Token(Token = "0x6006551"), Address(RVA = "0x4AF8F60", Offset = "0x4AF8F60", VA = "0x4AF8F60")] get
      {
        return (IReadOnlyList<int>) null;
      }
    }

    [Token(Token = "0x17000F4D")]
    public string Description
    {
      [Token(Token = "0x6006552"), Address(RVA = "0x4AF8F68", Offset = "0x4AF8F68", VA = "0x4AF8F68")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x6006553")]
    [Address(RVA = "0x4AF7730", Offset = "0x4AF7730", VA = "0x4AF7730")]
    public void CollectParams()
    {
    }

    [Token(Token = "0x6006554")]
    [Address(RVA = "0x4AF9044", Offset = "0x4AF9044", VA = "0x4AF9044")]
    public EffectDetailData()
    {
    }
  }
}
