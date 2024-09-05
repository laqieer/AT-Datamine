// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.ArenaDailyRewardMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000DEA")]
  [Serializable]
  public sealed class ArenaDailyRewardMaster : BaseMaster<ArenaDailyRewardData>
  {
    [Token(Token = "0x60054EE")]
    [Address(RVA = "0x3AA9858", Offset = "0x3AA9858", VA = "0x3AA9858")]
    public IReadOnlyDictionary<int, ArenaDailyRewardData> GetEntities()
    {
      return (IReadOnlyDictionary<int, ArenaDailyRewardData>) null;
    }

    [Token(Token = "0x60054EF")]
    [Address(RVA = "0x3AA9860", Offset = "0x3AA9860", VA = "0x3AA9860", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x60054F0")]
    [Address(RVA = "0x3AA98C0", Offset = "0x3AA98C0", VA = "0x3AA98C0", Slot = "5")]
    protected override ArenaDailyRewardData LoadEntity(IMasterDataReader reader)
    {
      return (ArenaDailyRewardData) null;
    }

    [Token(Token = "0x60054F1")]
    [Address(RVA = "0x3AA9918", Offset = "0x3AA9918", VA = "0x3AA9918")]
    public ArenaDailyRewardMaster()
    {
    }
  }
}
