// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StoryCommunicationAttachMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x20011EE")]
  [Serializable]
  public sealed class StoryCommunicationAttachMaster : BaseMaster<StoryCommunicationAttachData>
  {
    [Token(Token = "0x4005604")]
    [FieldOffset(Offset = "0x18")]
    private Dictionary<int, List<StoryCommunicationAttachData>> groupingTable;

    [Token(Token = "0x6006667")]
    [Address(RVA = "0x4D2544C", Offset = "0x4D2544C", VA = "0x4D2544C")]
    public IReadOnlyDictionary<int, StoryCommunicationAttachData> GetEntities()
    {
      return (IReadOnlyDictionary<int, StoryCommunicationAttachData>) null;
    }

    [Token(Token = "0x6006668")]
    [Address(RVA = "0x4D25454", Offset = "0x4D25454", VA = "0x4D25454", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6006669")]
    [Address(RVA = "0x4D25518", Offset = "0x4D25518", VA = "0x4D25518", Slot = "5")]
    protected override StoryCommunicationAttachData LoadEntity(IMasterDataReader reader)
    {
      return (StoryCommunicationAttachData) null;
    }

    [Token(Token = "0x600666A")]
    [Address(RVA = "0x4D254BC", Offset = "0x4D254BC", VA = "0x4D254BC")]
    private void OnAwakeLoading()
    {
    }

    [Token(Token = "0x600666B")]
    [Address(RVA = "0x4D25588", Offset = "0x4D25588", VA = "0x4D25588")]
    private void OnLoadEntity(StoryCommunicationAttachData entity)
    {
    }

    [Token(Token = "0x600666C")]
    [Address(RVA = "0x4D2558C", Offset = "0x4D2558C", VA = "0x4D2558C")]
    private void GroupingByCommunicationID(StoryCommunicationAttachData entity)
    {
    }

    [Token(Token = "0x600666D")]
    [Address(RVA = "0x4D25708", Offset = "0x4D25708", VA = "0x4D25708")]
    public IEnumerable<StoryCommunicationAttachData> GetList()
    {
      return (IEnumerable<StoryCommunicationAttachData>) null;
    }

    [Token(Token = "0x600666E")]
    [Address(RVA = "0x4D25758", Offset = "0x4D25758", VA = "0x4D25758")]
    public IReadOnlyCollection<StoryCommunicationAttachData> GetListByCommunicationLabel(
      int groupLabel)
    {
      return (IReadOnlyCollection<StoryCommunicationAttachData>) null;
    }

    [Token(Token = "0x600666F")]
    [Address(RVA = "0x4D25814", Offset = "0x4D25814", VA = "0x4D25814")]
    public StoryCommunicationAttachData GetCommunicationLabelByCommunicationIDAndCommuGroupLabel(
      int communicationId,
      int commuGroupLabel)
    {
      return (StoryCommunicationAttachData) null;
    }

    [Token(Token = "0x6006670")]
    [Address(RVA = "0x4D25920", Offset = "0x4D25920", VA = "0x4D25920")]
    public StoryCommunicationAttachMaster()
    {
    }
  }
}
