// Decompiled with JetBrains decompiler
// Type: Scenes.Story.ChapterShop.BenefitsItem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using TMPro;
using UnityEngine;

#nullable disable
namespace Scenes.Story.ChapterShop
{
  [Token(Token = "0x2002EEC")]
  public class BenefitsItem : MonoBehaviour
  {
    [Token(Token = "0x400C90B")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private RectTransform rectTransform;
    [Token(Token = "0x400C90C")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private TextMeshProUGUI text;

    [Token(Token = "0x17003E2C")]
    public RectTransform RectTransform
    {
      [Token(Token = "0x601253E"), Address(RVA = "0x22F7284", Offset = "0x22F7284", VA = "0x22F7284")] get
      {
        return (RectTransform) null;
      }
    }

    [Token(Token = "0x601253F")]
    [Address(RVA = "0x22F728C", Offset = "0x22F728C", VA = "0x22F728C")]
    public void Set(string benefitsText)
    {
    }

    [Token(Token = "0x6012540")]
    [Address(RVA = "0x22F72B0", Offset = "0x22F72B0", VA = "0x22F72B0")]
    public BenefitsItem()
    {
    }
  }
}
