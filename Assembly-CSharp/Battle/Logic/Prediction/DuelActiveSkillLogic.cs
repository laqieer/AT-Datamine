// Decompiled with JetBrains decompiler
// Type: Battle.Logic.Prediction.DuelActiveSkillLogic
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data;
using Battle.Data.Board;
using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace Battle.Logic.Prediction
{
  [Token(Token = "0x20024F2")]
  public class DuelActiveSkillLogic : ActiveSkillLogic
  {
    [Token(Token = "0x4009E7E")]
    [FieldOffset(Offset = "0xD4")]
    private ActiveSkillActionGroup actionType;
    [Token(Token = "0x4009E7F")]
    [FieldOffset(Offset = "0xD8")]
    private UnitParameterData activateSupportUnit;
    [Token(Token = "0x4009E80")]
    [FieldOffset(Offset = "0xE0")]
    private SkillParameterData activateSupportGuardParam;

    [Token(Token = "0x600E3DA")]
    [Address(RVA = "0x477B280", Offset = "0x477B280", VA = "0x477B280")]
    protected DuelActiveSkillLogic(
      ActionContext context,
      TargetPair actionUnitPair,
      SkillParameterData activeSkillParam,
      TargetPair mainTarget,
      List<TargetPair> targets,
      UnitParameterData supportGuardUnit,
      SkillParameterData supportGuardSkillParam,
      ActiveSkillActionGroup duelActionType)
    {
    }

    [Token(Token = "0x600E3DB")]
    [Address(RVA = "0x477AD30", Offset = "0x477AD30", VA = "0x477AD30")]
    public static ActiveSkillLogic CreateDuel(
      ActionContext context,
      TargetPair actionUnitPair,
      SkillParameterData activeSkillParam,
      TargetPair mainTarget,
      List<TargetPair> targets,
      UnitParameterData supportGuardUnit,
      SkillParameterData supportGuardParam,
      ActiveSkillActionGroup duelActionType)
    {
      return (ActiveSkillLogic) null;
    }

    [Token(Token = "0x600E3DC")]
    [Address(RVA = "0x477A610", Offset = "0x477A610", VA = "0x477A610")]
    public static DuelActiveSkillLogic CreatePreDuel(
      ActionContext context,
      TargetPair actionUnitPair,
      SkillParameterData activeSkillParam,
      TargetPair mainTarget,
      List<TargetPair> targets)
    {
      return (DuelActiveSkillLogic) null;
    }

    [Token(Token = "0x600E3DD")]
    [Address(RVA = "0x477A8C0", Offset = "0x477A8C0", VA = "0x477A8C0")]
    public static DuelActiveSkillLogic CreatePostDuel(
      ActionContext context,
      TargetPair actionUnitPair,
      SkillParameterData activeSkillParam,
      TargetPair mainTarget,
      List<TargetPair> targets)
    {
      return (DuelActiveSkillLogic) null;
    }

    [Token(Token = "0x600E3DE")]
    [Address(RVA = "0x477B308", Offset = "0x477B308", VA = "0x477B308", Slot = "5")]
    protected override bool ApplyActiveSkill(TargetPair targetPair) => new bool();
  }
}
