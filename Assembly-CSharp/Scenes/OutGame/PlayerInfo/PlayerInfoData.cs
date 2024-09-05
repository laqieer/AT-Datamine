// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.PlayerInfo.PlayerInfoData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Cysharp.Threading.Tasks;
using GameCore.Popup;
using GameCore.Tween;
using Il2CppDummyDll;
using Network.API;
using Scenes.OutGame.TitleEmblem;
using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.OutGame.PlayerInfo
{
  [Token(Token = "0x200347D")]
  public class PlayerInfoData : MonoBehaviour
  {
    [Token(Token = "0x400E458")]
    private const string TWEEN_IN_KEY = "In_PlayerStatus";
    [Token(Token = "0x400E459")]
    private const string TWEEN_OUT_KEY = "Out_PlayerStatus";
    [Token(Token = "0x400E45A")]
    private const string POPUP_IN = "Popup_In";
    [Token(Token = "0x400E45B")]
    private const string POPUP_OUT = "Popup_Out";
    [Token(Token = "0x400E45C")]
    [FieldOffset(Offset = "0x18")]
    private int NAME_CHANGE_COOL_TIME_DAY;
    [Token(Token = "0x400E45D")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private UITweenGroup tweenGroup;
    [Token(Token = "0x400E45E")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private Image unitImage;
    [Token(Token = "0x400E45F")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private PlayerTitlePanel playerTitle;
    [Token(Token = "0x400E460")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private Text playerName;
    [Token(Token = "0x400E461")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private Text rank;
    [Token(Token = "0x400E462")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private Text nextRankValue;
    [Token(Token = "0x400E463")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private Slider expGauge;
    [Token(Token = "0x400E464")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private Text playerIdText;
    [Token(Token = "0x400E465")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    private Text comment;
    [Token(Token = "0x400E466")]
    [FieldOffset(Offset = "0x68")]
    private long playerId;
    [Token(Token = "0x400E467")]
    [FieldOffset(Offset = "0x70")]
    private int unitId;
    [Token(Token = "0x400E468")]
    [FieldOffset(Offset = "0x78")]
    private ConfirmationPopup confirmationPopup;
    [Token(Token = "0x400E469")]
    [FieldOffset(Offset = "0x80")]
    private TextEditPopup nameChangePopup;
    [Token(Token = "0x400E46A")]
    [FieldOffset(Offset = "0x88")]
    private TextEditPopup commentEditPopup;
    [Token(Token = "0x400E46B")]
    [FieldOffset(Offset = "0x90")]
    private PlayerInfoLoader loader;
    [Token(Token = "0x400E46C")]
    [FieldOffset(Offset = "0x98")]
    private PlayerTitleLoader titleLoader;
    [Token(Token = "0x400E46D")]
    [FieldOffset(Offset = "0xA0")]
    private bool isClickToBackButton;
    [Token(Token = "0x400E46E")]
    [FieldOffset(Offset = "0xA8")]
    private APIPlayerNameEdit playerNameEditApi;
    [Token(Token = "0x400E46F")]
    [FieldOffset(Offset = "0xB0")]
    private APIPlayerCommentEdit playerCommentEditApi;
    [Token(Token = "0x400E470")]
    [FieldOffset(Offset = "0xB8")]
    private APIPlayerTitleEdit playerTitleEditApi;

    [Token(Token = "0x17004461")]
    public bool IsTweenPlaying
    {
      [Token(Token = "0x601496E"), Address(RVA = "0x1AABC44", Offset = "0x1AABC44", VA = "0x1AABC44")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x601496F")]
    [Address(RVA = "0x1AABC60", Offset = "0x1AABC60", VA = "0x1AABC60")]
    public void Initialize(Sprite unitSprite, PlayerInfoLoader loader)
    {
    }

    [Token(Token = "0x6014970")]
    [Address(RVA = "0x1AAC158", Offset = "0x1AAC158", VA = "0x1AAC158")]
    private void ResetTitle()
    {
    }

    [Token(Token = "0x6014971")]
    [Address(RVA = "0x1AAC1C4", Offset = "0x1AAC1C4", VA = "0x1AAC1C4")]
    private IEnumerator OpenConfirmationPopupByDecisionButton(
      string title,
      string message,
      Action onClickDecisionButton)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6014972")]
    [Address(RVA = "0x1AAC274", Offset = "0x1AAC274", VA = "0x1AAC274")]
    private void OpenNgWordPopup(TextEditPopup textEditPopup)
    {
    }

    [Token(Token = "0x6014973")]
    [Address(RVA = "0x1AAC3E8", Offset = "0x1AAC3E8", VA = "0x1AAC3E8")]
    private IEnumerator OpenNameChangePopup() => (IEnumerator) null;

    [Token(Token = "0x6014974")]
    [Address(RVA = "0x1AAC478", Offset = "0x1AAC478", VA = "0x1AAC478")]
    private IEnumerator OpenCommentEditPopup() => (IEnumerator) null;

    [Token(Token = "0x6014975")]
    [Address(RVA = "0x1AAC508", Offset = "0x1AAC508", VA = "0x1AAC508")]
    private IEnumerator PlayerNameEditAPICoroutine(string newPlayerName) => (IEnumerator) null;

    [Token(Token = "0x6014976")]
    [Address(RVA = "0x1AAC5A4", Offset = "0x1AAC5A4", VA = "0x1AAC5A4")]
    private IEnumerator CommnetEditAPICoroutine(string newComment) => (IEnumerator) null;

    [Token(Token = "0x6014977")]
    [Address(RVA = "0x1AAC640", Offset = "0x1AAC640", VA = "0x1AAC640")]
    private IEnumerator PlayerTitleEditAPICoroutine(TitleSet titleSet) => (IEnumerator) null;

    [Token(Token = "0x6014978")]
    [Address(RVA = "0x1AAC6EC", Offset = "0x1AAC6EC", VA = "0x1AAC6EC")]
    public void OnClickToChangeTitle()
    {
    }

    [Token(Token = "0x6014979")]
    [Address(RVA = "0x1AAC70C", Offset = "0x1AAC70C", VA = "0x1AAC70C")]
    private UniTaskVoid OpenTitleEditPopupAsync() => new UniTaskVoid();

    [Token(Token = "0x601497A")]
    [Address(RVA = "0x1AAC784", Offset = "0x1AAC784", VA = "0x1AAC784")]
    public void OnClickToChangePlayerName()
    {
    }

    [Token(Token = "0x601497B")]
    [Address(RVA = "0x1AAC7A4", Offset = "0x1AAC7A4", VA = "0x1AAC7A4")]
    public void OnClickToCopyPlayerID()
    {
    }

    [Token(Token = "0x601497C")]
    [Address(RVA = "0x1AAC8CC", Offset = "0x1AAC8CC", VA = "0x1AAC8CC")]
    public void OnClickToChangeComment()
    {
    }

    [Token(Token = "0x601497D")]
    [Address(RVA = "0x1AAC8EC", Offset = "0x1AAC8EC", VA = "0x1AAC8EC")]
    public void OnClickToMoveUnitList()
    {
    }

    [Token(Token = "0x601497E")]
    [Address(RVA = "0x1AAC8F0", Offset = "0x1AAC8F0", VA = "0x1AAC8F0")]
    public void OnClickToMoveUnitViewer()
    {
    }

    [Token(Token = "0x601497F")]
    [Address(RVA = "0x1AACA0C", Offset = "0x1AACA0C", VA = "0x1AACA0C")]
    public void OnClickToMoveGuild()
    {
    }

    [Token(Token = "0x6014980")]
    [Address(RVA = "0x1AACA10", Offset = "0x1AACA10", VA = "0x1AACA10")]
    public void PlayToInAnim()
    {
    }

    [Token(Token = "0x6014981")]
    [Address(RVA = "0x1AACA68", Offset = "0x1AACA68", VA = "0x1AACA68")]
    public void PlayToOutAnim()
    {
    }

    [Token(Token = "0x6014982")]
    [Address(RVA = "0x1AACAC0", Offset = "0x1AACAC0", VA = "0x1AACAC0")]
    public void OnClosePlayerInfo()
    {
    }

    [Token(Token = "0x6014983")]
    [Address(RVA = "0x1AACB60", Offset = "0x1AACB60", VA = "0x1AACB60")]
    public IEnumerator SymbolUnitEdit() => (IEnumerator) null;

    [Token(Token = "0x6014984")]
    [Address(RVA = "0x1AACBF0", Offset = "0x1AACBF0", VA = "0x1AACBF0")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x6014985")]
    [Address(RVA = "0x1AACC10", Offset = "0x1AACC10", VA = "0x1AACC10")]
    public PlayerInfoData()
    {
    }
  }
}
