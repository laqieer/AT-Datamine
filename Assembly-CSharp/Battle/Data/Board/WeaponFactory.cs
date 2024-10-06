// Decompiled with JetBrains decompiler
// Type: Battle.Data.Board.WeaponFactory
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
  [Token(Token = "0x2002819")]
  public static class WeaponFactory
  {
    [Token(Token = "0x600FC3C")]
    public static WeaponData CreateFromEntityWeapon<THandler>(
      string manageId,
      Weapon weapon,
      Dictionary<int, WeaponMasterBonus> masterBonusDic,
      THandler handler)
      where THandler : IWeaponDataHandler, ISkillDataHandler, IEffectHandler, IBadStatusEffectHandler
    {
      return (WeaponData) null;
    }

    [Token(Token = "0x600FC3D")]
    public static WeaponData CreateFromWeaponMaster<THandler>(
      string manageId,
      GameCore.MasterData.WeaponData master,
      int level,
      int skillLevel,
      Dictionary<int, WeaponMasterBonus> masterBonusDic,
      THandler handler)
      where THandler : IWeaponDataHandler, ISkillDataHandler, IEffectHandler, IBadStatusEffectHandler
    {
      return (WeaponData) null;
    }

    [Token(Token = "0x600FC3E")]
    public static WeaponData CreateFromSchema<THandler>(staq.SaveSchema.WeaponData schema, THandler handler) where THandler : IWeaponDataHandler, ISkillDataHandler, IEffectHandler, IBadStatusEffectHandler
    {
      return (WeaponData) null;
    }

    [Token(Token = "0x600FC3F")]
    public static WeaponData CreateForExpedition<THandler>(
      string manageId,
      int masterId,
      Style style,
      THandler handler)
      where THandler : IWeaponDataHandler, ISkillDataHandler, IEffectHandler, IBadStatusEffectHandler
    {
      return (WeaponData) null;
    }

    [Token(Token = "0x600FC40")]
    public static WeaponData CreateClassDefault<THandler>(
      string manageId,
      ClassData classData,
      Dictionary<int, WeaponMasterBonus> masterBonusDic,
      THandler handler)
      where THandler : IWeaponDataHandler, ISkillDataHandler, IEffectHandler, IBadStatusEffectHandler
    {
      return (WeaponData) null;
    }

    [Token(Token = "0x600FC41")]
    private static WeaponData CreateSubstitute<THandler>(
      EquipmentClassificationData classification,
      THandler handler)
      where THandler : IWeaponDataHandler, ISkillDataHandler, IEffectHandler, IBadStatusEffectHandler
    {
      return (WeaponData) null;
    }

    [Token(Token = "0x600FC42")]
    [Address(RVA = "0x4423B44", Offset = "0x4423B44", VA = "0x4423B44")]
    private static StaqData.BattleParameter CreateMasterBonusParameter(
      EquipmentClassificationData classification,
      Dictionary<int, WeaponMasterBonus> masterBonusDic)
    {
      return (StaqData.BattleParameter) null;
    }

    [Token(Token = "0x600FC43")]
    public static WeaponParameterData CreateParameter<THandler>(
      WeaponData weapon,
      THandler handler,
      ISkillParameterDataHandler skillParamHandler)
      where THandler : IWeaponDataHandler, ISkillDataHandler, IEffectHandler, IBadStatusEffectHandler
    {
      return (WeaponParameterData) null;
    }

    [Token(Token = "0x600FC44")]
    private static WeaponParameterData CreateSubstituteParameter<THandler>(
      WeaponData weapon,
      THandler handler,
      ISkillParameterDataHandler skillParamHandler)
      where THandler : IWeaponDataHandler, ISkillDataHandler, IEffectHandler, IBadStatusEffectHandler
    {
      return (WeaponParameterData) null;
    }

    [Token(Token = "0x600FC45")]
    private static WeaponParameterData CreateParameter<THandler>(
      WeaponData weapon,
      int durable,
      THandler handler,
      ISkillParameterDataHandler skillParamHandler)
      where THandler : IWeaponDataHandler, ISkillDataHandler, IEffectHandler, IBadStatusEffectHandler
    {
      return (WeaponParameterData) null;
    }

    [Token(Token = "0x600FC46")]
    public static WeaponParameterData CreateParameterFromSchema<THandler>(
      staq.SaveSchema.WeaponParameterData schema,
      THandler handler,
      IBoardDataHandler paramHandler)
      where THandler : IBattleDataHandler
    {
      return (WeaponParameterData) null;
    }
  }
}
