// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StoryCommunicationRewardPriorityMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x200120A")]
  [Serializable]
  public sealed class StoryCommunicationRewardPriorityMaster : 
    BaseMaster<StoryCommunicationRewardPriorityData>
  {
    [Token(Token = "0x60066E3")]
    [Address(RVA = "0x4D29D34", Offset = "0x4D29D34", VA = "0x4D29D34")]
    public IReadOnlyDictionary<int, StoryCommunicationRewardPriorityData> GetEntities()
    {
      return (IReadOnlyDictionary<int, StoryCommunicationRewardPriorityData>) null;
    }

    [Token(Token = "0x60066E4")]
    [Address(RVA = "0x4D29D3C", Offset = "0x4D29D3C", VA = "0x4D29D3C", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x60066E5")]
    [Address(RVA = "0x4D29D9C", Offset = "0x4D29D9C", VA = "0x4D29D9C", Slot = "5")]
    protected override StoryCommunicationRewardPriorityData LoadEntity(IMasterDataReader reader)
    {
      return (StoryCommunicationRewardPriorityData) null;
    }

    [Token(Token = "0x60066E6")]
    [Address(RVA = "0x4D29DF4", Offset = "0x4D29DF4", VA = "0x4D29DF4")]
    public StoryCommunicationRewardPriorityMaster()
    {
    }
  }
}
