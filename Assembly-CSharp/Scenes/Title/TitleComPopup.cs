// Decompiled with JetBrains decompiler
// Type: Scenes.Title.TitleComPopup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.Tween;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.Title
{
  [Token(Token = "0x20028E7")]
  public class TitleComPopup : MonoBehaviour
  {
    [Token(Token = "0x400AE6A")]
    private const string TITLEMENU_TWEEN_IN = "Popup_In";
    [Token(Token = "0x400AE6B")]
    private const string TITLEMENU_TWEEN_OUT = "Popup_Out";
    [Token(Token = "0x400AE6C")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private UITweenGroup uiTweenGroup;
    [Token(Token = "0x400AE6D")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private ScrollRect menuScrollRect;

    [Token(Token = "0x6010169")]
    [Address(RVA = "0x416F6E4", Offset = "0x416F6E4", VA = "0x416F6E4")]
    public void Show()
    {
    }

    [Token(Token = "0x601016A")]
    [Address(RVA = "0x416F7B8", Offset = "0x416F7B8", VA = "0x416F7B8")]
    private void FinishedInAnime()
    {
    }

    [Token(Token = "0x601016B")]
    [Address(RVA = "0x416F858", Offset = "0x416F858", VA = "0x416F858")]
    public void Close()
    {
    }

    [Token(Token = "0x601016C")]
    [Address(RVA = "0x416F910", Offset = "0x416F910", VA = "0x416F910")]
    private void FinishedOutAnime()
    {
    }

    [Token(Token = "0x601016D")]
    [Address(RVA = "0x416F9B8", Offset = "0x416F9B8", VA = "0x416F9B8")]
    public TitleComPopup()
    {
    }
  }
}
