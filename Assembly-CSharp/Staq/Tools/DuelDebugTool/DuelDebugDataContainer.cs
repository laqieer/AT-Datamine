// Decompiled with JetBrains decompiler
// Type: Staq.Tools.DuelDebugTool.DuelDebugDataContainer
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace Staq.Tools.DuelDebugTool
{
  [Token(Token = "0x200097E")]
  public class DuelDebugDataContainer
  {
    [Token(Token = "0x4002C27")]
    [FieldOffset(Offset = "0x10")]
    public DuelDebugEnvironment Environment;
    [Token(Token = "0x4002C28")]
    [FieldOffset(Offset = "0x18")]
    public DuelDebugActor Attacker;
    [Token(Token = "0x4002C29")]
    [FieldOffset(Offset = "0x20")]
    public DuelDebugActor AttackerSupporter;
    [Token(Token = "0x4002C2A")]
    [FieldOffset(Offset = "0x28")]
    public DuelDebugActor Defender;
    [Token(Token = "0x4002C2B")]
    [FieldOffset(Offset = "0x30")]
    public DuelDebugActor DefenderSupporter;
    [Token(Token = "0x4002C2C")]
    [FieldOffset(Offset = "0x38")]
    public List<DuelDebugTurn> TurnList;

    [Token(Token = "0x6003601")]
    [Address(RVA = "0x35312D0", Offset = "0x35312D0", VA = "0x35312D0")]
    public DuelDebugDataContainer()
    {
    }

    [Token(Token = "0x6003602")]
    [Address(RVA = "0x35312EC", Offset = "0x35312EC", VA = "0x35312EC")]
    public void Reset()
    {
    }

    [Token(Token = "0x6003603")]
    [Address(RVA = "0x352C284", Offset = "0x352C284", VA = "0x352C284")]
    public void AddNewTurn()
    {
    }

    [Token(Token = "0x6003604")]
    [Address(RVA = "0x352C38C", Offset = "0x352C38C", VA = "0x352C38C")]
    public void RemoveLastTurn()
    {
    }

    [Token(Token = "0x6003605")]
    [Address(RVA = "0x35314E4", Offset = "0x35314E4", VA = "0x35314E4")]
    public DuelInputData ConvertToInputData() => (DuelInputData) null;

    [Token(Token = "0x6003606")]
    [Address(RVA = "0x35316B0", Offset = "0x35316B0", VA = "0x35316B0")]
    public void Load(DuelInputData sourceData)
    {
    }
  }
}
