// Decompiled with JetBrains decompiler
// Type: Battle.UI.BattleLogView
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data.Board;
using Battle.Process;
using GameCore.Input;
using Il2CppDummyDll;
using System;
using System.Collections;
using UI.Direction;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Battle.UI
{
  [Token(Token = "0x200230A")]
  public sealed class BattleLogView : MonoBehaviour
  {
    [Token(Token = "0x4009440")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private UITimelineController timeLineController;
    [Token(Token = "0x4009441")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Transform logTextTrans;
    [Token(Token = "0x4009442")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private Button logButton;
    [Token(Token = "0x4009443")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private CanvasGroup canvasGroup;
    [Token(Token = "0x4009444")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private InfiniteScrollView infiniteScrollView;
    [Token(Token = "0x4009445")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private Text logText;
    [Token(Token = "0x4009446")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private BackKeyHandlerComponent backKeyHandlerComponent;
    [Token(Token = "0x4009447")]
    [FieldOffset(Offset = "0x50")]
    public bool logShow;
    [Token(Token = "0x4009448")]
    [FieldOffset(Offset = "0x58")]
    private Action hideCallback;

    [Token(Token = "0x600D618")]
    [Address(RVA = "0x1D1A930", Offset = "0x1D1A930", VA = "0x1D1A930")]
    public IEnumerator Initialize() => (IEnumerator) null;

    [Token(Token = "0x600D619")]
    [Address(RVA = "0x1D1A9C0", Offset = "0x1D1A9C0", VA = "0x1D1A9C0")]
    public void SetLogText(BattleCore core, BoardData board)
    {
    }

    [Token(Token = "0x600D61A")]
    [Address(RVA = "0x1D1ACAC", Offset = "0x1D1ACAC", VA = "0x1D1ACAC")]
    public void Show(Action hideCallback = null)
    {
    }

    [Token(Token = "0x600D61B")]
    [Address(RVA = "0x1D1AD20", Offset = "0x1D1AD20", VA = "0x1D1AD20")]
    public void Hide()
    {
    }

    [Token(Token = "0x600D61C")]
    [Address(RVA = "0x1D1ADD0", Offset = "0x1D1ADD0", VA = "0x1D1ADD0")]
    public void SetActive(bool isActive)
    {
    }

    [Token(Token = "0x600D61D")]
    [Address(RVA = "0x1D1ADF8", Offset = "0x1D1ADF8", VA = "0x1D1ADF8")]
    public BattleLogView()
    {
    }
  }
}
