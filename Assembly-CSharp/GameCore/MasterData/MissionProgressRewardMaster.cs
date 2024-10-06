// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.MissionProgressRewardMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x200109F")]
  [Serializable]
  public sealed class MissionProgressRewardMaster : BaseMaster<MissionProgressRewardData>
  {
    [Token(Token = "0x40051F6")]
    [FieldOffset(Offset = "0x18")]
    private Dictionary<int, List<MissionProgressRewardData>> missionGroupIdDataMap;

    [Token(Token = "0x600603D")]
    [Address(RVA = "0x28D5894", Offset = "0x28D5894", VA = "0x28D5894")]
    public IReadOnlyDictionary<int, MissionProgressRewardData> GetEntities()
    {
      return (IReadOnlyDictionary<int, MissionProgressRewardData>) null;
    }

    [Token(Token = "0x600603E")]
    [Address(RVA = "0x28D589C", Offset = "0x28D589C", VA = "0x28D589C", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x600603F")]
    [Address(RVA = "0x28D58FC", Offset = "0x28D58FC", VA = "0x28D58FC", Slot = "5")]
    protected override MissionProgressRewardData LoadEntity(IMasterDataReader reader)
    {
      return (MissionProgressRewardData) null;
    }

    [Token(Token = "0x6006040")]
    [Address(RVA = "0x28D596C", Offset = "0x28D596C", VA = "0x28D596C")]
    private void OnLoadEntity(MissionProgressRewardData entity)
    {
    }

    [Token(Token = "0x6006041")]
    [Address(RVA = "0x28D5AE8", Offset = "0x28D5AE8", VA = "0x28D5AE8")]
    public List<MissionProgressRewardData> GetListByGroupId(int missionGroupId)
    {
      return (List<MissionProgressRewardData>) null;
    }

    [Token(Token = "0x6006042")]
    [Address(RVA = "0x28D5BBC", Offset = "0x28D5BBC", VA = "0x28D5BBC")]
    public MissionProgressRewardMaster()
    {
    }
  }
}
