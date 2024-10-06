// Decompiled with JetBrains decompiler
// Type: Battle.Logic.Prediction.EffectResult
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data;
using Battle.Data.Board;
using GameCore.MasterData;
using Il2CppDummyDll;
using System.Collections.Generic;

#nullable enable
namespace Battle.Logic.Prediction
{
  [Token(Token = "0x20024F5")]
  public sealed class EffectResult
  {
    [Token(Token = "0x4009E8F")]
    [FieldOffset(Offset = "0x10")]
    public SkillTriggerTimingTypeEnum Trigger;
    [Token(Token = "0x4009E90")]
    [FieldOffset(Offset = "0x14")]
    public ActiveSkillActionGroup DuelActionType;
    [Token(Token = "0x4009E91")]
    [FieldOffset(Offset = "0x18")]
    public int ActivatorUnitId;
    [Token(Token = "0x4009E92")]
    [FieldOffset(Offset = "0x1C")]
    public (int x, int y) ActivatorCoord;
    [Token(Token = "0x4009E93")]
    [FieldOffset(Offset = "0x28")]
    public 
    #nullable disable
    EffectData Effect;
    [Token(Token = "0x4009E94")]
    [FieldOffset(Offset = "0x30")]
    public int HitRate;
    [Token(Token = "0x4009E95")]
    [FieldOffset(Offset = "0x34")]
    public int CriticalRate;
    [Token(Token = "0x4009E96")]
    [FieldOffset(Offset = "0x38")]
    public (BattleBadStatusTypeEnum badstatus, int chance)? EnchantBadStatusChance;
    [Token(Token = "0x4009E97")]
    [FieldOffset(Offset = "0x48")]
    public List<(BattleBadStatusTypeEnum badstatus, int chance)> ClearBadStatusChanceList;
    [Token(Token = "0x4009E98")]
    [FieldOffset(Offset = "0x50")]
    public 
    #nullable enable
    ModifierEffectData? EnchantBuffEffect;
    [Token(Token = "0x4009E99")]
    [FieldOffset(Offset = "0x58")]
    public 
    #nullable disable
    List<ClearEffectData> ClearBuffEffects;
    [Token(Token = "0x4009E9A")]
    [FieldOffset(Offset = "0x60")]
    public List<TargetResult> Targets;
    [Token(Token = "0x4009E9B")]
    [FieldOffset(Offset = "0x68")]
    public UnitParameterChange ActivatorBefore;
    [Token(Token = "0x4009E9C")]
    [FieldOffset(Offset = "0x70")]
    public UnitParameterChange ActivatorAfter;

    [Token(Token = "0x170030D1")]
    public TargetResult MainTarget
    {
      [Token(Token = "0x600E3F0"), Address(RVA = "0x477EC94", Offset = "0x477EC94", VA = "0x477EC94")] get
      {
        return (TargetResult) null;
      }
    }

    [Token(Token = "0x600E3F1")]
    [Address(RVA = "0x4778ED4", Offset = "0x4778ED4", VA = "0x4778ED4")]
    public void AddTargetResult(TargetPair target, UnitParameterChange paramChange)
    {
    }

    [Token(Token = "0x600E3F2")]
    [Address(RVA = "0x477ED0C", Offset = "0x477ED0C", VA = "0x477ED0C")]
    private TargetResult GetTargetResult(TargetPair targetPair) => (TargetResult) null;

    [Token(Token = "0x600E3F3")]
    [Address(RVA = "0x477EE5C", Offset = "0x477EE5C", VA = "0x477EE5C")]
    private TargetResult GetTargetResult(int unitId, int x, int y) => (TargetResult) null;

    [Token(Token = "0x600E3F4")]
    [Address(RVA = "0x4778DD0", Offset = "0x4778DD0", VA = "0x4778DD0")]
    public EffectResult()
    {
    }
  }
}
