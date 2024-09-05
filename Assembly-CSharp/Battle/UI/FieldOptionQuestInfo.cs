// Decompiled with JetBrains decompiler
// Type: Battle.UI.FieldOptionQuestInfo
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data;
using Battle.Data.Board;
using GameCore.Input;
using Il2CppDummyDll;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UI.Direction;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

#nullable disable
namespace Battle.UI
{
  [Token(Token = "0x2002323")]
  public class FieldOptionQuestInfo : MonoBehaviour
  {
    [Token(Token = "0x40094EA")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private UITimelineController timelineController;
    [Token(Token = "0x40094EB")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Button closeButton;
    [Token(Token = "0x40094EC")]
    [FieldOffset(Offset = "0x28")]
    private bool showFlag;
    [Token(Token = "0x40094ED")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private Text titleText;
    [Token(Token = "0x40094EE")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private Text winningDetailText;
    [Token(Token = "0x40094EF")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private Text losingDetailText;
    [Token(Token = "0x40094F0")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private GameObject storyBattleMissionObj;
    [Token(Token = "0x40094F1")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private Text storyBattleMissionText;
    [Token(Token = "0x40094F2")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private Text unitCurrentStateText;
    [Token(Token = "0x40094F3")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    private Text turnText;
    [Token(Token = "0x40094F4")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    private Transform dropIconTrans;
    [Token(Token = "0x40094F5")]
    [FieldOffset(Offset = "0x70")]
    [SerializeField]
    private TextMeshProUGUI goldDropText;
    [Token(Token = "0x40094F6")]
    [FieldOffset(Offset = "0x78")]
    [SerializeField]
    private TextMeshProUGUI silverDropText;
    [Token(Token = "0x40094F7")]
    [FieldOffset(Offset = "0x80")]
    [SerializeField]
    private TextMeshProUGUI bronzeDropText;
    [Token(Token = "0x40094F8")]
    [FieldOffset(Offset = "0x88")]
    [SerializeField]
    private GameObject difficultyObj;
    [Token(Token = "0x40094F9")]
    [FieldOffset(Offset = "0x90")]
    [SerializeField]
    private GameObject difficultyHardObj;
    [Token(Token = "0x40094FA")]
    [FieldOffset(Offset = "0x98")]
    [SerializeField]
    private GameObject difficultyVeryHardObj;
    [Token(Token = "0x40094FB")]
    [FieldOffset(Offset = "0xA0")]
    [SerializeField]
    private BackKeyHandlerComponent backKeyHandlerComponent;
    [Token(Token = "0x40094FC")]
    [FieldOffset(Offset = "0xA8")]
    private UnityAction endCallback;

    [Token(Token = "0x17002E4F")]
    public UnityAction CloseButtonEvent
    {
      [Token(Token = "0x600D6C4"), Address(RVA = "0x1D22EE8", Offset = "0x1D22EE8", VA = "0x1D22EE8")] set
      {
      }
    }

    [Token(Token = "0x600D6C5")]
    [Address(RVA = "0x1D22F0C", Offset = "0x1D22F0C", VA = "0x1D22F0C")]
    public IEnumerator InitializeCoroutine(
      StoryBattleConfig config,
      BoardData board,
      UnityAction callback = null)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x600D6C6")]
    [Address(RVA = "0x1D22FBC", Offset = "0x1D22FBC", VA = "0x1D22FBC")]
    private void SetUpDropItem(IReadOnlyDictionary<int, int> dropItems)
    {
    }

    [Token(Token = "0x600D6C7")]
    [Address(RVA = "0x1D231EC", Offset = "0x1D231EC", VA = "0x1D231EC")]
    public void Show()
    {
    }

    [Token(Token = "0x600D6C8")]
    [Address(RVA = "0x1D23290", Offset = "0x1D23290", VA = "0x1D23290")]
    public void Hide()
    {
    }

    [Token(Token = "0x600D6C9")]
    [Address(RVA = "0x1D23338", Offset = "0x1D23338", VA = "0x1D23338")]
    public IEnumerator PopupDelete() => (IEnumerator) null;

    [Token(Token = "0x600D6CA")]
    [Address(RVA = "0x1D233C8", Offset = "0x1D233C8", VA = "0x1D233C8")]
    private string CreateUnitCurrentStateText(BoardData board) => (string) null;

    [Token(Token = "0x600D6CB")]
    [Address(RVA = "0x1D23984", Offset = "0x1D23984", VA = "0x1D23984")]
    public FieldOptionQuestInfo()
    {
    }
  }
}
