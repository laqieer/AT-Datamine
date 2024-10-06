// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.Battle.ResultUnit.WeaponCellApplyer
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using GameCore.MasterData;
using Il2CppDummyDll;

#nullable disable
namespace Scenes.OutGame.Battle.ResultUnit
{
  [Token(Token = "0x20037BC")]
  public class WeaponCellApplyer : IEquipCellApplyer
  {
    [Token(Token = "0x400F3A7")]
    [FieldOffset(Offset = "0x10")]
    private ResultEquipCell _view;
    [Token(Token = "0x400F3A8")]
    [FieldOffset(Offset = "0x18")]
    private int _level;

    [Token(Token = "0x6015EFC")]
    [Address(RVA = "0x23215F0", Offset = "0x23215F0", VA = "0x23215F0")]
    public static WeaponCellApplyer Create(
      AssetCachedSpawner assetCachedSpawner,
      ResultEquipCell view,
      ResultData.WeaponDifference diff)
    {
      return (WeaponCellApplyer) null;
    }

    [Token(Token = "0x6015EFD")]
    [Address(RVA = "0x232A134", Offset = "0x232A134", VA = "0x232A134")]
    private WeaponCellApplyer(
      AssetCachedSpawner assetCachedSpawner,
      ResultEquipCell view,
      ResultData.WeaponDifference diff)
    {
    }

    [Token(Token = "0x6015EFE")]
    [Address(RVA = "0x232A368", Offset = "0x232A368", VA = "0x232A368", Slot = "4")]
    public void ApplyExp(int exp)
    {
    }

    [Token(Token = "0x6015EFF")]
    [Address(RVA = "0x232A2E0", Offset = "0x232A2E0", VA = "0x232A2E0")]
    private void SetLevelExp(int exp)
    {
    }

    [Token(Token = "0x6015F00")]
    [Address(RVA = "0x232A3AC", Offset = "0x232A3AC", VA = "0x232A3AC")]
    private WeaponExpData ExpData(int exp) => (WeaponExpData) null;

    [Token(Token = "0x6015F01")]
    [Address(RVA = "0x232A488", Offset = "0x232A488", VA = "0x232A488")]
    private float CalcExpRate(WeaponExpData expData, float exp) => new float();
  }
}
