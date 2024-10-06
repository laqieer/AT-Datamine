// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.PlayerInfo.PlayerProfile.PersonalEmblemListItemChild
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Scenes.OutGame.PersonalEmblem;
using System;
using UnityEngine;

#nullable disable
namespace Scenes.OutGame.PlayerInfo.PlayerProfile
{
  [Token(Token = "0x20034AA")]
  public class PersonalEmblemListItemChild : MonoBehaviour
  {
    [Token(Token = "0x400E51D")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private PersonalEmblemThumb personalEmblemThumb;
    [Token(Token = "0x400E51E")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private CommonButton button;
    [Token(Token = "0x400E51F")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private CommonToggle toggle;
    [Token(Token = "0x400E520")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private GameObject newBadge;
    [Token(Token = "0x400E521")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private GameObject selectBadge;
    [Token(Token = "0x400E522")]
    [FieldOffset(Offset = "0x40")]
    private PersonalEmblemListItem.PersonalEmblemCellData cellData;

    [Token(Token = "0x6014A88")]
    [Address(RVA = "0x1D6654C", Offset = "0x1D6654C", VA = "0x1D6654C")]
    public void LoadImage(
      PersonalEmblemListItem.PersonalEmblemCellData cellData)
    {
    }

    [Token(Token = "0x6014A89")]
    [Address(RVA = "0x1D6672C", Offset = "0x1D6672C", VA = "0x1D6672C")]
    public void SetOnClickAction(Action<int> onClick)
    {
    }

    [Token(Token = "0x6014A8A")]
    [Address(RVA = "0x1D66694", Offset = "0x1D66694", VA = "0x1D66694")]
    public void SetSelecting(bool isActive)
    {
    }

    [Token(Token = "0x6014A8B")]
    [Address(RVA = "0x1D665FC", Offset = "0x1D665FC", VA = "0x1D665FC")]
    public void SetNewBadge(bool isActive)
    {
    }

    [Token(Token = "0x6014A8C")]
    [Address(RVA = "0x1D66A24", Offset = "0x1D66A24", VA = "0x1D66A24")]
    public PersonalEmblemListItemChild()
    {
    }
  }
}
