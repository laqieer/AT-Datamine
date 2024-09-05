// Decompiled with JetBrains decompiler
// Type: Battle.Data.Board.UnitParameterSource
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using StaqData;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace Battle.Data.Board
{
  [Token(Token = "0x2002815")]
  public struct UnitParameterSource
  {
    [Token(Token = "0x400AAD6")]
    [FieldOffset(Offset = "0x0")]
    public UnitData unit;
    [Token(Token = "0x400AAD7")]
    [FieldOffset(Offset = "0x8")]
    public AIParameterData aiParam;
    [Token(Token = "0x400AAD8")]
    [FieldOffset(Offset = "0x10")]
    public Vector2Int coordinate;
    [Token(Token = "0x400AAD9")]
    [FieldOffset(Offset = "0x18")]
    public int lp;
    [Token(Token = "0x400AADA")]
    [FieldOffset(Offset = "0x1C")]
    public int level;
    [Token(Token = "0x400AADB")]
    [FieldOffset(Offset = "0x20")]
    public int exp;
    [Token(Token = "0x400AADC")]
    [FieldOffset(Offset = "0x24")]
    public bool calculatedFromParam;
    [Token(Token = "0x400AADD")]
    [FieldOffset(Offset = "0x28")]
    public HP[] hpList;
    [Token(Token = "0x400AADE")]
    [FieldOffset(Offset = "0x30")]
    public int currentIndex;
    [Token(Token = "0x400AADF")]
    [FieldOffset(Offset = "0x34")]
    public int barrier;
    [Token(Token = "0x400AAE0")]
    [FieldOffset(Offset = "0x38")]
    public BarrierParameter[] barrierList;
    [Token(Token = "0x400AAE1")]
    [FieldOffset(Offset = "0x40")]
    public IBasicParameter basicParam;
    [Token(Token = "0x400AAE2")]
    [FieldOffset(Offset = "0x48")]
    public int doubledAtId;
    [Token(Token = "0x400AAE3")]
    [FieldOffset(Offset = "0x4C")]
    public int leaderId;
    [Token(Token = "0x400AAE4")]
    [FieldOffset(Offset = "0x50")]
    public List<WeaponParameterData> weaponParams;
    [Token(Token = "0x400AAE5")]
    [FieldOffset(Offset = "0x58")]
    public int currentWeaponIndex;
    [Token(Token = "0x400AAE6")]
    [FieldOffset(Offset = "0x5C")]
    public int currentSkillStock;
    [Token(Token = "0x400AAE7")]
    [FieldOffset(Offset = "0x60")]
    public IDictionary<WeaponTypeEnum, int> achieveWeaponProficiencyDic;
    [Token(Token = "0x400AAE8")]
    [FieldOffset(Offset = "0x68")]
    public List<EffectParameterData> duplicatedEffectParameters;
    [Token(Token = "0x400AAE9")]
    [FieldOffset(Offset = "0x70")]
    public List<EffectParameterData> partySkillEffectParameters;
    [Token(Token = "0x400AAEA")]
    [FieldOffset(Offset = "0x78")]
    public List<EffectParameterData> useItemEffectParameters;
    [Token(Token = "0x400AAEB")]
    [FieldOffset(Offset = "0x80")]
    public List<EffectParameterData> badStatusEffectParameters;
    [Token(Token = "0x400AAEC")]
    [FieldOffset(Offset = "0x88")]
    public List<SkillParameterData> skillParams;
    [Token(Token = "0x400AAED")]
    [FieldOffset(Offset = "0x90")]
    public SkillParameterData chargeTargetSkill;
    [Token(Token = "0x400AAEE")]
    [FieldOffset(Offset = "0x98")]
    public int skillChargingCount;
    [Token(Token = "0x400AAEF")]
    [FieldOffset(Offset = "0x9C")]
    public (int x, int y)? chargeTargetCoord;
    [Token(Token = "0x400AAF0")]
    [FieldOffset(Offset = "0xA8")]
    public SortieState sortieState;
    [Token(Token = "0x400AAF1")]
    [FieldOffset(Offset = "0xAC")]
    public UnitActionState actionState;
    [Token(Token = "0x400AAF2")]
    [FieldOffset(Offset = "0xB0")]
    public int waitTurnCountFromSortied;
    [Token(Token = "0x400AAF3")]
    [FieldOffset(Offset = "0xB4")]
    public int passedWaitTurnCountFromSortied;
    [Token(Token = "0x400AAF4")]
    [FieldOffset(Offset = "0xB8")]
    public int prevAttackToUnitId;
    [Token(Token = "0x400AAF5")]
    [FieldOffset(Offset = "0xBC")]
    public int beAttackedUnitId;
    [Token(Token = "0x400AAF6")]
    [FieldOffset(Offset = "0xC0")]
    public int currentMovePoint;
    [Token(Token = "0x400AAF7")]
    [FieldOffset(Offset = "0xC4")]
    public int totalMoveDistanceDuringATurn;
    [Token(Token = "0x400AAF8")]
    [FieldOffset(Offset = "0xC8")]
    public bool isImmortal;
    [Token(Token = "0x400AAF9")]
    [FieldOffset(Offset = "0xC9")]
    public bool isWeaponCare;
    [Token(Token = "0x400AAFA")]
    [FieldOffset(Offset = "0xCC")]
    public int drop;
    [Token(Token = "0x400AAFB")]
    [FieldOffset(Offset = "0xD0")]
    public int expGain;
    [Token(Token = "0x400AAFC")]
    [FieldOffset(Offset = "0xD4")]
    public int expPool;
    [Token(Token = "0x400AAFD")]
    [FieldOffset(Offset = "0xD8")]
    public int totalDealtDamage;
    [Token(Token = "0x400AAFE")]
    [FieldOffset(Offset = "0xDC")]
    public int highestDealtDamage;
    [Token(Token = "0x400AAFF")]
    [FieldOffset(Offset = "0xE0")]
    public int breakBarrierCount;
    [Token(Token = "0x400AB00")]
    [FieldOffset(Offset = "0xE8")]
    public List<int> armorBreakUnitId;
    [Token(Token = "0x400AB01")]
    [FieldOffset(Offset = "0xF0")]
    public List<int> killUnitId;
    [Token(Token = "0x400AB02")]
    [FieldOffset(Offset = "0xF8")]
    public int turnNumberWhenDied;
    [Token(Token = "0x400AB03")]
    [FieldOffset(Offset = "0xFC")]
    public bool hideWeapon;
  }
}
