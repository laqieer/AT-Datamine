// Decompiled with JetBrains decompiler
// Type: Battle.Data.Board.UnitSource
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using StaqData;
using System.Collections.Generic;

#nullable disable
namespace Battle.Data.Board
{
  [Token(Token = "0x2002808")]
  public struct UnitSource
  {
    [Token(Token = "0x400AA79")]
    [FieldOffset(Offset = "0x0")]
    public int id;
    [Token(Token = "0x400AA7A")]
    [FieldOffset(Offset = "0x8")]
    public string uniqueId;
    [Token(Token = "0x400AA7B")]
    [FieldOffset(Offset = "0x10")]
    public int styleId;
    [Token(Token = "0x400AA7C")]
    [FieldOffset(Offset = "0x14")]
    public int rarity;
    [Token(Token = "0x400AA7D")]
    [FieldOffset(Offset = "0x18")]
    public int reincarnationCount;
    [Token(Token = "0x400AA7E")]
    [FieldOffset(Offset = "0x1C")]
    public int limitbreak;
    [Token(Token = "0x400AA7F")]
    [FieldOffset(Offset = "0x20")]
    public int initialExp;
    [Token(Token = "0x400AA80")]
    [FieldOffset(Offset = "0x24")]
    public int initialLp;
    [Token(Token = "0x400AA81")]
    [FieldOffset(Offset = "0x28")]
    public int initialDamage;
    [Token(Token = "0x400AA82")]
    [FieldOffset(Offset = "0x30")]
    public BasicParameter initialParameter;
    [Token(Token = "0x400AA83")]
    [FieldOffset(Offset = "0x38")]
    public Dictionary<int, BasicParameter> lvUpParams;
    [Token(Token = "0x400AA84")]
    [FieldOffset(Offset = "0x40")]
    public int[] reinforceAtkType;
    [Token(Token = "0x400AA85")]
    [FieldOffset(Offset = "0x48")]
    public int[] resistAtkType;
    [Token(Token = "0x400AA86")]
    [FieldOffset(Offset = "0x50")]
    public int[] reinforceElementType;
    [Token(Token = "0x400AA87")]
    [FieldOffset(Offset = "0x58")]
    public int[] resistElementType;
    [Token(Token = "0x400AA88")]
    [FieldOffset(Offset = "0x60")]
    public BattleParameter styleMasterBonus;
    [Token(Token = "0x400AA89")]
    [FieldOffset(Offset = "0x68")]
    public BattleParameter baseRatedBuff;
    [Token(Token = "0x400AA8A")]
    [FieldOffset(Offset = "0x70")]
    public ForceTypeEnum force;
    [Token(Token = "0x400AA8B")]
    [FieldOffset(Offset = "0x74")]
    public int gridSize;
    [Token(Token = "0x400AA8C")]
    [FieldOffset(Offset = "0x78")]
    public int aiTypeId;
    [Token(Token = "0x400AA8D")]
    [FieldOffset(Offset = "0x80")]
    public List<WeaponData> weapons;
    [Token(Token = "0x400AA8E")]
    [FieldOffset(Offset = "0x88")]
    public Dictionary<WeaponTypeEnum, ProficiencyTypeEnum> proficiency;
    [Token(Token = "0x400AA8F")]
    [FieldOffset(Offset = "0x90")]
    public List<AccessoryData> accessories;
    [Token(Token = "0x400AA90")]
    [FieldOffset(Offset = "0x98")]
    public List<MindEquipmentData> mindEquipments;
    [Token(Token = "0x400AA91")]
    [FieldOffset(Offset = "0xA0")]
    public List<TrustData> trusts;
    [Token(Token = "0x400AA92")]
    [FieldOffset(Offset = "0xA8")]
    public List<SkillData> customSkills;
    [Token(Token = "0x400AA93")]
    [FieldOffset(Offset = "0xB0")]
    public List<SkillData> unitSkills;
    [Token(Token = "0x400AA94")]
    [FieldOffset(Offset = "0xB8")]
    public List<SkillData> commuSkills;
    [Token(Token = "0x400AA95")]
    [FieldOffset(Offset = "0xC0")]
    public int troops;
    [Token(Token = "0x400AA96")]
    [FieldOffset(Offset = "0xC4")]
    public int baseExp;
    [Token(Token = "0x400AA97")]
    [FieldOffset(Offset = "0xC8")]
    public int correctMoveAmount;
  }
}
