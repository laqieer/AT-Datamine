// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.AccessoriesLimitBreakDescriptionMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000F4B")]
  [Serializable]
  public sealed class AccessoriesLimitBreakDescriptionMaster : 
    BaseMaster<AccessoriesLimitBreakDescriptionData>
  {
    [Token(Token = "0x6005A17")]
    [Address(RVA = "0x3C3B5FC", Offset = "0x3C3B5FC", VA = "0x3C3B5FC")]
    public IReadOnlyDictionary<int, AccessoriesLimitBreakDescriptionData> GetEntities()
    {
      return (IReadOnlyDictionary<int, AccessoriesLimitBreakDescriptionData>) null;
    }

    [Token(Token = "0x6005A18")]
    [Address(RVA = "0x3C3B604", Offset = "0x3C3B604", VA = "0x3C3B604", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6005A19")]
    [Address(RVA = "0x3C3B664", Offset = "0x3C3B664", VA = "0x3C3B664", Slot = "5")]
    protected override AccessoriesLimitBreakDescriptionData LoadEntity(IMasterDataReader reader)
    {
      return (AccessoriesLimitBreakDescriptionData) null;
    }

    [Token(Token = "0x6005A1A")]
    [Address(RVA = "0x3C3B6BC", Offset = "0x3C3B6BC", VA = "0x3C3B6BC")]
    public AccessoriesLimitBreakDescriptionData GetData(
      int accessoriesLimitBreak,
      int limitBreakCount,
      RarityTypeEnum rarity)
    {
      return (AccessoriesLimitBreakDescriptionData) null;
    }

    [Token(Token = "0x6005A1B")]
    [Address(RVA = "0x3C3B7C4", Offset = "0x3C3B7C4", VA = "0x3C3B7C4")]
    public AccessoriesLimitBreakDescriptionMaster()
    {
    }
  }
}
