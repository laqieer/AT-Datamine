// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.EquipmentDetail.EquipmentLvUpEffect
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using Il2CppDummyDll;
using Scenes.OutGame.OutGameMenu;
using StaqData;
using System.Collections;

#nullable disable
namespace Scenes.OutGame.EquipmentDetail
{
  [Token(Token = "0x2003683")]
  public class EquipmentLvUpEffect : LvUpEffectBase
  {
    [Token(Token = "0x6015726")]
    [Address(RVA = "0x18E4A04", Offset = "0x18E4A04", VA = "0x18E4A04")]
    public IEnumerator InitializeAsync(
      AssetCachedSpawner assetCachedSpawner,
      Weapon dispWeapon,
      int lvUpValue)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6015727")]
    [Address(RVA = "0x18E4AB8", Offset = "0x18E4AB8", VA = "0x18E4AB8")]
    public IEnumerator InitializeAsync(
      AssetCachedSpawner assetCachedSpawner,
      Accessory dispAccessory,
      int lvUpValue)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6015728")]
    [Address(RVA = "0x18E4B6C", Offset = "0x18E4B6C", VA = "0x18E4B6C")]
    public EquipmentLvUpEffect()
    {
    }
  }
}
