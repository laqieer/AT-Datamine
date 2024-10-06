// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.LobbyFreeActionLeaderUnitEventMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x200107F")]
  [Serializable]
  public sealed class LobbyFreeActionLeaderUnitEventMaster : 
    BaseMaster<LobbyFreeActionLeaderUnitEventData>
  {
    [Token(Token = "0x400518E")]
    [FieldOffset(Offset = "0x18")]
    private Dictionary<int, Dictionary<int, List<LobbyFreeActionLeaderUnitEventData>>> groupingTable;

    [Token(Token = "0x6005FAE")]
    [Address(RVA = "0x28D09A8", Offset = "0x28D09A8", VA = "0x28D09A8")]
    public IReadOnlyDictionary<int, LobbyFreeActionLeaderUnitEventData> GetEntities()
    {
      return (IReadOnlyDictionary<int, LobbyFreeActionLeaderUnitEventData>) null;
    }

    [Token(Token = "0x6005FAF")]
    [Address(RVA = "0x28D09B0", Offset = "0x28D09B0", VA = "0x28D09B0", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6005FB0")]
    [Address(RVA = "0x28D0A68", Offset = "0x28D0A68", VA = "0x28D0A68", Slot = "5")]
    protected override LobbyFreeActionLeaderUnitEventData LoadEntity(IMasterDataReader reader)
    {
      return (LobbyFreeActionLeaderUnitEventData) null;
    }

    [Token(Token = "0x6005FB1")]
    [Address(RVA = "0x28D0A18", Offset = "0x28D0A18", VA = "0x28D0A18")]
    private void OnAwakeLoading()
    {
    }

    [Token(Token = "0x6005FB2")]
    [Address(RVA = "0x28D0AD8", Offset = "0x28D0AD8", VA = "0x28D0AD8")]
    private void OnLoadEntity(LobbyFreeActionLeaderUnitEventData entity)
    {
    }

    [Token(Token = "0x6005FB3")]
    [Address(RVA = "0x28D0D3C", Offset = "0x28D0D3C", VA = "0x28D0D3C")]
    public IEnumerable<LobbyFreeActionLeaderUnitEventData> GetList()
    {
      return (IEnumerable<LobbyFreeActionLeaderUnitEventData>) null;
    }

    [Token(Token = "0x6005FB4")]
    [Address(RVA = "0x28D0D8C", Offset = "0x28D0D8C", VA = "0x28D0D8C")]
    public IReadOnlyList<LobbyFreeActionLeaderUnitEventData> GetList(int groupLabel, int styleID)
    {
      return (IReadOnlyList<LobbyFreeActionLeaderUnitEventData>) null;
    }

    [Token(Token = "0x6005FB5")]
    [Address(RVA = "0x28D0E88", Offset = "0x28D0E88", VA = "0x28D0E88")]
    public LobbyFreeActionLeaderUnitEventData GetListByCondition(
      int groupLabel,
      int styleID,
      int chapterID,
      DateTime time,
      Func<int, bool> ignoreFunc = null)
    {
      return (LobbyFreeActionLeaderUnitEventData) null;
    }

    [Token(Token = "0x6005FB6")]
    [Address(RVA = "0x28D1078", Offset = "0x28D1078", VA = "0x28D1078")]
    public LobbyFreeActionLeaderUnitEventMaster()
    {
    }
  }
}
