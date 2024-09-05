// Decompiled with JetBrains decompiler
// Type: PlayerMake.NameInputView
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;
using UI.Direction;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Playables;
using UnityEngine.UI;

#nullable disable
namespace PlayerMake
{
  [Token(Token = "0x2000999")]
  public class NameInputView : MonoBehaviour
  {
    [Token(Token = "0x4002CBA")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Button decideButton;
    [Token(Token = "0x4002CBB")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private InputField nameInputField;
    [Token(Token = "0x4002CBC")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private PlayableDirector playableDirector;
    [Token(Token = "0x4002CBD")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private UITimelineController uiTimelineController;

    [Token(Token = "0x60036B2")]
    [Address(RVA = "0x35386D8", Offset = "0x35386D8", VA = "0x35386D8")]
    public IEnumerator InitializeAsync() => (IEnumerator) null;

    [Token(Token = "0x60036B3")]
    [Address(RVA = "0x3538768", Offset = "0x3538768", VA = "0x3538768")]
    public IEnumerator PlayInTimeline() => (IEnumerator) null;

    [Token(Token = "0x60036B4")]
    [Address(RVA = "0x35387F8", Offset = "0x35387F8", VA = "0x35387F8")]
    public IEnumerator PlayOutTimeline() => (IEnumerator) null;

    [Token(Token = "0x60036B5")]
    [Address(RVA = "0x3538888", Offset = "0x3538888", VA = "0x3538888")]
    public void RegisterDecideCallback(UnityAction action)
    {
    }

    [Token(Token = "0x60036B6")]
    [Address(RVA = "0x35388AC", Offset = "0x35388AC", VA = "0x35388AC")]
    public void ClearCallback()
    {
    }

    [Token(Token = "0x60036B7")]
    [Address(RVA = "0x35388D0", Offset = "0x35388D0", VA = "0x35388D0")]
    public string GetName() => (string) null;

    [Token(Token = "0x60036B8")]
    [Address(RVA = "0x35388EC", Offset = "0x35388EC", VA = "0x35388EC")]
    public void SetName(string n)
    {
    }

    [Token(Token = "0x60036B9")]
    [Address(RVA = "0x3538908", Offset = "0x3538908", VA = "0x3538908")]
    public void InputEnable(bool enable)
    {
    }

    [Token(Token = "0x60036BA")]
    [Address(RVA = "0x3538928", Offset = "0x3538928", VA = "0x3538928")]
    public NameInputView()
    {
    }
  }
}
