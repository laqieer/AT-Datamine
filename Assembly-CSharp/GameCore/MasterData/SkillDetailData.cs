// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.SkillDetailData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x20011B9")]
  [Serializable]
  public sealed class SkillDetailData : IMasterDataEntity
  {
    [Token(Token = "0x4005540")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4005541")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public int baseID;
    [Token(Token = "0x4005542")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public int level;
    [Token(Token = "0x4005543")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    public int tags;
    [Token(Token = "0x4005544")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public int cost;
    [Token(Token = "0x4005545")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    public int usableCount;
    [Token(Token = "0x4005546")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    public int consumeDurability;
    [Token(Token = "0x4005547")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    public int requiredChargeTurns;
    [Token(Token = "0x4005548")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    public int battleStartCoolTime;
    [Token(Token = "0x4005549")]
    [FieldOffset(Offset = "0x34")]
    [SerializeField]
    public int coolTime;
    [Token(Token = "0x400554A")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    public SkillTriggerTimingTypeEnum triggerTiming;
    [Token(Token = "0x400554B")]
    [FieldOffset(Offset = "0x3C")]
    [SerializeField]
    public ConditionOpTypeEnum op1;
    [Token(Token = "0x400554C")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    public int requiredConditionID1;
    [Token(Token = "0x400554D")]
    [FieldOffset(Offset = "0x44")]
    [SerializeField]
    public ConditionTargetTypeEnum conditionTarget1;
    [Token(Token = "0x400554E")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    public ConditionOpTypeEnum op2;
    [Token(Token = "0x400554F")]
    [FieldOffset(Offset = "0x4C")]
    [SerializeField]
    public int requiredConditionID2;
    [Token(Token = "0x4005550")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    public ConditionTargetTypeEnum conditionTarget2;
    [Token(Token = "0x4005551")]
    [FieldOffset(Offset = "0x54")]
    [SerializeField]
    public int requiredConditionID3;
    [Token(Token = "0x4005552")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    public ConditionTargetTypeEnum conditionTarget3;
    [Token(Token = "0x4005553")]
    [FieldOffset(Offset = "0x5C")]
    [SerializeField]
    public TargettableUnitTypeEnum targettableUnit;
    [Token(Token = "0x4005554")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    public int firingRangeID;
    [Token(Token = "0x4005555")]
    [FieldOffset(Offset = "0x64")]
    [SerializeField]
    public int supportSkillDetail;

    [Token(Token = "0x17000F50")]
    public int Key
    {
      [Token(Token = "0x600657B"), Address(RVA = "0x4D1B698", Offset = "0x4D1B698", VA = "0x4D1B698", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x600657C")]
    [Address(RVA = "0x4D1B6A0", Offset = "0x4D1B6A0", VA = "0x4D1B6A0", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x600657D")]
    [Address(RVA = "0x4D1BF2C", Offset = "0x4D1BF2C", VA = "0x4D1BF2C", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x17000F51")]
    public string Description
    {
      [Token(Token = "0x600657E"), Address(RVA = "0x4D1B454", Offset = "0x4D1B454", VA = "0x4D1B454")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x600657F")]
    [Address(RVA = "0x4D1C0F0", Offset = "0x4D1C0F0", VA = "0x4D1C0F0")]
    public SkillDetailData()
    {
    }
  }
}
