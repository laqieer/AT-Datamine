// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.Info.Equipment.UI.LoadedWeaponUIProvider
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace Scenes.OutGame.Info.Equipment.UI
{
  [Token(Token = "0x20035C1")]
  public class LoadedWeaponUIProvider
  {
    [Token(Token = "0x400E9E3")]
    private const string AB_LABEL = "ui_page_abridged";
    [Token(Token = "0x400E9E4")]
    private const string ASSET_NAME = "Container_Equipment_Weapon";

    [Token(Token = "0x6015279")]
    [Address(RVA = "0x4AAF038", Offset = "0x4AAF038", VA = "0x4AAF038")]
    public EquipmentWeaponUI Instantiate(Transform parent) => (EquipmentWeaponUI) null;

    [Token(Token = "0x601527A")]
    [Address(RVA = "0x4AAF1B0", Offset = "0x4AAF1B0", VA = "0x4AAF1B0")]
    public LoadedWeaponUIProvider()
    {
    }
  }
}
