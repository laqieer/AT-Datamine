// Decompiled with JetBrains decompiler
// Type: Battle.MainDirector
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data;
using Battle.Data.Board;
using Battle.Particle;
using Battle.Process;
using Battle.Staging;
using Battle.UI;
using Il2CppDummyDll;
using System.Collections;
using UI.ItemDetail;
using UnityEngine;

#nullable disable
namespace Battle
{
  [Token(Token = "0x2002271")]
  public sealed class MainDirector : 
    MonoBehaviour,
    IDirector,
    IStepUpdate,
    PlayConfigControl.ISystemControlHandler,
    CameraDirector.IOnSwitchCameraSettingHandler,
    CameraConfigPanel.ICameraConfigHandler
  {
    [Token(Token = "0x4009130")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private ScreenDirector screenDirector;
    [Token(Token = "0x4009131")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private MapDirector mapDirector;
    [Token(Token = "0x4009132")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private CameraDirector cameraDirector;
    [Token(Token = "0x4009133")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private AttentionDirector attentionDirector;
    [Token(Token = "0x4009134")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private FieldDamageDirector fieldDmgDirector;
    [Token(Token = "0x4009135")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private StagingDirector stagingSequencer;
    [Token(Token = "0x4009136")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private StagingDirector advSequencer;
    [Token(Token = "0x4009137")]
    [FieldOffset(Offset = "0x50")]
    private BattleVoiceDirector voiceDirector;
    [Token(Token = "0x4009138")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private UIManager uiManager;
    [Token(Token = "0x4009139")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    private ActorDirector actorDirector;
    [Token(Token = "0x400913A")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    private ParticleEmitter particleEmitter;
    [Token(Token = "0x400913B")]
    [FieldOffset(Offset = "0x70")]
    [SerializeField]
    private BattleConfigAsset config;
    [Token(Token = "0x400913E")]
    [FieldOffset(Offset = "0x88")]
    private bool initialized;
    [Token(Token = "0x400913F")]
    [FieldOffset(Offset = "0x90")]
    private BattleCore core;
    [Token(Token = "0x4009141")]
    [FieldOffset(Offset = "0xA0")]
    private GameObject questInfoPrefab;
    [Token(Token = "0x4009142")]
    [FieldOffset(Offset = "0xA8")]
    private GameObject missonInfoPrefab;
    [Token(Token = "0x4009143")]
    [FieldOffset(Offset = "0xB0")]
    private GameObject giveupInfoPrefab;
    [Token(Token = "0x4009144")]
    [FieldOffset(Offset = "0xB8")]
    private GameObject optionInfoPrefab;
    [Token(Token = "0x4009145")]
    [FieldOffset(Offset = "0xC0")]
    private GameObject itemIconPrefab;
    [Token(Token = "0x4009146")]
    [FieldOffset(Offset = "0xC8")]
    private ItemDetailPopupProvider itemDetailPopupGenerator;

    [Token(Token = "0x17002D82")]
    public ScreenDirector Screen
    {
      [Token(Token = "0x600D18F"), Address(RVA = "0x1957F18", Offset = "0x1957F18", VA = "0x1957F18")] get
      {
        return (ScreenDirector) null;
      }
    }

    [Token(Token = "0x17002D83")]
    public MapDirectorBase Map
    {
      [Token(Token = "0x600D190"), Address(RVA = "0x1957F20", Offset = "0x1957F20", VA = "0x1957F20", Slot = "8")] get
      {
        return (MapDirectorBase) null;
      }
    }

    [Token(Token = "0x17002D84")]
    public CameraDirector Camera
    {
      [Token(Token = "0x600D191"), Address(RVA = "0x1957F28", Offset = "0x1957F28", VA = "0x1957F28", Slot = "9")] get
      {
        return (CameraDirector) null;
      }
    }

    [Token(Token = "0x17002D85")]
    public AttentionDirector Attention
    {
      [Token(Token = "0x600D192"), Address(RVA = "0x1957F30", Offset = "0x1957F30", VA = "0x1957F30", Slot = "10")] get
      {
        return (AttentionDirector) null;
      }
    }

    [Token(Token = "0x17002D86")]
    public FieldDamageDirector FieldDmg
    {
      [Token(Token = "0x600D193"), Address(RVA = "0x1957F38", Offset = "0x1957F38", VA = "0x1957F38", Slot = "11")] get
      {
        return (FieldDamageDirector) null;
      }
    }

    [Token(Token = "0x17002D87")]
    public StagingDirector Staging
    {
      [Token(Token = "0x600D194"), Address(RVA = "0x1957F40", Offset = "0x1957F40", VA = "0x1957F40", Slot = "12")] get
      {
        return (StagingDirector) null;
      }
    }

    [Token(Token = "0x17002D88")]
    public StagingDirector Adv
    {
      [Token(Token = "0x600D195"), Address(RVA = "0x1957F48", Offset = "0x1957F48", VA = "0x1957F48", Slot = "13")] get
      {
        return (StagingDirector) null;
      }
    }

    [Token(Token = "0x17002D89")]
    public BattleVoiceDirector Voice
    {
      [Token(Token = "0x600D196"), Address(RVA = "0x1957F50", Offset = "0x1957F50", VA = "0x1957F50", Slot = "14")] get
      {
        return (BattleVoiceDirector) null;
      }
    }

    [Token(Token = "0x17002D8A")]
    public UIManager UI
    {
      [Token(Token = "0x600D197"), Address(RVA = "0x1957F58", Offset = "0x1957F58", VA = "0x1957F58", Slot = "15")] get
      {
        return (UIManager) null;
      }
    }

    [Token(Token = "0x17002D8B")]
    public ActorDirector Actor
    {
      [Token(Token = "0x600D198"), Address(RVA = "0x1957F60", Offset = "0x1957F60", VA = "0x1957F60", Slot = "16")] get
      {
        return (ActorDirector) null;
      }
    }

    [Token(Token = "0x17002D8C")]
    public ParticleEmitter Particle
    {
      [Token(Token = "0x600D199"), Address(RVA = "0x1957F68", Offset = "0x1957F68", VA = "0x1957F68", Slot = "17")] get
      {
        return (ParticleEmitter) null;
      }
    }

    [Token(Token = "0x17002D8D")]
    public SimpleDuelActionReciever SimpleDuel
    {
      [Token(Token = "0x600D19A"), Address(RVA = "0x1957F70", Offset = "0x1957F70", VA = "0x1957F70", Slot = "18")] get
      {
        return (SimpleDuelActionReciever) null;
      }
    }

    [Token(Token = "0x17002D8E")]
    public BattleConfigAsset Config
    {
      [Token(Token = "0x600D19B"), Address(RVA = "0x1957F78", Offset = "0x1957F78", VA = "0x1957F78", Slot = "19")] get
      {
        return (BattleConfigAsset) null;
      }
    }

    [Token(Token = "0x14000136")]
    public event MainDirector.OnGiveupDelegate GiveupEvent
    {
      [Token(Token = "0x600D19C"), Address(RVA = "0x1957F80", Offset = "0x1957F80", VA = "0x1957F80")] add
      {
      }
      [Token(Token = "0x600D19D"), Address(RVA = "0x195801C", Offset = "0x195801C", VA = "0x195801C")] remove
      {
      }
    }

    [Token(Token = "0x14000137")]
    public event MainDirector.OnSkipDelegate SkipEvent
    {
      [Token(Token = "0x600D19E"), Address(RVA = "0x19580B8", Offset = "0x19580B8", VA = "0x19580B8")] add
      {
      }
      [Token(Token = "0x600D19F"), Address(RVA = "0x1958154", Offset = "0x1958154", VA = "0x1958154")] remove
      {
      }
    }

    [Token(Token = "0x17002D8F")]
    public ISystemFlags SystemFlags
    {
      [Token(Token = "0x600D1A0"), Address(RVA = "0x19581F0", Offset = "0x19581F0", VA = "0x19581F0", Slot = "20")] get
      {
        return (ISystemFlags) null;
      }
      [Token(Token = "0x600D1A1"), Address(RVA = "0x19581F8", Offset = "0x19581F8", VA = "0x19581F8")] private set
      {
      }
    }

    [Token(Token = "0x600D1A2")]
    [Address(RVA = "0x1958200", Offset = "0x1958200", VA = "0x1958200", Slot = "4")]
    public void Initialize(BattleCore core, ISystemFlags systemFlags)
    {
    }

    [Token(Token = "0x600D1A3")]
    [Address(RVA = "0x1958618", Offset = "0x1958618", VA = "0x1958618", Slot = "5")]
    public void Release()
    {
    }

    [Token(Token = "0x600D1A4")]
    [Address(RVA = "0x19586D0", Offset = "0x19586D0", VA = "0x19586D0", Slot = "6")]
    public IEnumerator LoadResource() => (IEnumerator) null;

    [Token(Token = "0x600D1A5")]
    [Address(RVA = "0x1958760", Offset = "0x1958760", VA = "0x1958760", Slot = "7")]
    public IEnumerator LoadItemIcon() => (IEnumerator) null;

    [Token(Token = "0x600D1A6")]
    [Address(RVA = "0x19587F0", Offset = "0x19587F0", VA = "0x19587F0", Slot = "22")]
    public void Step(float delta)
    {
    }

    [Token(Token = "0x600D1A7")]
    [Address(RVA = "0x195894C", Offset = "0x195894C", VA = "0x195894C")]
    private void ToggleBattleMenu()
    {
    }

    [Token(Token = "0x600D1A8")]
    [Address(RVA = "0x1958A60", Offset = "0x1958A60", VA = "0x1958A60")]
    private void ToggleStatusIcon(bool val)
    {
    }

    [Token(Token = "0x600D1A9")]
    [Address(RVA = "0x1958DE0", Offset = "0x1958DE0", VA = "0x1958DE0")]
    private void SwitchFastMode(bool isFirstMode)
    {
    }

    [Token(Token = "0x600D1AA")]
    [Address(RVA = "0x1958E80", Offset = "0x1958E80", VA = "0x1958E80", Slot = "23")]
    public void OnChangeMapViewCameraSetting()
    {
    }

    [Token(Token = "0x600D1AB")]
    [Address(RVA = "0x1958FB0", Offset = "0x1958FB0", VA = "0x1958FB0", Slot = "28")]
    public void OnSwitchDangerArea(bool val)
    {
    }

    [Token(Token = "0x600D1AC")]
    [Address(RVA = "0x195910C", Offset = "0x195910C", VA = "0x195910C", Slot = "29")]
    public void OnSkip()
    {
    }

    [Token(Token = "0x600D1AD")]
    [Address(RVA = "0x1959128", Offset = "0x1959128", VA = "0x1959128", Slot = "27")]
    public void OnSwitchStatusIcon(bool val)
    {
    }

    [Token(Token = "0x600D1AE")]
    [Address(RVA = "0x19592CC", Offset = "0x19592CC", VA = "0x19592CC")]
    public void OnSwitchStatusIcon()
    {
    }

    [Token(Token = "0x600D1AF")]
    [Address(RVA = "0x1959534", Offset = "0x1959534", VA = "0x1959534", Slot = "24")]
    public void OnSwitchAutoModeOn()
    {
    }

    [Token(Token = "0x600D1B0")]
    [Address(RVA = "0x19597A4", Offset = "0x19597A4", VA = "0x19597A4", Slot = "25")]
    public void OnSwitchAutoModeOff()
    {
    }

    [Token(Token = "0x600D1B1")]
    [Address(RVA = "0x1959594", Offset = "0x1959594", VA = "0x1959594")]
    private IEnumerator OnSwitchAutoModeCoroutineOnRequest() => (IEnumerator) null;

    [Token(Token = "0x600D1B2")]
    [Address(RVA = "0x1959804", Offset = "0x1959804", VA = "0x1959804")]
    private IEnumerator OnSwitchAutoModeCoroutineOffRequest() => (IEnumerator) null;

    [Token(Token = "0x600D1B3")]
    [Address(RVA = "0x19595FC", Offset = "0x19595FC", VA = "0x19595FC")]
    private void OnSwitchAutoModeCommon(bool val)
    {
    }

    [Token(Token = "0x600D1B4")]
    [Address(RVA = "0x19598D4", Offset = "0x19598D4", VA = "0x19598D4", Slot = "26")]
    public void OnSwitchFastMode(bool val)
    {
    }

    [Token(Token = "0x600D1B5")]
    [Address(RVA = "0x1959A74", Offset = "0x1959A74", VA = "0x1959A74", Slot = "30")]
    public void OnSwitchGridView(bool val)
    {
    }

    [Token(Token = "0x600D1B6")]
    [Address(RVA = "0x1959BDC", Offset = "0x1959BDC", VA = "0x1959BDC", Slot = "31")]
    public void OnChangeDuelAnimation(bool val)
    {
    }

    [Token(Token = "0x600D1B7")]
    [Address(RVA = "0x1959D10", Offset = "0x1959D10", VA = "0x1959D10")]
    public void OnSwitchAutoBattleDisableScenarioStart(bool val)
    {
    }

    [Token(Token = "0x600D1B8")]
    [Address(RVA = "0x1959E28", Offset = "0x1959E28", VA = "0x1959E28")]
    public void OnSwitchAutoBattlePauseUnitLost(bool val)
    {
    }

    [Token(Token = "0x600D1B9")]
    [Address(RVA = "0x1959F40", Offset = "0x1959F40", VA = "0x1959F40")]
    public void OnSwitchAutoBattleDisableDownLP(bool val)
    {
    }

    [Token(Token = "0x600D1BA")]
    [Address(RVA = "0x195A058", Offset = "0x195A058", VA = "0x195A058")]
    public void OnSwitchAutoPlacement(bool val)
    {
    }

    [Token(Token = "0x600D1BB")]
    [Address(RVA = "0x195A170", Offset = "0x195A170", VA = "0x195A170")]
    public void OnSwitchLevelUpEffect(bool val)
    {
    }

    [Token(Token = "0x600D1BC")]
    [Address(RVA = "0x195A288", Offset = "0x195A288", VA = "0x195A288", Slot = "32")]
    public void OnSwitchCameraSetting()
    {
    }

    [Token(Token = "0x600D1BD")]
    [Address(RVA = "0x195A36C", Offset = "0x195A36C", VA = "0x195A36C", Slot = "33")]
    public void OnChangeCamera(int index)
    {
    }

    [Token(Token = "0x600D1BE")]
    [Address(RVA = "0x195A388", Offset = "0x195A388", VA = "0x195A388", Slot = "34")]
    public void OnCloseCameraConfig()
    {
    }

    [Token(Token = "0x600D1BF")]
    [Address(RVA = "0x195A400", Offset = "0x195A400", VA = "0x195A400")]
    public void OnOpenCameraConfig()
    {
    }

    [Token(Token = "0x600D1C0")]
    [Address(RVA = "0x195A47C", Offset = "0x195A47C", VA = "0x195A47C")]
    public void OnSelectUnitInUnitList(UnitParameterData unit)
    {
    }

    [Token(Token = "0x600D1C1")]
    [Address(RVA = "0x195A6AC", Offset = "0x195A6AC", VA = "0x195A6AC")]
    public void Giveup()
    {
    }

    [Token(Token = "0x600D1C2")]
    [Address(RVA = "0x195A6C8", Offset = "0x195A6C8", VA = "0x195A6C8")]
    public void OnOpenMission(BoardData board, StoryBattleConfig config)
    {
    }

    [Token(Token = "0x600D1C3")]
    [Address(RVA = "0x195AC7C", Offset = "0x195AC7C", VA = "0x195AC7C", Slot = "21")]
    public void OnUsersUnitLpDown()
    {
    }

    [Token(Token = "0x600D1C4")]
    [Address(RVA = "0x195ADA0", Offset = "0x195ADA0", VA = "0x195ADA0")]
    public void SetUpOptionMenuEvent()
    {
    }

    [Token(Token = "0x600D1C5")]
    [Address(RVA = "0x195B038", Offset = "0x195B038", VA = "0x195B038")]
    public void SetUpOptionMenuEventForArena()
    {
    }

    [Token(Token = "0x600D1C6")]
    [Address(RVA = "0x195B180", Offset = "0x195B180", VA = "0x195B180")]
    private void CloseOptionMenu()
    {
    }

    [Token(Token = "0x600D1C7")]
    [Address(RVA = "0x195B214", Offset = "0x195B214", VA = "0x195B214")]
    private void ChangeOptionTopToQuestInformation()
    {
    }

    [Token(Token = "0x600D1C8")]
    [Address(RVA = "0x195B3FC", Offset = "0x195B3FC", VA = "0x195B3FC")]
    private void ChangeOptionTopToOptionSetting()
    {
    }

    [Token(Token = "0x600D1C9")]
    [Address(RVA = "0x195B5A8", Offset = "0x195B5A8", VA = "0x195B5A8")]
    private void ChangeOptionTopToUnitInformation()
    {
    }

    [Token(Token = "0x600D1CA")]
    [Address(RVA = "0x195B63C", Offset = "0x195B63C", VA = "0x195B63C")]
    private void ChangeOptionTopToMissionInformation()
    {
    }

    [Token(Token = "0x600D1CB")]
    [Address(RVA = "0x195BDA4", Offset = "0x195BDA4", VA = "0x195BDA4")]
    private void ChangeOptionTopToGiveUp()
    {
    }

    [Token(Token = "0x600D1CC")]
    [Address(RVA = "0x195BFF0", Offset = "0x195BFF0", VA = "0x195BFF0")]
    public MainDirector()
    {
    }

    [Token(Token = "0x2002272")]
    public delegate void OnGiveupDelegate();

    [Token(Token = "0x2002273")]
    public delegate void OnSwitchStatusIconDelegate(bool val);

    [Token(Token = "0x2002274")]
    public delegate void OnSwitchFastModeDelegate(bool val);

    [Token(Token = "0x2002275")]
    public delegate void OnSkipDelegate();
  }
}
