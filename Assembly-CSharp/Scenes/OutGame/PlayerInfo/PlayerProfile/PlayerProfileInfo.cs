// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.PlayerInfo.PlayerProfile.PlayerProfileInfo
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using GameCore.Popup;
using GameCore.Tween;
using Il2CppDummyDll;
using Network;
using Scenes.OutGame.OutGameMenu;
using Scenes.OutGame.PersonalEmblem;
using Scenes.OutGame.PlayerInfo.AvatarSelect;
using System;
using System.Collections;
using System.Collections.Generic;
using UI.Direction;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.OutGame.PlayerInfo.PlayerProfile
{
  [Token(Token = "0x20034B2")]
  public class PlayerProfileInfo : MonoBehaviour
  {
    [Token(Token = "0x400E54C")]
    public const string AssetbundleName = "ui_page_outgame_playerprofile_prefab";
    [Token(Token = "0x400E54D")]
    private const string AssetName = "Content_GlobalMenu_PlayerProfile";
    [Token(Token = "0x400E54E")]
    private const string NameEditAssetName = "Com_Popup_Base_S_NameEdit";
    [Token(Token = "0x400E54F")]
    public const string CommentEditAssetName = "Com_Popup_Base_M_CommentChange";
    [Token(Token = "0x400E550")]
    private const string PersonalEmblemChangeAssetName = "Container_Popup_TitleSelect";
    [Token(Token = "0x400E551")]
    private const string ErrorCodeNgWord = "exceptions.NgWordError";
    [Token(Token = "0x400E552")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private StyleThumb unitIcon;
    [Token(Token = "0x400E553")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private CommonButton nameEditButton;
    [Token(Token = "0x400E554")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private CommonButton playerIdCopyButton;
    [Token(Token = "0x400E555")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private CommonButton commentEditButton;
    [Token(Token = "0x400E556")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private CommonButton backButton;
    [Token(Token = "0x400E557")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private CommonButton personalEmblemChangeButton;
    [Token(Token = "0x400E558")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private CommonButton avatarSelectButton;
    [Token(Token = "0x400E559")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private Text playerNameText;
    [Token(Token = "0x400E55A")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private Text playerRankText;
    [Token(Token = "0x400E55B")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    private Text playerRankNextText;
    [Token(Token = "0x400E55C")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    private RectTransform playerRankNextUnmask;
    [Token(Token = "0x400E55D")]
    [FieldOffset(Offset = "0x70")]
    [SerializeField]
    private Text playerIdText;
    [Token(Token = "0x400E55E")]
    [FieldOffset(Offset = "0x78")]
    [SerializeField]
    private Text lastLoginDayText;
    [Token(Token = "0x400E55F")]
    [FieldOffset(Offset = "0x80")]
    [SerializeField]
    private Text totalPowerText;
    [Token(Token = "0x400E560")]
    [FieldOffset(Offset = "0x88")]
    [SerializeField]
    private Text commentText;
    [Token(Token = "0x400E561")]
    [FieldOffset(Offset = "0x90")]
    [SerializeField]
    private UITimelineController timelineController;
    [Token(Token = "0x400E562")]
    [FieldOffset(Offset = "0x98")]
    [SerializeField]
    private Image avatarImage;
    [Token(Token = "0x400E563")]
    [FieldOffset(Offset = "0xA0")]
    [SerializeField]
    private PersonalEmblemThumb personalEmblemThumb;
    [Token(Token = "0x400E564")]
    [FieldOffset(Offset = "0xA8")]
    [SerializeField]
    private UITweenGroup personalEmblemChangeButtonTweenGroup;
    [Token(Token = "0x400E565")]
    [FieldOffset(Offset = "0xB0")]
    private AssetCachedSpawner assetCachedSpawner;
    [Token(Token = "0x400E566")]
    [FieldOffset(Offset = "0xB8")]
    private TextEditPopup nameChangePopup;
    [Token(Token = "0x400E567")]
    [FieldOffset(Offset = "0xC0")]
    private TextEditPopup commentEditPopup;
    [Token(Token = "0x400E568")]
    [FieldOffset(Offset = "0xC8")]
    private PersonalEmblemChangePopup emblemChangePopup;
    [Token(Token = "0x400E569")]
    [FieldOffset(Offset = "0xD0")]
    private AvatarSelectPopupProvider avatarSelectPopupProvider;
    [Token(Token = "0x400E56A")]
    [FieldOffset(Offset = "0xD8")]
    private Dictionary<string, Action> dicNetworkErrorHandle;

    [Token(Token = "0x1700448D")]
    public bool IsPlayingAnim
    {
      [Token(Token = "0x6014AB9"), Address(RVA = "0x1D687D8", Offset = "0x1D687D8", VA = "0x1D687D8")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x6014ABA")]
    [Address(RVA = "0x1D687F4", Offset = "0x1D687F4", VA = "0x1D687F4")]
    public static void SpawnAsync(
      AssetCachedSpawner assetCachedSpawner,
      Transform parent,
      Action<PlayerProfileInfo> onFinish)
    {
    }

    [Token(Token = "0x6014ABB")]
    [Address(RVA = "0x1D689B0", Offset = "0x1D689B0", VA = "0x1D689B0")]
    public IEnumerator InitializeAsync(AssetCachedSpawner assetCachedSpawner) => (IEnumerator) null;

    [Token(Token = "0x6014ABC")]
    [Address(RVA = "0x1D68A4C", Offset = "0x1D68A4C", VA = "0x1D68A4C")]
    private void InitButton()
    {
    }

    [Token(Token = "0x6014ABD")]
    [Address(RVA = "0x1D68D1C", Offset = "0x1D68D1C", VA = "0x1D68D1C")]
    public void PlayInAnim()
    {
    }

    [Token(Token = "0x6014ABE")]
    [Address(RVA = "0x1D690FC", Offset = "0x1D690FC", VA = "0x1D690FC")]
    public void PlayOutAnim(Action onFinished)
    {
    }

    [Token(Token = "0x1700448E")]
    private int SymbolUnitId
    {
      [Token(Token = "0x6014ABF"), Address(RVA = "0x1D691D0", Offset = "0x1D691D0", VA = "0x1D691D0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6014AC0")]
    [Address(RVA = "0x1D69240", Offset = "0x1D69240", VA = "0x1D69240")]
    private void RequestLoadAvatarImage()
    {
    }

    [Token(Token = "0x6014AC1")]
    [Address(RVA = "0x1D693C4", Offset = "0x1D693C4", VA = "0x1D693C4")]
    private void UpdateView()
    {
    }

    [Token(Token = "0x6014AC2")]
    [Address(RVA = "0x1D69744", Offset = "0x1D69744", VA = "0x1D69744")]
    private void SetSymbolUnitThumb(int styleId, bool requestLoad = false)
    {
    }

    [Token(Token = "0x1700448F")]
    private string Comment
    {
      [Token(Token = "0x6014AC3"), Address(RVA = "0x1D69684", Offset = "0x1D69684", VA = "0x1D69684")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x6014AC4")]
    [Address(RVA = "0x1D69850", Offset = "0x1D69850", VA = "0x1D69850")]
    private void OnClickToMoveUnitList()
    {
    }

    [Token(Token = "0x6014AC5")]
    [Address(RVA = "0x1D69A34", Offset = "0x1D69A34", VA = "0x1D69A34")]
    private IEnumerator OpenPersonalEmblemChangePopup() => (IEnumerator) null;

    [Token(Token = "0x6014AC6")]
    [Address(RVA = "0x1D69AC4", Offset = "0x1D69AC4", VA = "0x1D69AC4")]
    private IEnumerator PlayerEmblemEditAPICoroutine(int targetEmblemId) => (IEnumerator) null;

    [Token(Token = "0x6014AC7")]
    [Address(RVA = "0x1D68E14", Offset = "0x1D68E14", VA = "0x1D68E14")]
    private void UpdatePersonalEmblemBadge()
    {
    }

    [Token(Token = "0x6014AC8")]
    [Address(RVA = "0x1D69B64", Offset = "0x1D69B64", VA = "0x1D69B64")]
    private IEnumerator OpenAvatarSelectPopup() => (IEnumerator) null;

    [Token(Token = "0x6014AC9")]
    [Address(RVA = "0x1D69BF4", Offset = "0x1D69BF4", VA = "0x1D69BF4")]
    private IEnumerator OpenNameChangePopup() => (IEnumerator) null;

    [Token(Token = "0x6014ACA")]
    [Address(RVA = "0x1D69C84", Offset = "0x1D69C84", VA = "0x1D69C84")]
    private IEnumerator PlayerNameEditAPICoroutine(string newPlayerName) => (IEnumerator) null;

    [Token(Token = "0x6014ACB")]
    [Address(RVA = "0x1D69D20", Offset = "0x1D69D20", VA = "0x1D69D20")]
    private IEnumerator OnNetworkError(NetworkErrorResult networkErrorResult) => (IEnumerator) null;

    [Token(Token = "0x6014ACC")]
    [Address(RVA = "0x1D69DBC", Offset = "0x1D69DBC", VA = "0x1D69DBC")]
    private IEnumerator OpenCommentEditPopup() => (IEnumerator) null;

    [Token(Token = "0x6014ACD")]
    [Address(RVA = "0x1D69E4C", Offset = "0x1D69E4C", VA = "0x1D69E4C")]
    private IEnumerator CommnetEditAPICoroutine(string newComment) => (IEnumerator) null;

    [Token(Token = "0x6014ACE")]
    [Address(RVA = "0x1D69EE8", Offset = "0x1D69EE8", VA = "0x1D69EE8")]
    private void ShowToaster(PlayerProfileInfo.ToasterType toasterType, Action onComplete = null)
    {
    }

    [Token(Token = "0x6014ACF")]
    [Address(RVA = "0x1D6A140", Offset = "0x1D6A140", VA = "0x1D6A140")]
    public PlayerProfileInfo()
    {
    }

    [Token(Token = "0x20034B3")]
    private enum ToasterType
    {
      [Token(Token = "0x400E56C")] NGword,
      [Token(Token = "0x400E56D")] NameChangeCoolTime,
      [Token(Token = "0x400E56E")] CompletedCopyPlayerID,
    }
  }
}
