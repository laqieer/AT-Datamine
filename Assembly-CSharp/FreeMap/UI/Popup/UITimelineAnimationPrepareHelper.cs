// Decompiled with JetBrains decompiler
// Type: FreeMap.UI.Popup.UITimelineAnimationPrepareHelper
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;
using UI.Direction;
using UnityEngine;

#nullable disable
namespace FreeMap.UI.Popup
{
  [Token(Token = "0x200167A")]
  [RequireComponent(typeof (UITimelineController))]
  public class UITimelineAnimationPrepareHelper : MonoBehaviour
  {
    [Token(Token = "0x4006522")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private UITimelineController timelineController;

    [Token(Token = "0x14000110")]
    public event Action OnInitialized
    {
      [Token(Token = "0x6007ED8"), Address(RVA = "0x21B3BA0", Offset = "0x21B3BA0", VA = "0x21B3BA0")] add
      {
      }
      [Token(Token = "0x6007ED9"), Address(RVA = "0x21B3C3C", Offset = "0x21B3C3C", VA = "0x21B3C3C")] remove
      {
      }
    }

    [Token(Token = "0x6007EDA")]
    [Address(RVA = "0x21B3CD8", Offset = "0x21B3CD8", VA = "0x21B3CD8")]
    private bool IsPlayable() => new bool();

    [Token(Token = "0x6007EDB")]
    [Address(RVA = "0x21B3CF4", Offset = "0x21B3CF4", VA = "0x21B3CF4")]
    private void OnValidate()
    {
    }

    [Token(Token = "0x6007EDC")]
    [Address(RVA = "0x21B3D44", Offset = "0x21B3D44", VA = "0x21B3D44")]
    private void Start()
    {
    }

    [Token(Token = "0x6007EDD")]
    [Address(RVA = "0x21B3D88", Offset = "0x21B3D88", VA = "0x21B3D88")]
    private IEnumerator Initialize() => (IEnumerator) null;

    [Token(Token = "0x6007EDE")]
    [Address(RVA = "0x21B3E18", Offset = "0x21B3E18", VA = "0x21B3E18")]
    public void Ready(
      UITimelineController.DirectionType direction,
      string keyword = "",
      Action callback = null)
    {
    }

    [Token(Token = "0x6007EDF")]
    [Address(RVA = "0x21B3E38", Offset = "0x21B3E38", VA = "0x21B3E38")]
    public IEnumerator AnimationReady(
      UITimelineController.DirectionType direction,
      string keyword = "",
      Action callback = null)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6007EE0")]
    [Address(RVA = "0x21B3B38", Offset = "0x21B3B38", VA = "0x21B3B38")]
    public void In(bool ready = true, string keyword = "", Action callback = null)
    {
    }

    [Token(Token = "0x6007EE1")]
    [Address(RVA = "0x21B3B68", Offset = "0x21B3B68", VA = "0x21B3B68")]
    public void Out(bool ready = true, string keyword = "", Action callback = null)
    {
    }

    [Token(Token = "0x6007EE2")]
    [Address(RVA = "0x21B3F84", Offset = "0x21B3F84", VA = "0x21B3F84")]
    public void Play(
      UITimelineController.DirectionType direction,
      bool ready,
      string keyword = "",
      Action callback = null)
    {
    }

    [Token(Token = "0x6007EE3")]
    [Address(RVA = "0x21B3EEC", Offset = "0x21B3EEC", VA = "0x21B3EEC")]
    public IEnumerator AnimationPlay(
      UITimelineController.DirectionType direction,
      bool ready,
      string keyword = "",
      Action callback = null)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6007EE4")]
    [Address(RVA = "0x21B3FD0", Offset = "0x21B3FD0", VA = "0x21B3FD0")]
    public UITimelineAnimationPrepareHelper()
    {
    }
  }
}
