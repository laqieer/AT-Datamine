// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StoryCommunicationIdentifierMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x20011F3")]
  [Serializable]
  public sealed class StoryCommunicationIdentifierMaster : 
    BaseMaster<StoryCommunicationIdentifierData>
  {
    [Token(Token = "0x600667F")]
    [Address(RVA = "0x4D261B8", Offset = "0x4D261B8", VA = "0x4D261B8")]
    public IReadOnlyDictionary<int, StoryCommunicationIdentifierData> GetEntities()
    {
      return (IReadOnlyDictionary<int, StoryCommunicationIdentifierData>) null;
    }

    [Token(Token = "0x6006680")]
    [Address(RVA = "0x4D261C0", Offset = "0x4D261C0", VA = "0x4D261C0", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6006681")]
    [Address(RVA = "0x4D26220", Offset = "0x4D26220", VA = "0x4D26220", Slot = "5")]
    protected override StoryCommunicationIdentifierData LoadEntity(IMasterDataReader reader)
    {
      return (StoryCommunicationIdentifierData) null;
    }

    [Token(Token = "0x6006682")]
    [Address(RVA = "0x4D26278", Offset = "0x4D26278", VA = "0x4D26278")]
    public IEnumerable<StoryCommunicationIdentifierData> GetList()
    {
      return (IEnumerable<StoryCommunicationIdentifierData>) null;
    }

    [Token(Token = "0x6006683")]
    [Address(RVA = "0x4D262C8", Offset = "0x4D262C8", VA = "0x4D262C8")]
    public IEnumerable<StoryCommunicationIdentifierData> GetByGroupLabel(int groupLabel)
    {
      return (IEnumerable<StoryCommunicationIdentifierData>) null;
    }

    [Token(Token = "0x6006684")]
    [Address(RVA = "0x4D263D0", Offset = "0x4D263D0", VA = "0x4D263D0")]
    public IEnumerable<StoryCommunicationIdentifierData> GetByCharacterId(int characterId)
    {
      return (IEnumerable<StoryCommunicationIdentifierData>) null;
    }

    [Token(Token = "0x6006685")]
    [Address(RVA = "0x4D264D8", Offset = "0x4D264D8", VA = "0x4D264D8")]
    public StoryCommunicationIdentifierMaster()
    {
    }
  }
}
