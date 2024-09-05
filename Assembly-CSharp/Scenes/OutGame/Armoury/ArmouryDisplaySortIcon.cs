// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.Armoury.ArmouryDisplaySortIcon
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.OutGame.Armoury
{
  [Token(Token = "0x200380C")]
  [Serializable]
  internal class ArmouryDisplaySortIcon
  {
    [Token(Token = "0x400F4C8")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private GameObject sortIconRoot;
    [Token(Token = "0x400F4C9")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Image sortIconImage;
    [Token(Token = "0x400F4CA")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private TextMeshProUGUI parameterText;

    [Token(Token = "0x60160C4")]
    [Address(RVA = "0x20EE4B8", Offset = "0x20EE4B8", VA = "0x20EE4B8")]
    public void Setup(Sprite sprite, int value)
    {
    }

    [Token(Token = "0x60160C5")]
    [Address(RVA = "0x20EE5DC", Offset = "0x20EE5DC", VA = "0x20EE5DC")]
    public void SetActive(bool isActive)
    {
    }

    [Token(Token = "0x60160C6")]
    [Address(RVA = "0x20EE52C", Offset = "0x20EE52C", VA = "0x20EE52C")]
    public void SetText(int value)
    {
    }

    [Token(Token = "0x60160C7")]
    [Address(RVA = "0x20EE5FC", Offset = "0x20EE5FC", VA = "0x20EE5FC")]
    public ArmouryDisplaySortIcon()
    {
    }
  }
}
