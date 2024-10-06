// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.OutGameMenu.MindequipmentThumbResource
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
  [Token(Token = "0x200398C")]
  public class MindequipmentThumbResource
  {
    [Token(Token = "0x400FB67")]
    [FieldOffset(Offset = "0x10")]
    public bool IsEquiped;
    [Token(Token = "0x400FB68")]
    [FieldOffset(Offset = "0x18")]
    public MindEquipment mindequipmentData;
    [Token(Token = "0x400FB69")]
    [FieldOffset(Offset = "0x20")]
    public IEquipmentListAssetLoader assetLoader;
    [Token(Token = "0x400FB6A")]
    [FieldOffset(Offset = "0x28")]
    public Action<int> OnClickThumbnail;
    [Token(Token = "0x400FB6B")]
    [FieldOffset(Offset = "0x30")]
    public bool IsSelected;
    [Token(Token = "0x400FB6C")]
    [FieldOffset(Offset = "0x38")]
    public UnityEvent<bool> OnChangeSelected;
    [Token(Token = "0x400FB6D")]
    [FieldOffset(Offset = "0x40")]
    public bool IsNew;
    [Token(Token = "0x400FB6E")]
    [FieldOffset(Offset = "0x48")]
    public UnityEvent<bool> OnChangeNew;

    [Token(Token = "0x60169D9")]
    [Address(RVA = "0x42F4F28", Offset = "0x42F4F28", VA = "0x42F4F28")]
    public MindequipmentThumbResource()
    {
    }
  }
}
