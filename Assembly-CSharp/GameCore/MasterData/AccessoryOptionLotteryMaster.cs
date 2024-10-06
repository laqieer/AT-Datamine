// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.AccessoryOptionLotteryMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000F49")]
  [Serializable]
  public sealed class AccessoryOptionLotteryMaster : BaseMaster<AccessoryOptionLotteryData>
  {
    [Token(Token = "0x6005A0F")]
    [Address(RVA = "0x3C3B200", Offset = "0x3C3B200", VA = "0x3C3B200")]
    public IReadOnlyDictionary<int, AccessoryOptionLotteryData> GetEntities()
    {
      return (IReadOnlyDictionary<int, AccessoryOptionLotteryData>) null;
    }

    [Token(Token = "0x6005A10")]
    [Address(RVA = "0x3C3B208", Offset = "0x3C3B208", VA = "0x3C3B208", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6005A11")]
    [Address(RVA = "0x3C3B268", Offset = "0x3C3B268", VA = "0x3C3B268", Slot = "5")]
    protected override AccessoryOptionLotteryData LoadEntity(IMasterDataReader reader)
    {
      return (AccessoryOptionLotteryData) null;
    }

    [Token(Token = "0x6005A12")]
    [Address(RVA = "0x3C3B2C0", Offset = "0x3C3B2C0", VA = "0x3C3B2C0")]
    public AccessoryOptionLotteryMaster()
    {
    }
  }
}
