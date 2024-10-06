// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.LobbyFreeActionEventMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001079")]
  [Serializable]
  public sealed class LobbyFreeActionEventMaster : BaseMaster<LobbyFreeActionEventData>
  {
    [Token(Token = "0x4005172")]
    [FieldOffset(Offset = "0x18")]
    private Dictionary<int, List<LobbyFreeActionEventData>> groupingTable;

    [Token(Token = "0x6005F8B")]
    [Address(RVA = "0x28CF194", Offset = "0x28CF194", VA = "0x28CF194")]
    public IReadOnlyDictionary<int, LobbyFreeActionEventData> GetEntities()
    {
      return (IReadOnlyDictionary<int, LobbyFreeActionEventData>) null;
    }

    [Token(Token = "0x6005F8C")]
    [Address(RVA = "0x28CF19C", Offset = "0x28CF19C", VA = "0x28CF19C", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6005F8D")]
    [Address(RVA = "0x28CF254", Offset = "0x28CF254", VA = "0x28CF254", Slot = "5")]
    protected override LobbyFreeActionEventData LoadEntity(IMasterDataReader reader)
    {
      return (LobbyFreeActionEventData) null;
    }

    [Token(Token = "0x6005F8E")]
    [Address(RVA = "0x28CF204", Offset = "0x28CF204", VA = "0x28CF204")]
    private void OnAwakeLoading()
    {
    }

    [Token(Token = "0x6005F8F")]
    [Address(RVA = "0x28CF2C4", Offset = "0x28CF2C4", VA = "0x28CF2C4")]
    private void OnLoadEntity(LobbyFreeActionEventData entity)
    {
    }

    [Token(Token = "0x6005F90")]
    [Address(RVA = "0x28CF484", Offset = "0x28CF484", VA = "0x28CF484")]
    public IReadOnlyList<LobbyFreeActionEventData> GetListByGroupLabel(int groupLabel)
    {
      return (IReadOnlyList<LobbyFreeActionEventData>) null;
    }

    [Token(Token = "0x6005F91")]
    [Address(RVA = "0x28CF540", Offset = "0x28CF540", VA = "0x28CF540")]
    public IEnumerable<LobbyFreeActionEventData> GetListByCondition(
      int groupLabel,
      int chapterID,
      DateTime time)
    {
      return (IEnumerable<LobbyFreeActionEventData>) null;
    }

    [Token(Token = "0x6005F92")]
    [Address(RVA = "0x28CF644", Offset = "0x28CF644", VA = "0x28CF644")]
    public LobbyFreeActionEventMaster()
    {
    }
  }
}
