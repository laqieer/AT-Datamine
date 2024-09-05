// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.MedalTradePrizeResetMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001179")]
  [Serializable]
  public sealed class MedalTradePrizeResetMaster : BaseMaster<MedalTradePrizeResetData>
  {
    [Token(Token = "0x600647B")]
    [Address(RVA = "0x4AEFDE4", Offset = "0x4AEFDE4", VA = "0x4AEFDE4")]
    public IReadOnlyDictionary<int, MedalTradePrizeResetData> GetEntities()
    {
      return (IReadOnlyDictionary<int, MedalTradePrizeResetData>) null;
    }

    [Token(Token = "0x600647C")]
    [Address(RVA = "0x4AEFDEC", Offset = "0x4AEFDEC", VA = "0x4AEFDEC", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x600647D")]
    [Address(RVA = "0x4AEFE4C", Offset = "0x4AEFE4C", VA = "0x4AEFE4C", Slot = "5")]
    protected override MedalTradePrizeResetData LoadEntity(IMasterDataReader reader)
    {
      return (MedalTradePrizeResetData) null;
    }

    [Token(Token = "0x600647E")]
    [Address(RVA = "0x4AEFEA4", Offset = "0x4AEFEA4", VA = "0x4AEFEA4")]
    public MedalTradePrizeResetMaster()
    {
    }
  }
}
