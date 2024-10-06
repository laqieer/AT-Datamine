// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.MissionMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x20010A5")]
  [Serializable]
  public sealed class MissionMaster : BaseMaster<MissionData>
  {
    [Token(Token = "0x4005205")]
    public const string TEXT_AB = "text_masterdata_mission";

    [Token(Token = "0x6006058")]
    [Address(RVA = "0x28D67CC", Offset = "0x28D67CC", VA = "0x28D67CC")]
    public IReadOnlyDictionary<int, MissionData> GetEntities()
    {
      return (IReadOnlyDictionary<int, MissionData>) null;
    }

    [Token(Token = "0x6006059")]
    [Address(RVA = "0x28D67D4", Offset = "0x28D67D4", VA = "0x28D67D4", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x600605A")]
    [Address(RVA = "0x28D6834", Offset = "0x28D6834", VA = "0x28D6834", Slot = "5")]
    protected override MissionData LoadEntity(IMasterDataReader reader) => (MissionData) null;

    [Token(Token = "0x600605B")]
    [Address(RVA = "0x28D688C", Offset = "0x28D688C", VA = "0x28D688C")]
    public MissionMaster()
    {
    }
  }
}
