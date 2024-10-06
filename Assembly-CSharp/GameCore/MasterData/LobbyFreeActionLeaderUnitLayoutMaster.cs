// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.LobbyFreeActionLeaderUnitLayoutMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001083")]
  [Serializable]
  public sealed class LobbyFreeActionLeaderUnitLayoutMaster : 
    BaseMaster<LobbyFreeActionLeaderUnitLayoutData>
  {
    [Token(Token = "0x40051A2")]
    private const int DefaultLayoutID = 0;
    [Token(Token = "0x40051A3")]
    [FieldOffset(Offset = "0x18")]
    private Dictionary<int, List<LobbyFreeActionLeaderUnitLayoutData>> groupingTable;

    [Token(Token = "0x6005FC0")]
    [Address(RVA = "0x28D18F4", Offset = "0x28D18F4", VA = "0x28D18F4")]
    public IReadOnlyDictionary<int, LobbyFreeActionLeaderUnitLayoutData> GetEntities()
    {
      return (IReadOnlyDictionary<int, LobbyFreeActionLeaderUnitLayoutData>) null;
    }

    [Token(Token = "0x6005FC1")]
    [Address(RVA = "0x28D18FC", Offset = "0x28D18FC", VA = "0x28D18FC", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6005FC2")]
    [Address(RVA = "0x28D19B4", Offset = "0x28D19B4", VA = "0x28D19B4", Slot = "5")]
    protected override LobbyFreeActionLeaderUnitLayoutData LoadEntity(IMasterDataReader reader)
    {
      return (LobbyFreeActionLeaderUnitLayoutData) null;
    }

    [Token(Token = "0x6005FC3")]
    [Address(RVA = "0x28D1964", Offset = "0x28D1964", VA = "0x28D1964")]
    private void OnAwakeLoading()
    {
    }

    [Token(Token = "0x6005FC4")]
    [Address(RVA = "0x28D1A24", Offset = "0x28D1A24", VA = "0x28D1A24")]
    private void OnLoadEntity(LobbyFreeActionLeaderUnitLayoutData entity)
    {
    }

    [Token(Token = "0x6005FC5")]
    [Address(RVA = "0x28D1BE4", Offset = "0x28D1BE4", VA = "0x28D1BE4")]
    public LobbyFreeActionLeaderUnitLayoutData GetDefaultLayoutData()
    {
      return (LobbyFreeActionLeaderUnitLayoutData) null;
    }

    [Token(Token = "0x6005FC6")]
    [Address(RVA = "0x28D1C30", Offset = "0x28D1C30", VA = "0x28D1C30")]
    public IReadOnlyList<LobbyFreeActionLeaderUnitLayoutData> GetListByGroupLabel(
      int layoutGroupLabel)
    {
      return (IReadOnlyList<LobbyFreeActionLeaderUnitLayoutData>) null;
    }

    [Token(Token = "0x6005FC7")]
    [Address(RVA = "0x28D1CEC", Offset = "0x28D1CEC", VA = "0x28D1CEC")]
    public LobbyFreeActionLeaderUnitLayoutData GetListByCondition(
      int layoutGroupLabel,
      int styleID,
      int chapterID,
      DateTime time)
    {
      return (LobbyFreeActionLeaderUnitLayoutData) null;
    }

    [Token(Token = "0x6005FC8")]
    [Address(RVA = "0x28D1E14", Offset = "0x28D1E14", VA = "0x28D1E14")]
    public LobbyFreeActionLeaderUnitLayoutMaster()
    {
    }
  }
}
