// Decompiled with JetBrains decompiler
// Type: UI.ItemDetail.ContentRecommendBtnView
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace UI.ItemDetail
{
  [Token(Token = "0x20008BD")]
  public class ContentRecommendBtnView : MonoBehaviour
  {
    [Token(Token = "0x40028F9")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Text _title;
    [Token(Token = "0x40028FA")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private ContentRecommendSubView _subViewBase;

    [Token(Token = "0x6003196")]
    [Address(RVA = "0x3C19578", Offset = "0x3C19578", VA = "0x3C19578")]
    private void Awake()
    {
    }

    [Token(Token = "0x6003197")]
    [Address(RVA = "0x3C195A4", Offset = "0x3C195A4", VA = "0x3C195A4")]
    public void SetTitle(string title)
    {
    }

    [Token(Token = "0x6003198")]
    [Address(RVA = "0x3C19640", Offset = "0x3C19640", VA = "0x3C19640")]
    public ContentRecommendSubView AddSubContent() => (ContentRecommendSubView) null;

    [Token(Token = "0x6003199")]
    [Address(RVA = "0x3C19704", Offset = "0x3C19704", VA = "0x3C19704")]
    public ContentRecommendBtnView()
    {
    }
  }
}
