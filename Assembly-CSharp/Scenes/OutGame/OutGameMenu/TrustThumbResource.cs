// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.OutGameMenu.TrustThumbResource
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
  [Token(Token = "0x2003994")]
  public class TrustThumbResource
  {
    [Token(Token = "0x400FB8E")]
    [FieldOffset(Offset = "0x10")]
    public bool IsEquiped;
    [Token(Token = "0x400FB8F")]
    [FieldOffset(Offset = "0x18")]
    public UnitTrust trustData;
    [Token(Token = "0x400FB90")]
    [FieldOffset(Offset = "0x20")]
    public IEquipmentListAssetLoader assetLoader;
    [Token(Token = "0x400FB91")]
    [FieldOffset(Offset = "0x28")]
    public Action<int> OnClickThumbnail;
    [Token(Token = "0x400FB92")]
    [FieldOffset(Offset = "0x30")]
    public bool IsSelected;
    [Token(Token = "0x400FB93")]
    [FieldOffset(Offset = "0x38")]
    public UnityEvent<bool> OnChangeSelected;
    [Token(Token = "0x400FB94")]
    [FieldOffset(Offset = "0x40")]
    public bool IsNew;
    [Token(Token = "0x400FB95")]
    [FieldOffset(Offset = "0x48")]
    public UnityEvent<bool> OnChangeNew;

    [Token(Token = "0x6016A01")]
    [Address(RVA = "0x42F6AC0", Offset = "0x42F6AC0", VA = "0x42F6AC0")]
    public TrustThumbResource()
    {
    }
  }
}
