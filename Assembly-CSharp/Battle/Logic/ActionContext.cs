// Decompiled with JetBrains decompiler
// Type: Battle.Logic.ActionContext
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data;
using Battle.Data.Board;
using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace Battle.Logic
{
  [Token(Token = "0x20024CC")]
  public struct ActionContext
  {
    [Token(Token = "0x4009DC6")]
    [FieldOffset(Offset = "0x0")]
    public readonly BoardData Board;
    [Token(Token = "0x4009DC7")]
    [FieldOffset(Offset = "0x8")]
    public readonly UnitParameterData ActionUnit;
    [Token(Token = "0x4009DC8")]
    [FieldOffset(Offset = "0x10")]
    public readonly GridData ActionUnitGrid;
    [Token(Token = "0x4009DC9")]
    [FieldOffset(Offset = "0x18")]
    public readonly UnitParameterData ActionSupportUnit;
    [Token(Token = "0x4009DCA")]
    [FieldOffset(Offset = "0x20")]
    public readonly UnitParameterData MainActionTargetUnit;
    [Token(Token = "0x4009DCB")]
    [FieldOffset(Offset = "0x28")]
    public readonly IReadOnlyList<TargetPair> ActionTargets;
    [Token(Token = "0x4009DCC")]
    [FieldOffset(Offset = "0x30")]
    public readonly GridData ActionTargetGrid;
    [Token(Token = "0x4009DCD")]
    [FieldOffset(Offset = "0x38")]
    public readonly UnitParameterData ActionTargetSupportUnit;
    [Token(Token = "0x4009DCE")]
    [FieldOffset(Offset = "0x40")]
    public readonly string PrimaryDuelSceneName;
    [Token(Token = "0x4009DCF")]
    [FieldOffset(Offset = "0x48")]
    public readonly IReadOnlyList<UnitParameterData> ActionUnitStratagemSupporters;
    [Token(Token = "0x4009DD0")]
    [FieldOffset(Offset = "0x50")]
    public readonly ItemParameterData ActionUnitItemParam;
    [Token(Token = "0x4009DD1")]
    [FieldOffset(Offset = "0x58")]
    public readonly SkillParameterData ActionUnitSkillParam;
    [Token(Token = "0x4009DD2")]
    [FieldOffset(Offset = "0x60")]
    public readonly SkillParameterData MainActionTargetUnitSkillParam;

    [Token(Token = "0x600E269")]
    [Address(RVA = "0x4017B20", Offset = "0x4017B20", VA = "0x4017B20")]
    public static ActionContext Create(
      BoardData board,
      UnitParameterData actionUnit,
      GridData actionUnitGrid,
      UnitParameterData actionSupportUnit,
      UnitParameterData mainActionTargetUnit,
      IReadOnlyList<TargetPair> actionTargets,
      GridData actionTargetGrid,
      UnitParameterData actionTargetSupportUnit,
      string primaryDuelSceneName,
      IReadOnlyList<UnitParameterData> actionUnitStratagemSupporters,
      ItemParameterData actionUnitItem,
      SkillParameterData actionUnitSkillParam,
      SkillParameterData actionTargetSkillParam)
    {
      return new ActionContext();
    }

    [Token(Token = "0x600E26A")]
    [Address(RVA = "0x4017B44", Offset = "0x4017B44", VA = "0x4017B44")]
    private ActionContext(
      BoardData board,
      UnitParameterData actionUnit,
      GridData actionUnitGrid,
      UnitParameterData actionSupportUnit,
      UnitParameterData mainActionTargetUnit,
      IReadOnlyList<TargetPair> actionTargets,
      GridData actionTargetGrid,
      UnitParameterData actionTargetSupportUnit,
      string primaryDuelSceneName,
      IReadOnlyList<UnitParameterData> actionUnitSupporters,
      ItemParameterData actionUnitItemParam,
      SkillParameterData actionUnitSkill,
      SkillParameterData actionTargetSkill)
    {
    }
  }
}
