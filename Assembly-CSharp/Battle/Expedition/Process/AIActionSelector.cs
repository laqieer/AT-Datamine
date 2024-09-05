// Decompiled with JetBrains decompiler
// Type: Battle.Expedition.Process.AIActionSelector
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Command;
using Battle.Process;
using Battle.Score;
using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace Battle.Expedition.Process
{
  [Il2CppDummyDll.Token(Token = "0x20025E0")]
  public sealed class AIActionSelector : Battle.Process.AIActionSelector
  {
    [Il2CppDummyDll.Token(Token = "0x600EA0D")]
    [Address(RVA = "0x4C4FDF4", Offset = "0x4C4FDF4", VA = "0x4C4FDF4")]
    public AIActionSelector(BattleCore core, int playerId)
    {
    }

    [Il2CppDummyDll.Token(Token = "0x600EA0E")]
    [Address(RVA = "0x4C4FDFC", Offset = "0x4C4FDFC", VA = "0x4C4FDFC", Slot = "25")]
    protected override Queue<UnitCommandBase> CreateActionCommand(CommandScore commandData)
    {
      return (Queue<UnitCommandBase>) null;
    }
  }
}
