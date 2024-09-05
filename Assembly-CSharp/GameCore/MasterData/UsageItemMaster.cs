// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.UsageItemMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x200106C")]
  [Serializable]
  public sealed class UsageItemMaster : BaseMaster<UsageItemData>
  {
    [Token(Token = "0x6005F48")]
    [Address(RVA = "0x28CC9C8", Offset = "0x28CC9C8", VA = "0x28CC9C8")]
    public IReadOnlyDictionary<int, UsageItemData> GetEntities()
    {
      return (IReadOnlyDictionary<int, UsageItemData>) null;
    }

    [Token(Token = "0x6005F49")]
    [Address(RVA = "0x28CC9D0", Offset = "0x28CC9D0", VA = "0x28CC9D0", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6005F4A")]
    [Address(RVA = "0x28CCA30", Offset = "0x28CCA30", VA = "0x28CCA30", Slot = "5")]
    protected override UsageItemData LoadEntity(IMasterDataReader reader) => (UsageItemData) null;

    [Token(Token = "0x6005F4B")]
    [Address(RVA = "0x28CCA88", Offset = "0x28CCA88", VA = "0x28CCA88")]
    public UsageItemMaster()
    {
    }
  }
}
