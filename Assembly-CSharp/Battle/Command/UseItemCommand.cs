// Decompiled with JetBrains decompiler
// Type: Battle.Command.UseItemCommand
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data;
using Battle.Data.Board;
using Battle.Logic;
using Battle.Process;
using Battle.RouteSearch;
using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace Battle.Command
{
  [Token(Token = "0x20024BC")]
  public class UseItemCommand : UnitCommandBase, IKillableCommand
  {
    [Token(Token = "0x4009D80")]
    [FieldOffset(Offset = "0x40")]
    private BattlePlayerData itemUser;
    [Token(Token = "0x4009D81")]
    [FieldOffset(Offset = "0x48")]
    private List<TargetPair> targets;
    [Token(Token = "0x4009D82")]
    [FieldOffset(Offset = "0x50")]
    private GridData castTo;
    [Token(Token = "0x4009D83")]
    [FieldOffset(Offset = "0x58")]
    private AttackableAreaSearcher effectiveArea;
    [Token(Token = "0x4009D84")]
    [FieldOffset(Offset = "0x60")]
    private ItemParameterData itemParam;
    [Token(Token = "0x4009D86")]
    [FieldOffset(Offset = "0x70")]
    private List<(UnitParameterData unit, UnitParameterChange paramChange)> effected;
    [Token(Token = "0x4009D87")]
    [FieldOffset(Offset = "0x78")]
    private List<(int unitId, int index, BarrierDamageLogic logic)> barrierDamages;

    [Token(Token = "0x1700306C")]
    public override CommandType CommandType
    {
      [Token(Token = "0x600E1FA"), Address(RVA = "0x4265E2C", Offset = "0x4265E2C", VA = "0x4265E2C", Slot = "10")] get
      {
        return new CommandType();
      }
    }

    [Token(Token = "0x1700306D")]
    public UnitParameterData MainTarget
    {
      [Token(Token = "0x600E1FB"), Address(RVA = "0x42657A0", Offset = "0x42657A0", VA = "0x42657A0")] get
      {
        return (UnitParameterData) null;
      }
    }

    [Token(Token = "0x1700306E")]
    public GridData CastTo
    {
      [Token(Token = "0x600E1FC"), Address(RVA = "0x4265E34", Offset = "0x4265E34", VA = "0x4265E34")] get
      {
        return (GridData) null;
      }
    }

    [Token(Token = "0x1700306F")]
    public ItemParameterData UseItem
    {
      [Token(Token = "0x600E1FD"), Address(RVA = "0x4265E3C", Offset = "0x4265E3C", VA = "0x4265E3C")] get
      {
        return (ItemParameterData) null;
      }
    }

    [Token(Token = "0x17003070")]
    public List<UnitParameterData> KilledUnits
    {
      [Token(Token = "0x600E1FE"), Address(RVA = "0x4265E44", Offset = "0x4265E44", VA = "0x4265E44", Slot = "11")] get
      {
        return (List<UnitParameterData>) null;
      }
      [Token(Token = "0x600E1FF"), Address(RVA = "0x4265E4C", Offset = "0x4265E4C", VA = "0x4265E4C")] private set
      {
      }
    }

    [Token(Token = "0x17003071")]
    public IReadOnlyList<(UnitParameterData unit, UnitParameterChange paramChange)> Effected
    {
      [Token(Token = "0x600E200"), Address(RVA = "0x4265E54", Offset = "0x4265E54", VA = "0x4265E54")] get
      {
        return (IReadOnlyList<(UnitParameterData, UnitParameterChange)>) null;
      }
    }

    [Token(Token = "0x600E201")]
    [Address(RVA = "0x4263F0C", Offset = "0x4263F0C", VA = "0x4263F0C")]
    public UseItemCommand(
      BattleCore core,
      BattlePlayerData itemUser,
      IReadOnlyList<TargetPair> targets,
      GridData castTo,
      AttackableAreaSearcher effectiveArea,
      ItemParameterData itemParam)
    {
    }

    [Token(Token = "0x600E202")]
    [Address(RVA = "0x4265E5C", Offset = "0x4265E5C", VA = "0x4265E5C", Slot = "4")]
    public override bool Validate() => new bool();

    [Token(Token = "0x600E203")]
    [Address(RVA = "0x4265E64", Offset = "0x4265E64", VA = "0x4265E64", Slot = "5")]
    public override void Prepare()
    {
    }

    [Token(Token = "0x600E204")]
    [Address(RVA = "0x42661B8", Offset = "0x42661B8", VA = "0x42661B8", Slot = "6")]
    protected override void ExecuteInternal()
    {
    }

    [Token(Token = "0x600E205")]
    [Address(RVA = "0x4266F4C", Offset = "0x4266F4C", VA = "0x4266F4C", Slot = "8")]
    protected override void CompleteInternal()
    {
    }

    [Token(Token = "0x600E206")]
    [Address(RVA = "0x426725C", Offset = "0x426725C", VA = "0x426725C", Slot = "9")]
    protected override void CanceledInternal()
    {
    }

    [Token(Token = "0x600E207")]
    [Address(RVA = "0x4267260", Offset = "0x4267260", VA = "0x4267260")]
    private BarrierDamageLogic GetBarrierDamageLogic(int unit, int index)
    {
      return (BarrierDamageLogic) null;
    }

    [Token(Token = "0x600E208")]
    [Address(RVA = "0x4266B3C", Offset = "0x4266B3C", VA = "0x4266B3C")]
    private void CollectBarrierDamage(ActiveSkillLogicBase logic)
    {
    }
  }
}
