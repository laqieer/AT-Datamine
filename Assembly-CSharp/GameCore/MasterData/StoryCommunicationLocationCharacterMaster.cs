// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StoryCommunicationLocationCharacterMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x20011F7")]
  [Serializable]
  public sealed class StoryCommunicationLocationCharacterMaster : 
    BaseMaster<StoryCommunicationLocationCharacterData>
  {
    [Token(Token = "0x600668E")]
    [Address(RVA = "0x4D2693C", Offset = "0x4D2693C", VA = "0x4D2693C")]
    public IReadOnlyDictionary<int, StoryCommunicationLocationCharacterData> GetEntities()
    {
      return (IReadOnlyDictionary<int, StoryCommunicationLocationCharacterData>) null;
    }

    [Token(Token = "0x600668F")]
    [Address(RVA = "0x4D26944", Offset = "0x4D26944", VA = "0x4D26944", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6006690")]
    [Address(RVA = "0x4D269A4", Offset = "0x4D269A4", VA = "0x4D269A4", Slot = "5")]
    protected override StoryCommunicationLocationCharacterData LoadEntity(IMasterDataReader reader)
    {
      return (StoryCommunicationLocationCharacterData) null;
    }

    [Token(Token = "0x6006691")]
    [Address(RVA = "0x4D269FC", Offset = "0x4D269FC", VA = "0x4D269FC")]
    public StoryCommunicationLocationCharacterData Get(int communicationID, int locationID)
    {
      return (StoryCommunicationLocationCharacterData) null;
    }

    [Token(Token = "0x6006692")]
    [Address(RVA = "0x4D26B90", Offset = "0x4D26B90", VA = "0x4D26B90")]
    public StoryCommunicationLocationCharacterMaster()
    {
    }
  }
}
