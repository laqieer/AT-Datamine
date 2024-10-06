// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StoryCommunicationLocationTermMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x20011FB")]
  [Serializable]
  public sealed class StoryCommunicationLocationTermMaster : 
    BaseMaster<StoryCommunicationLocationTermData>
  {
    [Token(Token = "0x60066A0")]
    [Address(RVA = "0x4D27414", Offset = "0x4D27414", VA = "0x4D27414")]
    public IReadOnlyDictionary<int, StoryCommunicationLocationTermData> GetEntities()
    {
      return (IReadOnlyDictionary<int, StoryCommunicationLocationTermData>) null;
    }

    [Token(Token = "0x60066A1")]
    [Address(RVA = "0x4D2741C", Offset = "0x4D2741C", VA = "0x4D2741C", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x60066A2")]
    [Address(RVA = "0x4D2747C", Offset = "0x4D2747C", VA = "0x4D2747C", Slot = "5")]
    protected override StoryCommunicationLocationTermData LoadEntity(IMasterDataReader reader)
    {
      return (StoryCommunicationLocationTermData) null;
    }

    [Token(Token = "0x60066A3")]
    [Address(RVA = "0x4D274D4", Offset = "0x4D274D4", VA = "0x4D274D4")]
    public StoryCommunicationLocationTermMaster()
    {
    }
  }
}
