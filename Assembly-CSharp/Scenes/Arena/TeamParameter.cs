// Decompiled with JetBrains decompiler
// Type: Scenes.Arena.TeamParameter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace Scenes.Arena
{
  [Token(Token = "0x200314F")]
  public class TeamParameter
  {
    [Token(Token = "0x400D1FF")]
    [FieldOffset(Offset = "0x10")]
    public List<int> teamStyleIds;
    [Token(Token = "0x400D200")]
    [FieldOffset(Offset = "0x18")]
    public string combatPower;
    [Token(Token = "0x400D201")]
    [FieldOffset(Offset = "0x20")]
    public string playerName;
    [Token(Token = "0x400D202")]
    [FieldOffset(Offset = "0x28")]
    public int emblemId;

    [Token(Token = "0x60133DA")]
    [Address(RVA = "0x4A238B0", Offset = "0x4A238B0", VA = "0x4A238B0")]
    public TeamParameter(
      List<int> teamStyleIds,
      string combatPower,
      string playerName,
      int emblemId)
    {
    }
  }
}
