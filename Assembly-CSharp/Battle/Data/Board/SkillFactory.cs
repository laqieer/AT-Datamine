// Decompiled with JetBrains decompiler
// Type: Battle.Data.Board.SkillFactory
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using System.Collections.Generic;
using System.Diagnostics;

#nullable disable
namespace Battle.Data.Board
{
  [Token(Token = "0x20027FC")]
  public static class SkillFactory
  {
    [Token(Token = "0x600FA34")]
    public static SkillData Create<THandler>(int skill, int level, int rarity, THandler handler) where THandler : ISkillDataHandler, IEffectHandler, IBadStatusEffectHandler
    {
      return (SkillData) null;
    }

    [Token(Token = "0x600FA35")]
    public static SkillData Create<THandler>(
      int id,
      int skill,
      int level,
      int rarity,
      THandler handler)
      where THandler : ISkillDataHandler, IEffectHandler, IBadStatusEffectHandler
    {
      return (SkillData) null;
    }

    [Token(Token = "0x600FA36")]
    public static SkillData CreateFromSchema<THandler>(staq.SaveSchema.SkillData skillSchema, THandler handler) where THandler : ISkillDataHandler, IEffectHandler, IBadStatusEffectHandler
    {
      return (SkillData) null;
    }

    [Token(Token = "0x600FA37")]
    [Address(RVA = "0x44BE978", Offset = "0x44BE978", VA = "0x44BE978")]
    public static SkillParameterData CreateParameter(
      int id,
      SkillData skill,
      ISkillParameterDataHandler skillParamHandler)
    {
      return (SkillParameterData) null;
    }

    [Token(Token = "0x600FA38")]
    public static SkillParameterData CreateParameterFromSchema<THandler>(
      staq.SaveSchema.SkillParameterData schema,
      THandler handler,
      IBoardDataHandler paramHandler)
      where THandler : IBattleDataHandler
    {
      return (SkillParameterData) null;
    }

    [Token(Token = "0x600FA39")]
    [Address(RVA = "0x44C6A18", Offset = "0x44C6A18", VA = "0x44C6A18")]
    [Conditional("UNITY_EDITOR")]
    private static void OutputInvalidMasterLog(
      int skillId,
      int level,
      GameCore.MasterData.SkillData skill,
      SkillDetailData skillDetail,
      List<EffectDetailData> effectDetails)
    {
    }
  }
}
