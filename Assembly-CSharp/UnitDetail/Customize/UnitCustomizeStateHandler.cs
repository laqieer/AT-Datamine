// Decompiled with JetBrains decompiler
// Type: UnitDetail.Customize.UnitCustomizeStateHandler
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.Tween;
using Il2CppDummyDll;
using StaqData;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using TeamOrganization;
using UnitDetail.Customize.FeatureDetail;
using UnitDetail.Customize.ParameterDetail;
using UnitDetail.Customize.State;
using UnitDetail.State;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace UnitDetail.Customize
{
  [Token(Token = "0x20004E5")]
  public class UnitCustomizeStateHandler : UnitDetailStateHandlerBase
  {
    [Token(Token = "0x400197C")]
    private const string UnitDetailViewPrefabtName = "CharaPage";
    [Token(Token = "0x400197D")]
    private const string ParameterDetailPrefabName = "UnitDetail_StatusDetail";
    [Token(Token = "0x400197E")]
    private const string FeatureDetailPrefabName = "UnitDetail_ResistDetail";
    [Token(Token = "0x400197F")]
    [FieldOffset(Offset = "0x28")]
    public ReadOnlyDictionary<UnitCustomizeStateHandler.SubStateIndices, string> TabAnimationPartDic;
    [Token(Token = "0x4001980")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private UITweenGroup tweenGroup;
    [Token(Token = "0x4001981")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private Image favoriteImage;
    [Token(Token = "0x4001982")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private Color defaultColor;
    [Token(Token = "0x4001983")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private Color favoriteColor;
    [Token(Token = "0x4001984")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    private Transform unitDetailViewPlacement;
    [Token(Token = "0x4001985")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    private Transform detailViewPlacement;
    [Token(Token = "0x4001986")]
    [FieldOffset(Offset = "0x70")]
    [SerializeField]
    private Text aiText;
    [Token(Token = "0x4001987")]
    [FieldOffset(Offset = "0x78")]
    private UIAnimationController unitDetailViewAnimation;
    [Token(Token = "0x4001988")]
    [FieldOffset(Offset = "0x80")]
    private UIAnimationController parameterDetailViewAnimation;
    [Token(Token = "0x4001989")]
    [FieldOffset(Offset = "0x88")]
    private UIAnimationController featureDetailViewAnimation;
    [Token(Token = "0x400198A")]
    [FieldOffset(Offset = "0x90")]
    private List<UIAnimationController> animationControllerList;
    [Token(Token = "0x400198B")]
    [FieldOffset(Offset = "0x98")]
    private UnitCustomizeStateHandler.UnitCustomizeSubStateMachine subStateMachine;
    [Token(Token = "0x400198C")]
    [FieldOffset(Offset = "0xA0")]
    private Dictionary<UnitCustomizeStateHandler.SubStateIndices, CustomizeSubState> subStateDic;
    [Token(Token = "0x400198D")]
    [FieldOffset(Offset = "0xA8")]
    private UnitCustomizeStateHandler.PopupIndices popupIndex;
    [Token(Token = "0x400198E")]
    [FieldOffset(Offset = "0xB0")]
    private UnitDetailView unitDetailView;
    [Token(Token = "0x400198F")]
    [FieldOffset(Offset = "0xB8")]
    private UnitDetailView appearanceUnitDetailView;
    [Token(Token = "0x4001990")]
    [FieldOffset(Offset = "0xC0")]
    private UnitParameterDetailView parameterDetailView;
    [Token(Token = "0x4001991")]
    [FieldOffset(Offset = "0xC8")]
    private UnitFeatureDetailView featureDetailView;

    [Token(Token = "0x17000379")]
    public Transform DetailViewPlacement
    {
      [Token(Token = "0x6001BBB"), Address(RVA = "0x2C2D3DC", Offset = "0x2C2D3DC", VA = "0x2C2D3DC")] get
      {
        return (Transform) null;
      }
    }

    [Token(Token = "0x1700037A")]
    public UnitFeatureDetailView FeatureDetailView
    {
      [Token(Token = "0x6001BBC"), Address(RVA = "0x2C2D3E4", Offset = "0x2C2D3E4", VA = "0x2C2D3E4")] get
      {
        return (UnitFeatureDetailView) null;
      }
    }

    [Token(Token = "0x1700037B")]
    public Action OnOpenStyleLvupPopup
    {
      [Token(Token = "0x6001BBD"), Address(RVA = "0x2C2D3EC", Offset = "0x2C2D3EC", VA = "0x2C2D3EC")] set
      {
      }
    }

    [Token(Token = "0x1700037C")]
    public Action OnOpenLimitBreakPopup
    {
      [Token(Token = "0x6001BBE"), Address(RVA = "0x2C2D408", Offset = "0x2C2D408", VA = "0x2C2D408")] set
      {
      }
    }

    [Token(Token = "0x1700037D")]
    public Action OnOpenWeaponProficiencyPopup
    {
      [Token(Token = "0x6001BBF"), Address(RVA = "0x2C2D424", Offset = "0x2C2D424", VA = "0x2C2D424")] set
      {
      }
    }

    [Token(Token = "0x1700037E")]
    public Action OnOpenReincarnationPopup
    {
      [Token(Token = "0x6001BC0"), Address(RVA = "0x2C2D440", Offset = "0x2C2D440", VA = "0x2C2D440")] get
      {
        return (Action) null;
      }
      [Token(Token = "0x6001BC1"), Address(RVA = "0x2C2D448", Offset = "0x2C2D448", VA = "0x2C2D448")] set
      {
      }
    }

    [Token(Token = "0x1700037F")]
    public Action OnClickToFavoriteAction
    {
      [Token(Token = "0x6001BC2"), Address(RVA = "0x2C2D450", Offset = "0x2C2D450", VA = "0x2C2D450")] get
      {
        return (Action) null;
      }
      [Token(Token = "0x6001BC3"), Address(RVA = "0x2C2D458", Offset = "0x2C2D458", VA = "0x2C2D458")] set
      {
      }
    }

    [Token(Token = "0x17000380")]
    public Action OnClickToAiAction
    {
      [Token(Token = "0x6001BC4"), Address(RVA = "0x2C2D460", Offset = "0x2C2D460", VA = "0x2C2D460")] get
      {
        return (Action) null;
      }
      [Token(Token = "0x6001BC5"), Address(RVA = "0x2C2D468", Offset = "0x2C2D468", VA = "0x2C2D468")] set
      {
      }
    }

    [Token(Token = "0x17000381")]
    public Action OnOpenAbilityBoardPopup
    {
      [Token(Token = "0x6001BC6"), Address(RVA = "0x2C2D470", Offset = "0x2C2D470", VA = "0x2C2D470")] get
      {
        return (Action) null;
      }
      [Token(Token = "0x6001BC7"), Address(RVA = "0x2C2D478", Offset = "0x2C2D478", VA = "0x2C2D478")] set
      {
      }
    }

    [Token(Token = "0x17000382")]
    public Action<Style> DeckUnitUpdateAction
    {
      [Token(Token = "0x6001BC8"), Address(RVA = "0x2C2D480", Offset = "0x2C2D480", VA = "0x2C2D480")] get
      {
        return (Action<Style>) null;
      }
      [Token(Token = "0x6001BC9"), Address(RVA = "0x2C2D488", Offset = "0x2C2D488", VA = "0x2C2D488")] set
      {
      }
    }

    [Token(Token = "0x17000383")]
    public Action<OrganizationEquipmentSlot.EquipmentSlotType> OnClickToLockEquipment
    {
      [Token(Token = "0x6001BCA"), Address(RVA = "0x2C2D490", Offset = "0x2C2D490", VA = "0x2C2D490")] get
      {
        return (Action<OrganizationEquipmentSlot.EquipmentSlotType>) null;
      }
      [Token(Token = "0x6001BCB"), Address(RVA = "0x2C2D498", Offset = "0x2C2D498", VA = "0x2C2D498")] set
      {
      }
    }

    [Token(Token = "0x17000384")]
    public UnitDetailInfo ActiveUnit
    {
      [Token(Token = "0x6001BCC"), Address(RVA = "0x2C2D4A0", Offset = "0x2C2D4A0", VA = "0x2C2D4A0")] get
      {
        return (UnitDetailInfo) null;
      }
    }

    [Token(Token = "0x17000385")]
    public ItemInfoBase SelectItemInfo
    {
      [Token(Token = "0x6001BCD"), Address(RVA = "0x2C2D4BC", Offset = "0x2C2D4BC", VA = "0x2C2D4BC")] get
      {
        return (ItemInfoBase) null;
      }
      [Token(Token = "0x6001BCE"), Address(RVA = "0x2C2D4C4", Offset = "0x2C2D4C4", VA = "0x2C2D4C4")] set
      {
      }
    }

    [Token(Token = "0x6001BCF")]
    [Address(RVA = "0x2C2D4CC", Offset = "0x2C2D4CC", VA = "0x2C2D4CC")]
    public bool IsCheckEquipmnetInventory() => new bool();

    [Token(Token = "0x6001BD0")]
    [Address(RVA = "0x2C2D53C", Offset = "0x2C2D53C", VA = "0x2C2D53C", Slot = "18")]
    protected override void InitializeImpl()
    {
    }

    [Token(Token = "0x6001BD1")]
    [Address(RVA = "0x2C2EF94", Offset = "0x2C2EF94", VA = "0x2C2EF94", Slot = "19")]
    protected override void UpdateUnitImpl()
    {
    }

    [Token(Token = "0x6001BD2")]
    [Address(RVA = "0x2C2F530", Offset = "0x2C2F530", VA = "0x2C2F530", Slot = "20")]
    protected override void DeckUnitUpdateImpl()
    {
    }

    [Token(Token = "0x6001BD3")]
    [Address(RVA = "0x2C2F574", Offset = "0x2C2F574", VA = "0x2C2F574", Slot = "21")]
    public override void UpdateCheckEquipmentParam(ItemInfoBase itemInfo)
    {
    }

    [Token(Token = "0x6001BD4")]
    [Address(RVA = "0x2C2FE84", Offset = "0x2C2FE84", VA = "0x2C2FE84", Slot = "4")]
    public override void Show()
    {
    }

    [Token(Token = "0x6001BD5")]
    [Address(RVA = "0x2C2FEA8", Offset = "0x2C2FEA8", VA = "0x2C2FEA8", Slot = "5")]
    public override void Hide()
    {
    }

    [Token(Token = "0x6001BD6")]
    [Address(RVA = "0x2C2FECC", Offset = "0x2C2FECC", VA = "0x2C2FECC")]
    public void OnNextUnit()
    {
    }

    [Token(Token = "0x6001BD7")]
    [Address(RVA = "0x2C2FEE8", Offset = "0x2C2FEE8", VA = "0x2C2FEE8")]
    public void OnPrevUnit()
    {
    }

    [Token(Token = "0x6001BD8")]
    [Address(RVA = "0x2C2FF04", Offset = "0x2C2FF04", VA = "0x2C2FF04")]
    public void ChangeSubState(
      UnitCustomizeStateHandler.SubStateIndices subStateIndex)
    {
    }

    [Token(Token = "0x6001BD9")]
    [Address(RVA = "0x2C2DEC4", Offset = "0x2C2DEC4", VA = "0x2C2DEC4")]
    private void SetupStateMachine()
    {
    }

    [Token(Token = "0x6001BDA")]
    [Address(RVA = "0x2C30050", Offset = "0x2C30050", VA = "0x2C30050", Slot = "6")]
    public override void OnFlick(CommonGesturePanel.Direction direction, Vector2 speed)
    {
    }

    [Token(Token = "0x6001BDB")]
    [Address(RVA = "0x2C3016C", Offset = "0x2C3016C", VA = "0x2C3016C")]
    public void PlayTabAnimation(
      UnitCustomizeStateHandler.SubStateIndices current,
      UnitCustomizeStateHandler.SubStateIndices next)
    {
    }

    [Token(Token = "0x6001BDC")]
    [Address(RVA = "0x2C2C32C", Offset = "0x2C2C32C", VA = "0x2C2C32C")]
    public void PlayChangeUnitAnimation(UnitCustomizeStateHandler.Direction direction)
    {
    }

    [Token(Token = "0x6001BDD")]
    [Address(RVA = "0x2C303F0", Offset = "0x2C303F0", VA = "0x2C303F0")]
    private void ShowParameterDetailView()
    {
    }

    [Token(Token = "0x6001BDE")]
    [Address(RVA = "0x2C3058C", Offset = "0x2C3058C", VA = "0x2C3058C")]
    private void HideParameterDetailView()
    {
    }

    [Token(Token = "0x6001BDF")]
    [Address(RVA = "0x2C30660", Offset = "0x2C30660", VA = "0x2C30660")]
    private void ShowFeatureDetailView()
    {
    }

    [Token(Token = "0x6001BE0")]
    [Address(RVA = "0x2C30698", Offset = "0x2C30698", VA = "0x2C30698")]
    private void HideFeatureDetailView()
    {
    }

    [Token(Token = "0x6001BE1")]
    [Address(RVA = "0x2C306BC", Offset = "0x2C306BC", VA = "0x2C306BC")]
    private void ShowPopup(UnitCustomizeStateHandler.PopupIndices popupIndex)
    {
    }

    [Token(Token = "0x6001BE2")]
    [Address(RVA = "0x2C30710", Offset = "0x2C30710", VA = "0x2C30710")]
    private void HidePopup()
    {
    }

    [Token(Token = "0x6001BE3")]
    [Address(RVA = "0x2C3015C", Offset = "0x2C3015C", VA = "0x2C3015C")]
    private bool IsValidFlick() => new bool();

    [Token(Token = "0x6001BE4")]
    [Address(RVA = "0x2C3074C", Offset = "0x2C3074C", VA = "0x2C3074C")]
    public void ShowInventory()
    {
    }

    [Token(Token = "0x6001BE5")]
    [Address(RVA = "0x2C312D0", Offset = "0x2C312D0", VA = "0x2C312D0")]
    public void HideInventory()
    {
    }

    [Token(Token = "0x6001BE6")]
    [Address(RVA = "0x2C31340", Offset = "0x2C31340", VA = "0x2C31340")]
    private void Update()
    {
    }

    [Token(Token = "0x6001BE7")]
    [Address(RVA = "0x2C3148C", Offset = "0x2C3148C", VA = "0x2C3148C")]
    public void OnDetailEquipment(ItemInfoBase itemInfo)
    {
    }

    [Token(Token = "0x6001BE8")]
    [Address(RVA = "0x2C31490", Offset = "0x2C31490", VA = "0x2C31490")]
    public void OnSelectEquipment(ItemInfoBase itemInfo)
    {
    }

    [Token(Token = "0x6001BE9")]
    [Address(RVA = "0x2C314FC", Offset = "0x2C314FC", VA = "0x2C314FC")]
    public void OnConfrimEquipment(ItemInfoBase itemInfo)
    {
    }

    [Token(Token = "0x6001BEA")]
    [Address(RVA = "0x2C31568", Offset = "0x2C31568", VA = "0x2C31568")]
    public void OnLockEquipment(
      OrganizationEquipmentSlot.EquipmentSlotType equipmentSlotType)
    {
    }

    [Token(Token = "0x6001BEB")]
    [Address(RVA = "0x2C31584", Offset = "0x2C31584", VA = "0x2C31584")]
    public void OnClickParameterDetailButton()
    {
    }

    [Token(Token = "0x6001BEC")]
    [Address(RVA = "0x2C3158C", Offset = "0x2C3158C", VA = "0x2C3158C")]
    public void OnClickCloseParameterDetailButton()
    {
    }

    [Token(Token = "0x6001BED")]
    [Address(RVA = "0x2C31590", Offset = "0x2C31590", VA = "0x2C31590")]
    public void OnClickFeatureDetailButton()
    {
    }

    [Token(Token = "0x6001BEE")]
    [Address(RVA = "0x2C31598", Offset = "0x2C31598", VA = "0x2C31598")]
    public void OnClickCloseFeatureDetailButton()
    {
    }

    [Token(Token = "0x6001BEF")]
    [Address(RVA = "0x2C3159C", Offset = "0x2C3159C", VA = "0x2C3159C")]
    public void OnClickViewerButton()
    {
    }

    [Token(Token = "0x6001BF0")]
    [Address(RVA = "0x2C315B8", Offset = "0x2C315B8", VA = "0x2C315B8")]
    public void OnClickSwitchFavorite()
    {
    }

    [Token(Token = "0x6001BF1")]
    [Address(RVA = "0x2C315D4", Offset = "0x2C315D4", VA = "0x2C315D4")]
    public void OnClickInfomationButton()
    {
    }

    [Token(Token = "0x6001BF2")]
    [Address(RVA = "0x2C315D8", Offset = "0x2C315D8", VA = "0x2C315D8")]
    public void OnClickAwakeButton()
    {
    }

    [Token(Token = "0x6001BF3")]
    [Address(RVA = "0x2C315DC", Offset = "0x2C315DC", VA = "0x2C315DC")]
    public void OnClickLimitBreakButton()
    {
    }

    [Token(Token = "0x6001BF4")]
    [Address(RVA = "0x2C315E0", Offset = "0x2C315E0", VA = "0x2C315E0")]
    public void OnClickAbilityBoardButton()
    {
    }

    [Token(Token = "0x6001BF5")]
    [Address(RVA = "0x2C315FC", Offset = "0x2C315FC", VA = "0x2C315FC")]
    public void OnClickToReincarnationButton()
    {
    }

    [Token(Token = "0x6001BF6")]
    [Address(RVA = "0x2C31618", Offset = "0x2C31618", VA = "0x2C31618")]
    public void OnClickToAiButton()
    {
    }

    [Token(Token = "0x6001BF7")]
    [Address(RVA = "0x2C31634", Offset = "0x2C31634", VA = "0x2C31634", Slot = "22")]
    public override void OnBack()
    {
    }

    [Token(Token = "0x6001BF8")]
    [Address(RVA = "0x2C31694", Offset = "0x2C31694", VA = "0x2C31694")]
    public UnitCustomizeStateHandler()
    {
    }

    [Token(Token = "0x20004E6")]
    public enum SubStateIndices
    {
      [Token(Token = "0x400199A")] Status,
      [Token(Token = "0x400199B")] EquipmentTop,
      [Token(Token = "0x400199C")] EquipmnetInventory,
      [Token(Token = "0x400199D")] Skill,
    }

    [Token(Token = "0x20004E7")]
    public enum PopupIndices
    {
      [Token(Token = "0x400199F")] None,
      [Token(Token = "0x40019A0")] ParameterDetail,
      [Token(Token = "0x40019A1")] FeatureDetail,
    }

    [Token(Token = "0x20004E8")]
    public enum Direction
    {
      [Token(Token = "0x40019A3")] Left,
      [Token(Token = "0x40019A4")] Right,
    }

    [Token(Token = "0x20004E9")]
    public class UnitCustomizeSubStateMachine : 
      UnitDetailSubStateMachine<UnitCustomizeStateHandler, CustomizeSubState>
    {
      [Token(Token = "0x6001BFA")]
      [Address(RVA = "0x2C2FFE8", Offset = "0x2C2FFE8", VA = "0x2C2FFE8")]
      public UnitCustomizeSubStateMachine(UnitCustomizeStateHandler handler)
      {
      }
    }
  }
}
