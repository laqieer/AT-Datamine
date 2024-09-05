// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.MedalTradePrizeMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x200117B")]
  [Serializable]
  public sealed class MedalTradePrizeMaster : BaseMaster<MedalTradePrizeData>
  {
    [Token(Token = "0x6006485")]
    [Address(RVA = "0x4AF03A4", Offset = "0x4AF03A4", VA = "0x4AF03A4")]
    public IReadOnlyDictionary<int, MedalTradePrizeData> GetEntities()
    {
      return (IReadOnlyDictionary<int, MedalTradePrizeData>) null;
    }

    [Token(Token = "0x6006486")]
    [Address(RVA = "0x4AF03AC", Offset = "0x4AF03AC", VA = "0x4AF03AC", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6006487")]
    [Address(RVA = "0x4AF040C", Offset = "0x4AF040C", VA = "0x4AF040C", Slot = "5")]
    protected override MedalTradePrizeData LoadEntity(IMasterDataReader reader)
    {
      return (MedalTradePrizeData) null;
    }

    [Token(Token = "0x6006488")]
    [Address(RVA = "0x4AF0464", Offset = "0x4AF0464", VA = "0x4AF0464")]
    public MedalTradePrizeData[] GetItems(int shopId) => (MedalTradePrizeData[]) null;

    [Token(Token = "0x6006489")]
    [Address(RVA = "0x4AF0588", Offset = "0x4AF0588", VA = "0x4AF0588")]
    public MedalTradePrizeMaster()
    {
    }
  }
}
