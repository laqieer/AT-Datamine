// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.LobbyFreeActionConditionsMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001077")]
  [Serializable]
  public sealed class LobbyFreeActionConditionsMaster : BaseMaster<LobbyFreeActionConditionsData>
  {
    [Token(Token = "0x6005F7E")]
    [Address(RVA = "0x28CE800", Offset = "0x28CE800", VA = "0x28CE800")]
    public IReadOnlyDictionary<int, LobbyFreeActionConditionsData> GetEntities()
    {
      return (IReadOnlyDictionary<int, LobbyFreeActionConditionsData>) null;
    }

    [Token(Token = "0x6005F7F")]
    [Address(RVA = "0x28CE808", Offset = "0x28CE808", VA = "0x28CE808", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6005F80")]
    [Address(RVA = "0x28CE868", Offset = "0x28CE868", VA = "0x28CE868", Slot = "5")]
    protected override LobbyFreeActionConditionsData LoadEntity(IMasterDataReader reader)
    {
      return (LobbyFreeActionConditionsData) null;
    }

    [Token(Token = "0x6005F81")]
    [Address(RVA = "0x28CE8C0", Offset = "0x28CE8C0", VA = "0x28CE8C0")]
    public LobbyFreeActionConditionsMaster()
    {
    }
  }
}
