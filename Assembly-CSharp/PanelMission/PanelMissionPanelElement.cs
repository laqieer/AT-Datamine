// Decompiled with JetBrains decompiler
// Type: PanelMission.PanelMissionPanelElement
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using GameCore.Tween;
using GameCore.UIControls;
using Il2CppDummyDll;
using Scenes.OutGame.OutGameMenu;
using System;
using System.Collections;
using UI.ItemDetail;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace PanelMission
{
  [Token(Token = "0x2000A13")]
  public class PanelMissionPanelElement : MonoBehaviour
  {
    [Token(Token = "0x4002EAA")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private GameObject _gaugeRoot;
    [Token(Token = "0x4002EAB")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private GameObject _gauge;
    [Token(Token = "0x4002EAC")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private Text _gaugeTextDone;
    [Token(Token = "0x4002EAD")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private Text _gaugeTextMax;
    [Token(Token = "0x4002EAE")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private CommonButton _searchButton;
    [Token(Token = "0x4002EAF")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private GameObject _clearImage;
    [Token(Token = "0x4002EB0")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private Text _missionNameText;
    [Token(Token = "0x4002EB1")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private Text _rewardItemNum;
    [Token(Token = "0x4002EB2")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private ItemIcon _itemIcon;
    [Token(Token = "0x4002EB3")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    private MindequipmentThumb _mindequipmentThumb;
    [Token(Token = "0x4002EB4")]
    [FieldOffset(Offset = "0x68")]
    private UITweenGroup _tweenGroup;
    [Token(Token = "0x4002EB5")]
    [FieldOffset(Offset = "0x70")]
    private Button _rewardGetButton;
    [Token(Token = "0x4002EB6")]
    [FieldOffset(Offset = "0x78")]
    private Action<int, int> OnPressRewardGetButton;
    [Token(Token = "0x4002EB7")]
    [FieldOffset(Offset = "0x80")]
    private Action<int, int> OnPressChallengeButton;
    [Token(Token = "0x4002EBA")]
    [FieldOffset(Offset = "0x90")]
    private AssetCachedSpawner assetCachedSpawner;
    [Token(Token = "0x4002EBB")]
    [FieldOffset(Offset = "0x98")]
    private ItemDetailPopupProvider itemDetailPopupGenerator;
    [Token(Token = "0x4002EBC")]
    [FieldOffset(Offset = "0xA0")]
    private PanelMissionViewModelFactory.PanelElementViewModel _viewModel;

    [Token(Token = "0x1700082D")]
    public int PanelMissionGroupId
    {
      [Token(Token = "0x6003962"), Address(RVA = "0x3113B24", Offset = "0x3113B24", VA = "0x3113B24")] get
      {
        return new int();
      }
      [Token(Token = "0x6003963"), Address(RVA = "0x3113B2C", Offset = "0x3113B2C", VA = "0x3113B2C")] set
      {
      }
    }

    [Token(Token = "0x1700082E")]
    public int PanelIndex
    {
      [Token(Token = "0x6003964"), Address(RVA = "0x3113B34", Offset = "0x3113B34", VA = "0x3113B34")] get
      {
        return new int();
      }
      [Token(Token = "0x6003965"), Address(RVA = "0x3113B3C", Offset = "0x3113B3C", VA = "0x3113B3C")] set
      {
      }
    }

    [Token(Token = "0x6003966")]
    [Address(RVA = "0x3113B44", Offset = "0x3113B44", VA = "0x3113B44")]
    public IEnumerator InitializeAsync() => (IEnumerator) null;

    [Token(Token = "0x6003967")]
    [Address(RVA = "0x3113BD4", Offset = "0x3113BD4", VA = "0x3113BD4")]
    public void MakePanelReceived()
    {
    }

    [Token(Token = "0x6003968")]
    [Address(RVA = "0x3113CDC", Offset = "0x3113CDC", VA = "0x3113CDC")]
    public void SetOnPressRewardGetButton(Action<int, int> action)
    {
    }

    [Token(Token = "0x6003969")]
    [Address(RVA = "0x3113DA4", Offset = "0x3113DA4", VA = "0x3113DA4")]
    public void DisableRewardGetFunction()
    {
    }

    [Token(Token = "0x600396A")]
    [Address(RVA = "0x3113E9C", Offset = "0x3113E9C", VA = "0x3113E9C")]
    public void SetOnPressChallengeButton(Action<int, int> action)
    {
    }

    [Token(Token = "0x600396B")]
    [Address(RVA = "0x3113FC4", Offset = "0x3113FC4", VA = "0x3113FC4")]
    public void RemoveOnPressRewardGetButton()
    {
    }

    [Token(Token = "0x600396C")]
    [Address(RVA = "0x3113FE8", Offset = "0x3113FE8", VA = "0x3113FE8")]
    public void Refresh(
      PanelMissionViewModelFactory.PanelElementViewModel elementViewModel,
      bool panelIsLocked,
      bool canReceiveReward)
    {
    }

    [Token(Token = "0x600396D")]
    [Address(RVA = "0x31145A4", Offset = "0x31145A4", VA = "0x31145A4")]
    public IEnumerator LoadItemImage(
      PanelMissionViewModelFactory.PanelElementViewModel elementViewModel)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x600396E")]
    [Address(RVA = "0x3114634", Offset = "0x3114634", VA = "0x3114634")]
    private void OnClickItem(ItemIcon itemIcon)
    {
    }

    [Token(Token = "0x600396F")]
    [Address(RVA = "0x311465C", Offset = "0x311465C", VA = "0x311465C")]
    private void OnClickItem()
    {
    }

    [Token(Token = "0x6003970")]
    [Address(RVA = "0x3114684", Offset = "0x3114684", VA = "0x3114684")]
    public PanelMissionPanelElement()
    {
    }
  }
}
