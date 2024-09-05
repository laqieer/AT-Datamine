// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StoryBattleMissionRewardMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000E6A")]
  [Serializable]
  public sealed class StoryBattleMissionRewardMaster : BaseMaster<StoryBattleMissionRewardData>
  {
    [Token(Token = "0x60057D6")]
    [Address(RVA = "0x3E44158", Offset = "0x3E44158", VA = "0x3E44158")]
    public IReadOnlyDictionary<int, StoryBattleMissionRewardData> GetEntities()
    {
      return (IReadOnlyDictionary<int, StoryBattleMissionRewardData>) null;
    }

    [Token(Token = "0x60057D7")]
    [Address(RVA = "0x3E44160", Offset = "0x3E44160", VA = "0x3E44160", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x60057D8")]
    [Address(RVA = "0x3E441C0", Offset = "0x3E441C0", VA = "0x3E441C0", Slot = "5")]
    protected override StoryBattleMissionRewardData LoadEntity(IMasterDataReader reader)
    {
      return (StoryBattleMissionRewardData) null;
    }

    [Token(Token = "0x60057D9")]
    [Address(RVA = "0x3E44218", Offset = "0x3E44218", VA = "0x3E44218")]
    public StoryBattleMissionRewardMaster()
    {
    }
  }
}
