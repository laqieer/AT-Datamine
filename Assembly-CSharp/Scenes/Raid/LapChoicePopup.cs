// Decompiled with JetBrains decompiler
// Type: Scenes.Raid.LapChoicePopup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;
using TMPro;
using UI.Direction;
using UnityEngine;

#nullable disable
namespace Scenes.Raid
{
  [Token(Token = "0x20029BA")]
  internal class LapChoicePopup : MonoBehaviour
  {
    [Token(Token = "0x400B1BD")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private UITimelineController timelineController;
    [Token(Token = "0x400B1BE")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private TextMeshProUGUI lapText;
    [Token(Token = "0x400B1BF")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private CommonButton minButton;
    [Token(Token = "0x400B1C0")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private CommonButton minusButton;
    [Token(Token = "0x400B1C1")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private CommonButton plusButton;
    [Token(Token = "0x400B1C2")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private CommonButton maxButton;
    [Token(Token = "0x400B1C3")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private CommonButton closeButton;
    [Token(Token = "0x400B1C4")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private CommonButton challengeButton;
    [Token(Token = "0x400B1C5")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private CommonButton fullScreenButton;
    [Token(Token = "0x400B1C6")]
    [FieldOffset(Offset = "0x60")]
    private Action<int> challengeAction;
    [Token(Token = "0x400B1C7")]
    [FieldOffset(Offset = "0x68")]
    private Action closeAction;
    [Token(Token = "0x400B1C8")]
    [FieldOffset(Offset = "0x70")]
    private int selectLapCnt;
    [Token(Token = "0x400B1C9")]
    [FieldOffset(Offset = "0x74")]
    private int maxLap;

    [Token(Token = "0x6010619")]
    [Address(RVA = "0x4885828", Offset = "0x4885828", VA = "0x4885828")]
    public void Initialize(
      int raidId,
      int position,
      int lap,
      Action<int> challengeAction,
      Action closeAction)
    {
    }

    [Token(Token = "0x601061A")]
    [Address(RVA = "0x4885F70", Offset = "0x4885F70", VA = "0x4885F70")]
    public void Open(Action finishAction = null)
    {
    }

    [Token(Token = "0x601061B")]
    [Address(RVA = "0x4886018", Offset = "0x4886018", VA = "0x4886018")]
    public void Close()
    {
    }

    [Token(Token = "0x601061C")]
    [Address(RVA = "0x48860AC", Offset = "0x48860AC", VA = "0x48860AC")]
    private void OnClickMin()
    {
    }

    [Token(Token = "0x601061D")]
    [Address(RVA = "0x48860D8", Offset = "0x48860D8", VA = "0x48860D8")]
    private void OnClickMinus()
    {
    }

    [Token(Token = "0x601061E")]
    [Address(RVA = "0x48860FC", Offset = "0x48860FC", VA = "0x48860FC")]
    private void OnClickPlus()
    {
    }

    [Token(Token = "0x601061F")]
    [Address(RVA = "0x4886120", Offset = "0x4886120", VA = "0x4886120")]
    private void OnClickMax()
    {
    }

    [Token(Token = "0x6010620")]
    [Address(RVA = "0x4885EF0", Offset = "0x4885EF0", VA = "0x4885EF0")]
    private void UpdateButtonState()
    {
    }

    [Token(Token = "0x6010621")]
    [Address(RVA = "0x4885DA0", Offset = "0x4885DA0", VA = "0x4885DA0")]
    private void SetLapText()
    {
    }

    [Token(Token = "0x6010622")]
    [Address(RVA = "0x4885F98", Offset = "0x4885F98", VA = "0x4885F98")]
    private IEnumerator PlayTimeline(UITimelineController.DirectionType type, Action finishAction = null)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6010623")]
    [Address(RVA = "0x4886174", Offset = "0x4886174", VA = "0x4886174")]
    public LapChoicePopup()
    {
    }
  }
}
