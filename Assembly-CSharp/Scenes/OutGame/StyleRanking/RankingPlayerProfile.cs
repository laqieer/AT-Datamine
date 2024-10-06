// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.StyleRanking.RankingPlayerProfile
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using GameCore.Input;
using Il2CppDummyDll;
using Network.Param;
using Scenes.OutGame.OutGameMenu;
using Scenes.OutGame.PersonalEmblem;
using System;
using System.Collections;
using UI.Direction;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.OutGame.StyleRanking
{
  [Token(Token = "0x2003360")]
  internal class RankingPlayerProfile : MonoBehaviour
  {
    [Token(Token = "0x400DE8D")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private UITimelineController timelineController;
    [Token(Token = "0x400DE8E")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Image avatarImage;
    [Token(Token = "0x400DE8F")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private StyleThumb unitIcon;
    [Token(Token = "0x400DE90")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private Text playerNameText;
    [Token(Token = "0x400DE91")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private Text playerRankText;
    [Token(Token = "0x400DE92")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private Text playerRankNextText;
    [Token(Token = "0x400DE93")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private RectTransform playerRankNextUnmask;
    [Token(Token = "0x400DE94")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private Text playerIdText;
    [Token(Token = "0x400DE95")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private Text lastLoginDayText;
    [Token(Token = "0x400DE96")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    private Text combatPowerText;
    [Token(Token = "0x400DE97")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    private Text commentText;
    [Token(Token = "0x400DE98")]
    [FieldOffset(Offset = "0x70")]
    [SerializeField]
    private PersonalEmblemThumb personalEmblemThumb;
    [Token(Token = "0x400DE99")]
    [FieldOffset(Offset = "0x78")]
    [SerializeField]
    private CommonButton backButton;
    [Token(Token = "0x400DE9A")]
    [FieldOffset(Offset = "0x80")]
    [SerializeField]
    private GameObject[] disableObj;
    [Token(Token = "0x400DE9B")]
    [FieldOffset(Offset = "0x88")]
    [SerializeField]
    private GameObject playerIdObj;
    [Token(Token = "0x400DE9C")]
    [FieldOffset(Offset = "0x90")]
    [SerializeField]
    private BackKeyHandlerComponent backKeyHandlerComponent;
    [Token(Token = "0x400DE9D")]
    [FieldOffset(Offset = "0x98")]
    private AssetCachedSpawner assetCachedSpawner;
    [Token(Token = "0x400DE9E")]
    [FieldOffset(Offset = "0xA0")]
    private Action<bool> setSubSceneOperatin;
    [Token(Token = "0x400DE9F")]
    [FieldOffset(Offset = "0xA8")]
    private Action finishAction;

    [Token(Token = "0x6014307")]
    [Address(RVA = "0x1E15E24", Offset = "0x1E15E24", VA = "0x1E15E24")]
    public void Initialize(
      AssetCachedSpawner assetCachedSpawner,
      Action<bool> setSubSceneOperatin,
      Action finishAction)
    {
    }

    [Token(Token = "0x6014308")]
    [Address(RVA = "0x1E15F9C", Offset = "0x1E15F9C", VA = "0x1E15F9C")]
    public IEnumerator InitializeAsync(int combatPower, PlayerRankingProfileType playerInfo)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6014309")]
    [Address(RVA = "0x1E16038", Offset = "0x1E16038", VA = "0x1E16038")]
    public void Open()
    {
    }

    [Token(Token = "0x601430A")]
    [Address(RVA = "0x1E1618C", Offset = "0x1E1618C", VA = "0x1E1618C")]
    public void Close()
    {
    }

    [Token(Token = "0x601430B")]
    [Address(RVA = "0x1E16240", Offset = "0x1E16240", VA = "0x1E16240")]
    private void SetAvatarImage(int avatarId)
    {
    }

    [Token(Token = "0x601430C")]
    [Address(RVA = "0x1E16394", Offset = "0x1E16394", VA = "0x1E16394")]
    private void SetFavoriteStyle(int styleId)
    {
    }

    [Token(Token = "0x601430D")]
    [Address(RVA = "0x1E160BC", Offset = "0x1E160BC", VA = "0x1E160BC")]
    private void PlayTimeline(UITimelineController.DirectionType type, Action finishAction = null)
    {
    }

    [Token(Token = "0x601430E")]
    [Address(RVA = "0x1E16474", Offset = "0x1E16474", VA = "0x1E16474")]
    public RankingPlayerProfile()
    {
    }
  }
}
