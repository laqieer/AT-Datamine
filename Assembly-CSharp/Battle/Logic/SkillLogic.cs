// Decompiled with JetBrains decompiler
// Type: Battle.Logic.SkillLogic
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data;
using Battle.Data.Board;
using GameCore.MasterData;
using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace Battle.Logic
{
  [Token(Token = "0x20024E1")]
  public static class SkillLogic
  {
    [Token(Token = "0x600E350")]
    [Address(RVA = "0x401FDD0", Offset = "0x401FDD0", VA = "0x401FDD0")]
    public static void IgnitionTriggerSkill(
      SkillTriggerTimingTypeEnum timing,
      IReadOnlyList<SkillParameterData> triggerSkillParams,
      ConditionParam skillCondition,
      ref SkillLogic.EffectedTriggerSkillContainer container)
    {
    }

    [Token(Token = "0x600E351")]
    [Address(RVA = "0x4027D8C", Offset = "0x4027D8C", VA = "0x4027D8C")]
    private static bool IsIgnitableTriggerSkill(
      SkillTriggerTimingTypeEnum timing,
      SkillParameterData triggerSkillParam,
      ConditionParam skillCondition,
      ref SkillLogic.EffectedTriggerSkillContainer container)
    {
      return new bool();
    }

    [Token(Token = "0x600E352")]
    [Address(RVA = "0x4027E44", Offset = "0x4027E44", VA = "0x4027E44")]
    private static void IgnitionTriggerSkillEffect(
      SkillTriggerTimingTypeEnum timing,
      BoardData board,
      UnitParameterData skillTarget,
      ConditionParam skillCondition,
      SkillParameterData skillParam,
      ref SkillLogic.EffectedTriggerSkillContainer container)
    {
    }

    [Token(Token = "0x600E353")]
    [Address(RVA = "0x4028690", Offset = "0x4028690", VA = "0x4028690")]
    private static bool InRange(
      EffectData effect,
      UnitParameterData effectBase,
      UnitParameterData target)
    {
      return new bool();
    }

    [Token(Token = "0x600E354")]
    [Address(RVA = "0x4028858", Offset = "0x4028858", VA = "0x4028858")]
    public static void ApplyPassiveSkillEffects(
      BoardData board,
      UnitParameterData unitParam,
      SkillParameterData skillParam)
    {
    }

    [Token(Token = "0x600E355")]
    [Address(RVA = "0x4029098", Offset = "0x4029098", VA = "0x4029098")]
    public static void RemoveAllPassiveSkillEffect(BoardData board, UnitParameterData owner)
    {
    }

    [Token(Token = "0x600E356")]
    [Address(RVA = "0x40294C4", Offset = "0x40294C4", VA = "0x40294C4")]
    public static void RemovePassiveSkillEffect(
      UnitParameterData unit,
      SkillParameterData skillParam)
    {
    }

    [Token(Token = "0x20024E2")]
    public class EffectedTriggerSkillContainer
    {
      [Token(Token = "0x4009E38")]
      [FieldOffset(Offset = "0x10")]
      private Dictionary<ITargettable, SkillLogic.EffectedTriggerSkillInfo> dic;
      [Token(Token = "0x4009E39")]
      [FieldOffset(Offset = "0x18")]
      private HashSet<SkillParameterData> triggeredSkills;

      [Token(Token = "0x170030B2")]
      public List<ITargettable> Activators
      {
        [Token(Token = "0x600E357"), Address(RVA = "0x40298C8", Offset = "0x40298C8", VA = "0x40298C8")] get
        {
          return (List<ITargettable>) null;
        }
      }

      [Token(Token = "0x170030B3")]
      public List<SkillParameterData> TriggeredSkills
      {
        [Token(Token = "0x600E358"), Address(RVA = "0x40255C0", Offset = "0x40255C0", VA = "0x40255C0")] get
        {
          return (List<SkillParameterData>) null;
        }
      }

      [Token(Token = "0x600E359")]
      [Address(RVA = "0x402872C", Offset = "0x402872C", VA = "0x402872C")]
      public void Add(
        UnitParameterData activator,
        UnitParameterData target,
        UnitParameterChange changeParam,
        SkillParameterData skillParam,
        EffectData effect)
      {
      }

      [Token(Token = "0x600E35A")]
      [Address(RVA = "0x4029AF4", Offset = "0x4029AF4", VA = "0x4029AF4")]
      public SkillLogic.EffectedTriggerSkillInfo GetInfo(ITargettable activator)
      {
        return (SkillLogic.EffectedTriggerSkillInfo) null;
      }

      [Token(Token = "0x600E35B")]
      [Address(RVA = "0x401FBDC", Offset = "0x401FBDC", VA = "0x401FBDC")]
      public EffectedTriggerSkillContainer()
      {
      }
    }

    [Token(Token = "0x20024E3")]
    public class EffectedTriggerSkillInfo
    {
      [Token(Token = "0x4009E3B")]
      [FieldOffset(Offset = "0x18")]
      private List<(UnitParameterData target, UnitParameterChange changeParam, EffectData effect)> details;

      [Token(Token = "0x170030B4")]
      public UnitParameterData Activator
      {
        [Token(Token = "0x600E35C"), Address(RVA = "0x4029B64", Offset = "0x4029B64", VA = "0x4029B64")] get
        {
          return (UnitParameterData) null;
        }
        [Token(Token = "0x600E35D"), Address(RVA = "0x4029B6C", Offset = "0x4029B6C", VA = "0x4029B6C")] private set
        {
        }
      }

      [Token(Token = "0x170030B5")]
      public IReadOnlyList<(UnitParameterData target, UnitParameterChange changeParam, EffectData effect)> Details
      {
        [Token(Token = "0x600E35E"), Address(RVA = "0x4029B74", Offset = "0x4029B74", VA = "0x4029B74")] get
        {
          return (IReadOnlyList<(UnitParameterData, UnitParameterChange, EffectData)>) null;
        }
      }

      [Token(Token = "0x600E35F")]
      [Address(RVA = "0x4029934", Offset = "0x4029934", VA = "0x4029934")]
      public EffectedTriggerSkillInfo(UnitParameterData activator)
      {
      }

      [Token(Token = "0x600E360")]
      [Address(RVA = "0x40299C4", Offset = "0x40299C4", VA = "0x40299C4")]
      public void AddDetail(
        UnitParameterData target,
        UnitParameterChange changeParam,
        EffectData effect)
      {
      }
    }
  }
}
