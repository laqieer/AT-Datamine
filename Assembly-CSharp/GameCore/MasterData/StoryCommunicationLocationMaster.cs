// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StoryCommunicationLocationMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x20011F9")]
  [Serializable]
  public sealed class StoryCommunicationLocationMaster : BaseMaster<StoryCommunicationLocationData>
  {
    [Token(Token = "0x4005621")]
    public const string TEXT_AB = "text_masterdata_story";

    [Token(Token = "0x6006697")]
    [Address(RVA = "0x4D26ECC", Offset = "0x4D26ECC", VA = "0x4D26ECC")]
    public IReadOnlyDictionary<int, StoryCommunicationLocationData> GetEntities()
    {
      return (IReadOnlyDictionary<int, StoryCommunicationLocationData>) null;
    }

    [Token(Token = "0x6006698")]
    [Address(RVA = "0x4D26ED4", Offset = "0x4D26ED4", VA = "0x4D26ED4", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6006699")]
    [Address(RVA = "0x4D26F34", Offset = "0x4D26F34", VA = "0x4D26F34", Slot = "5")]
    protected override StoryCommunicationLocationData LoadEntity(IMasterDataReader reader)
    {
      return (StoryCommunicationLocationData) null;
    }

    [Token(Token = "0x600669A")]
    [Address(RVA = "0x4D26F8C", Offset = "0x4D26F8C", VA = "0x4D26F8C")]
    public StoryCommunicationLocationMaster()
    {
    }
  }
}
