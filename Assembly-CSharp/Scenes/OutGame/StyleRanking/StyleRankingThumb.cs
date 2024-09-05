// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.StyleRanking.StyleRankingThumb
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using Il2CppDummyDll;
using Scenes.OutGame.OutGameMenu;
using Scenes.OutGame.PersonalEmblem;
using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.OutGame.StyleRanking
{
  [Token(Token = "0x2003378")]
  internal class StyleRankingThumb : MonoBehaviour
  {
    [Token(Token = "0x400DF1D")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private StyleThumb styleThumb;
    [Token(Token = "0x400DF1E")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private RankingView rankingView;
    [Token(Token = "0x400DF1F")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private StyleThumb favoriteStyleThumb;
    [Token(Token = "0x400DF20")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private Text playerNameText;
    [Token(Token = "0x400DF21")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private Text combatPowerText;
    [Token(Token = "0x400DF22")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private Text playerRankText;
    [Token(Token = "0x400DF23")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private GuildNameView guildNameView;
    [Token(Token = "0x400DF24")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private GameObject myCursorObj;
    [Token(Token = "0x400DF25")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private GameObject notPossessionMask;
    [Token(Token = "0x400DF26")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    private CommonButton button;
    [Token(Token = "0x400DF27")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    private PersonalEmblemThumb emblemThumb;
    [Token(Token = "0x400DF28")]
    [FieldOffset(Offset = "0x70")]
    [SerializeField]
    private TextMeshProUGUI loginTimeText;

    [Token(Token = "0x601439B")]
    [Address(RVA = "0x1E172EC", Offset = "0x1E172EC", VA = "0x1E172EC")]
    public void SetPersonalEmblem(int emblemId, AssetCachedSpawner assetCachedSpawner)
    {
    }

    [Token(Token = "0x601439C")]
    [Address(RVA = "0x1E1AF60", Offset = "0x1E1AF60", VA = "0x1E1AF60")]
    public void SetRankingStyle(int styleId, AssetCachedSpawner assetCachedSpawner)
    {
    }

    [Token(Token = "0x601439D")]
    [Address(RVA = "0x1E16FB4", Offset = "0x1E16FB4", VA = "0x1E16FB4")]
    public void SetFavoriteStyle(int styleId, AssetCachedSpawner assetCachedSpawner)
    {
    }

    [Token(Token = "0x601439E")]
    [Address(RVA = "0x1E16F9C", Offset = "0x1E16F9C", VA = "0x1E16F9C")]
    public void SetRanking(int ranking)
    {
    }

    [Token(Token = "0x601439F")]
    [Address(RVA = "0x1E17024", Offset = "0x1E17024", VA = "0x1E17024")]
    public void SetPlayerName(string playerName)
    {
    }

    [Token(Token = "0x60143A0")]
    [Address(RVA = "0x1E17080", Offset = "0x1E17080", VA = "0x1E17080")]
    public void SetPlayerRank(int experience)
    {
    }

    [Token(Token = "0x60143A1")]
    [Address(RVA = "0x1E17048", Offset = "0x1E17048", VA = "0x1E17048")]
    public void SetCombatPower(int combatPower)
    {
    }

    [Token(Token = "0x60143A2")]
    [Address(RVA = "0x1E1718C", Offset = "0x1E1718C", VA = "0x1E1718C")]
    public void SetGuildName(string name)
    {
    }

    [Token(Token = "0x60143A3")]
    [Address(RVA = "0x1E185D8", Offset = "0x1E185D8", VA = "0x1E185D8")]
    public void SetNotPossession()
    {
    }

    [Token(Token = "0x60143A4")]
    [Address(RVA = "0x1E1721C", Offset = "0x1E1721C", VA = "0x1E1721C")]
    public void SetActiveMyCursor(bool state)
    {
    }

    [Token(Token = "0x60143A5")]
    [Address(RVA = "0x1E18654", Offset = "0x1E18654", VA = "0x1E18654")]
    public void SetActiveMask(bool state)
    {
    }

    [Token(Token = "0x60143A6")]
    [Address(RVA = "0x1E1723C", Offset = "0x1E1723C", VA = "0x1E1723C")]
    public void SetButtonAction(Action buttonAction)
    {
    }

    [Token(Token = "0x60143A7")]
    [Address(RVA = "0x1E1738C", Offset = "0x1E1738C", VA = "0x1E1738C")]
    public void SetLastLoginTime(DateTime lastLoginTime)
    {
    }

    [Token(Token = "0x60143A8")]
    [Address(RVA = "0x1E1AFD0", Offset = "0x1E1AFD0", VA = "0x1E1AFD0")]
    private void SetThumbView(StyleThumb target)
    {
    }

    [Token(Token = "0x60143A9")]
    [Address(RVA = "0x1E1B054", Offset = "0x1E1B054", VA = "0x1E1B054")]
    public StyleRankingThumb()
    {
    }
  }
}
