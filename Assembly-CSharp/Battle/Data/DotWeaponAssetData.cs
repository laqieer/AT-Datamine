// Decompiled with JetBrains decompiler
// Type: Battle.Data.DotWeaponAssetData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;

#nullable disable
namespace Battle.Data
{
  [Token(Token = "0x20026FB")]
  public sealed class DotWeaponAssetData : DotWeaponAssetDataBase
  {
    [Token(Token = "0x400A6B2")]
    [FieldOffset(Offset = "0x70")]
    private bool loaded;

    [Token(Token = "0x600F17C")]
    [Address(RVA = "0x41AED30", Offset = "0x41AED30", VA = "0x41AED30", Slot = "16")]
    public override void Load(
      string styleDuelMotionType,
      EquipmentClassificationData equipmentClassificationData,
      StyleData styleData)
    {
    }

    [Token(Token = "0x600F17D")]
    [Address(RVA = "0x41AF190", Offset = "0x41AF190", VA = "0x41AF190", Slot = "17")]
    public override void Unload()
    {
    }

    [Token(Token = "0x600F17E")]
    [Address(RVA = "0x41AEF80", Offset = "0x41AEF80", VA = "0x41AEF80")]
    private void LoadDotModels(string frontDotName, string backDotName, int weaponPrefabId = 0)
    {
    }

    [Token(Token = "0x600F17F")]
    [Address(RVA = "0x41AEDA8", Offset = "0x41AEDA8", VA = "0x41AEDA8")]
    private void LoadMotions(
      string styleDuelMotionType,
      EquipmentClassificationData equipmentClassificationData)
    {
    }

    [Token(Token = "0x600F180")]
    [Address(RVA = "0x41AF218", Offset = "0x41AF218", VA = "0x41AF218")]
    public DotWeaponAssetData()
    {
    }
  }
}
