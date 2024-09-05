// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.MedalTradeItemMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001176")]
  [Serializable]
  public sealed class MedalTradeItemMaster : BaseMaster<MedalTradeItemData>
  {
    [Token(Token = "0x6006470")]
    [Address(RVA = "0x4AEF8A4", Offset = "0x4AEF8A4", VA = "0x4AEF8A4")]
    public IReadOnlyDictionary<int, MedalTradeItemData> GetEntities()
    {
      return (IReadOnlyDictionary<int, MedalTradeItemData>) null;
    }

    [Token(Token = "0x6006471")]
    [Address(RVA = "0x4AEF8AC", Offset = "0x4AEF8AC", VA = "0x4AEF8AC", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6006472")]
    [Address(RVA = "0x4AEF90C", Offset = "0x4AEF90C", VA = "0x4AEF90C", Slot = "5")]
    protected override MedalTradeItemData LoadEntity(IMasterDataReader reader)
    {
      return (MedalTradeItemData) null;
    }

    [Token(Token = "0x6006473")]
    [Address(RVA = "0x4AEF964", Offset = "0x4AEF964", VA = "0x4AEF964")]
    public MedalTradeItemData[] GetItems(int prizeId) => (MedalTradeItemData[]) null;

    [Token(Token = "0x6006474")]
    [Address(RVA = "0x4AEFA88", Offset = "0x4AEFA88", VA = "0x4AEFA88")]
    public MedalTradeItemMaster()
    {
    }
  }
}
