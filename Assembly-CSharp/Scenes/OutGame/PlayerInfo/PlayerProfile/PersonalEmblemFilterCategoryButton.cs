// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.PlayerInfo.PlayerProfile.PersonalEmblemFilterCategoryButton
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.OutGame.PlayerInfo.PlayerProfile
{
  [Token(Token = "0x20034A5")]
  public class PersonalEmblemFilterCategoryButton : MonoBehaviour
  {
    [Token(Token = "0x400E509")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Toggle toggle;
    [Token(Token = "0x400E50A")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private TextMeshProUGUI buttonText;

    [Token(Token = "0x6014A74")]
    [Address(RVA = "0x1D65B3C", Offset = "0x1D65B3C", VA = "0x1D65B3C")]
    public void AssignTo(PersonalEmblemFilterToggleGroup toggleGroup)
    {
    }

    [Token(Token = "0x6014A75")]
    [Address(RVA = "0x1D65C04", Offset = "0x1D65C04", VA = "0x1D65C04")]
    public void SetText(string text)
    {
    }

    [Token(Token = "0x6014A76")]
    [Address(RVA = "0x1D65C28", Offset = "0x1D65C28", VA = "0x1D65C28")]
    public PersonalEmblemFilterCategoryButton()
    {
    }
  }
}
