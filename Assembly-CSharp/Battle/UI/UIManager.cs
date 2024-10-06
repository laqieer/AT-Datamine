// Decompiled with JetBrains decompiler
// Type: Battle.UI.UIManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data;
using Battle.Data.Board;
using Battle.UI.Rewind;
using GameCore;
using Il2CppDummyDll;
using Scenes.OutGame.Info.Skill;
using Scenes.OutGame.StyleLevelUp;
using StaqData.StatusIcon;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

#nullable disable
namespace Battle.UI
{
  [Token(Token = "0x2002366")]
  public class UIManager : MonoBehaviour, IDisposable
  {
    [Token(Token = "0x400966B")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Canvas mainCanvas;
    [Token(Token = "0x400966C")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private RectTransform mainCanvasTransform;
    [Token(Token = "0x400966D")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private Canvas frontCanvas;
    [Token(Token = "0x400966E")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private RectTransform frontCanvasTransform;
    [Token(Token = "0x400966F")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private UnitCommandPanel unitCommand;
    [Token(Token = "0x4009670")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private PlayerCommandPanel playerCommand;
    [Token(Token = "0x4009671")]
    [FieldOffset(Offset = "0x48")]
    private InitialPlacement initialPlacement;
    [Token(Token = "0x4009672")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private PlayConfigControl playConfigControl;
    [Token(Token = "0x4009673")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private GridInformation gridInformation;
    [Token(Token = "0x4009674")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    private ItemDroppedInformation itemDroppedInformation;
    [Token(Token = "0x4009675")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    private FieldPredictionPanel fieldPrediction;
    [Token(Token = "0x4009676")]
    [FieldOffset(Offset = "0x70")]
    [SerializeField]
    private DoubleExeConfirmPanel doubleExeConfirmPanel;
    [Token(Token = "0x4009677")]
    [FieldOffset(Offset = "0x78")]
    [SerializeField]
    private ItemList itemList;
    [Token(Token = "0x4009678")]
    [FieldOffset(Offset = "0x80")]
    [SerializeField]
    private CameraConfigPanel cameraConfigPanel;
    [Token(Token = "0x4009679")]
    [FieldOffset(Offset = "0x88")]
    [SerializeField]
    private FieldUnitListController fieldUnitListController;
    [Token(Token = "0x400967A")]
    [FieldOffset(Offset = "0x90")]
    [SerializeField]
    private FieldUnitSimpleStatus fieldUnitSimpleStatusPanel;
    [Token(Token = "0x400967B")]
    [FieldOffset(Offset = "0x98")]
    [SerializeField]
    private FieldAutoTurretSimpleStatus fieldAutoTurretSimpleStatusPanel;
    [Token(Token = "0x400967C")]
    [FieldOffset(Offset = "0xA0")]
    [SerializeField]
    private MissionPanel missionPanel;
    [Token(Token = "0x400967D")]
    [FieldOffset(Offset = "0xA8")]
    [SerializeField]
    private Button menuButton;
    [Token(Token = "0x400967E")]
    [FieldOffset(Offset = "0xB0")]
    private BattleRewindManager battleRewind;
    [Token(Token = "0x400967F")]
    [FieldOffset(Offset = "0xB8")]
    [SerializeField]
    private GameObject frontCanvasSafeArea;
    [Token(Token = "0x4009680")]
    [FieldOffset(Offset = "0xC0")]
    [SerializeField]
    private BattleRetreatLostUI battleRetreatLostUI;
    [Token(Token = "0x4009681")]
    [FieldOffset(Offset = "0xC8")]
    private Dictionary<int, Sprite> unitThumbnailSprites;
    [Token(Token = "0x4009682")]
    [FieldOffset(Offset = "0xD0")]
    private IconFactory iconFactory;
    [Token(Token = "0x4009683")]
    [FieldOffset(Offset = "0xD8")]
    private WorldSpaceCanvasManager worldSpaceCanvasManager;
    [Token(Token = "0x4009684")]
    [FieldOffset(Offset = "0xE0")]
    [SerializeField]
    private BattleGetExp battleGetExp;
    [Token(Token = "0x4009686")]
    [FieldOffset(Offset = "0xF0")]
    [SerializeField]
    private FieldOptionTopPanel fieldOptionTopPanel;
    [Token(Token = "0x4009687")]
    [FieldOffset(Offset = "0xF8")]
    public OperationTextUI operationTextUI;
    [Token(Token = "0x4009688")]
    [FieldOffset(Offset = "0x100")]
    public StyleLevelUpEffect levelUpUI;
    [Token(Token = "0x4009689")]
    [FieldOffset(Offset = "0x108")]
    private UnitListPanel fieldOptionUnitListPanel;
    [Token(Token = "0x400968A")]
    [FieldOffset(Offset = "0x110")]
    [SerializeField]
    private Transform uiObjectParent;
    [Token(Token = "0x400968B")]
    [FieldOffset(Offset = "0x118")]
    public UnityAction<bool> FieldTouchEnabled;
    [Token(Token = "0x400968D")]
    [FieldOffset(Offset = "0x121")]
    private bool isTutorial;
    [Token(Token = "0x400968E")]
    [FieldOffset(Offset = "0x128")]
    public GameObject TutorialArrow;
    [Token(Token = "0x400968F")]
    [FieldOffset(Offset = "0x130")]
    private AssetCachedSpawner _spawner;
    [Token(Token = "0x4009690")]
    [FieldOffset(Offset = "0x138")]
    private bool isInitialized;
    [Token(Token = "0x4009691")]
    [FieldOffset(Offset = "0x139")]
    [HideInInspector]
    public bool isBattleMenu;
    [Token(Token = "0x4009692")]
    [FieldOffset(Offset = "0x13A")]
    private bool disposed;

    [Token(Token = "0x17002E6F")]
    public RectTransform MainCanvasTransform
    {
      [Token(Token = "0x600D819"), Address(RVA = "0x1B8FF0C", Offset = "0x1B8FF0C", VA = "0x1B8FF0C")] get
      {
        return (RectTransform) null;
      }
    }

    [Token(Token = "0x17002E70")]
    public RectTransform FrontCanvasTransform
    {
      [Token(Token = "0x600D81A"), Address(RVA = "0x1B8FF14", Offset = "0x1B8FF14", VA = "0x1B8FF14")] get
      {
        return (RectTransform) null;
      }
    }

    [Token(Token = "0x17002E71")]
    public UnitCommandPanel UnitCommand
    {
      [Token(Token = "0x600D81B"), Address(RVA = "0x1B8FF1C", Offset = "0x1B8FF1C", VA = "0x1B8FF1C")] get
      {
        return (UnitCommandPanel) null;
      }
    }

    [Token(Token = "0x17002E72")]
    public PlayerCommandPanel PlayerCommand
    {
      [Token(Token = "0x600D81C"), Address(RVA = "0x1B8FF24", Offset = "0x1B8FF24", VA = "0x1B8FF24")] get
      {
        return (PlayerCommandPanel) null;
      }
    }

    [Token(Token = "0x17002E73")]
    public InitialPlacement InitialPlacement
    {
      [Token(Token = "0x600D81D"), Address(RVA = "0x1B8FF2C", Offset = "0x1B8FF2C", VA = "0x1B8FF2C")] get
      {
        return (InitialPlacement) null;
      }
    }

    [Token(Token = "0x17002E74")]
    public PlayConfigControl PlayConfigControl
    {
      [Token(Token = "0x600D81E"), Address(RVA = "0x1B8FFEC", Offset = "0x1B8FFEC", VA = "0x1B8FFEC")] get
      {
        return (PlayConfigControl) null;
      }
    }

    [Token(Token = "0x17002E75")]
    public GridInformation GridInformation
    {
      [Token(Token = "0x600D81F"), Address(RVA = "0x1B8FFF4", Offset = "0x1B8FFF4", VA = "0x1B8FFF4")] get
      {
        return (GridInformation) null;
      }
    }

    [Token(Token = "0x17002E76")]
    public ItemDroppedInformation ItemDroppedInformation
    {
      [Token(Token = "0x600D820"), Address(RVA = "0x1B8FFFC", Offset = "0x1B8FFFC", VA = "0x1B8FFFC")] get
      {
        return (ItemDroppedInformation) null;
      }
    }

    [Token(Token = "0x17002E77")]
    public FieldPredictionPanel FieldPrediction
    {
      [Token(Token = "0x600D821"), Address(RVA = "0x1B90004", Offset = "0x1B90004", VA = "0x1B90004")] get
      {
        return (FieldPredictionPanel) null;
      }
    }

    [Token(Token = "0x17002E78")]
    public DoubleExeConfirmPanel DoubleExeConfirmPanel
    {
      [Token(Token = "0x600D822"), Address(RVA = "0x1B9000C", Offset = "0x1B9000C", VA = "0x1B9000C")] get
      {
        return (DoubleExeConfirmPanel) null;
      }
    }

    [Token(Token = "0x17002E79")]
    public ItemList ItemList
    {
      [Token(Token = "0x600D823"), Address(RVA = "0x1B90014", Offset = "0x1B90014", VA = "0x1B90014")] get
      {
        return (ItemList) null;
      }
    }

    [Token(Token = "0x17002E7A")]
    public CameraConfigPanel CameraConfigPanel
    {
      [Token(Token = "0x600D824"), Address(RVA = "0x1B9001C", Offset = "0x1B9001C", VA = "0x1B9001C")] get
      {
        return (CameraConfigPanel) null;
      }
    }

    [Token(Token = "0x17002E7B")]
    public FieldUnitListManager FieldUnitListManager
    {
      [Token(Token = "0x600D825"), Address(RVA = "0x1B90024", Offset = "0x1B90024", VA = "0x1B90024")] get
      {
        return (FieldUnitListManager) null;
      }
    }

    [Token(Token = "0x17002E7C")]
    public FieldUnitSimpleStatus FieldUnitSimpleStatusPanel
    {
      [Token(Token = "0x600D826"), Address(RVA = "0x1B90040", Offset = "0x1B90040", VA = "0x1B90040")] get
      {
        return (FieldUnitSimpleStatus) null;
      }
    }

    [Token(Token = "0x17002E7D")]
    public FieldAutoTurretSimpleStatus FieldAutoTurretSimpleStatusPanel
    {
      [Token(Token = "0x600D827"), Address(RVA = "0x1B90048", Offset = "0x1B90048", VA = "0x1B90048")] get
      {
        return (FieldAutoTurretSimpleStatus) null;
      }
    }

    [Token(Token = "0x17002E7E")]
    public MissionPanel MissionPanel
    {
      [Token(Token = "0x600D828"), Address(RVA = "0x1B90050", Offset = "0x1B90050", VA = "0x1B90050")] get
      {
        return (MissionPanel) null;
      }
    }

    [Token(Token = "0x17002E7F")]
    public Button.ButtonClickedEvent OnClickMenu
    {
      [Token(Token = "0x600D829"), Address(RVA = "0x1B90058", Offset = "0x1B90058", VA = "0x1B90058")] get
      {
        return (Button.ButtonClickedEvent) null;
      }
    }

    [Token(Token = "0x17002E80")]
    public BattleRewindManager BattleRewind
    {
      [Token(Token = "0x600D82A"), Address(RVA = "0x1B90074", Offset = "0x1B90074", VA = "0x1B90074")] get
      {
        return (BattleRewindManager) null;
      }
    }

    [Token(Token = "0x17002E81")]
    public GameObject FrontCanvasSafeArea
    {
      [Token(Token = "0x600D82B"), Address(RVA = "0x1B90194", Offset = "0x1B90194", VA = "0x1B90194")] get
      {
        return (GameObject) null;
      }
    }

    [Token(Token = "0x17002E82")]
    public BattleRetreatLostUI BattleRetreatLostUI
    {
      [Token(Token = "0x600D82C"), Address(RVA = "0x1B9019C", Offset = "0x1B9019C", VA = "0x1B9019C")] get
      {
        return (BattleRetreatLostUI) null;
      }
    }

    [Token(Token = "0x17002E83")]
    public Dictionary<int, Sprite> UnitThumbnailSprites
    {
      [Token(Token = "0x600D82D"), Address(RVA = "0x1B901A4", Offset = "0x1B901A4", VA = "0x1B901A4")] get
      {
        return (Dictionary<int, Sprite>) null;
      }
      [Token(Token = "0x600D82E"), Address(RVA = "0x1B901AC", Offset = "0x1B901AC", VA = "0x1B901AC")] set
      {
      }
    }

    [Token(Token = "0x17002E84")]
    public IconFactory IconFactory
    {
      [Token(Token = "0x600D82F"), Address(RVA = "0x1B901C0", Offset = "0x1B901C0", VA = "0x1B901C0")] get
      {
        return (IconFactory) null;
      }
    }

    [Token(Token = "0x17002E85")]
    public WorldSpaceCanvasManager WorldSpaceCanvasManager
    {
      [Token(Token = "0x600D830"), Address(RVA = "0x1B901C8", Offset = "0x1B901C8", VA = "0x1B901C8")] get
      {
        return (WorldSpaceCanvasManager) null;
      }
      [Token(Token = "0x600D831"), Address(RVA = "0x1B901D0", Offset = "0x1B901D0", VA = "0x1B901D0")] set
      {
      }
    }

    [Token(Token = "0x17002E86")]
    public BattleGetExp BattleGetExp
    {
      [Token(Token = "0x600D832"), Address(RVA = "0x1B90248", Offset = "0x1B90248", VA = "0x1B90248")] get
      {
        return (BattleGetExp) null;
      }
    }

    [Token(Token = "0x17002E87")]
    public BattleLogView battleLogView
    {
      [Token(Token = "0x600D833"), Address(RVA = "0x1B90250", Offset = "0x1B90250", VA = "0x1B90250")] get
      {
        return (BattleLogView) null;
      }
      [Token(Token = "0x600D834"), Address(RVA = "0x1B90258", Offset = "0x1B90258", VA = "0x1B90258")] set
      {
      }
    }

    [Token(Token = "0x17002E88")]
    public FieldOptionTopPanel FieldOptionTopPanel
    {
      [Token(Token = "0x600D835"), Address(RVA = "0x1B90260", Offset = "0x1B90260", VA = "0x1B90260")] get
      {
        return (FieldOptionTopPanel) null;
      }
    }

    [Token(Token = "0x17002E89")]
    public UnitListPanel FieldOptionUnitListPanel
    {
      [Token(Token = "0x600D836"), Address(RVA = "0x1B90268", Offset = "0x1B90268", VA = "0x1B90268")] get
      {
        return (UnitListPanel) null;
      }
    }

    [Token(Token = "0x17002E8A")]
    public bool IsArena
    {
      [Token(Token = "0x600D837"), Address(RVA = "0x1B90418", Offset = "0x1B90418", VA = "0x1B90418")] get
      {
        return new bool();
      }
      [Token(Token = "0x600D838"), Address(RVA = "0x1B90420", Offset = "0x1B90420", VA = "0x1B90420")] private set
      {
      }
    }

    [Token(Token = "0x17002E8B")]
    public AssetCachedSpawner Spawner
    {
      [Token(Token = "0x600D839"), Address(RVA = "0x1B9042C", Offset = "0x1B9042C", VA = "0x1B9042C")] get
      {
        return (AssetCachedSpawner) null;
      }
    }

    [Token(Token = "0x600D83A")]
    [Address(RVA = "0x1B904C0", Offset = "0x1B904C0", VA = "0x1B904C0")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x600D83B")]
    [Address(RVA = "0x1B904C4", Offset = "0x1B904C4", VA = "0x1B904C4", Slot = "4")]
    public void Dispose()
    {
    }

    [Token(Token = "0x600D83C")]
    [Address(RVA = "0x1B90590", Offset = "0x1B90590", VA = "0x1B90590")]
    public void Initialize(
      ISystemFlags systemFlags,
      BattleConfigAsset battleConfig,
      BoardData board)
    {
    }

    [Token(Token = "0x600D83D")]
    [Address(RVA = "0x1B90854", Offset = "0x1B90854", VA = "0x1B90854")]
    private IEnumerator CreateTutorialArrow() => (IEnumerator) null;

    [Token(Token = "0x600D83E")]
    [Address(RVA = "0x1B90918", Offset = "0x1B90918", VA = "0x1B90918")]
    public void ShowMenuButton()
    {
    }

    [Token(Token = "0x600D83F")]
    [Address(RVA = "0x1B908C4", Offset = "0x1B908C4", VA = "0x1B908C4")]
    public void HideMenuButton()
    {
    }

    [Token(Token = "0x600D840")]
    [Address(RVA = "0x1B90954", Offset = "0x1B90954", VA = "0x1B90954")]
    public void ShowUI3DRoot()
    {
    }

    [Token(Token = "0x600D841")]
    [Address(RVA = "0x1B909D8", Offset = "0x1B909D8", VA = "0x1B909D8")]
    public void HideUI3DRoot()
    {
    }

    [Token(Token = "0x600D842")]
    [Address(RVA = "0x1B90A5C", Offset = "0x1B90A5C", VA = "0x1B90A5C")]
    public void ShowCanvas(UIManager.CanvasType type)
    {
    }

    [Token(Token = "0x600D843")]
    [Address(RVA = "0x1B90A9C", Offset = "0x1B90A9C", VA = "0x1B90A9C")]
    public void StatusPanelShow(UIManager.SimpleStatusPanelType simpleStatusPanel)
    {
    }

    [Token(Token = "0x600D844")]
    [Address(RVA = "0x1B90B0C", Offset = "0x1B90B0C", VA = "0x1B90B0C")]
    public void StatusPanelsHide()
    {
    }

    [Token(Token = "0x600D845")]
    [Address(RVA = "0x1B90B40", Offset = "0x1B90B40", VA = "0x1B90B40")]
    public void HideCanvas(UIManager.CanvasType type)
    {
    }

    [Token(Token = "0x600D846")]
    [Address(RVA = "0x1B9034C", Offset = "0x1B9034C", VA = "0x1B9034C")]
    private void InitializeFieldOptionUnitListPanel(UnitListPanel panel)
    {
    }

    [Token(Token = "0x600D847")]
    [Address(RVA = "0x1B90B88", Offset = "0x1B90B88", VA = "0x1B90B88")]
    public void ShowUI()
    {
    }

    [Token(Token = "0x600D848")]
    [Address(RVA = "0x1B90BB0", Offset = "0x1B90BB0", VA = "0x1B90BB0")]
    public void ShowUnit(
      BoardData board,
      UnitParameterData unit,
      BattlePlayerData owner,
      bool isNeedLp,
      int barrierIndex)
    {
    }

    [Token(Token = "0x600D849")]
    [Address(RVA = "0x1B91170", Offset = "0x1B91170", VA = "0x1B91170")]
    public BattlePopupPanel ShowStyle(StyleModel style) => (BattlePopupPanel) null;

    [Token(Token = "0x600D84A")]
    [Address(RVA = "0x1B911CC", Offset = "0x1B911CC", VA = "0x1B911CC")]
    private StylePanel ShowStyle(out StyleModel model) => (StylePanel) null;

    [Token(Token = "0x600D84B")]
    [Address(RVA = "0x1B91570", Offset = "0x1B91570", VA = "0x1B91570")]
    public EquipmentPanel ShowWeapon(WeaponModel weapon) => (EquipmentPanel) null;

    [Token(Token = "0x600D84C")]
    [Address(RVA = "0x1B915CC", Offset = "0x1B915CC", VA = "0x1B915CC")]
    private EquipmentPanel ShowWeaponInfo(out WeaponModel model) => (EquipmentPanel) null;

    [Token(Token = "0x600D84D")]
    [Address(RVA = "0x1B91C1C", Offset = "0x1B91C1C", VA = "0x1B91C1C")]
    public EquipmentPanel ShowAccessory(AccessoryModel acc) => (EquipmentPanel) null;

    [Token(Token = "0x600D84E")]
    [Address(RVA = "0x1B91C74", Offset = "0x1B91C74", VA = "0x1B91C74")]
    private EquipmentPanel ShowAccessory(out AccessoryModel model) => (EquipmentPanel) null;

    [Token(Token = "0x600D84F")]
    [Address(RVA = "0x1B92520", Offset = "0x1B92520", VA = "0x1B92520")]
    public EquipmentPanel ShowUnitTrust(TrustModel trust) => (EquipmentPanel) null;

    [Token(Token = "0x600D850")]
    [Address(RVA = "0x1B9257C", Offset = "0x1B9257C", VA = "0x1B9257C")]
    private EquipmentPanel ShowUnitTrust(out TrustModel model) => (EquipmentPanel) null;

    [Token(Token = "0x600D851")]
    [Address(RVA = "0x1B92A50", Offset = "0x1B92A50", VA = "0x1B92A50")]
    public EquipmentPanel ShowMindEquipment(MindEquipmentModel mindEquipment)
    {
      return (EquipmentPanel) null;
    }

    [Token(Token = "0x600D852")]
    [Address(RVA = "0x1B92AAC", Offset = "0x1B92AAC", VA = "0x1B92AAC")]
    private EquipmentPanel ShowMindEquipment(out MindEquipmentModel model) => (EquipmentPanel) null;

    [Token(Token = "0x600D853")]
    [Address(RVA = "0x1B93064", Offset = "0x1B93064", VA = "0x1B93064")]
    public void ShowSkillDetail(SkillModelBase skill)
    {
    }

    [Token(Token = "0x600D854")]
    [Address(RVA = "0x1B93220", Offset = "0x1B93220", VA = "0x1B93220")]
    private void ShowSkillDetail(SkillModel skill)
    {
    }

    [Token(Token = "0x600D855")]
    [Address(RVA = "0x1B930B8", Offset = "0x1B930B8", VA = "0x1B930B8")]
    private SkillDetailPanel ShowSkillDetail(out SkillModel model) => (SkillDetailPanel) null;

    [Token(Token = "0x600D856")]
    [Address(RVA = "0x1B9340C", Offset = "0x1B9340C", VA = "0x1B9340C")]
    private void ShowBattleConditionDetail(StatusConditionModel[] models)
    {
    }

    [Token(Token = "0x600D857")]
    [Address(RVA = "0x1B93A50", Offset = "0x1B93A50", VA = "0x1B93A50")]
    public void HideUI()
    {
    }

    [Token(Token = "0x600D858")]
    [Address(RVA = "0x1B908BC", Offset = "0x1B908BC", VA = "0x1B908BC")]
    public Coroutine StartCoroutines(IEnumerator e, Action completeAction = null)
    {
      return (Coroutine) null;
    }

    [Token(Token = "0x600D859")]
    private bool InstantiateUIComponent<T>(
      string assetBundleLabel,
      string assetName,
      RectTransform canvasTransform,
      ref T component)
      where T : class
    {
      return new bool();
    }

    [Token(Token = "0x600D85A")]
    [Address(RVA = "0x1B93A78", Offset = "0x1B93A78", VA = "0x1B93A78")]
    public UIManager()
    {
    }

    [Token(Token = "0x2002367")]
    public enum CanvasType
    {
      [Token(Token = "0x4009694")] Main,
      [Token(Token = "0x4009695")] Front,
    }

    [Token(Token = "0x2002368")]
    public enum SimpleStatusPanelType
    {
      [Token(Token = "0x4009697")] Unit,
      [Token(Token = "0x4009698")] AutoTurret,
    }
  }
}
