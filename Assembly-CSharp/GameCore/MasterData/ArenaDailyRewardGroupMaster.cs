// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.ArenaDailyRewardGroupMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000DE6")]
  [Serializable]
  public sealed class ArenaDailyRewardGroupMaster : BaseMaster<ArenaDailyRewardGroupData>
  {
    [Token(Token = "0x60054DE")]
    [Address(RVA = "0x3AA91B0", Offset = "0x3AA91B0", VA = "0x3AA91B0")]
    public IReadOnlyDictionary<int, ArenaDailyRewardGroupData> GetEntities()
    {
      return (IReadOnlyDictionary<int, ArenaDailyRewardGroupData>) null;
    }

    [Token(Token = "0x60054DF")]
    [Address(RVA = "0x3AA91B8", Offset = "0x3AA91B8", VA = "0x3AA91B8", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x60054E0")]
    [Address(RVA = "0x3AA9218", Offset = "0x3AA9218", VA = "0x3AA9218", Slot = "5")]
    protected override ArenaDailyRewardGroupData LoadEntity(IMasterDataReader reader)
    {
      return (ArenaDailyRewardGroupData) null;
    }

    [Token(Token = "0x60054E1")]
    [Address(RVA = "0x3AA9270", Offset = "0x3AA9270", VA = "0x3AA9270")]
    public ArenaDailyRewardGroupMaster()
    {
    }
  }
}
