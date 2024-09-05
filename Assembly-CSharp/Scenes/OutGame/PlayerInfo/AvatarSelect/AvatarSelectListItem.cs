// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.PlayerInfo.AvatarSelect.AvatarSelectListItem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.OutGame.PlayerInfo.AvatarSelect
{
  [Token(Token = "0x20034CE")]
  public class AvatarSelectListItem : MonoBehaviour
  {
    [Token(Token = "0x400E5D2")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Image image;
    [Token(Token = "0x400E5D3")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Button button;
    [Token(Token = "0x400E5D4")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private GameObject selectedMask;
    [Token(Token = "0x400E5D5")]
    [FieldOffset(Offset = "0x30")]
    public Action OnClick;

    [Token(Token = "0x6014B85")]
    [Address(RVA = "0x1D6F81C", Offset = "0x1D6F81C", VA = "0x1D6F81C")]
    private void Awake()
    {
    }

    [Token(Token = "0x6014B86")]
    [Address(RVA = "0x1D6F8B0", Offset = "0x1D6F8B0", VA = "0x1D6F8B0")]
    public void SetImage(Sprite image)
    {
    }

    [Token(Token = "0x6014B87")]
    [Address(RVA = "0x1D6F8CC", Offset = "0x1D6F8CC", VA = "0x1D6F8CC")]
    public void SetActiveSelectedMask(bool isActive)
    {
    }

    [Token(Token = "0x6014B88")]
    [Address(RVA = "0x1D6F8EC", Offset = "0x1D6F8EC", VA = "0x1D6F8EC")]
    public AvatarSelectListItem()
    {
    }
  }
}
