// Decompiled with JetBrains decompiler
// Type: Scenes.Title.TitlePrivacyPolicyPopup
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
  [Token(Token = "0x20028F3")]
  public class TitlePrivacyPolicyPopup : MonoBehaviour
  {
    [Token(Token = "0x400AEAD")]
    private const string TITLEMENU_TWEEN_IN = "Popup_In";
    [Token(Token = "0x400AEAE")]
    private const string TITLEMENU_TWEEN_OUT = "Popup_Out";
    [Token(Token = "0x400AEAF")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private UITweenGroup uiTweenGroup;
    [Token(Token = "0x400AEB0")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private ScrollRect menuScrollRect;

    [Token(Token = "0x60101C6")]
    [Address(RVA = "0x4170F9C", Offset = "0x4170F9C", VA = "0x4170F9C")]
    public void Show()
    {
    }

    [Token(Token = "0x60101C7")]
    [Address(RVA = "0x4172AD8", Offset = "0x4172AD8", VA = "0x4172AD8")]
    private void FinishedInAnime()
    {
    }

    [Token(Token = "0x60101C8")]
    [Address(RVA = "0x4172B78", Offset = "0x4172B78", VA = "0x4172B78")]
    public void Close()
    {
    }

    [Token(Token = "0x60101C9")]
    [Address(RVA = "0x4172C30", Offset = "0x4172C30", VA = "0x4172C30")]
    private void FinishedOutAnime()
    {
    }

    [Token(Token = "0x60101CA")]
    [Address(RVA = "0x4172CD8", Offset = "0x4172CD8", VA = "0x4172CD8")]
    public TitlePrivacyPolicyPopup()
    {
    }
  }
}
