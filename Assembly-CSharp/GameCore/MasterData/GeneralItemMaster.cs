// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.GeneralItemMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x200105B")]
  [Serializable]
  public sealed class GeneralItemMaster : BaseMaster<GeneralItemData>
  {
    [Token(Token = "0x4005106")]
    public const string TEXT_AB = "text_masterdata_item";

    [Token(Token = "0x6005EF2")]
    [Address(RVA = "0x28C9704", Offset = "0x28C9704", VA = "0x28C9704")]
    public IReadOnlyDictionary<int, GeneralItemData> GetEntities()
    {
      return (IReadOnlyDictionary<int, GeneralItemData>) null;
    }

    [Token(Token = "0x6005EF3")]
    [Address(RVA = "0x28C970C", Offset = "0x28C970C", VA = "0x28C970C", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6005EF4")]
    [Address(RVA = "0x28C976C", Offset = "0x28C976C", VA = "0x28C976C", Slot = "5")]
    protected override GeneralItemData LoadEntity(IMasterDataReader reader)
    {
      return (GeneralItemData) null;
    }

    [Token(Token = "0x6005EF5")]
    [Address(RVA = "0x28C97C4", Offset = "0x28C97C4", VA = "0x28C97C4")]
    public GeneralItemMaster()
    {
    }
  }
}
