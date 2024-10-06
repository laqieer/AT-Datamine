// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.BoxItemMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001046")]
  [Serializable]
  public sealed class BoxItemMaster : BaseMaster<BoxItemData>
  {
    [Token(Token = "0x400509A")]
    public const string TEXT_AB = "text_masterdata_item";

    [Token(Token = "0x6005E81")]
    [Address(RVA = "0x28C4100", Offset = "0x28C4100", VA = "0x28C4100")]
    public IReadOnlyDictionary<int, BoxItemData> GetEntities()
    {
      return (IReadOnlyDictionary<int, BoxItemData>) null;
    }

    [Token(Token = "0x6005E82")]
    [Address(RVA = "0x28C4108", Offset = "0x28C4108", VA = "0x28C4108", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6005E83")]
    [Address(RVA = "0x28C4168", Offset = "0x28C4168", VA = "0x28C4168", Slot = "5")]
    protected override BoxItemData LoadEntity(IMasterDataReader reader) => (BoxItemData) null;

    [Token(Token = "0x6005E84")]
    [Address(RVA = "0x28C41C0", Offset = "0x28C41C0", VA = "0x28C41C0")]
    public BoxItemMaster()
    {
    }
  }
}
