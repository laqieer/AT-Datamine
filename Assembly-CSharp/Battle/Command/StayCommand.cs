// Decompiled with JetBrains decompiler
// Type: Battle.Command.StayCommand
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data.Board;
using Battle.Logic;
using Battle.Process;
using Il2CppDummyDll;

#nullable disable
namespace Battle.Command
{
  [Token(Token = "0x20024B6")]
  public sealed class StayCommand : UnitCommandBase
  {
    [Token(Token = "0x4009D6C")]
    [FieldOffset(Offset = "0x48")]
    private SkillLogic.EffectedTriggerSkillContainer triggerEffectContainer;

    [Token(Token = "0x17003067")]
    public override CommandType CommandType
    {
      [Token(Token = "0x600E1CE"), Address(RVA = "0x42626F8", Offset = "0x42626F8", VA = "0x42626F8", Slot = "10")] get
      {
        return new CommandType();
      }
    }

    [Token(Token = "0x17003068")]
    public GridData StayGrid
    {
      [Token(Token = "0x600E1CF"), Address(RVA = "0x4262700", Offset = "0x4262700", VA = "0x4262700")] get
      {
        return (GridData) null;
      }
      [Token(Token = "0x600E1D0"), Address(RVA = "0x4262708", Offset = "0x4262708", VA = "0x4262708")] private set
      {
      }
    }

    [Token(Token = "0x600E1D1")]
    [Address(RVA = "0x4262710", Offset = "0x4262710", VA = "0x4262710")]
    public StayCommand(BattleCore core, UnitParameterData owner)
    {
    }

    [Token(Token = "0x600E1D2")]
    [Address(RVA = "0x4262794", Offset = "0x4262794", VA = "0x4262794", Slot = "4")]
    public override bool Validate() => new bool();

    [Token(Token = "0x600E1D3")]
    [Address(RVA = "0x426279C", Offset = "0x426279C", VA = "0x426279C", Slot = "6")]
    protected override void ExecuteInternal()
    {
    }

    [Token(Token = "0x600E1D4")]
    [Address(RVA = "0x42628E0", Offset = "0x42628E0", VA = "0x42628E0", Slot = "8")]
    protected override void CompleteInternal()
    {
    }

    [Token(Token = "0x600E1D5")]
    [Address(RVA = "0x4262B3C", Offset = "0x4262B3C", VA = "0x4262B3C", Slot = "9")]
    protected override void CanceledInternal()
    {
    }

    [Token(Token = "0x600E1D6")]
    [Address(RVA = "0x4262804", Offset = "0x4262804", VA = "0x4262804")]
    private void IgnitionTriggerSkill(
      ref SkillLogic.EffectedTriggerSkillContainer container)
    {
    }
  }
}
