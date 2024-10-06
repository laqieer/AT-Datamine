// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.Battle.ResultUnit.AccessoryCellApplyer
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using GameCore.MasterData;
using Il2CppDummyDll;

#nullable disable
namespace Scenes.OutGame.Battle.ResultUnit
{
  [Token(Token = "0x20037B4")]
  public class AccessoryCellApplyer : IEquipCellApplyer
  {
    [Token(Token = "0x400F393")]
    [FieldOffset(Offset = "0x10")]
    private ResultEquipCell _view;
    [Token(Token = "0x400F394")]
    [FieldOffset(Offset = "0x18")]
    private int _level;

    [Token(Token = "0x6015EDE")]
    [Address(RVA = "0x23216D8", Offset = "0x23216D8", VA = "0x23216D8")]
    public static AccessoryCellApplyer Create(
      AssetCachedSpawner assetCachedSpawner,
      ResultEquipCell view,
      ResultData.AccessoryDifference diff)
    {
      return (AccessoryCellApplyer) null;
    }

    [Token(Token = "0x6015EDF")]
    [Address(RVA = "0x2329740", Offset = "0x2329740", VA = "0x2329740")]
    private AccessoryCellApplyer(
      AssetCachedSpawner assetCachedSpawner,
      ResultEquipCell view,
      ResultData.AccessoryDifference diff)
    {
    }

    [Token(Token = "0x6015EE0")]
    [Address(RVA = "0x2329AF4", Offset = "0x2329AF4", VA = "0x2329AF4", Slot = "4")]
    public void ApplyExp(int exp)
    {
    }

    [Token(Token = "0x6015EE1")]
    [Address(RVA = "0x2329A6C", Offset = "0x2329A6C", VA = "0x2329A6C")]
    private void SetLevelExp(int exp)
    {
    }

    [Token(Token = "0x6015EE2")]
    [Address(RVA = "0x2329BB4", Offset = "0x2329BB4", VA = "0x2329BB4")]
    private AccessoriesExpData ExpData(int exp) => (AccessoriesExpData) null;

    [Token(Token = "0x6015EE3")]
    [Address(RVA = "0x2329D30", Offset = "0x2329D30", VA = "0x2329D30")]
    private float CalcExpRate(AccessoriesExpData expData, float exp) => new float();
  }
}
