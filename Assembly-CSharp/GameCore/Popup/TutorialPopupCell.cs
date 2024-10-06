// Decompiled with JetBrains decompiler
// Type: GameCore.Popup.TutorialPopupCell
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace GameCore.Popup
{
  [Token(Token = "0x2000D1D")]
  public class TutorialPopupCell : MonoBehaviour
  {
    [Token(Token = "0x4003ACA")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Text title;
    [Token(Token = "0x4003ACB")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Text text;
    [Token(Token = "0x4003ACC")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private Image image;
    [Token(Token = "0x4003ACD")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private RawImage rawImage;
    [Token(Token = "0x4003ACE")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private GameObject textBg;

    [Token(Token = "0x6004B7A")]
    [Address(RVA = "0x32E53F0", Offset = "0x32E53F0", VA = "0x32E53F0")]
    public void Initialize(string title, string text, Sprite sprite)
    {
    }

    [Token(Token = "0x6004B7B")]
    [Address(RVA = "0x32E5B30", Offset = "0x32E5B30", VA = "0x32E5B30")]
    public void InitializeMovie(string title, Texture movieTexture)
    {
    }

    [Token(Token = "0x6004B7C")]
    [Address(RVA = "0x32E6398", Offset = "0x32E6398", VA = "0x32E6398")]
    public TutorialPopupCell()
    {
    }
  }
}
