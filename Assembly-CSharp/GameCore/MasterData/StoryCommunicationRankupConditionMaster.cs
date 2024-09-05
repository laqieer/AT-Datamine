// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StoryCommunicationRankupConditionMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001201")]
  [Serializable]
  public sealed class StoryCommunicationRankupConditionMaster : 
    BaseMaster<StoryCommunicationRankupConditionData>
  {
    [Token(Token = "0x4005642")]
    public const string TEXT_AB = "text_masterdata_story";
    [Token(Token = "0x4005643")]
    [FieldOffset(Offset = "0x18")]
    private Dictionary<(int, int), List<StoryCommunicationRankupConditionData>> rankupGroup;

    [Token(Token = "0x60066BD")]
    [Address(RVA = "0x4D28AF4", Offset = "0x4D28AF4", VA = "0x4D28AF4")]
    public IReadOnlyDictionary<int, StoryCommunicationRankupConditionData> GetEntities()
    {
      return (IReadOnlyDictionary<int, StoryCommunicationRankupConditionData>) null;
    }

    [Token(Token = "0x60066BE")]
    [Address(RVA = "0x4D28AFC", Offset = "0x4D28AFC", VA = "0x4D28AFC", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x60066BF")]
    [Address(RVA = "0x4D28BB4", Offset = "0x4D28BB4", VA = "0x4D28BB4", Slot = "5")]
    protected override StoryCommunicationRankupConditionData LoadEntity(IMasterDataReader reader)
    {
      return (StoryCommunicationRankupConditionData) null;
    }

    [Token(Token = "0x60066C0")]
    [Address(RVA = "0x4D28B64", Offset = "0x4D28B64", VA = "0x4D28B64")]
    private void OnAwakeLoading()
    {
    }

    [Token(Token = "0x60066C1")]
    [Address(RVA = "0x4D28C24", Offset = "0x4D28C24", VA = "0x4D28C24")]
    private void OnLoadEntity(StoryCommunicationRankupConditionData entity)
    {
    }

    [Token(Token = "0x60066C2")]
    [Address(RVA = "0x4D28C28", Offset = "0x4D28C28", VA = "0x4D28C28")]
    private void Grouping(StoryCommunicationRankupConditionData entity)
    {
    }

    [Token(Token = "0x60066C3")]
    [Address(RVA = "0x4D28E0C", Offset = "0x4D28E0C", VA = "0x4D28E0C")]
    public IReadOnlyList<StoryCommunicationRankupConditionData> GetList(
      int communicationID,
      int rank)
    {
      return (IReadOnlyList<StoryCommunicationRankupConditionData>) null;
    }

    [Token(Token = "0x60066C4")]
    [Address(RVA = "0x4D28EB8", Offset = "0x4D28EB8", VA = "0x4D28EB8")]
    public StoryCommunicationRankupConditionMaster()
    {
    }
  }
}
