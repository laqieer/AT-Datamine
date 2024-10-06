// Decompiled with JetBrains decompiler
// Type: Battle.Log.DuelLog
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.DuelScene;
using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace Battle.Log
{
  [Token(Token = "0x200250A")]
  public sealed class DuelLog : ActionLog
  {
    [Token(Token = "0x4009F2D")]
    [FieldOffset(Offset = "0x20")]
    private List<Team> defenderTeams;
    [Token(Token = "0x4009F2E")]
    [FieldOffset(Offset = "0x28")]
    private List<ActionLog> startDuelActions;
    [Token(Token = "0x4009F2F")]
    [FieldOffset(Offset = "0x30")]
    private DuelLog log;
    [Token(Token = "0x4009F30")]
    [FieldOffset(Offset = "0x38")]
    private DuelData startDuelData;
    [Token(Token = "0x4009F31")]
    [FieldOffset(Offset = "0x40")]
    private DuelData inDuelData;
    [Token(Token = "0x4009F32")]
    [FieldOffset(Offset = "0x48")]
    private DuelData endDuelData;

    [Token(Token = "0x170030FA")]
    public override LogType LogType
    {
      [Token(Token = "0x600E4A7"), Address(RVA = "0x4788638", Offset = "0x4788638", VA = "0x4788638", Slot = "5")] get
      {
        return new LogType();
      }
    }

    [Token(Token = "0x170030FB")]
    public Team AttackerTeam
    {
      [Token(Token = "0x600E4A8"), Address(RVA = "0x4788640", Offset = "0x4788640", VA = "0x4788640")] get
      {
        return (Team) null;
      }
      [Token(Token = "0x600E4A9"), Address(RVA = "0x4788648", Offset = "0x4788648", VA = "0x4788648")] private set
      {
      }
    }

    [Token(Token = "0x170030FC")]
    public IReadOnlyList<Team> DefenderTeams
    {
      [Token(Token = "0x600E4AA"), Address(RVA = "0x4788650", Offset = "0x4788650", VA = "0x4788650")] get
      {
        return (IReadOnlyList<Team>) null;
      }
    }

    [Token(Token = "0x600E4AB")]
    [Address(RVA = "0x4788658", Offset = "0x4788658", VA = "0x4788658")]
    public DuelLog(
      Team attacker,
      DuelData startDuelData,
      DuelData inDuelData,
      DuelData endDuelData)
    {
    }

    [Token(Token = "0x600E4AC")]
    [Address(RVA = "0x478866C", Offset = "0x478866C", VA = "0x478866C")]
    public DuelLog(
      Team attacker,
      IReadOnlyList<Team> defenders,
      DuelData startDuelData,
      DuelData inDuelData,
      DuelData endDuelData)
    {
    }
  }
}
