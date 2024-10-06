// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.LobbyTimeslotMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x200108C")]
  [Serializable]
  public sealed class LobbyTimeslotMaster : BaseMaster<LobbyTimeslotData>
  {
    [Token(Token = "0x6005FEE")]
    [Address(RVA = "0x28D332C", Offset = "0x28D332C", VA = "0x28D332C")]
    public IReadOnlyDictionary<int, LobbyTimeslotData> GetEntities()
    {
      return (IReadOnlyDictionary<int, LobbyTimeslotData>) null;
    }

    [Token(Token = "0x6005FEF")]
    [Address(RVA = "0x28D3334", Offset = "0x28D3334", VA = "0x28D3334", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6005FF0")]
    [Address(RVA = "0x28D3394", Offset = "0x28D3394", VA = "0x28D3394", Slot = "5")]
    protected override LobbyTimeslotData LoadEntity(IMasterDataReader reader)
    {
      return (LobbyTimeslotData) null;
    }

    [Token(Token = "0x6005FF1")]
    [Address(RVA = "0x28D33EC", Offset = "0x28D33EC", VA = "0x28D33EC")]
    public LobbyTimeslotMaster()
    {
    }
  }
}
