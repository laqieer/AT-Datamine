// Decompiled with JetBrains decompiler
// Type: Battle.Process.AIActionSelector
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Command;
using Battle.Data.Board;
using Battle.Score;
using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

#nullable disable
namespace Battle.Process
{
  [Il2CppDummyDll.Token(Token = "0x200261A")]
  public class AIActionSelector : AutoActionSelector
  {
    [Il2CppDummyDll.Token(Token = "0x400A39A")]
    [FieldOffset(Offset = "0x70")]
    private AIController aiController;
    [Il2CppDummyDll.Token(Token = "0x400A39B")]
    [FieldOffset(Offset = "0x78")]
    private CommandScore commandData;
    [Il2CppDummyDll.Token(Token = "0x400A39C")]
    [FieldOffset(Offset = "0x80")]
    private int playerId;
    [Il2CppDummyDll.Token(Token = "0x400A39E")]
    [FieldOffset(Offset = "0x90")]
    protected bool forceEndAction;

    [Il2CppDummyDll.Token(Token = "0x1700323E")]
    private IDirector director
    {
      [Il2CppDummyDll.Token(Token = "0x600EB7C"), Address(RVA = "0x4B9BAB8", Offset = "0x4B9BAB8", VA = "0x4B9BAB8")] get
      {
        return (IDirector) null;
      }
    }

    [Il2CppDummyDll.Token(Token = "0x1700323F")]
    protected CancellationToken Token
    {
      [Il2CppDummyDll.Token(Token = "0x600EB7D"), Address(RVA = "0x4B9BAD4", Offset = "0x4B9BAD4", VA = "0x4B9BAD4")] get
      {
        return new CancellationToken();
      }
      [Il2CppDummyDll.Token(Token = "0x600EB7E"), Address(RVA = "0x4B9BADC", Offset = "0x4B9BADC", VA = "0x4B9BADC")] private set
      {
      }
    }

    [Il2CppDummyDll.Token(Token = "0x17003240")]
    public Queue<UnitCommandLog> ReservedOnEndActionCommands
    {
      [Il2CppDummyDll.Token(Token = "0x600EB7F"), Address(RVA = "0x4B9BAE4", Offset = "0x4B9BAE4", VA = "0x4B9BAE4")] get
      {
        return (Queue<UnitCommandLog>) null;
      }
      [Il2CppDummyDll.Token(Token = "0x600EB80"), Address(RVA = "0x4B9BAEC", Offset = "0x4B9BAEC", VA = "0x4B9BAEC")] private set
      {
      }
    }

    [Il2CppDummyDll.Token(Token = "0x600EB81")]
    [Address(RVA = "0x4B990EC", Offset = "0x4B990EC", VA = "0x4B990EC")]
    public AIActionSelector(BattleCore core, int playerId)
    {
    }

    [Il2CppDummyDll.Token(Token = "0x600EB82")]
    [Address(RVA = "0x4B9BC04", Offset = "0x4B9BC04", VA = "0x4B9BC04", Slot = "15")]
    public override void CancelSelection()
    {
    }

    [Il2CppDummyDll.Token(Token = "0x600EB83")]
    [Address(RVA = "0x4B9BC7C", Offset = "0x4B9BC7C", VA = "0x4B9BC7C", Slot = "11")]
    public override void Finish()
    {
    }

    [Il2CppDummyDll.Token(Token = "0x600EB84")]
    [Address(RVA = "0x4B9BD6C", Offset = "0x4B9BD6C", VA = "0x4B9BD6C", Slot = "17")]
    public override void OnSelectGrid(GridData grid)
    {
    }

    [Il2CppDummyDll.Token(Token = "0x600EB85")]
    [Address(RVA = "0x4B9BD70", Offset = "0x4B9BD70", VA = "0x4B9BD70", Slot = "24")]
    public override Task ThinkNextAction(
      UnitParameterData unit,
      bool forceEndAction,
      Action<bool> onSelected,
      CancellationToken token)
    {
      return (Task) null;
    }

    [Il2CppDummyDll.Token(Token = "0x600EB86")]
    [Address(RVA = "0x4B9BE78", Offset = "0x4B9BE78", VA = "0x4B9BE78")]
    private void OnSimulateCommandFinish(CommandBase command, bool canceled)
    {
    }

    [Il2CppDummyDll.Token(Token = "0x600EB87")]
    [Address(RVA = "0x4B9BEA8", Offset = "0x4B9BEA8", VA = "0x4B9BEA8")]
    protected void PostThinkCommand()
    {
    }

    [Il2CppDummyDll.Token(Token = "0x600EB88")]
    [Address(RVA = "0x4B9C34C", Offset = "0x4B9C34C", VA = "0x4B9C34C", Slot = "25")]
    protected virtual Queue<UnitCommandBase> CreateActionCommand(CommandScore commandData)
    {
      return (Queue<UnitCommandBase>) null;
    }

    [Il2CppDummyDll.Token(Token = "0x600EB89")]
    [Address(RVA = "0x4B9CE20", Offset = "0x4B9CE20", VA = "0x4B9CE20", Slot = "26")]
    protected virtual Task<CommandScore> ThinkNextCommand(CancellationToken token)
    {
      return (Task<CommandScore>) null;
    }

    [Il2CppDummyDll.Token(Token = "0x600EB8A")]
    [Address(RVA = "0x4B9CF1C", Offset = "0x4B9CF1C", VA = "0x4B9CF1C", Slot = "23")]
    protected override UnitParameterData GetNextActionUnit(CancellationToken token)
    {
      return (UnitParameterData) null;
    }

    [Il2CppDummyDll.Token(Token = "0x600EB8B")]
    [Address(RVA = "0x4B9D134", Offset = "0x4B9D134", VA = "0x4B9D134")]
    private bool IsActionableUnit(UnitParameterData unit) => new bool();

    [Il2CppDummyDll.Token(Token = "0x600EB8C")]
    [Address(RVA = "0x4B9D1B4", Offset = "0x4B9D1B4", VA = "0x4B9D1B4", Slot = "22")]
    public override void OnPlayerPhaseBegin()
    {
    }

    [Il2CppDummyDll.Token(Token = "0x600EB8D")]
    [Address(RVA = "0x4B9D1B8", Offset = "0x4B9D1B8", VA = "0x4B9D1B8")]
    public void SetupTargetChest()
    {
    }

    [Il2CppDummyDll.Token(Token = "0x600EB8E")]
    [Address(RVA = "0x4B9DC78", Offset = "0x4B9DC78", VA = "0x4B9DC78")]
    public void ClearTargetChest()
    {
    }
  }
}
