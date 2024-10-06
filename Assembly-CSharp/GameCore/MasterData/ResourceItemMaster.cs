// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.ResourceItemMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001066")]
  [Serializable]
  public sealed class ResourceItemMaster : BaseMaster<ResourceItemData>
  {
    [Token(Token = "0x6005F2A")]
    [Address(RVA = "0x28CB6DC", Offset = "0x28CB6DC", VA = "0x28CB6DC")]
    public IReadOnlyDictionary<int, ResourceItemData> GetEntities()
    {
      return (IReadOnlyDictionary<int, ResourceItemData>) null;
    }

    [Token(Token = "0x6005F2B")]
    [Address(RVA = "0x28CB6E4", Offset = "0x28CB6E4", VA = "0x28CB6E4", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6005F2C")]
    [Address(RVA = "0x28CB744", Offset = "0x28CB744", VA = "0x28CB744", Slot = "5")]
    protected override ResourceItemData LoadEntity(IMasterDataReader reader)
    {
      return (ResourceItemData) null;
    }

    [Token(Token = "0x6005F2D")]
    [Address(RVA = "0x28CB79C", Offset = "0x28CB79C", VA = "0x28CB79C")]
    public ResourceItemMaster()
    {
    }
  }
}
