// Decompiled with JetBrains decompiler
// Type: ADV2.PsBattleAdv.PsBattleAdvMainDirector
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle;
using Battle.Data;
using Battle.Particle;
using Battle.Process;
using Battle.Staging;
using Battle.UI;
using Il2CppDummyDll;
using System.Collections;
using UnityEngine;

#nullable disable
namespace ADV2.PsBattleAdv
{
  [Token(Token = "0x2003E6D")]
  public class PsBattleAdvMainDirector : MonoBehaviour, IDirector, IStepUpdate
  {
    [Token(Token = "0x40111DD")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private MapDirector mapDirector;
    [Token(Token = "0x40111DE")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private CameraDirector cameraDirector;
    [Token(Token = "0x40111DF")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private AttentionDirector attentionDirector;
    [Token(Token = "0x40111E0")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private FieldDamageDirector fieldDmgDirector;
    [Token(Token = "0x40111E1")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private StagingDirector stagingSequencer;
    [Token(Token = "0x40111E2")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private StagingDirector advSequencer;
    [Token(Token = "0x40111E3")]
    [FieldOffset(Offset = "0x48")]
    private BattleVoiceDirector voiceDirector;
    [Token(Token = "0x40111E4")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private ActorDirector actorDirector;
    [Token(Token = "0x40111E5")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private ParticleEmitter particleEmitter;
    [Token(Token = "0x40111E6")]
    [FieldOffset(Offset = "0x60")]
    private SimpleDuelActionReciever simpleDuel;
    [Token(Token = "0x40111E7")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    private BattleConfigAsset config;
    [Token(Token = "0x40111E8")]
    [FieldOffset(Offset = "0x70")]
    private bool initialized;
    [Token(Token = "0x40111E9")]
    [FieldOffset(Offset = "0x78")]
    private ISystemFlags systemFlags;
    [Token(Token = "0x40111EA")]
    private const float MapViewCameraChangeDuration = 0.5f;

    [Token(Token = "0x17005186")]
    public MapDirectorBase Map
    {
      [Token(Token = "0x60191F1"), Address(RVA = "0x2CF4118", Offset = "0x2CF4118", VA = "0x2CF4118", Slot = "8")] get
      {
        return (MapDirectorBase) null;
      }
    }

    [Token(Token = "0x17005187")]
    public Battle.CameraDirector Camera
    {
      [Token(Token = "0x60191F2"), Address(RVA = "0x2CF4120", Offset = "0x2CF4120", VA = "0x2CF4120", Slot = "9")] get
      {
        return (Battle.CameraDirector) null;
      }
    }

    [Token(Token = "0x17005188")]
    public AttentionDirector Attention
    {
      [Token(Token = "0x60191F3"), Address(RVA = "0x2CF4128", Offset = "0x2CF4128", VA = "0x2CF4128", Slot = "10")] get
      {
        return (AttentionDirector) null;
      }
    }

    [Token(Token = "0x17005189")]
    public FieldDamageDirector FieldDmg
    {
      [Token(Token = "0x60191F4"), Address(RVA = "0x2CF4130", Offset = "0x2CF4130", VA = "0x2CF4130", Slot = "11")] get
      {
        return (FieldDamageDirector) null;
      }
    }

    [Token(Token = "0x1700518A")]
    public StagingDirector Staging
    {
      [Token(Token = "0x60191F5"), Address(RVA = "0x2CF4138", Offset = "0x2CF4138", VA = "0x2CF4138", Slot = "12")] get
      {
        return (StagingDirector) null;
      }
    }

    [Token(Token = "0x1700518B")]
    public StagingDirector Adv
    {
      [Token(Token = "0x60191F6"), Address(RVA = "0x2CF4140", Offset = "0x2CF4140", VA = "0x2CF4140", Slot = "13")] get
      {
        return (StagingDirector) null;
      }
    }

    [Token(Token = "0x1700518C")]
    public BattleVoiceDirector Voice
    {
      [Token(Token = "0x60191F7"), Address(RVA = "0x2CF4148", Offset = "0x2CF4148", VA = "0x2CF4148", Slot = "14")] get
      {
        return (BattleVoiceDirector) null;
      }
    }

    [Token(Token = "0x1700518D")]
    public UIManager UI
    {
      [Token(Token = "0x60191F8"), Address(RVA = "0x2CF4150", Offset = "0x2CF4150", VA = "0x2CF4150", Slot = "15")] get
      {
        return (UIManager) null;
      }
    }

    [Token(Token = "0x1700518E")]
    public ActorDirector Actor
    {
      [Token(Token = "0x60191F9"), Address(RVA = "0x2CF4158", Offset = "0x2CF4158", VA = "0x2CF4158", Slot = "16")] get
      {
        return (ActorDirector) null;
      }
    }

    [Token(Token = "0x1700518F")]
    public ParticleEmitter Particle
    {
      [Token(Token = "0x60191FA"), Address(RVA = "0x2CF4160", Offset = "0x2CF4160", VA = "0x2CF4160", Slot = "17")] get
      {
        return (ParticleEmitter) null;
      }
    }

    [Token(Token = "0x17005190")]
    public SimpleDuelActionReciever SimpleDuel
    {
      [Token(Token = "0x60191FB"), Address(RVA = "0x2CF4168", Offset = "0x2CF4168", VA = "0x2CF4168", Slot = "18")] get
      {
        return (SimpleDuelActionReciever) null;
      }
    }

    [Token(Token = "0x17005191")]
    public BattleConfigAsset Config
    {
      [Token(Token = "0x60191FC"), Address(RVA = "0x2CF4170", Offset = "0x2CF4170", VA = "0x2CF4170", Slot = "19")] get
      {
        return (BattleConfigAsset) null;
      }
    }

    [Token(Token = "0x17005192")]
    public ISystemFlags SystemFlags
    {
      [Token(Token = "0x60191FD"), Address(RVA = "0x2CF4178", Offset = "0x2CF4178", VA = "0x2CF4178", Slot = "20")] get
      {
        return (ISystemFlags) null;
      }
    }

    [Token(Token = "0x60191FE")]
    [Address(RVA = "0x2CF4180", Offset = "0x2CF4180", VA = "0x2CF4180", Slot = "4")]
    public void Initialize(BattleCore core, ISystemFlags systemFlags)
    {
    }

    [Token(Token = "0x60191FF")]
    [Address(RVA = "0x2CF42F8", Offset = "0x2CF42F8", VA = "0x2CF42F8", Slot = "5")]
    public void Release()
    {
    }

    [Token(Token = "0x6019200")]
    [Address(RVA = "0x2CF43C0", Offset = "0x2CF43C0", VA = "0x2CF43C0", Slot = "6")]
    public IEnumerator LoadResource() => (IEnumerator) null;

    [Token(Token = "0x6019201")]
    [Address(RVA = "0x2CF4448", Offset = "0x2CF4448", VA = "0x2CF4448", Slot = "7")]
    public IEnumerator LoadItemIcon() => (IEnumerator) null;

    [Token(Token = "0x6019202")]
    [Address(RVA = "0x2CF44D0", Offset = "0x2CF44D0", VA = "0x2CF44D0", Slot = "22")]
    public void Step(float delta)
    {
    }

    [Token(Token = "0x6019203")]
    [Address(RVA = "0x2CF4554", Offset = "0x2CF4554", VA = "0x2CF4554")]
    public void OnChangeMapViewCameraSetting()
    {
    }

    [Token(Token = "0x6019204")]
    [Address(RVA = "0x2CF4574", Offset = "0x2CF4574", VA = "0x2CF4574")]
    public void OnSwitchAutoMode(bool val)
    {
    }

    [Token(Token = "0x6019205")]
    [Address(RVA = "0x2CF4620", Offset = "0x2CF4620", VA = "0x2CF4620")]
    public void OnChangeDuelAnimation(bool val)
    {
    }

    [Token(Token = "0x6019206")]
    [Address(RVA = "0x2CF46CC", Offset = "0x2CF46CC", VA = "0x2CF46CC")]
    public void SwitchGridVisible()
    {
    }

    [Token(Token = "0x6019207")]
    [Address(RVA = "0x2CF4700", Offset = "0x2CF4700", VA = "0x2CF4700")]
    public void Hide()
    {
    }

    [Token(Token = "0x6019208")]
    [Address(RVA = "0x2CF4744", Offset = "0x2CF4744", VA = "0x2CF4744", Slot = "21")]
    public void OnUsersUnitLpDown()
    {
    }

    [Token(Token = "0x6019209")]
    [Address(RVA = "0x2CF4748", Offset = "0x2CF4748", VA = "0x2CF4748")]
    public PsBattleAdvMainDirector()
    {
    }
  }
}
