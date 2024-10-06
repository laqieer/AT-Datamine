// Decompiled with JetBrains decompiler
// Type: Battle.Command.UnitCommandBase
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data.Board;
using Battle.Process;
using Il2CppDummyDll;

#nullable disable
namespace Battle.Command
{
  [Token(Token = "0x20024B8")]
  public abstract class UnitCommandBase : CommandBase
  {
    [Token(Token = "0x4009D6F")]
    [FieldOffset(Offset = "0x30")]
    public GridData PreGrid;
    [Token(Token = "0x4009D70")]
    [FieldOffset(Offset = "0x38")]
    public GridData PostGrid;

    [Token(Token = "0x1700306A")]
    public abstract CommandType CommandType { [Token(Token = "0x600E1DF")] get; }

    [Token(Token = "0x1700306B")]
    public UnitParameterData OwnerUnit
    {
      [Token(Token = "0x600E1E0"), Address(RVA = "0x42630B4", Offset = "0x42630B4", VA = "0x42630B4")] get
      {
        return (UnitParameterData) null;
      }
      [Token(Token = "0x600E1E1"), Address(RVA = "0x42630BC", Offset = "0x42630BC", VA = "0x42630BC")] protected set
      {
      }
    }

    [Token(Token = "0x600E1E2")]
    [Address(RVA = "0x4256414", Offset = "0x4256414", VA = "0x4256414")]
    protected UnitCommandBase(BattleCore core, UnitParameterData ownerUnit)
    {
    }

    [Token(Token = "0x600E1E3")]
    [Address(RVA = "0x42568D4", Offset = "0x42568D4", VA = "0x42568D4", Slot = "5")]
    public override void Prepare()
    {
    }
  }
}
