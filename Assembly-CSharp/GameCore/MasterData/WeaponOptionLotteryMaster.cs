// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.WeaponOptionLotteryMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000F8C")]
  [Serializable]
  public sealed class WeaponOptionLotteryMaster : BaseMaster<WeaponOptionLotteryData>
  {
    [Token(Token = "0x6005B60")]
    [Address(RVA = "0x2781B00", Offset = "0x2781B00", VA = "0x2781B00")]
    public IReadOnlyDictionary<int, WeaponOptionLotteryData> GetEntities()
    {
      return (IReadOnlyDictionary<int, WeaponOptionLotteryData>) null;
    }

    [Token(Token = "0x6005B61")]
    [Address(RVA = "0x2781B08", Offset = "0x2781B08", VA = "0x2781B08", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6005B62")]
    [Address(RVA = "0x2781B68", Offset = "0x2781B68", VA = "0x2781B68", Slot = "5")]
    protected override WeaponOptionLotteryData LoadEntity(IMasterDataReader reader)
    {
      return (WeaponOptionLotteryData) null;
    }

    [Token(Token = "0x6005B63")]
    [Address(RVA = "0x2781BC0", Offset = "0x2781BC0", VA = "0x2781BC0")]
    public IReadOnlyCollection<WeaponOptionLotteryData> GetList()
    {
      return (IReadOnlyCollection<WeaponOptionLotteryData>) null;
    }

    [Token(Token = "0x6005B64")]
    [Address(RVA = "0x2781C10", Offset = "0x2781C10", VA = "0x2781C10")]
    public WeaponOptionLotteryMaster()
    {
    }
  }
}
