// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.SortieTextItem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.OutGame
{
  [Token(Token = "0x2003263")]
  public class SortieTextItem : MonoBehaviour
  {
    [Token(Token = "0x400D796")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private RectTransform rectTransform;
    [Token(Token = "0x400D797")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Image alertIcon;
    [Token(Token = "0x400D798")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private Text text;

    [Token(Token = "0x17004157")]
    public RectTransform RectTransform
    {
      [Token(Token = "0x6013A73"), Address(RVA = "0x4621BF0", Offset = "0x4621BF0", VA = "0x4621BF0")] get
      {
        return (RectTransform) null;
      }
    }

    [Token(Token = "0x6013A74")]
    [Address(RVA = "0x4621BF8", Offset = "0x4621BF8", VA = "0x4621BF8")]
    public void SetMessage(bool isAlert, string message)
    {
    }

    [Token(Token = "0x6013A75")]
    [Address(RVA = "0x4621C68", Offset = "0x4621C68", VA = "0x4621C68")]
    public SortieTextItem()
    {
    }
  }
}
