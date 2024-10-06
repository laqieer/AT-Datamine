// Decompiled with JetBrains decompiler
// Type: PlayerMake.PlayerMakeView
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;
using UI.Direction;
using UnityEngine;
using UnityEngine.Playables;

#nullable disable
namespace PlayerMake
{
  [Token(Token = "0x20009A9")]
  public class PlayerMakeView : MonoBehaviour
  {
    [Token(Token = "0x4002CE5")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private PlayableDirector playableDirector;
    [Token(Token = "0x4002CE6")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private UITimelineController uiTimelineController;
    [Token(Token = "0x4002CE7")]
    [FieldOffset(Offset = "0x28")]
    public NameInputView NameInputView;

    [Token(Token = "0x60036F9")]
    [Address(RVA = "0x35396C0", Offset = "0x35396C0", VA = "0x35396C0")]
    public IEnumerator InitializeAsync() => (IEnumerator) null;

    [Token(Token = "0x60036FA")]
    [Address(RVA = "0x3539D3C", Offset = "0x3539D3C", VA = "0x3539D3C")]
    private IEnumerator WaitTimelineEnd() => (IEnumerator) null;

    [Token(Token = "0x60036FB")]
    [Address(RVA = "0x3539DCC", Offset = "0x3539DCC", VA = "0x3539DCC")]
    public IEnumerator PlayInTimeline() => (IEnumerator) null;

    [Token(Token = "0x60036FC")]
    [Address(RVA = "0x3539E5C", Offset = "0x3539E5C", VA = "0x3539E5C")]
    public void PlayLoopTimeline()
    {
    }

    [Token(Token = "0x60036FD")]
    [Address(RVA = "0x3539F6C", Offset = "0x3539F6C", VA = "0x3539F6C")]
    public IEnumerator PlayOutTimeline() => (IEnumerator) null;

    [Token(Token = "0x60036FE")]
    [Address(RVA = "0x3539FFC", Offset = "0x3539FFC", VA = "0x3539FFC")]
    public IEnumerator PlayConfirmInTimeline() => (IEnumerator) null;

    [Token(Token = "0x60036FF")]
    [Address(RVA = "0x353A08C", Offset = "0x353A08C", VA = "0x353A08C")]
    public IEnumerator PlayConfirmBackTimeline() => (IEnumerator) null;

    [Token(Token = "0x6003700")]
    [Address(RVA = "0x353A11C", Offset = "0x353A11C", VA = "0x353A11C")]
    public IEnumerator PlayConfirmOutTimeline() => (IEnumerator) null;

    [Token(Token = "0x6003701")]
    [Address(RVA = "0x353A1AC", Offset = "0x353A1AC", VA = "0x353A1AC")]
    public PlayerMakeView()
    {
    }
  }
}
