// Decompiled with JetBrains decompiler
// Type: UI.TextAccessor
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace UI
{
  [Token(Token = "0x2000884")]
  public class TextAccessor : MonoBehaviour
  {
    [Token(Token = "0x4002824")]
    [FieldOffset(Offset = "0x18")]
    private Text textui;
    [Token(Token = "0x4002825")]
    [FieldOffset(Offset = "0x20")]
    private TMP_Text textmeshPro;
    [Token(Token = "0x4002826")]
    [FieldOffset(Offset = "0x28")]
    private bool tryget;

    [Token(Token = "0x60030AA")]
    [Address(RVA = "0x3E7A7C8", Offset = "0x3E7A7C8", VA = "0x3E7A7C8")]
    private void TryGet()
    {
    }

    [Token(Token = "0x17000711")]
    public string text
    {
      [Token(Token = "0x60030AB"), Address(RVA = "0x3E7A84C", Offset = "0x3E7A84C", VA = "0x3E7A84C")] set
      {
      }
    }

    [Token(Token = "0x17000712")]
    public Color color
    {
      [Token(Token = "0x60030AC"), Address(RVA = "0x3E7A938", Offset = "0x3E7A938", VA = "0x3E7A938")] set
      {
      }
    }

    [Token(Token = "0x17000713")]
    public RectTransform rectTransform
    {
      [Token(Token = "0x60030AD"), Address(RVA = "0x3E7AA54", Offset = "0x3E7AA54", VA = "0x3E7AA54")] get
      {
        return (RectTransform) null;
      }
    }

    [Token(Token = "0x17000714")]
    public ILayoutElement LayoutElement
    {
      [Token(Token = "0x60030AE"), Address(RVA = "0x3E7AB6C", Offset = "0x3E7AB6C", VA = "0x3E7AB6C")] get
      {
        return (ILayoutElement) null;
      }
    }

    [Token(Token = "0x60030AF")]
    [Address(RVA = "0x3E7AC64", Offset = "0x3E7AC64", VA = "0x3E7AC64")]
    public TextAccessor()
    {
    }
  }
}
