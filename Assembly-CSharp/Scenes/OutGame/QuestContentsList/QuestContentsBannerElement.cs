// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.QuestContentsList.QuestContentsBannerElement
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.OutGame.QuestContentsList
{
  [Token(Token = "0x200340B")]
  public class QuestContentsBannerElement : MonoBehaviour
  {
    [Token(Token = "0x400E268")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private RawImage targetRawImage;
    [Token(Token = "0x400E269")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Button targetBtn;

    [Token(Token = "0x17004422")]
    public RawImage Image
    {
      [Token(Token = "0x6014753"), Address(RVA = "0x1894FD4", Offset = "0x1894FD4", VA = "0x1894FD4")] get
      {
        return (RawImage) null;
      }
    }

    [Token(Token = "0x17004423")]
    public Button Btn
    {
      [Token(Token = "0x6014754"), Address(RVA = "0x1894FDC", Offset = "0x1894FDC", VA = "0x1894FDC")] get
      {
        return (Button) null;
      }
    }

    [Token(Token = "0x6014755")]
    [Address(RVA = "0x1894FE4", Offset = "0x1894FE4", VA = "0x1894FE4")]
    public QuestContentsBannerElement()
    {
    }
  }
}
