// Decompiled with JetBrains decompiler
// Type: Battle.Command.ChargeStartCommand
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data.Board;
using Battle.Process;
using Il2CppDummyDll;

#nullable disable
namespace Battle.Command
{
  [Token(Token = "0x20024A7")]
  public sealed class ChargeStartCommand : UnitCommandBase
  {
    [Token(Token = "0x4009D2B")]
    [FieldOffset(Offset = "0x40")]
    private SkillParameterData skill;

    [Token(Token = "0x1700304A")]
    public override CommandType CommandType
    {
      [Token(Token = "0x600E114"), Address(RVA = "0x42563B0", Offset = "0x42563B0", VA = "0x42563B0", Slot = "10")] get
      {
        return new CommandType();
      }
    }

    [Token(Token = "0x1700304B")]
    public SkillParameterData Skill
    {
      [Token(Token = "0x600E115"), Address(RVA = "0x42563B8", Offset = "0x42563B8", VA = "0x42563B8")] get
      {
        return (SkillParameterData) null;
      }
    }

    [Token(Token = "0x1700304C")]
    public GridData CastTo
    {
      [Token(Token = "0x600E116"), Address(RVA = "0x42563C0", Offset = "0x42563C0", VA = "0x42563C0")] get
      {
        return (GridData) null;
      }
      [Token(Token = "0x600E117"), Address(RVA = "0x42563C8", Offset = "0x42563C8", VA = "0x42563C8")] private set
      {
      }
    }

    [Token(Token = "0x600E118")]
    [Address(RVA = "0x42563D0", Offset = "0x42563D0", VA = "0x42563D0")]
    public ChargeStartCommand(
      BattleCore core,
      UnitParameterData owner,
      SkillParameterData skill,
      GridData castTo)
    {
    }

    [Token(Token = "0x600E119")]
    [Address(RVA = "0x4256444", Offset = "0x4256444", VA = "0x4256444", Slot = "4")]
    public override bool Validate() => new bool();

    [Token(Token = "0x600E11A")]
    [Address(RVA = "0x42564A0", Offset = "0x42564A0", VA = "0x42564A0", Slot = "6")]
    protected override void ExecuteInternal()
    {
    }

    [Token(Token = "0x600E11B")]
    [Address(RVA = "0x4256594", Offset = "0x4256594", VA = "0x4256594", Slot = "8")]
    protected override void CompleteInternal()
    {
    }

    [Token(Token = "0x600E11C")]
    [Address(RVA = "0x425674C", Offset = "0x425674C", VA = "0x425674C", Slot = "9")]
    protected override void CanceledInternal()
    {
    }
  }
}
