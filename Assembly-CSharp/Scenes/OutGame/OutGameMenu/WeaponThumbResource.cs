// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.OutGameMenu.WeaponThumbResource
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using StaqData;
using System;
using UnityEngine.Events;

#nullable disable
namespace Scenes.OutGame.OutGameMenu
{
  [Token(Token = "0x2003999")]
  public class WeaponThumbResource
  {
    [Token(Token = "0x400FBAA")]
    [FieldOffset(Offset = "0x10")]
    public bool IsEquiped;
    [Token(Token = "0x400FBAB")]
    [FieldOffset(Offset = "0x18")]
    public Weapon weaponData;
    [Token(Token = "0x400FBAC")]
    [FieldOffset(Offset = "0x20")]
    public IEquipmentListAssetLoader assetLoader;
    [Token(Token = "0x400FBAD")]
    [FieldOffset(Offset = "0x28")]
    public Action<int> OnClickThumbnail;
    [Token(Token = "0x400FBAE")]
    [FieldOffset(Offset = "0x30")]
    public bool IsSelected;
    [Token(Token = "0x400FBAF")]
    [FieldOffset(Offset = "0x38")]
    public UnityEvent<bool> OnChangeSelected;
    [Token(Token = "0x400FBB0")]
    [FieldOffset(Offset = "0x40")]
    public bool IsNew;
    [Token(Token = "0x400FBB1")]
    [FieldOffset(Offset = "0x48")]
    public UnityEvent<bool> OnChangeNew;
    [Token(Token = "0x400FBB2")]
    [FieldOffset(Offset = "0x50")]
    public bool IsDisabledEnhancedBadge;

    [Token(Token = "0x6016A16")]
    [Address(RVA = "0x3F5E2A8", Offset = "0x3F5E2A8", VA = "0x3F5E2A8")]
    public WeaponThumbResource()
    {
    }
  }
}
