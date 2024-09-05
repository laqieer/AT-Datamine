// Decompiled with JetBrains decompiler
// Type: Routine.InteractRoutineValidator
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data.Board;
using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace Routine
{
  [Token(Token = "0x2002236")]
  public class InteractRoutineValidator : ActionRoutineValidator
  {
    [Token(Token = "0x400906D")]
    [FieldOffset(Offset = "0x28")]
    private List<InteractRoutine.CachedInteractableInfo> interactableList;

    [Token(Token = "0x600D030")]
    [Address(RVA = "0x4CD4314", Offset = "0x4CD4314", VA = "0x4CD4314", Slot = "4")]
    public override List<WeaponParameterData> GetValidWeaponParams(BoardData board)
    {
      return (List<WeaponParameterData>) null;
    }

    [Token(Token = "0x600D031")]
    [Address(RVA = "0x4CD4354", Offset = "0x4CD4354", VA = "0x4CD4354", Slot = "5")]
    public override List<SkillParameterData> GetValidSkillParams(BoardData board)
    {
      return (List<SkillParameterData>) null;
    }

    [Token(Token = "0x600D032")]
    [Address(RVA = "0x4CD4394", Offset = "0x4CD4394", VA = "0x4CD4394", Slot = "6")]
    public override List<UnitParameterData> GetValidMainTargets(BoardData board)
    {
      return (List<UnitParameterData>) null;
    }

    [Token(Token = "0x17002D4E")]
    private InteractArg InteractArg
    {
      [Token(Token = "0x600D033"), Address(RVA = "0x4CD43D4", Offset = "0x4CD43D4", VA = "0x4CD43D4")] get
      {
        return (InteractArg) null;
      }
    }

    [Token(Token = "0x600D034")]
    [Address(RVA = "0x4CD3580", Offset = "0x4CD3580", VA = "0x4CD3580")]
    public InteractRoutineValidator(UnitParameterData activator, InteractArg arg)
    {
    }

    [Token(Token = "0x600D035")]
    [Address(RVA = "0x4CD4208", Offset = "0x4CD4208", VA = "0x4CD4208")]
    public void SetInteractable(
      List<InteractRoutine.CachedInteractableInfo> interactable)
    {
    }

    [Token(Token = "0x600D036")]
    [Address(RVA = "0x4CD3F24", Offset = "0x4CD3F24", VA = "0x4CD3F24")]
    public List<GridData> GetValidFacilityGrids(BoardData board) => (List<GridData>) null;

    [Token(Token = "0x600D037")]
    [Address(RVA = "0x4CD4450", Offset = "0x4CD4450", VA = "0x4CD4450")]
    private bool IsValidFacility(FacilityData facility) => new bool();

    [Token(Token = "0x600D038")]
    [Address(RVA = "0x4CD4574", Offset = "0x4CD4574", VA = "0x4CD4574", Slot = "7")]
    public override List<(int, int)> GetMoveGridList(BoardData board) => (List<(int, int)>) null;
  }
}
