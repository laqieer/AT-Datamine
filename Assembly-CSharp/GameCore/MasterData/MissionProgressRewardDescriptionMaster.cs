// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.MissionProgressRewardDescriptionMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x200109D")]
  [Serializable]
  public sealed class MissionProgressRewardDescriptionMaster : 
    BaseMaster<MissionProgressRewardDescriptionData>
  {
    [Token(Token = "0x6006035")]
    [Address(RVA = "0x28D549C", Offset = "0x28D549C", VA = "0x28D549C")]
    public IReadOnlyDictionary<int, MissionProgressRewardDescriptionData> GetEntities()
    {
      return (IReadOnlyDictionary<int, MissionProgressRewardDescriptionData>) null;
    }

    [Token(Token = "0x6006036")]
    [Address(RVA = "0x28D54A4", Offset = "0x28D54A4", VA = "0x28D54A4", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6006037")]
    [Address(RVA = "0x28D5504", Offset = "0x28D5504", VA = "0x28D5504", Slot = "5")]
    protected override MissionProgressRewardDescriptionData LoadEntity(IMasterDataReader reader)
    {
      return (MissionProgressRewardDescriptionData) null;
    }

    [Token(Token = "0x6006038")]
    [Address(RVA = "0x28D555C", Offset = "0x28D555C", VA = "0x28D555C")]
    public MissionProgressRewardDescriptionMaster()
    {
    }
  }
}
