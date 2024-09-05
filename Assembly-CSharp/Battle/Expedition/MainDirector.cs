// Decompiled with JetBrains decompiler
// Type: Battle.Expedition.MainDirector
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data;
using Battle.Particle;
using Battle.Process;
using Battle.Staging;
using Battle.UI;
using GameCore.Tween;
using Il2CppDummyDll;
using StaqData.StatusIcon;
using System.Collections;
using UnityEngine;

#nullable disable
namespace Battle.Expedition
{
  [Token(Token = "0x20025D1")]
  public class MainDirector : MonoBehaviour, IDirector, IStepUpdate
  {
    [Token(Token = "0x400A29F")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private MapDirector mapDirector;
    [Token(Token = "0x400A2A0")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private CameraDirector cameraDirector;
    [Token(Token = "0x400A2A1")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private AttentionDirector attentionDirector;
    [Token(Token = "0x400A2A2")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private FieldDamageDirector fieldDmgDirector;
    [Token(Token = "0x400A2A3")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private StagingDirector stagingSequencer;
    [Token(Token = "0x400A2A4")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private StagingDirector advSequencer;
    [Token(Token = "0x400A2A5")]
    [FieldOffset(Offset = "0x48")]
    private BattleVoiceDirector voiceDirector;
    [Token(Token = "0x400A2A6")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private ActorDirector actorDirector;
    [Token(Token = "0x400A2A7")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private ParticleEmitter particleEmitter;
    [Token(Token = "0x400A2A8")]
    [FieldOffset(Offset = "0x60")]
    private SimpleDuelActionReciever simpleDuel;
    [Token(Token = "0x400A2A9")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    private ScreenEffectDirector screenEffectDirector;
    [Token(Token = "0x400A2AA")]
    [FieldOffset(Offset = "0x70")]
    [SerializeField]
    private BattleConfigAsset config;
    [Token(Token = "0x400A2AB")]
    [FieldOffset(Offset = "0x78")]
    [SerializeField]
    private UITweenGroup transitionCoverTweenGroup;
    [Token(Token = "0x400A2AC")]
    [FieldOffset(Offset = "0x80")]
    private IconFactory iconFactory;
    [Token(Token = "0x400A2AD")]
    [FieldOffset(Offset = "0x88")]
    private bool initialized;
    [Token(Token = "0x400A2AE")]
    [FieldOffset(Offset = "0x90")]
    private ISystemFlags systemFlags;
    [Token(Token = "0x400A2AF")]
    private const float MapViewCameraChangeDuration = 0.5f;

    [Token(Token = "0x170031D6")]
    public MapDirectorBase Map
    {
      [Token(Token = "0x600E972"), Address(RVA = "0x4C4A800", Offset = "0x4C4A800", VA = "0x4C4A800", Slot = "8")] get
      {
        return (MapDirectorBase) null;
      }
    }

    [Token(Token = "0x170031D7")]
    public Battle.CameraDirector Camera
    {
      [Token(Token = "0x600E973"), Address(RVA = "0x4C4A808", Offset = "0x4C4A808", VA = "0x4C4A808", Slot = "9")] get
      {
        return (Battle.CameraDirector) null;
      }
    }

    [Token(Token = "0x170031D8")]
    public Battle.AttentionDirector Attention
    {
      [Token(Token = "0x600E974"), Address(RVA = "0x4C4A810", Offset = "0x4C4A810", VA = "0x4C4A810", Slot = "10")] get
      {
        return (Battle.AttentionDirector) null;
      }
    }

    [Token(Token = "0x170031D9")]
    public FieldDamageDirector FieldDmg
    {
      [Token(Token = "0x600E975"), Address(RVA = "0x4C4A818", Offset = "0x4C4A818", VA = "0x4C4A818", Slot = "11")] get
      {
        return (FieldDamageDirector) null;
      }
    }

    [Token(Token = "0x170031DA")]
    public StagingDirector Staging
    {
      [Token(Token = "0x600E976"), Address(RVA = "0x4C4A820", Offset = "0x4C4A820", VA = "0x4C4A820", Slot = "12")] get
      {
        return (StagingDirector) null;
      }
    }

    [Token(Token = "0x170031DB")]
    public StagingDirector Adv
    {
      [Token(Token = "0x600E977"), Address(RVA = "0x4C4A828", Offset = "0x4C4A828", VA = "0x4C4A828", Slot = "13")] get
      {
        return (StagingDirector) null;
      }
    }

    [Token(Token = "0x170031DC")]
    public BattleVoiceDirector Voice
    {
      [Token(Token = "0x600E978"), Address(RVA = "0x4C4A830", Offset = "0x4C4A830", VA = "0x4C4A830", Slot = "14")] get
      {
        return (BattleVoiceDirector) null;
      }
    }

    [Token(Token = "0x170031DD")]
    public UIManager UI
    {
      [Token(Token = "0x600E979"), Address(RVA = "0x4C4A838", Offset = "0x4C4A838", VA = "0x4C4A838", Slot = "15")] get
      {
        return (UIManager) null;
      }
    }

    [Token(Token = "0x170031DE")]
    public ActorDirector Actor
    {
      [Token(Token = "0x600E97A"), Address(RVA = "0x4C4A840", Offset = "0x4C4A840", VA = "0x4C4A840", Slot = "16")] get
      {
        return (ActorDirector) null;
      }
    }

    [Token(Token = "0x170031DF")]
    public ParticleEmitter Particle
    {
      [Token(Token = "0x600E97B"), Address(RVA = "0x4C4A848", Offset = "0x4C4A848", VA = "0x4C4A848", Slot = "17")] get
      {
        return (ParticleEmitter) null;
      }
    }

    [Token(Token = "0x170031E0")]
    public Battle.SimpleDuelActionReciever SimpleDuel
    {
      [Token(Token = "0x600E97C"), Address(RVA = "0x4C4A850", Offset = "0x4C4A850", VA = "0x4C4A850", Slot = "18")] get
      {
        return (Battle.SimpleDuelActionReciever) null;
      }
    }

    [Token(Token = "0x170031E1")]
    public ScreenEffectDirector ScreenEffectDirector
    {
      [Token(Token = "0x600E97D"), Address(RVA = "0x4C4A858", Offset = "0x4C4A858", VA = "0x4C4A858")] get
      {
        return (ScreenEffectDirector) null;
      }
    }

    [Token(Token = "0x170031E2")]
    public BattleConfigAsset Config
    {
      [Token(Token = "0x600E97E"), Address(RVA = "0x4C4A860", Offset = "0x4C4A860", VA = "0x4C4A860", Slot = "19")] get
      {
        return (BattleConfigAsset) null;
      }
    }

    [Token(Token = "0x170031E3")]
    public UITweenGroup TransitionCoverTweenGroup
    {
      [Token(Token = "0x600E97F"), Address(RVA = "0x4C4A868", Offset = "0x4C4A868", VA = "0x4C4A868")] get
      {
        return (UITweenGroup) null;
      }
    }

    [Token(Token = "0x170031E4")]
    public IconFactory IconFactory
    {
      [Token(Token = "0x600E980"), Address(RVA = "0x4C4A870", Offset = "0x4C4A870", VA = "0x4C4A870")] get
      {
        return (IconFactory) null;
      }
    }

    [Token(Token = "0x170031E5")]
    public ISystemFlags SystemFlags
    {
      [Token(Token = "0x600E981"), Address(RVA = "0x4C4A878", Offset = "0x4C4A878", VA = "0x4C4A878", Slot = "20")] get
      {
        return (ISystemFlags) null;
      }
    }

    [Token(Token = "0x600E982")]
    [Address(RVA = "0x4C4A880", Offset = "0x4C4A880", VA = "0x4C4A880", Slot = "4")]
    public void Initialize(BattleCore core, ISystemFlags systemFlags)
    {
    }

    [Token(Token = "0x600E983")]
    [Address(RVA = "0x4C4AAE4", Offset = "0x4C4AAE4", VA = "0x4C4AAE4")]
    public void SetBattleCore(BattleCore core)
    {
    }

    [Token(Token = "0x600E984")]
    [Address(RVA = "0x4C4ABFC", Offset = "0x4C4ABFC", VA = "0x4C4ABFC", Slot = "5")]
    public void Release()
    {
    }

    [Token(Token = "0x600E985")]
    [Address(RVA = "0x4C4AC84", Offset = "0x4C4AC84", VA = "0x4C4AC84", Slot = "6")]
    public IEnumerator LoadResource() => (IEnumerator) null;

    [Token(Token = "0x600E986")]
    [Address(RVA = "0x4C4AD0C", Offset = "0x4C4AD0C", VA = "0x4C4AD0C", Slot = "7")]
    public IEnumerator LoadItemIcon() => (IEnumerator) null;

    [Token(Token = "0x600E987")]
    [Address(RVA = "0x4C4AD94", Offset = "0x4C4AD94", VA = "0x4C4AD94", Slot = "22")]
    public void Step(float delta)
    {
    }

    [Token(Token = "0x600E988")]
    [Address(RVA = "0x4C4AE34", Offset = "0x4C4AE34", VA = "0x4C4AE34")]
    public void OnChangeMapViewCameraSetting()
    {
    }

    [Token(Token = "0x600E989")]
    [Address(RVA = "0x4C4AE54", Offset = "0x4C4AE54", VA = "0x4C4AE54")]
    public void OnSwitchAutoMode(bool val)
    {
    }

    [Token(Token = "0x600E98A")]
    [Address(RVA = "0x4C4AF00", Offset = "0x4C4AF00", VA = "0x4C4AF00")]
    public void OnSwitchFastMode(bool val)
    {
    }

    [Token(Token = "0x600E98B")]
    [Address(RVA = "0x4C4AFAC", Offset = "0x4C4AFAC", VA = "0x4C4AFAC")]
    public void OnChangeGameSpeed()
    {
    }

    [Token(Token = "0x600E98C")]
    [Address(RVA = "0x4C4B090", Offset = "0x4C4B090", VA = "0x4C4B090")]
    public void OnChangeDuelAnimation(bool val)
    {
    }

    [Token(Token = "0x600E98D")]
    [Address(RVA = "0x4C4B13C", Offset = "0x4C4B13C", VA = "0x4C4B13C")]
    public void ChangeCameraAngle()
    {
    }

    [Token(Token = "0x600E98E")]
    [Address(RVA = "0x4C4B15C", Offset = "0x4C4B15C", VA = "0x4C4B15C")]
    public void SwitchGridVisible()
    {
    }

    [Token(Token = "0x600E98F")]
    [Address(RVA = "0x4C4AA10", Offset = "0x4C4AA10", VA = "0x4C4AA10")]
    public void OnSwitchGridView(bool val)
    {
    }

    [Token(Token = "0x600E990")]
    [Address(RVA = "0x4C4B190", Offset = "0x4C4B190", VA = "0x4C4B190")]
    public void Hide()
    {
    }

    [Token(Token = "0x600E991")]
    [Address(RVA = "0x4C4B288", Offset = "0x4C4B288", VA = "0x4C4B288", Slot = "21")]
    public void OnUsersUnitLpDown()
    {
    }

    [Token(Token = "0x600E992")]
    [Address(RVA = "0x4C4B28C", Offset = "0x4C4B28C", VA = "0x4C4B28C")]
    public MainDirector()
    {
    }
  }
}
