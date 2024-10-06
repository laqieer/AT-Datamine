// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.LobbySeasonMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001088")]
  [Serializable]
  public sealed class LobbySeasonMaster : BaseMaster<LobbySeasonData>
  {
    [Token(Token = "0x6005FDD")]
    [Address(RVA = "0x28D28CC", Offset = "0x28D28CC", VA = "0x28D28CC")]
    public IReadOnlyDictionary<int, LobbySeasonData> GetEntities()
    {
      return (IReadOnlyDictionary<int, LobbySeasonData>) null;
    }

    [Token(Token = "0x6005FDE")]
    [Address(RVA = "0x28D28D4", Offset = "0x28D28D4", VA = "0x28D28D4", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6005FDF")]
    [Address(RVA = "0x28D2934", Offset = "0x28D2934", VA = "0x28D2934", Slot = "5")]
    protected override LobbySeasonData LoadEntity(IMasterDataReader reader)
    {
      return (LobbySeasonData) null;
    }

    [Token(Token = "0x6005FE0")]
    [Address(RVA = "0x28D298C", Offset = "0x28D298C", VA = "0x28D298C")]
    public LobbySeasonMaster()
    {
    }
  }
}
