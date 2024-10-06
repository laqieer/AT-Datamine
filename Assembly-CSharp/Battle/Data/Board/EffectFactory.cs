// Decompiled with JetBrains decompiler
// Type: Battle.Data.Board.EffectFactory
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace Battle.Data.Board
{
  [Token(Token = "0x20027AA")]
  public class EffectFactory
  {
    [Token(Token = "0x400A90F")]
    public const int BarrierBreakEffectId = 600000001;
    [Token(Token = "0x400A910")]
    public const int ArmorBreakEffectId = 600000002;
    [Token(Token = "0x400A911")]
    [FieldOffset(Offset = "0x10")]
    private IBattleDataHandler handler;

    [Token(Token = "0x600F798")]
    [Address(RVA = "0x1EDAF8C", Offset = "0x1EDAF8C", VA = "0x1EDAF8C")]
    public EffectFactory(IBattleDataHandler handler)
    {
    }

    [Token(Token = "0x600F799")]
    [Address(RVA = "0x1EDAFB8", Offset = "0x1EDAFB8", VA = "0x1EDAFB8")]
    private void SetupSystemEffect()
    {
    }

    [Token(Token = "0x600F79A")]
    [Address(RVA = "0x1EDB180", Offset = "0x1EDB180", VA = "0x1EDB180")]
    public EffectData Create(int effect) => (EffectData) null;

    [Token(Token = "0x600F79B")]
    [Address(RVA = "0x1EDBF6C", Offset = "0x1EDBF6C", VA = "0x1EDBF6C")]
    public EffectData CreateFromSchema(staq.SaveSchema.EffectData schema) => (EffectData) null;

    [Token(Token = "0x600F79C")]
    [Address(RVA = "0x1EDB84C", Offset = "0x1EDB84C", VA = "0x1EDB84C")]
    private EffectData Create(EffectSource source) => (EffectData) null;

    [Token(Token = "0x600F79D")]
    [Address(RVA = "0x1EDBFA0", Offset = "0x1EDBFA0", VA = "0x1EDBFA0")]
    private EffectData CreateEnchantEffect(EffectSource source) => (EffectData) null;

    [Token(Token = "0x600F79E")]
    [Address(RVA = "0x1EDC698", Offset = "0x1EDC698", VA = "0x1EDC698")]
    private BadStatusEffectData CreateBadStatusEffect(
      int sourceId,
      int badStatusDetailId,
      int duration)
    {
      return (BadStatusEffectData) null;
    }

    [Token(Token = "0x600F79F")]
    [Address(RVA = "0x1EDC4CC", Offset = "0x1EDC4CC", VA = "0x1EDC4CC")]
    private BadStatusEffectData CreateBadStatusEffect(EffectSource source)
    {
      return (BadStatusEffectData) null;
    }

    [Token(Token = "0x600F7A0")]
    [Address(RVA = "0x1EDB4D8", Offset = "0x1EDB4D8", VA = "0x1EDB4D8")]
    private List<ConditionDetail> CreateEffectConditons(EffectDetailData effectDetail)
    {
      return (List<ConditionDetail>) null;
    }

    [Token(Token = "0x600F7A1")]
    [Address(RVA = "0x1EDCAF4", Offset = "0x1EDCAF4", VA = "0x1EDCAF4")]
    public EffectParameterData CreateParameterFromSchema(staq.SaveSchema.EffectParameterData schema)
    {
      return (EffectParameterData) null;
    }

    [Token(Token = "0x600F7A2")]
    [Address(RVA = "0x1EDCE4C", Offset = "0x1EDCE4C", VA = "0x1EDCE4C")]
    public EffectParameterData CreateBadStateFromSchema(staq.SaveSchema.EffectParameterData schema)
    {
      return (EffectParameterData) null;
    }
  }
}
