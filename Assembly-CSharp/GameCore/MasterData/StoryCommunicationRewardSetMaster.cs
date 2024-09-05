// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StoryCommunicationRewardSetMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x200120C")]
  [Serializable]
  public sealed class StoryCommunicationRewardSetMaster : BaseMaster<StoryCommunicationRewardSetData>
  {
    [Token(Token = "0x400565B")]
    [FieldOffset(Offset = "0x18")]
    private Dictionary<int, List<StoryCommunicationRewardSetData>> groupingTable;

    [Token(Token = "0x60066EB")]
    [Address(RVA = "0x4D2A04C", Offset = "0x4D2A04C", VA = "0x4D2A04C")]
    public IReadOnlyDictionary<int, StoryCommunicationRewardSetData> GetEntities()
    {
      return (IReadOnlyDictionary<int, StoryCommunicationRewardSetData>) null;
    }

    [Token(Token = "0x60066EC")]
    [Address(RVA = "0x4D2A054", Offset = "0x4D2A054", VA = "0x4D2A054", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x60066ED")]
    [Address(RVA = "0x4D2A118", Offset = "0x4D2A118", VA = "0x4D2A118", Slot = "5")]
    protected override StoryCommunicationRewardSetData LoadEntity(IMasterDataReader reader)
    {
      return (StoryCommunicationRewardSetData) null;
    }

    [Token(Token = "0x60066EE")]
    [Address(RVA = "0x4D2A0BC", Offset = "0x4D2A0BC", VA = "0x4D2A0BC")]
    private void OnAwakeLoading()
    {
    }

    [Token(Token = "0x60066EF")]
    [Address(RVA = "0x4D2A188", Offset = "0x4D2A188", VA = "0x4D2A188")]
    private void OnLoadEntity(StoryCommunicationRewardSetData entity)
    {
    }

    [Token(Token = "0x60066F0")]
    [Address(RVA = "0x4D2A238", Offset = "0x4D2A238", VA = "0x4D2A238")]
    private void GroupingByCommunicationID(StoryCommunicationRewardSetData entity)
    {
    }

    [Token(Token = "0x60066F1")]
    [Address(RVA = "0x4D2A3B4", Offset = "0x4D2A3B4", VA = "0x4D2A3B4")]
    public IReadOnlyCollection<StoryCommunicationRewardSetData> GetListByRewardSetLabel(int key)
    {
      return (IReadOnlyCollection<StoryCommunicationRewardSetData>) null;
    }

    [Token(Token = "0x60066F2")]
    [Address(RVA = "0x4D2A470", Offset = "0x4D2A470", VA = "0x4D2A470")]
    public StoryCommunicationRewardSetMaster()
    {
    }
  }
}
