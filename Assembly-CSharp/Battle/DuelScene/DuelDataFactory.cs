// Decompiled with JetBrains decompiler
// Type: Battle.DuelScene.DuelDataFactory
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data;
using Battle.Data.Board;
using Battle.Logic;
using Il2CppDummyDll;

#nullable disable
namespace Battle.DuelScene
{
  [Token(Token = "0x200254D")]
  public static class DuelDataFactory
  {
    [Token(Token = "0x600E63F")]
    [Address(RVA = "0x486DF2C", Offset = "0x486DF2C", VA = "0x486DF2C")]
    public static void CreateInitiateSkill(DuelData data, ActionContext context)
    {
    }

    [Token(Token = "0x600E640")]
    [Address(RVA = "0x486E008", Offset = "0x486E008", VA = "0x486E008")]
    public static ActionData CreateSelfActionData(
      ActionType type,
      UnitParameterData actionUnit,
      GridData actionUnitGrid,
      SkillParameterData usingSkill,
      UnitParameterChange ownerPrevParam,
      UnitParameterChange ownerAfterParam)
    {
      return (ActionData) null;
    }
  }
}
