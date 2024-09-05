// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.Info.Equipment.UI.EquipmentThumbnailUI
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.OutGame.Info.Equipment.UI
{
  [Token(Token = "0x20035B7")]
  [Serializable]
  public class EquipmentThumbnailUI
  {
    [Token(Token = "0x400E9C3")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private GameObject root;
    [Token(Token = "0x400E9C4")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Image thumbnail;

    [Token(Token = "0x6015250")]
    [Address(RVA = "0x4AAC4C4", Offset = "0x4AAC4C4", VA = "0x4AAC4C4")]
    public void SetThumbnail(Sprite sprite)
    {
    }

    [Token(Token = "0x6015251")]
    [Address(RVA = "0x4AAE0FC", Offset = "0x4AAE0FC", VA = "0x4AAE0FC")]
    public EquipmentThumbnailUI()
    {
    }
  }
}
