// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.EquipmentDetail.WeaponOptionEffectContainer
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using Il2CppDummyDll;
using StaqData;
using UnityEngine;

#nullable disable
namespace Scenes.OutGame.EquipmentDetail
{
  [Token(Token = "0x20036C2")]
  public class WeaponOptionEffectContainer : MonoBehaviour
  {
    [Token(Token = "0x400EEA4")]
    private const int LockedSlotIndex = 0;
    [Token(Token = "0x400EEA5")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private WeaponOptionEffectContentObj[] conents;

    [Token(Token = "0x60158E8")]
    [Address(RVA = "0x1A57B28", Offset = "0x1A57B28", VA = "0x1A57B28")]
    public void SetData(AssetCachedSpawner assetCachedSpawner, IOptionEffect optionEffect)
    {
    }

    [Token(Token = "0x60158E9")]
    [Address(RVA = "0x1A57AC4", Offset = "0x1A57AC4", VA = "0x1A57AC4")]
    public void Lock()
    {
    }

    [Token(Token = "0x60158EA")]
    [Address(RVA = "0x1A62A18", Offset = "0x1A62A18", VA = "0x1A62A18")]
    public WeaponOptionEffectContainer()
    {
    }
  }
}
