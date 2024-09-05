// Decompiled with JetBrains decompiler
// Type: Battle.Process.BattleSupportValueProcessor
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Command;
using Battle.Data.Board;
using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace Battle.Process
{
  [Token(Token = "0x20026A8")]
  public class BattleSupportValueProcessor
  {
    [Token(Token = "0x400A5D1")]
    [FieldOffset(Offset = "0x10")]
    private BoardData boardData;
    [Token(Token = "0x400A5D2")]
    [FieldOffset(Offset = "0x18")]
    private IDirector mainDirector;
    [Token(Token = "0x400A5D3")]
    [FieldOffset(Offset = "0x20")]
    private int increaseBySupport;
    [Token(Token = "0x400A5D4")]
    [FieldOffset(Offset = "0x24")]
    private int decreaseByDead;

    [Token(Token = "0x600EF6D")]
    [Address(RVA = "0x40D893C", Offset = "0x40D893C", VA = "0x40D893C")]
    public BattleSupportValueProcessor(BoardData board, IDirector mainDirector)
    {
    }

    [Token(Token = "0x600EF6E")]
    [Address(RVA = "0x40D8A40", Offset = "0x40D8A40", VA = "0x40D8A40")]
    public void ApplyBoard(BoardData board)
    {
    }

    [Token(Token = "0x600EF6F")]
    [Address(RVA = "0x40D8A48", Offset = "0x40D8A48", VA = "0x40D8A48")]
    public void FluctuationSupportValue(UnitCommandBase command)
    {
    }

    [Token(Token = "0x600EF70")]
    [Address(RVA = "0x40D8C94", Offset = "0x40D8C94", VA = "0x40D8C94")]
    private List<BattleSupportValueInfo> GetSupportValueInfo(CommandBase command)
    {
      return (List<BattleSupportValueInfo>) null;
    }

    [Token(Token = "0x600EF71")]
    [Address(RVA = "0x40D8D64", Offset = "0x40D8D64", VA = "0x40D8D64")]
    private List<BattleSupportValueInfo> GetSupportValueInfo(DuelCommand command)
    {
      return (List<BattleSupportValueInfo>) null;
    }

    [Token(Token = "0x600EF72")]
    [Address(RVA = "0x40D8E94", Offset = "0x40D8E94", VA = "0x40D8E94")]
    private void CalcSupport(
      BattlePlayerData player,
      DuelCommand command,
      ref List<BattleSupportValueInfo> list)
    {
    }

    [Token(Token = "0x600EF73")]
    [Address(RVA = "0x40D9184", Offset = "0x40D9184", VA = "0x40D9184")]
    private void CalcSupportOnCounter(
      BattlePlayerData player,
      DuelCommand command,
      ref List<BattleSupportValueInfo> list)
    {
    }

    [Token(Token = "0x600EF74")]
    [Address(RVA = "0x40D9A24", Offset = "0x40D9A24", VA = "0x40D9A24")]
    private void CalcValueBySupport(
      BattlePlayerData player,
      UnitParameterData main,
      UnitParameterData supporter,
      ref List<BattleSupportValueInfo> list)
    {
    }

    [Token(Token = "0x600EF75")]
    [Address(RVA = "0x40D9530", Offset = "0x40D9530", VA = "0x40D9530")]
    private void CalcValueByDeadParty(
      BattlePlayerData player,
      UnitParameterData unit,
      ref HashSet<UnitParameterData> checkedList,
      ref List<BattleSupportValueInfo> list)
    {
    }
  }
}
