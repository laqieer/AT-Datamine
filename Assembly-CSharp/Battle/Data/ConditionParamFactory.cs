// Decompiled with JetBrains decompiler
// Type: Battle.Data.ConditionParamFactory
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data.Board;
using Battle.Logic;
using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace Battle.Data
{
  [Token(Token = "0x200274D")]
  public static class ConditionParamFactory
  {
    [Token(Token = "0x600F513")]
    [Address(RVA = "0x1FB31EC", Offset = "0x1FB31EC", VA = "0x1FB31EC")]
    public static ConditionParams Create(
      ActionResult actionResult,
      params ConditionParam[] conditionParams)
    {
      return (ConditionParams) null;
    }

    [Token(Token = "0x600F514")]
    [Address(RVA = "0x1FB329C", Offset = "0x1FB329C", VA = "0x1FB329C")]
    public static ConditionParams Create(
      BoardData board,
      UnitParameterData triggerSkillActivator,
      UnitParameterData target,
      ActionContext? context)
    {
      return (ConditionParams) null;
    }

    [Token(Token = "0x600F515")]
    [Address(RVA = "0x1FB3558", Offset = "0x1FB3558", VA = "0x1FB3558")]
    public static ConditionParams Create(
      BoardData board,
      UnitParameterData triggerSkillActivator,
      UnitParameterData target,
      ActionContext? context,
      UnitParameterData activator,
      UnitParameterChange targetParamChange)
    {
      return (ConditionParams) null;
    }

    [Token(Token = "0x600F516")]
    [Address(RVA = "0x1FB37A0", Offset = "0x1FB37A0", VA = "0x1FB37A0")]
    public static ConditionParams CreateTriggerDuel(
      BoardData board,
      UnitParameterData triggerSkillActivator,
      UnitParameterData target,
      ActionContext? context,
      UnitParameterData activator,
      UnitParameterChange targetParamChange = null,
      ActiveSkillActionGroup duelActionType = ActiveSkillActionGroup.None)
    {
      return (ConditionParams) null;
    }

    [Token(Token = "0x600F517")]
    [Address(RVA = "0x1FB33A8", Offset = "0x1FB33A8", VA = "0x1FB33A8")]
    public static ActionConditionParam CreateActionConditionParam(
      BoardData board,
      UnitParameterData triggerSkillActivator,
      UnitParameterData target,
      ActionContext? context)
    {
      return (ActionConditionParam) null;
    }

    [Token(Token = "0x600F518")]
    [Address(RVA = "0x1FB3918", Offset = "0x1FB3918", VA = "0x1FB3918")]
    public static ActionResultConditionParam CreateActionResultConditionParam(
      BoardData board,
      UnitParameterData triggerSkillActivator,
      UnitParameterData target,
      UnitParameterData activator,
      IReadOnlyList<ActionResult> results)
    {
      return (ActionResultConditionParam) null;
    }

    [Token(Token = "0x600F519")]
    [Address(RVA = "0x1FB369C", Offset = "0x1FB369C", VA = "0x1FB369C")]
    public static ActionResultConditionParam CreateActionResultConditionParam(
      BoardData board,
      UnitParameterData triggerSkillActivator,
      UnitParameterData target,
      UnitParameterData activator,
      UnitParameterChange unitParameterChange)
    {
      return (ActionResultConditionParam) null;
    }
  }
}
