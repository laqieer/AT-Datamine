// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.LimitBreakLevelCapMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000F58")]
  [Serializable]
  public sealed class LimitBreakLevelCapMaster : BaseMaster<LimitBreakLevelCapData>
  {
    [Token(Token = "0x4004D11")]
    public const int DEFAULT_LEVEL_CAP = 1;
    [Token(Token = "0x4004D12")]
    [FieldOffset(Offset = "0x18")]
    private Dictionary<(ItemTypeEnum itemType, RarityTypeEnum rarityType), List<LimitBreakLevelCapData>> mappedList;

    [Token(Token = "0x6005A4E")]
    [Address(RVA = "0x3C3CE50", Offset = "0x3C3CE50", VA = "0x3C3CE50")]
    public IReadOnlyDictionary<int, LimitBreakLevelCapData> GetEntities()
    {
      return (IReadOnlyDictionary<int, LimitBreakLevelCapData>) null;
    }

    [Token(Token = "0x6005A4F")]
    [Address(RVA = "0x3C3CE58", Offset = "0x3C3CE58", VA = "0x3C3CE58", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6005A50")]
    [Address(RVA = "0x3C3D11C", Offset = "0x3C3D11C", VA = "0x3C3D11C", Slot = "5")]
    protected override LimitBreakLevelCapData LoadEntity(IMasterDataReader reader)
    {
      return (LimitBreakLevelCapData) null;
    }

    [Token(Token = "0x6005A51")]
    [Address(RVA = "0x3C3D18C", Offset = "0x3C3D18C", VA = "0x3C3D18C")]
    private void OnLoadEntity(LimitBreakLevelCapData entity)
    {
    }

    [Token(Token = "0x6005A52")]
    [Address(RVA = "0x3C3CEC0", Offset = "0x3C3CEC0", VA = "0x3C3CEC0")]
    private void OnCompletedLoading()
    {
    }

    [Token(Token = "0x6005A53")]
    [Address(RVA = "0x3C3D190", Offset = "0x3C3D190", VA = "0x3C3D190")]
    private void MapByItemAndRarity(LimitBreakLevelCapData entity)
    {
    }

    [Token(Token = "0x6005A54")]
    [Address(RVA = "0x3C3D36C", Offset = "0x3C3D36C", VA = "0x3C3D36C")]
    public int GetLevelCapBy(ItemTypeEnum itemType, RarityTypeEnum rarityType, int limitBreakCount)
    {
      return new int();
    }

    [Token(Token = "0x6005A55")]
    [Address(RVA = "0x3C390F8", Offset = "0x3C390F8", VA = "0x3C390F8")]
    public int GetMaxLimitBreakLevelCapBy(ItemTypeEnum itemType, RarityTypeEnum rarityType)
    {
      return new int();
    }

    [Token(Token = "0x6005A56")]
    [Address(RVA = "0x3C3D564", Offset = "0x3C3D564", VA = "0x3C3D564")]
    public int GetMaxLimitBreakCountBy(ItemTypeEnum itemType, RarityTypeEnum rarityType)
    {
      return new int();
    }

    [Token(Token = "0x6005A57")]
    [Address(RVA = "0x3C3D654", Offset = "0x3C3D654", VA = "0x3C3D654")]
    public LimitBreakLevelCapMaster()
    {
    }
  }
}
