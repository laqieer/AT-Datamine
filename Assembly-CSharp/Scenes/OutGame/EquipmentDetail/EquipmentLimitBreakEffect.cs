// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.EquipmentDetail.EquipmentLimitBreakEffect
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using Il2CppDummyDll;
using Scenes.OutGame.OutGameMenu;
using StaqData;
using System.Collections;
using TMPro;
using UnityEngine;

#nullable disable
namespace Scenes.OutGame.EquipmentDetail
{
  [Token(Token = "0x200367E")]
  public class EquipmentLimitBreakEffect : LimitBreakEffectBase
  {
    [Token(Token = "0x400ED05")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    private WeaponOptionEffectContainer[] options;
    [Token(Token = "0x400ED06")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    private GameObject[] optionEffects;
    [Token(Token = "0x400ED07")]
    [FieldOffset(Offset = "0x70")]
    [SerializeField]
    private TextMeshProUGUI unlockText;
    [Token(Token = "0x400ED08")]
    [FieldOffset(Offset = "0x78")]
    [SerializeField]
    private float optionEffectActiveFrame;
    [Token(Token = "0x400ED09")]
    [FieldOffset(Offset = "0x80")]
    private AssetCachedSpawner assetCachedSpawner;

    [Token(Token = "0x6015711")]
    [Address(RVA = "0x18E3A9C", Offset = "0x18E3A9C", VA = "0x18E3A9C")]
    public IEnumerator InitializeAsync(
      AssetCachedSpawner assetCachedSpawner,
      Weapon dispWeapon,
      int limitBreakNum)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6015712")]
    [Address(RVA = "0x18E3B50", Offset = "0x18E3B50", VA = "0x18E3B50")]
    public IEnumerator InitializeAsync(
      AssetCachedSpawner assetCachedSpawner,
      Accessory dispAccessory,
      int limitBreakNum)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6015713")]
    [Address(RVA = "0x18E3C04", Offset = "0x18E3C04", VA = "0x18E3C04")]
    public EquipmentLimitBreakEffect()
    {
    }
  }
}
