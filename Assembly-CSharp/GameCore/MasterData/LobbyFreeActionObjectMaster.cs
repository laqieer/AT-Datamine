// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.LobbyFreeActionObjectMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001086")]
  [Serializable]
  public sealed class LobbyFreeActionObjectMaster : BaseMaster<LobbyFreeActionObjectData>
  {
    [Token(Token = "0x6005FCF")]
    [Address(RVA = "0x28D249C", Offset = "0x28D249C", VA = "0x28D249C")]
    public IReadOnlyDictionary<int, LobbyFreeActionObjectData> GetEntities()
    {
      return (IReadOnlyDictionary<int, LobbyFreeActionObjectData>) null;
    }

    [Token(Token = "0x6005FD0")]
    [Address(RVA = "0x28D24A4", Offset = "0x28D24A4", VA = "0x28D24A4", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6005FD1")]
    [Address(RVA = "0x28D2504", Offset = "0x28D2504", VA = "0x28D2504", Slot = "5")]
    protected override LobbyFreeActionObjectData LoadEntity(IMasterDataReader reader)
    {
      return (LobbyFreeActionObjectData) null;
    }

    [Token(Token = "0x6005FD2")]
    [Address(RVA = "0x28D255C", Offset = "0x28D255C", VA = "0x28D255C")]
    public LobbyFreeActionObjectMaster()
    {
    }
  }
}
