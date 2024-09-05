// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.OutGameMenu.TeamCell
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.Tween;
using Il2CppDummyDll;
using System;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.OutGame.OutGameMenu
{
  [Token(Token = "0x2003AFD")]
  public class TeamCell : MonoBehaviour
  {
    [Token(Token = "0x40103EE")]
    private const string StyleNullDeckTeamName = "--------";
    [Token(Token = "0x40103EF")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private UITweenGroup tweenGroup;
    [Token(Token = "0x40103F0")]
    private const string TweenDisableInName = "TeamList_Disable_In";
    [Token(Token = "0x40103F1")]
    private const string TweenDisableOutName = "TeamList_Disable_Out";
    [Token(Token = "0x40103F2")]
    private const string CopyButtonInName = "CopyBtn_In";
    [Token(Token = "0x40103F3")]
    private const string ClearButtonInName = "ClearBtn_In";
    [Token(Token = "0x40103F4")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Text teamNameText;
    [Token(Token = "0x40103F5")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private Text teamCombatPowerText;
    [Token(Token = "0x40103F6")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private Text partyAiSettingName;
    [Token(Token = "0x40103F7")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private Button nameEditButton;
    [Token(Token = "0x40103F8")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private Button aiButton;
    [Token(Token = "0x40103F9")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private Button deleteButton;
    [Token(Token = "0x40103FA")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private Button cliearButton;
    [Token(Token = "0x40103FB")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private Button copyButton;
    [Token(Token = "0x40103FC")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    private Button pasteButton;
    [Token(Token = "0x40103FD")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    private Button fomationButton;
    [Token(Token = "0x40103FE")]
    [FieldOffset(Offset = "0x70")]
    [SerializeField]
    private Button itemSetButton;
    [Token(Token = "0x40103FF")]
    [FieldOffset(Offset = "0x78")]
    [SerializeField]
    private Button teamCreateButton;
    [Token(Token = "0x4010400")]
    [FieldOffset(Offset = "0x80")]
    [SerializeField]
    private PartyCell[] partyCells;
    [Token(Token = "0x4010401")]
    [FieldOffset(Offset = "0x88")]
    [SerializeField]
    private ItemSetCell itemSetCell;
    [Token(Token = "0x4010402")]
    [FieldOffset(Offset = "0x90")]
    [SerializeField]
    private GameObject imgTeamDisable;
    [Token(Token = "0x4010403")]
    [FieldOffset(Offset = "0x98")]
    private Action<int> onClickCopyButton;
    [Token(Token = "0x4010404")]
    [FieldOffset(Offset = "0xA0")]
    private Action onClickCliearButton;
    [Token(Token = "0x4010405")]
    [FieldOffset(Offset = "0xA8")]
    private Action<int> onClickPasteButton;
    [Token(Token = "0x4010406")]
    [FieldOffset(Offset = "0xB0")]
    private Action<int, string> onClickTeamNameChangeButton;
    [Token(Token = "0x4010407")]
    [FieldOffset(Offset = "0xB8")]
    private Action<int> onClickDeleteButton;
    [Token(Token = "0x4010408")]
    [FieldOffset(Offset = "0xC0")]
    private Action<int> onClickPartyAIButton;
    [Token(Token = "0x4010409")]
    [FieldOffset(Offset = "0xC8")]
    private Action<int> onClickItemSetButton;
    [Token(Token = "0x401040B")]
    [FieldOffset(Offset = "0xD8")]
    private PartyListBelowScreen partyListBelowScreen;

    [Token(Token = "0x17004BBD")]
    public int TeamId
    {
      [Token(Token = "0x6017355"), Address(RVA = "0x301BFB0", Offset = "0x301BFB0", VA = "0x301BFB0")] get
      {
        return new int();
      }
      [Token(Token = "0x6017356"), Address(RVA = "0x301BFB8", Offset = "0x301BFB8", VA = "0x301BFB8")] private set
      {
      }
    }

    [Token(Token = "0x6017357")]
    [Address(RVA = "0x3016000", Offset = "0x3016000", VA = "0x3016000")]
    public void InitTeamCell(int index, PartyListBelowScreen partyListBelowScreen)
    {
    }

    [Token(Token = "0x6017358")]
    [Address(RVA = "0x301493C", Offset = "0x301493C", VA = "0x301493C")]
    public void UpdataTeamCell(bool dotInitSkip = false)
    {
    }

    [Token(Token = "0x6017359")]
    [Address(RVA = "0x3016444", Offset = "0x3016444", VA = "0x3016444")]
    public void SetAction(
      Action<int> copy,
      Action cliear,
      Action<int> paste,
      Action<int, string> nameChange,
      Action<int> delete,
      Action<int> itemSet,
      Action<int> partyAi)
    {
    }

    [Token(Token = "0x601735A")]
    [Address(RVA = "0x3016AC4", Offset = "0x3016AC4", VA = "0x3016AC4")]
    public void ChangePaseteActive(bool isActive)
    {
    }

    [Token(Token = "0x601735B")]
    [Address(RVA = "0x301BFC0", Offset = "0x301BFC0", VA = "0x301BFC0")]
    public void OnNameEditButton()
    {
    }

    [Token(Token = "0x601735C")]
    [Address(RVA = "0x301C07C", Offset = "0x301C07C", VA = "0x301C07C")]
    public void OnAiButton()
    {
    }

    [Token(Token = "0x601735D")]
    [Address(RVA = "0x301C110", Offset = "0x301C110", VA = "0x301C110")]
    public void OnDeleteButton()
    {
    }

    [Token(Token = "0x601735E")]
    [Address(RVA = "0x301C1A4", Offset = "0x301C1A4", VA = "0x301C1A4")]
    public void OnCliearButton()
    {
    }

    [Token(Token = "0x601735F")]
    [Address(RVA = "0x3016A6C", Offset = "0x3016A6C", VA = "0x3016A6C")]
    public void ClearCopy()
    {
    }

    [Token(Token = "0x6017360")]
    [Address(RVA = "0x301C230", Offset = "0x301C230", VA = "0x301C230")]
    public void OnCopyButton()
    {
    }

    [Token(Token = "0x6017361")]
    [Address(RVA = "0x301C2E8", Offset = "0x301C2E8", VA = "0x301C2E8")]
    public void OnPasteButton()
    {
    }

    [Token(Token = "0x6017362")]
    [Address(RVA = "0x301C37C", Offset = "0x301C37C", VA = "0x301C37C")]
    public void OnFomationButton()
    {
    }

    [Token(Token = "0x6017363")]
    [Address(RVA = "0x301C4AC", Offset = "0x301C4AC", VA = "0x301C4AC")]
    public void OnItemSetButton()
    {
    }

    [Token(Token = "0x6017364")]
    [Address(RVA = "0x301C540", Offset = "0x301C540", VA = "0x301C540")]
    public void OnTeamCreateButton()
    {
    }

    [Token(Token = "0x6017365")]
    [Address(RVA = "0x301C670", Offset = "0x301C670", VA = "0x301C670")]
    public TeamCell()
    {
    }
  }
}
