// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.UnitDetailSubScene
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.Scene;
using GameCore.Tween;
using GameCore.Utility;
using Il2CppDummyDll;
using Network.API;
using Network.Param;
using Scenes.OutGame.UnitDetail;
using Scenes.OutGame.UnitDetail.AI;
using Scenes.OutGame.UnitDetail.LimitBreak;
using Scenes.OutGame.UnitDetail.Reincarnation;
using StaqData;
using System;
using System.Collections;
using System.Collections.Generic;
using TeamOrganization;
using UnitDetail;
using UnitDetail.Customize;
using UnitDetail.State;
using UnitDetail.Viewer;
using UnityEngine;

#nullable disable
namespace Scenes.OutGame
{
  [Token(Token = "0x200326B")]
  public class UnitDetailSubScene : SubScene
  {
    [Token(Token = "0x400D7BA")]
    [FieldOffset(Offset = "0x0")]
    private static readonly string[] SoundBanks;
    [Token(Token = "0x400D7BB")]
    public const string UnitDetailAssetBundleName = "2dassets_ui_unitdetail";
    [Token(Token = "0x400D7BC")]
    private const string StyleLevelupPopupAssetName = "Com_Popup_StyleStrengthen";
    [Token(Token = "0x400D7BD")]
    private const string LimitBreakPopupAssetName = "Container_UnitLimitOut";
    [Token(Token = "0x400D7BE")]
    private const string ReincarnationPopupAssetName = "Com_Popup_Reincarnation";
    [Token(Token = "0x400D7BF")]
    private const string ReincarnationMemoryPopupAssetName = "Com_Popup_ReincarnationMemory";
    [Token(Token = "0x400D7C0")]
    private const string AiPopupAssetName = "Com_Popup_AiEdit";
    [Token(Token = "0x400D7C1")]
    private const string ShowAnimName = "In_InfoAll";
    [Token(Token = "0x400D7C2")]
    private const string HideAnimName = "Out_InfoAll";
    [Token(Token = "0x400D7C3")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private CommonGesturePanel commonGesturePanel;
    [Token(Token = "0x400D7C4")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    private UITweenGroup tweenGroup;
    [Token(Token = "0x400D7C5")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    private SimpleProfile simpleProfile;
    [Token(Token = "0x400D7C6")]
    [FieldOffset(Offset = "0x70")]
    [SerializeField]
    private UnitCustomizeStateHandler unitCustomizeHandler;
    [Token(Token = "0x400D7C7")]
    [FieldOffset(Offset = "0x78")]
    [SerializeField]
    private UnitViewerStateHandler unitViewerHandler;
    [Token(Token = "0x400D7C8")]
    [FieldOffset(Offset = "0x80")]
    [SerializeField]
    private UnitViewerController unitViewerController;
    [Token(Token = "0x400D7C9")]
    [FieldOffset(Offset = "0x88")]
    [SerializeField]
    private RectTransform alertParent;
    [Token(Token = "0x400D7CA")]
    [FieldOffset(Offset = "0x90")]
    private CycleList<UnitDetailInfo> unitDetailCycleList;
    [Token(Token = "0x400D7CB")]
    [FieldOffset(Offset = "0x98")]
    private List<UnitDetailStateHandlerBase> stateHandlers;
    [Token(Token = "0x400D7CC")]
    [FieldOffset(Offset = "0xA0")]
    private UnitDetailStateMachine stateMachine;
    [Token(Token = "0x400D7CD")]
    [FieldOffset(Offset = "0xA8")]
    private List<UnitDetailState> stateList;
    [Token(Token = "0x400D7CE")]
    [FieldOffset(Offset = "0xB0")]
    private int firstViewStyleID;
    [Token(Token = "0x400D7CF")]
    [FieldOffset(Offset = "0xB4")]
    private bool isFirstUnitProfile;
    [Token(Token = "0x400D7D0")]
    [FieldOffset(Offset = "0xB5")]
    private bool IsOpenAbilityBoard;
    [Token(Token = "0x400D7D1")]
    [FieldOffset(Offset = "0xB8")]
    private List<PlayerUnitAbilityBoardCustomALotteryType> AbiliryBoardResumeData;
    [Token(Token = "0x400D7D2")]
    [FieldOffset(Offset = "0xC0")]
    private StyleLevelupPopup styleLevelupPopup;
    [Token(Token = "0x400D7D3")]
    [FieldOffset(Offset = "0xC8")]
    private LimitBreakPopup limitBreakPopup;
    [Token(Token = "0x400D7D4")]
    [FieldOffset(Offset = "0xD0")]
    private ReincarnationPopup reincarnationPopup;
    [Token(Token = "0x400D7D5")]
    [FieldOffset(Offset = "0xD8")]
    private ReincarnationMemoryPopup reincarnationMemoryPopup;
    [Token(Token = "0x400D7D6")]
    [FieldOffset(Offset = "0xE0")]
    private IndividualAIPopup individualAIPopup;
    [Token(Token = "0x400D7D7")]
    [FieldOffset(Offset = "0xE8")]
    private APIUnitFavorite unitFavoriteApi;
    [Token(Token = "0x400D7D8")]
    [FieldOffset(Offset = "0xF0")]
    private bool isConnectingApi;
    [Token(Token = "0x400D7D9")]
    [FieldOffset(Offset = "0xF8")]
    private Action<Style> deckUnitUpdate;

    [Token(Token = "0x1700415D")]
    public UnitDetailInfo ActiveUnit
    {
      [Token(Token = "0x6013A92"), Address(RVA = "0x46232B0", Offset = "0x46232B0", VA = "0x46232B0")] get
      {
        return (UnitDetailInfo) null;
      }
    }

    [Token(Token = "0x1700415E")]
    private bool IsEditor
    {
      [Token(Token = "0x6013A93"), Address(RVA = "0x4623300", Offset = "0x4623300", VA = "0x4623300")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x6013A94")]
    [Address(RVA = "0x4623308", Offset = "0x4623308", VA = "0x4623308", Slot = "7")]
    public override IEnumerator InitializeAsync() => (IEnumerator) null;

    [Token(Token = "0x6013A95")]
    [Address(RVA = "0x4623370", Offset = "0x4623370", VA = "0x4623370")]
    private void LoadComplete(
      List<string> successList,
      Dictionary<string, string> loadErrorAssetBundleDic)
    {
    }

    [Token(Token = "0x6013A96")]
    [Address(RVA = "0x4623E84", Offset = "0x4623E84", VA = "0x4623E84", Slot = "6")]
    public override void Initialize(ChangeSceneParameter param = null)
    {
    }

    [Token(Token = "0x6013A97")]
    [Address(RVA = "0x46242AC", Offset = "0x46242AC", VA = "0x46242AC")]
    private void OnDoublePointerUp(Vector2 position)
    {
    }

    [Token(Token = "0x6013A98")]
    [Address(RVA = "0x46242F4", Offset = "0x46242F4", VA = "0x46242F4")]
    private void OnSingleClick(Vector2 position)
    {
    }

    [Token(Token = "0x6013A99")]
    [Address(RVA = "0x462433C", Offset = "0x462433C", VA = "0x462433C")]
    private void OnDoubleClick(Vector2 position)
    {
    }

    [Token(Token = "0x6013A9A")]
    [Address(RVA = "0x4624384", Offset = "0x4624384", VA = "0x4624384")]
    private void OnPinchStart(Vector2 center)
    {
    }

    [Token(Token = "0x6013A9B")]
    [Address(RVA = "0x46243CC", Offset = "0x46243CC", VA = "0x46243CC")]
    private void OnPinch(float delta)
    {
    }

    [Token(Token = "0x6013A9C")]
    [Address(RVA = "0x462440C", Offset = "0x462440C", VA = "0x462440C")]
    private void OnPinchEnd(Vector2 position)
    {
    }

    [Token(Token = "0x6013A9D")]
    [Address(RVA = "0x4624454", Offset = "0x4624454", VA = "0x4624454")]
    private void OnFlick(CommonGesturePanel.Direction direction, Vector2 speed)
    {
    }

    [Token(Token = "0x6013A9E")]
    [Address(RVA = "0x46244A4", Offset = "0x46244A4", VA = "0x46244A4")]
    private void OnSinglePointerMoveStart(Vector2 position)
    {
    }

    [Token(Token = "0x6013A9F")]
    [Address(RVA = "0x46244EC", Offset = "0x46244EC", VA = "0x46244EC")]
    private void OnSinglePointerMove(Vector2 position, Vector2 delta)
    {
    }

    [Token(Token = "0x6013AA0")]
    [Address(RVA = "0x462454C", Offset = "0x462454C", VA = "0x462454C")]
    private void OnSinglePointerMoveEnd(Vector2 position)
    {
    }

    [Token(Token = "0x6013AA1")]
    [Address(RVA = "0x4624594", Offset = "0x4624594", VA = "0x4624594")]
    private void OnDoublePointerMoveStart(Vector2 center)
    {
    }

    [Token(Token = "0x6013AA2")]
    [Address(RVA = "0x4624598", Offset = "0x4624598", VA = "0x4624598")]
    private void OnDoublePointerMove(Vector2 position, Vector2 delta)
    {
    }

    [Token(Token = "0x6013AA3")]
    [Address(RVA = "0x46245E0", Offset = "0x46245E0", VA = "0x46245E0")]
    private void OnDoublePointerMoveEnd(Vector2 position)
    {
    }

    [Token(Token = "0x6013AA4")]
    [Address(RVA = "0x4624628", Offset = "0x4624628", VA = "0x4624628")]
    public void OnMenu()
    {
    }

    [Token(Token = "0x6013AA5")]
    [Address(RVA = "0x462462C", Offset = "0x462462C", VA = "0x462462C")]
    public void OnBack()
    {
    }

    [Token(Token = "0x6013AA6")]
    [Address(RVA = "0x4624658", Offset = "0x4624658", VA = "0x4624658")]
    public void ChangeState(UnitDetailSubScene.StateIndices stateIndex)
    {
    }

    [Token(Token = "0x6013AA7")]
    [Address(RVA = "0x4623CB8", Offset = "0x4623CB8", VA = "0x4623CB8")]
    public void UpdateUnit()
    {
    }

    [Token(Token = "0x6013AA8")]
    [Address(RVA = "0x46246DC", Offset = "0x46246DC", VA = "0x46246DC")]
    public void BackSubScene()
    {
    }

    [Token(Token = "0x6013AA9")]
    [Address(RVA = "0x462475C", Offset = "0x462475C", VA = "0x462475C")]
    public void OnSwitchOverViewer()
    {
    }

    [Token(Token = "0x6013AAA")]
    [Address(RVA = "0x462478C", Offset = "0x462478C", VA = "0x462478C")]
    public void OnSwitchOverCustomize()
    {
    }

    [Token(Token = "0x6013AAB")]
    [Address(RVA = "0x46247BC", Offset = "0x46247BC", VA = "0x46247BC")]
    public void OnNextUnit()
    {
    }

    [Token(Token = "0x6013AAC")]
    [Address(RVA = "0x462482C", Offset = "0x462482C", VA = "0x462482C")]
    public void OnPrevUnit()
    {
    }

    [Token(Token = "0x6013AAD")]
    [Address(RVA = "0x462489C", Offset = "0x462489C", VA = "0x462489C")]
    public void OnClickBackButton()
    {
    }

    [Token(Token = "0x6013AAE")]
    [Address(RVA = "0x4624950", Offset = "0x4624950", VA = "0x4624950")]
    private bool IsPointerOverGameObject(int index) => new bool();

    [Token(Token = "0x6013AAF")]
    [Address(RVA = "0x46238AC", Offset = "0x46238AC", VA = "0x46238AC")]
    private void SetupStateHandler()
    {
    }

    [Token(Token = "0x6013AB0")]
    [Address(RVA = "0x46239D8", Offset = "0x46239D8", VA = "0x46239D8")]
    private void SetupStateMachine()
    {
    }

    [Token(Token = "0x6013AB1")]
    [Address(RVA = "0x4623E2C", Offset = "0x4623E2C", VA = "0x4623E2C")]
    private void ShowUnitDetail()
    {
    }

    [Token(Token = "0x6013AB2")]
    [Address(RVA = "0x4624AB4", Offset = "0x4624AB4", VA = "0x4624AB4")]
    private void HideUnitDetail()
    {
    }

    [Token(Token = "0x6013AB3")]
    [Address(RVA = "0x4624B0C", Offset = "0x4624B0C", VA = "0x4624B0C")]
    public void DeckUnitUpdate()
    {
    }

    [Token(Token = "0x6013AB4")]
    [Address(RVA = "0x4624C58", Offset = "0x4624C58", VA = "0x4624C58")]
    public void OnClickToStyleLevelup()
    {
    }

    [Token(Token = "0x6013AB5")]
    [Address(RVA = "0x4624F74", Offset = "0x4624F74", VA = "0x4624F74")]
    public void OnClickToLimitBreak()
    {
    }

    [Token(Token = "0x6013AB6")]
    [Address(RVA = "0x46253CC", Offset = "0x46253CC", VA = "0x46253CC")]
    public void OnClickToReincarnation()
    {
    }

    [Token(Token = "0x6013AB7")]
    [Address(RVA = "0x462586C", Offset = "0x462586C", VA = "0x462586C")]
    public void OnClickToReincarnationMemory()
    {
    }

    [Token(Token = "0x6013AB8")]
    [Address(RVA = "0x4625C34", Offset = "0x4625C34", VA = "0x4625C34")]
    private bool UnlockSave() => new bool();

    [Token(Token = "0x6013AB9")]
    [Address(RVA = "0x4625D48", Offset = "0x4625D48", VA = "0x4625D48")]
    public void OnClickToAi()
    {
    }

    [Token(Token = "0x6013ABA")]
    [Address(RVA = "0x4626064", Offset = "0x4626064", VA = "0x4626064")]
    public void OnClickToLockEquipment(
      OrganizationEquipmentSlot.EquipmentSlotType equipmentSlotType)
    {
    }

    [Token(Token = "0x6013ABB")]
    [Address(RVA = "0x46261B8", Offset = "0x46261B8", VA = "0x46261B8")]
    public void OnClickToWeaponProficiency()
    {
    }

    [Token(Token = "0x6013ABC")]
    [Address(RVA = "0x4625CE0", Offset = "0x4625CE0", VA = "0x4625CE0")]
    private IEnumerator WaitPopupClose(Action finishAction) => (IEnumerator) null;

    [Token(Token = "0x6013ABD")]
    [Address(RVA = "0x4626220", Offset = "0x4626220", VA = "0x4626220")]
    public void SwitchFavorite()
    {
    }

    [Token(Token = "0x6013ABE")]
    [Address(RVA = "0x4626258", Offset = "0x4626258", VA = "0x4626258")]
    private IEnumerator CallToUnitFavoriteApi() => (IEnumerator) null;

    [Token(Token = "0x6013ABF")]
    [Address(RVA = "0x46262C0", Offset = "0x46262C0", VA = "0x46262C0")]
    public UnitDetailSubScene()
    {
    }

    [Token(Token = "0x6013AC0")]
    [Address(RVA = "0x46263C8", Offset = "0x46263C8", VA = "0x46263C8")]
    static UnitDetailSubScene()
    {
    }

    [Token(Token = "0x200326C")]
    public class UnitDetailSubSceneParam : ChangeSceneParameter
    {
      [Token(Token = "0x1700415F")]
      public int FirstViewStyleID
      {
        [Token(Token = "0x6013AC8"), Address(RVA = "0x1852558", Offset = "0x1852558", VA = "0x1852558")] get
        {
          return new int();
        }
        [Token(Token = "0x6013AC9"), Address(RVA = "0x1852560", Offset = "0x1852560", VA = "0x1852560")] private set
        {
        }
      }

      [Token(Token = "0x17004160")]
      public bool IsFirstUnitProfile
      {
        [Token(Token = "0x6013ACA"), Address(RVA = "0x1852568", Offset = "0x1852568", VA = "0x1852568")] get
        {
          return new bool();
        }
        [Token(Token = "0x6013ACB"), Address(RVA = "0x1852570", Offset = "0x1852570", VA = "0x1852570")] private set
        {
        }
      }

      [Token(Token = "0x17004161")]
      public Action<Style> DeckUnitUpdateAction
      {
        [Token(Token = "0x6013ACC"), Address(RVA = "0x185257C", Offset = "0x185257C", VA = "0x185257C")] get
        {
          return (Action<Style>) null;
        }
        [Token(Token = "0x6013ACD"), Address(RVA = "0x1852584", Offset = "0x1852584", VA = "0x1852584")] private set
        {
        }
      }

      [Token(Token = "0x6013ACE")]
      [Address(RVA = "0x185258C", Offset = "0x185258C", VA = "0x185258C")]
      public UnitDetailSubSceneParam(
        int firstViewStyleID,
        Action<Style> deckUnitUpdateAction,
        bool isFirstUnitProfile = false,
        bool isOpenAbilityBoard = false)
      {
      }
    }

    [Token(Token = "0x200326D")]
    public enum StateIndices
    {
      [Token(Token = "0x400D7DE")] Customize,
      [Token(Token = "0x400D7DF")] Viewer,
    }
  }
}
