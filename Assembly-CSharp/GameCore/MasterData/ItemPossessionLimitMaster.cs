// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.ItemPossessionLimitMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x200105D")]
  [Serializable]
  public sealed class ItemPossessionLimitMaster : BaseMaster<ItemPossessionLimitData>
  {
    [Token(Token = "0x400510F")]
    private const int WildCardItemID = 0;
    [Token(Token = "0x4005110")]
    [FieldOffset(Offset = "0x18")]
    private Dictionary<string, ItemPossessionLimitData> possessionLimitDataDic;

    [Token(Token = "0x6005EFC")]
    [Address(RVA = "0x28C9E14", Offset = "0x28C9E14", VA = "0x28C9E14")]
    public IReadOnlyDictionary<int, ItemPossessionLimitData> GetEntities()
    {
      return (IReadOnlyDictionary<int, ItemPossessionLimitData>) null;
    }

    [Token(Token = "0x6005EFD")]
    [Address(RVA = "0x28C9E1C", Offset = "0x28C9E1C", VA = "0x28C9E1C", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6005EFE")]
    [Address(RVA = "0x28C9F1C", Offset = "0x28C9F1C", VA = "0x28C9F1C", Slot = "5")]
    protected override ItemPossessionLimitData LoadEntity(IMasterDataReader reader)
    {
      return (ItemPossessionLimitData) null;
    }

    [Token(Token = "0x6005EFF")]
    [Address(RVA = "0x28C9E84", Offset = "0x28C9E84", VA = "0x28C9E84")]
    private void OnAwakeLoading()
    {
    }

    [Token(Token = "0x6005F00")]
    [Address(RVA = "0x28C9F8C", Offset = "0x28C9F8C", VA = "0x28C9F8C")]
    private void OnLoadEntity(ItemPossessionLimitData entity)
    {
    }

    [Token(Token = "0x6005F01")]
    [Address(RVA = "0x28C9FFC", Offset = "0x28C9FFC", VA = "0x28C9FFC")]
    private string MakeSearchKey(ItemTypeEnum itemType, int itemId) => (string) null;

    [Token(Token = "0x6005F02")]
    [Address(RVA = "0x28CA0C4", Offset = "0x28CA0C4", VA = "0x28CA0C4")]
    private string MakeSearchKey(ItemTypeEnum itemType) => (string) null;

    [Token(Token = "0x6005F03")]
    [Address(RVA = "0x28CA128", Offset = "0x28CA128", VA = "0x28CA128")]
    public ItemPossessionLimitData FindPossessionLimitData(ItemTypeEnum itemType, int itemId)
    {
      return (ItemPossessionLimitData) null;
    }

    [Token(Token = "0x6005F04")]
    [Address(RVA = "0x28CA1D8", Offset = "0x28CA1D8", VA = "0x28CA1D8")]
    public ItemPossessionLimitMaster()
    {
    }
  }
}
