// Decompiled with JetBrains decompiler
// Type: Battle.Data.Board.BoardSettings
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.RouteSearch;
using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace Battle.Data.Board
{
  [Token(Token = "0x2002764")]
  public class BoardSettings
  {
    [Token(Token = "0x600F643")]
    [Address(RVA = "0x1ED46C8", Offset = "0x1ED46C8", VA = "0x1ED46C8", Slot = "4")]
    public virtual Dictionary<int, List<int>> GetForceDic() => (Dictionary<int, List<int>>) null;

    [Token(Token = "0x600F644")]
    [Address(RVA = "0x1ED4720", Offset = "0x1ED4720", VA = "0x1ED4720", Slot = "5")]
    public virtual PathSearcher2D.NodeValidationCallback GetAttackableSearchStartNodeValidator(
      BoardData board,
      UnitParameterData owner)
    {
      return (PathSearcher2D.NodeValidationCallback) null;
    }

    [Token(Token = "0x600F645")]
    [Address(RVA = "0x1ED47E0", Offset = "0x1ED47E0", VA = "0x1ED47E0", Slot = "6")]
    public virtual PathSearcher2D.NodeValidationCallback GetAttackableSearchTargetValidator(
      BoardData board,
      UnitParameterData owner,
      SkillParameterData skill,
      BoardSettings.ExtendAttackableSearchTargetValidator extendValidator = null)
    {
      return (PathSearcher2D.NodeValidationCallback) null;
    }

    [Token(Token = "0x600F646")]
    [Address(RVA = "0x1ED48B4", Offset = "0x1ED48B4", VA = "0x1ED48B4", Slot = "7")]
    public virtual PathSearcher2D.NodeValidationCallback GetMovableSearchTargetValidator(
      BoardData board,
      UnitParameterData owner)
    {
      return (PathSearcher2D.NodeValidationCallback) null;
    }

    [Token(Token = "0x600F647")]
    [Address(RVA = "0x1ED4974", Offset = "0x1ED4974", VA = "0x1ED4974", Slot = "8")]
    public virtual PathSearcher2D.NodeValidationCallback GetOccupiableSearchTargetValidator(
      BoardData board,
      UnitParameterData owner)
    {
      return (PathSearcher2D.NodeValidationCallback) null;
    }

    [Token(Token = "0x600F648")]
    [Address(RVA = "0x1ED4A34", Offset = "0x1ED4A34", VA = "0x1ED4A34")]
    public BoardSettings()
    {
    }

    [Token(Token = "0x2002765")]
    public delegate bool ExtendAttackableSearchTargetValidator(
      BoardData board,
      UnitParameterData owner,
      UnitParameterData checkTargetUnit,
      GridData checkTargetGrid);
  }
}
