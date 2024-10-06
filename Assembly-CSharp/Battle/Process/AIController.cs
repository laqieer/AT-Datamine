// Decompiled with JetBrains decompiler
// Type: Battle.Process.AIController
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data;
using Battle.Data.Board;
using Battle.RouteSearch;
using Battle.Score;
using GameCore.MasterData;
using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

#nullable disable
namespace Battle.Process
{
  [Token(Token = "0x200261D")]
  public class AIController
  {
    [Token(Token = "0x400A3B1")]
    private const string AIParamSymbol = "AIParam";
    [Token(Token = "0x400A3B2")]
    [FieldOffset(Offset = "0x10")]
    private BattleCore core;
    [Token(Token = "0x400A3B3")]
    [FieldOffset(Offset = "0x18")]
    private BoardData orgBoard;
    [Token(Token = "0x400A3B4")]
    [FieldOffset(Offset = "0x20")]
    private TwoPointShortestPathSearcher shortest;
    [Token(Token = "0x400A3B5")]
    [FieldOffset(Offset = "0x28")]
    private Stopwatch sw;
    [Token(Token = "0x400A3B6")]
    private const int dumpCount = 10;
    [Token(Token = "0x400A3B7")]
    [FieldOffset(Offset = "0x30")]
    public Queue<long> ElapsedTimes;
    [Token(Token = "0x400A3B8")]
    [FieldOffset(Offset = "0x38")]
    private Routine.Environment env;

    [Token(Token = "0x17003241")]
    private BattleConfigData config
    {
      [Token(Token = "0x600EB93"), Address(RVA = "0x4B9EF08", Offset = "0x4B9EF08", VA = "0x4B9EF08")] get
      {
        return (BattleConfigData) null;
      }
    }

    [Token(Token = "0x17003242")]
    private BoardData currentBoard
    {
      [Token(Token = "0x600EB94"), Address(RVA = "0x4B9EF24", Offset = "0x4B9EF24", VA = "0x4B9EF24")] get
      {
        return (BoardData) null;
      }
    }

    [Token(Token = "0x17003243")]
    private AIScript aiScript
    {
      [Token(Token = "0x600EB95"), Address(RVA = "0x4B9EF40", Offset = "0x4B9EF40", VA = "0x4B9EF40")] get
      {
        return (AIScript) null;
      }
    }

    [Token(Token = "0x600EB96")]
    [Address(RVA = "0x4B9EF5C", Offset = "0x4B9EF5C", VA = "0x4B9EF5C")]
    public Routine.Environment GetEnvironment() => (Routine.Environment) null;

    [Token(Token = "0x600EB97")]
    [Address(RVA = "0x4B9BAFC", Offset = "0x4B9BAFC", VA = "0x4B9BAFC")]
    public AIController(BattleCore core)
    {
    }

    [Token(Token = "0x600EB98")]
    [Address(RVA = "0x4B9EF64", Offset = "0x4B9EF64", VA = "0x4B9EF64")]
    private void SetParam(AIParameterData param)
    {
    }

    [Token(Token = "0x600EB99")]
    [Address(RVA = "0x4B9EFC8", Offset = "0x4B9EFC8", VA = "0x4B9EFC8")]
    private CommandScore DecideNextCommand(
      int actionUnitId,
      string assetBundleName,
      string aiTypeName,
      Func<bool> isCanceled)
    {
      return (CommandScore) null;
    }

    [Token(Token = "0x600EB9A")]
    [Address(RVA = "0x4B9ED74", Offset = "0x4B9ED74", VA = "0x4B9ED74")]
    public Task<CommandScore> DecideNextCommandAsync(
      int actionUnitId,
      AITypeData aiType,
      CancellationToken token)
    {
      return (Task<CommandScore>) null;
    }

    [Token(Token = "0x600EB9B")]
    [Address(RVA = "0x4B9F214", Offset = "0x4B9F214", VA = "0x4B9F214")]
    public CommandScore CreateStayCommandData(int actionUnitId) => (CommandScore) null;

    [Token(Token = "0x600EB9C")]
    [Address(RVA = "0x4B9D1D8", Offset = "0x4B9D1D8", VA = "0x4B9D1D8")]
    public void SetupTargetChest(int playerId)
    {
    }

    [Token(Token = "0x600EB9D")]
    [Address(RVA = "0x4B9DC98", Offset = "0x4B9DC98", VA = "0x4B9DC98")]
    public void ClearTargetChest(int playerId)
    {
    }

    [Token(Token = "0x600EB9E")]
    [Address(RVA = "0x4B9F280", Offset = "0x4B9F280", VA = "0x4B9F280")]
    private void ClearTargetChest(BattlePlayerData player)
    {
    }

    [Token(Token = "0x600EB9F")]
    [Address(RVA = "0x4B9F3E4", Offset = "0x4B9F3E4", VA = "0x4B9F3E4")]
    [Conditional("UNITY_EDITOR")]
    private void StartElapsed()
    {
    }

    [Token(Token = "0x600EBA0")]
    [Address(RVA = "0x4B9F400", Offset = "0x4B9F400", VA = "0x4B9F400")]
    [Conditional("UNITY_EDITOR")]
    private void StopElapsed()
    {
    }

    [Token(Token = "0x600EBA1")]
    [Address(RVA = "0x4B9F41C", Offset = "0x4B9F41C", VA = "0x4B9F41C")]
    [Conditional("UNITY_EDITOR")]
    private void DumpElapsedTime()
    {
    }
  }
}
