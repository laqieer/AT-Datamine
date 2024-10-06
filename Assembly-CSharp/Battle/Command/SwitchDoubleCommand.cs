// Decompiled with JetBrains decompiler
// Type: Battle.Command.SwitchDoubleCommand
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data.Board;
using Battle.Process;
using Il2CppDummyDll;

#nullable disable
namespace Battle.Command
{
  [Token(Token = "0x20024B7")]
  public sealed class SwitchDoubleCommand : UnitCommandBase
  {
    [Token(Token = "0x4009D6D")]
    [FieldOffset(Offset = "0x40")]
    private bool noAnimation;

    [Token(Token = "0x17003069")]
    public override CommandType CommandType
    {
      [Token(Token = "0x600E1D8"), Address(RVA = "0x4262C54", Offset = "0x4262C54", VA = "0x4262C54", Slot = "10")] get
      {
        return new CommandType();
      }
    }

    [Token(Token = "0x600E1D9")]
    [Address(RVA = "0x4262C5C", Offset = "0x4262C5C", VA = "0x4262C5C")]
    public SwitchDoubleCommand(BattleCore core, UnitParameterData owner, bool noAnime = false)
    {
    }

    [Token(Token = "0x600E1DA")]
    [Address(RVA = "0x4262C9C", Offset = "0x4262C9C", VA = "0x4262C9C", Slot = "4")]
    public override bool Validate() => new bool();

    [Token(Token = "0x600E1DB")]
    [Address(RVA = "0x4262D20", Offset = "0x4262D20", VA = "0x4262D20", Slot = "6")]
    protected override void ExecuteInternal()
    {
    }

    [Token(Token = "0x600E1DC")]
    [Address(RVA = "0x4262D9C", Offset = "0x4262D9C", VA = "0x4262D9C", Slot = "8")]
    protected override void CompleteInternal()
    {
    }

    [Token(Token = "0x600E1DD")]
    [Address(RVA = "0x4262ECC", Offset = "0x4262ECC", VA = "0x4262ECC", Slot = "9")]
    protected override void CanceledInternal()
    {
    }
  }
}
