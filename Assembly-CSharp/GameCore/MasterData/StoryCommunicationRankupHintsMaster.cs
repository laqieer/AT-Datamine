// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StoryCommunicationRankupHintsMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001203")]
  [Serializable]
  public sealed class StoryCommunicationRankupHintsMaster : 
    BaseMaster<StoryCommunicationRankupHintsData>
  {
    [Token(Token = "0x4005649")]
    public const string TEXT_AB = "text_masterdata_story";

    [Token(Token = "0x60066C9")]
    [Address(RVA = "0x4D29238", Offset = "0x4D29238", VA = "0x4D29238")]
    public IReadOnlyDictionary<int, StoryCommunicationRankupHintsData> GetEntities()
    {
      return (IReadOnlyDictionary<int, StoryCommunicationRankupHintsData>) null;
    }

    [Token(Token = "0x60066CA")]
    [Address(RVA = "0x4D29240", Offset = "0x4D29240", VA = "0x4D29240", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x60066CB")]
    [Address(RVA = "0x4D292A0", Offset = "0x4D292A0", VA = "0x4D292A0", Slot = "5")]
    protected override StoryCommunicationRankupHintsData LoadEntity(IMasterDataReader reader)
    {
      return (StoryCommunicationRankupHintsData) null;
    }

    [Token(Token = "0x60066CC")]
    [Address(RVA = "0x4D292F8", Offset = "0x4D292F8", VA = "0x4D292F8")]
    public StoryCommunicationRankupHintsMaster()
    {
    }
  }
}
