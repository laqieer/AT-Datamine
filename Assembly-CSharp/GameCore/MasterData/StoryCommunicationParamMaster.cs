// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StoryCommunicationParamMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x20011FD")]
  [Serializable]
  public sealed class StoryCommunicationParamMaster : BaseMaster<StoryCommunicationParamData>
  {
    [Token(Token = "0x400562D")]
    [FieldOffset(Offset = "0x18")]
    private Dictionary<int, List<StoryCommunicationParamData>> groupingTable;

    [Token(Token = "0x60066A8")]
    [Address(RVA = "0x4D2780C", Offset = "0x4D2780C", VA = "0x4D2780C")]
    public IReadOnlyDictionary<int, StoryCommunicationParamData> GetEntities()
    {
      return (IReadOnlyDictionary<int, StoryCommunicationParamData>) null;
    }

    [Token(Token = "0x60066A9")]
    [Address(RVA = "0x4D27814", Offset = "0x4D27814", VA = "0x4D27814", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x60066AA")]
    [Address(RVA = "0x4D278D8", Offset = "0x4D278D8", VA = "0x4D278D8", Slot = "5")]
    protected override StoryCommunicationParamData LoadEntity(IMasterDataReader reader)
    {
      return (StoryCommunicationParamData) null;
    }

    [Token(Token = "0x60066AB")]
    [Address(RVA = "0x4D2787C", Offset = "0x4D2787C", VA = "0x4D2787C")]
    private void OnAwakeLoading()
    {
    }

    [Token(Token = "0x60066AC")]
    [Address(RVA = "0x4D27948", Offset = "0x4D27948", VA = "0x4D27948")]
    private void OnLoadEntity(StoryCommunicationParamData entity)
    {
    }

    [Token(Token = "0x60066AD")]
    [Address(RVA = "0x4D2794C", Offset = "0x4D2794C", VA = "0x4D2794C")]
    private void GroupingByCommunicationID(StoryCommunicationParamData entity)
    {
    }

    [Token(Token = "0x60066AE")]
    [Address(RVA = "0x4D27AC8", Offset = "0x4D27AC8", VA = "0x4D27AC8")]
    public IReadOnlyCollection<StoryCommunicationParamData> GetListByCommunicationID(
      int communicationID)
    {
      return (IReadOnlyCollection<StoryCommunicationParamData>) null;
    }

    [Token(Token = "0x60066AF")]
    [Address(RVA = "0x4D27B84", Offset = "0x4D27B84", VA = "0x4D27B84")]
    public IEnumerable<StoryCommunicationParamData> GetList()
    {
      return (IEnumerable<StoryCommunicationParamData>) null;
    }

    [Token(Token = "0x60066B0")]
    [Address(RVA = "0x4D27BD4", Offset = "0x4D27BD4", VA = "0x4D27BD4")]
    public StoryCommunicationParamData Get(int communicationID, int rank)
    {
      return (StoryCommunicationParamData) null;
    }

    [Token(Token = "0x60066B1")]
    [Address(RVA = "0x4D27FF0", Offset = "0x4D27FF0", VA = "0x4D27FF0")]
    public StoryCommunicationParamData GetMaxRank(int communicationID)
    {
      return (StoryCommunicationParamData) null;
    }

    [Token(Token = "0x60066B2")]
    [Address(RVA = "0x4D281E4", Offset = "0x4D281E4", VA = "0x4D281E4")]
    public StoryCommunicationParamMaster()
    {
    }
  }
}
