// Decompiled with JetBrains decompiler
// Type: PanelMission.PanelMissionLineRewardElement
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using GameCore.MasterData;
using GameCore.Tween;
using GameCore.UIControls;
using Il2CppDummyDll;
using System.Collections;
using TMPro;
using UI.ItemDetail;
using UnityEngine;
using UnityEngine.Playables;

#nullable disable
namespace PanelMission
{
  [Token(Token = "0x2000A10")]
  public class PanelMissionLineRewardElement : MonoBehaviour
  {
    [Token(Token = "0x4002E99")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private ItemIcon _itemIcon;
    [Token(Token = "0x4002E9A")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private TextMeshProUGUI _lineNumText;
    [Token(Token = "0x4002E9B")]
    [FieldOffset(Offset = "0x28")]
    private UITweenGroup _uiTweenGroup;
    [Token(Token = "0x4002E9C")]
    [FieldOffset(Offset = "0x30")]
    private PlayableDirector _playableDirector;
    [Token(Token = "0x4002E9D")]
    [FieldOffset(Offset = "0x38")]
    private AssetCachedSpawner assetCachedSpawner;
    [Token(Token = "0x4002E9E")]
    [FieldOffset(Offset = "0x40")]
    private ItemDetailPopupProvider itemDetailPopupGenerator;

    [Token(Token = "0x17000829")]
    public int MissionId
    {
      [Token(Token = "0x6003950"), Address(RVA = "0x3113610", Offset = "0x3113610", VA = "0x3113610")] get
      {
        return new int();
      }
      [Token(Token = "0x6003951"), Address(RVA = "0x3113618", Offset = "0x3113618", VA = "0x3113618")] private set
      {
      }
    }

    [Token(Token = "0x1700082A")]
    public int LineNum
    {
      [Token(Token = "0x6003952"), Address(RVA = "0x3113620", Offset = "0x3113620", VA = "0x3113620")] get
      {
        return new int();
      }
      [Token(Token = "0x6003953"), Address(RVA = "0x3113628", Offset = "0x3113628", VA = "0x3113628")] private set
      {
      }
    }

    [Token(Token = "0x6003954")]
    [Address(RVA = "0x3112ECC", Offset = "0x3112ECC", VA = "0x3112ECC")]
    public void Initialize()
    {
    }

    [Token(Token = "0x6003955")]
    [Address(RVA = "0x3112F7C", Offset = "0x3112F7C", VA = "0x3112F7C")]
    public IEnumerator Refresh(
      PanelMissionViewModelFactory.MissionLineRewardViewModel viewModel)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6003956")]
    [Address(RVA = "0x3113658", Offset = "0x3113658", VA = "0x3113658")]
    private void OpenSingleItemDetailPopup(RewardTypeEnum rewardType, int rewardId)
    {
    }

    [Token(Token = "0x6003957")]
    [Address(RVA = "0x3112C28", Offset = "0x3112C28", VA = "0x3112C28")]
    public void SetFlashEffectActive(bool value)
    {
    }

    [Token(Token = "0x6003958")]
    [Address(RVA = "0x3112C5C", Offset = "0x3112C5C", VA = "0x3112C5C")]
    public void MakeReceived()
    {
    }

    [Token(Token = "0x6003959")]
    [Address(RVA = "0x3113674", Offset = "0x3113674", VA = "0x3113674")]
    public PanelMissionLineRewardElement()
    {
    }
  }
}
