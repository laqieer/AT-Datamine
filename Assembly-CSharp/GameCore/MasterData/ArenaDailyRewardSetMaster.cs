// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.ArenaDailyRewardSetMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000DE8")]
  [Serializable]
  public sealed class ArenaDailyRewardSetMaster : BaseMaster<ArenaDailyRewardSetData>
  {
    [Token(Token = "0x60054E6")]
    [Address(RVA = "0x3AA945C", Offset = "0x3AA945C", VA = "0x3AA945C")]
    public IReadOnlyDictionary<int, ArenaDailyRewardSetData> GetEntities()
    {
      return (IReadOnlyDictionary<int, ArenaDailyRewardSetData>) null;
    }

    [Token(Token = "0x60054E7")]
    [Address(RVA = "0x3AA9464", Offset = "0x3AA9464", VA = "0x3AA9464", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x60054E8")]
    [Address(RVA = "0x3AA94C4", Offset = "0x3AA94C4", VA = "0x3AA94C4", Slot = "5")]
    protected override ArenaDailyRewardSetData LoadEntity(IMasterDataReader reader)
    {
      return (ArenaDailyRewardSetData) null;
    }

    [Token(Token = "0x60054E9")]
    [Address(RVA = "0x3AA951C", Offset = "0x3AA951C", VA = "0x3AA951C")]
    public ArenaDailyRewardSetMaster()
    {
    }
  }
}
