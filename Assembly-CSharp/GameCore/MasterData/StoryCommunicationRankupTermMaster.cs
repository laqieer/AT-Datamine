// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StoryCommunicationRankupTermMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001206")]
  [Serializable]
  public sealed class StoryCommunicationRankupTermMaster : 
    BaseMaster<StoryCommunicationRankupTermData>
  {
    [Token(Token = "0x60066D3")]
    [Address(RVA = "0x4D29620", Offset = "0x4D29620", VA = "0x4D29620")]
    public IReadOnlyDictionary<int, StoryCommunicationRankupTermData> GetEntities()
    {
      return (IReadOnlyDictionary<int, StoryCommunicationRankupTermData>) null;
    }

    [Token(Token = "0x60066D4")]
    [Address(RVA = "0x4D29628", Offset = "0x4D29628", VA = "0x4D29628", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x60066D5")]
    [Address(RVA = "0x4D29688", Offset = "0x4D29688", VA = "0x4D29688", Slot = "5")]
    protected override StoryCommunicationRankupTermData LoadEntity(IMasterDataReader reader)
    {
      return (StoryCommunicationRankupTermData) null;
    }

    [Token(Token = "0x60066D6")]
    [Address(RVA = "0x4D296E0", Offset = "0x4D296E0", VA = "0x4D296E0")]
    public StoryCommunicationRankupTermMaster()
    {
    }
  }
}
