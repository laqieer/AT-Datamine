// Decompiled with JetBrains decompiler
// Type: Scenes.Guild.Top.GuildTopBulletinBoard
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.Popup;
using Il2CppDummyDll;
using Network;
using Scenes.Guild.Data;
using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.Guild.Top
{
  [Token(Token = "0x2002B92")]
  public class GuildTopBulletinBoard : MonoBehaviour
  {
    [Token(Token = "0x400B98D")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private TextMeshProUGUI bulletinBoardTextDisplay;
    [Token(Token = "0x400B98E")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Text introductionTextDisplay;
    [Token(Token = "0x400B98F")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private CommonButton btnEdit;
    [Token(Token = "0x400B990")]
    private const string GuildNameEditAssetBundleName = "ui_page_outgame_playerprofile_prefab";
    [Token(Token = "0x400B991")]
    private const string GuildNameEditPrefabName = "Com_Popup_Base_M_CommentChange";
    [Token(Token = "0x400B992")]
    [FieldOffset(Offset = "0x30")]
    private GuildTopBulletinBoard.DisplayType type;
    [Token(Token = "0x400B993")]
    [FieldOffset(Offset = "0x38")]
    private GameObject popupPrefab;

    [Token(Token = "0x17003AC2")]
    public string DisplayText
    {
      [Token(Token = "0x6011056"), Address(RVA = "0x1C76DAC", Offset = "0x1C76DAC", VA = "0x1C76DAC")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17003AC3")]
    private GuildDetailInfo guildDetailInfo
    {
      [Token(Token = "0x6011057"), Address(RVA = "0x1C76DF0", Offset = "0x1C76DF0", VA = "0x1C76DF0")] get
      {
        return (GuildDetailInfo) null;
      }
    }

    [Token(Token = "0x6011058")]
    [Address(RVA = "0x1C76E48", Offset = "0x1C76E48", VA = "0x1C76E48")]
    public void Start()
    {
    }

    [Token(Token = "0x6011059")]
    [Address(RVA = "0x1C76EF4", Offset = "0x1C76EF4", VA = "0x1C76EF4")]
    public void Initialize(GuildTopBulletinBoard.DisplayType type)
    {
    }

    [Token(Token = "0x601105A")]
    [Address(RVA = "0x1C7707C", Offset = "0x1C7707C", VA = "0x1C7707C")]
    public IEnumerator StartSetupAsync() => (IEnumerator) null;

    [Token(Token = "0x601105B")]
    [Address(RVA = "0x1C7710C", Offset = "0x1C7710C", VA = "0x1C7710C")]
    private void OpenEditPopup()
    {
    }

    [Token(Token = "0x601105C")]
    [Address(RVA = "0x1C773E0", Offset = "0x1C773E0", VA = "0x1C773E0")]
    private TextEditPopup CreateTextEditPopup(string assetBundleName, string assetName)
    {
      return (TextEditPopup) null;
    }

    [Token(Token = "0x601105D")]
    [Address(RVA = "0x1C774AC", Offset = "0x1C774AC", VA = "0x1C774AC")]
    private IEnumerator RequestGuildBulletinBoardSet(string info) => (IEnumerator) null;

    [Token(Token = "0x601105E")]
    [Address(RVA = "0x1C77548", Offset = "0x1C77548", VA = "0x1C77548")]
    private IEnumerator ShowToasterNGWord(NetworkErrorResult networkErrorResult)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x601105F")]
    [Address(RVA = "0x1C775D8", Offset = "0x1C775D8", VA = "0x1C775D8")]
    public GuildTopBulletinBoard()
    {
    }

    [Token(Token = "0x2002B93")]
    public enum DisplayType
    {
      [Token(Token = "0x400B995")] Introduction,
      [Token(Token = "0x400B996")] BulletinBoard,
    }
  }
}
