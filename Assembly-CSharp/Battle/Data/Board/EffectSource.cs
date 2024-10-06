// Decompiled with JetBrains decompiler
// Type: Battle.Data.Board.EffectSource
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace Battle.Data.Board
{
  [Token(Token = "0x2002798")]
  public struct EffectSource
  {
    [Token(Token = "0x400A8D8")]
    [FieldOffset(Offset = "0x0")]
    public int id;
    [Token(Token = "0x400A8D9")]
    [FieldOffset(Offset = "0x4")]
    public BattleEffectTypeEnum effectType;
    [Token(Token = "0x400A8DA")]
    [FieldOffset(Offset = "0x8")]
    public string displayNameTemplate;
    [Token(Token = "0x400A8DB")]
    [FieldOffset(Offset = "0x10")]
    public SkillTriggerTimingTypeEnum trigger;
    [Token(Token = "0x400A8DC")]
    [FieldOffset(Offset = "0x14")]
    public TargettableUnitTypeEnum target;
    [Token(Token = "0x400A8DD")]
    [FieldOffset(Offset = "0x18")]
    public ConditionTargetTypeEnum effectiveBase;
    [Token(Token = "0x400A8DE")]
    [FieldOffset(Offset = "0x1C")]
    public int range;
    [Token(Token = "0x400A8DF")]
    [FieldOffset(Offset = "0x20")]
    public int effectGroup;
    [Token(Token = "0x400A8E0")]
    [FieldOffset(Offset = "0x28")]
    public List<ConditionDetail> conditions;
    [Token(Token = "0x400A8E1")]
    [FieldOffset(Offset = "0x30")]
    public EffectiveLengthTypeEnum durationType;
    [Token(Token = "0x400A8E2")]
    [FieldOffset(Offset = "0x34")]
    public int duration;
    [Token(Token = "0x400A8E3")]
    [FieldOffset(Offset = "0x38")]
    public bool hitCheck;
    [Token(Token = "0x400A8E4")]
    [FieldOffset(Offset = "0x39")]
    public bool dependedHit;
    [Token(Token = "0x400A8E5")]
    [FieldOffset(Offset = "0x40")]
    public List<int> contexts;
    [Token(Token = "0x400A8E6")]
    [FieldOffset(Offset = "0x48")]
    public string description;
  }
}
