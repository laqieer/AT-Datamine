// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StoryCommunicationGroupLabelMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x20011F1")]
  [Serializable]
  public sealed class StoryCommunicationGroupLabelMaster : 
    BaseMaster<StoryCommunicationGroupLabelData>
  {
    [Token(Token = "0x6006677")]
    [Address(RVA = "0x4D25F0C", Offset = "0x4D25F0C", VA = "0x4D25F0C")]
    public IReadOnlyDictionary<int, StoryCommunicationGroupLabelData> GetEntities()
    {
      return (IReadOnlyDictionary<int, StoryCommunicationGroupLabelData>) null;
    }

    [Token(Token = "0x6006678")]
    [Address(RVA = "0x4D25F14", Offset = "0x4D25F14", VA = "0x4D25F14", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6006679")]
    [Address(RVA = "0x4D25F74", Offset = "0x4D25F74", VA = "0x4D25F74", Slot = "5")]
    protected override StoryCommunicationGroupLabelData LoadEntity(IMasterDataReader reader)
    {
      return (StoryCommunicationGroupLabelData) null;
    }

    [Token(Token = "0x600667A")]
    [Address(RVA = "0x4D25FCC", Offset = "0x4D25FCC", VA = "0x4D25FCC")]
    public StoryCommunicationGroupLabelMaster()
    {
    }
  }
}
