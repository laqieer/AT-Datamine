// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.OutGameMenu.AccessoryThumbResource
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
  [Token(Token = "0x2003984")]
  public class AccessoryThumbResource
  {
    [Token(Token = "0x400FB48")]
    [FieldOffset(Offset = "0x10")]
    public bool IsEquiped;
    [Token(Token = "0x400FB49")]
    [FieldOffset(Offset = "0x18")]
    public Accessory accessoryData;
    [Token(Token = "0x400FB4A")]
    [FieldOffset(Offset = "0x20")]
    public IEquipmentListAssetLoader assetLoader;
    [Token(Token = "0x400FB4B")]
    [FieldOffset(Offset = "0x28")]
    public Action<int> OnClickThumbnail;
    [Token(Token = "0x400FB4C")]
    [FieldOffset(Offset = "0x30")]
    public bool IsSelected;
    [Token(Token = "0x400FB4D")]
    [FieldOffset(Offset = "0x38")]
    public UnityEvent<bool> OnChangeSelected;
    [Token(Token = "0x400FB4E")]
    [FieldOffset(Offset = "0x40")]
    public bool IsNew;
    [Token(Token = "0x400FB4F")]
    [FieldOffset(Offset = "0x48")]
    public UnityEvent<bool> OnChangeNew;

    [Token(Token = "0x60169B5")]
    [Address(RVA = "0x42F3B8C", Offset = "0x42F3B8C", VA = "0x42F3B8C")]
    public AccessoryThumbResource()
    {
    }
  }
}
