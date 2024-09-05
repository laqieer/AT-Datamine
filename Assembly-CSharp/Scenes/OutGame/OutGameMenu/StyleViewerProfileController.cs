// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.OutGameMenu.StyleViewerProfileController
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using StaqData;
using TMPro;
using UnityEngine;

#nullable disable
namespace Scenes.OutGame.OutGameMenu
{
  [Token(Token = "0x2003AC6")]
  public class StyleViewerProfileController : MonoBehaviour
  {
    [Token(Token = "0x40102B3")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private TextMeshProUGUI birthdayText;
    [Token(Token = "0x40102B4")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private TextMeshProUGUI bloodTypeText;
    [Token(Token = "0x40102B5")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private TextMeshProUGUI heightText;
    [Token(Token = "0x40102B6")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private TextMeshProUGUI weightText;
    [Token(Token = "0x40102B7")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private TextMeshProUGUI favoriteText;
    [Token(Token = "0x40102B8")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private TextMeshProUGUI dislikeText;
    [Token(Token = "0x40102B9")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private TextMeshProUGUI hobbyText;
    [Token(Token = "0x40102BA")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private TextMeshProUGUI groupText;
    [Token(Token = "0x40102BB")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private TextMeshProUGUI profileText;

    [Token(Token = "0x60171FD")]
    [Address(RVA = "0x30085B0", Offset = "0x30085B0", VA = "0x30085B0")]
    public void Initialize(Style style)
    {
    }

    [Token(Token = "0x60171FE")]
    [Address(RVA = "0x3008FCC", Offset = "0x3008FCC", VA = "0x3008FCC")]
    public StyleViewerProfileController()
    {
    }
  }
}
