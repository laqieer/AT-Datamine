// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StoryCommunicationReactionTypeMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001208")]
  [Serializable]
  public sealed class StoryCommunicationReactionTypeMaster : 
    BaseMaster<StoryCommunicationReactionTypeData>
  {
    [Token(Token = "0x60066DB")]
    [Address(RVA = "0x4D29A88", Offset = "0x4D29A88", VA = "0x4D29A88")]
    public IReadOnlyDictionary<int, StoryCommunicationReactionTypeData> GetEntities()
    {
      return (IReadOnlyDictionary<int, StoryCommunicationReactionTypeData>) null;
    }

    [Token(Token = "0x60066DC")]
    [Address(RVA = "0x4D29A90", Offset = "0x4D29A90", VA = "0x4D29A90", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x60066DD")]
    [Address(RVA = "0x4D29AF0", Offset = "0x4D29AF0", VA = "0x4D29AF0", Slot = "5")]
    protected override StoryCommunicationReactionTypeData LoadEntity(IMasterDataReader reader)
    {
      return (StoryCommunicationReactionTypeData) null;
    }

    [Token(Token = "0x60066DE")]
    [Address(RVA = "0x4D29B48", Offset = "0x4D29B48", VA = "0x4D29B48")]
    public StoryCommunicationReactionTypeMaster()
    {
    }
  }
}
