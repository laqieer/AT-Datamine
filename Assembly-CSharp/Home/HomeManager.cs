// Decompiled with JetBrains decompiler
// Type: Home.HomeManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using GameCore.DLC;
using GameCore.MasterData;
using Home.Event;
using Il2CppDummyDll;
using LoginBonus;
using Network;
using Network.API;
using Scenes.Home;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

#nullable disable
namespace Home
{
  [Token(Token = "0x2000B2C")]
  public class HomeManager : MonoBehaviour, ILoginBonus3DEffectPlayer, IHome3DEffectPlayer
  {
    [Token(Token = "0x4003300")]
    private const string BGSceneCameraName = "LinkCamera";
    [Token(Token = "0x4003301")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private LoginBonusManager loginBonusManager;
    [Token(Token = "0x4003302")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private float homeAPIUpdateMinutes;
    [Token(Token = "0x4003304")]
    [FieldOffset(Offset = "0x30")]
    private GameObject homeBGRoot;
    [Token(Token = "0x4003305")]
    [FieldOffset(Offset = "0x38")]
    private string homeBGSceneName;
    [Token(Token = "0x4003306")]
    [FieldOffset(Offset = "0x40")]
    private List<string> loadedBackgroundScene;
    [Token(Token = "0x4003307")]
    [FieldOffset(Offset = "0x48")]
    private List<string> loadedAssetBundleNames;
    [Token(Token = "0x4003308")]
    [FieldOffset(Offset = "0x50")]
    private List<HomeCharacterSettingsAsset> homeCharacterSettingsAssets;
    [Token(Token = "0x4003309")]
    [FieldOffset(Offset = "0x58")]
    private List<HomeCharacterController> homeCharacterControllers;
    [Token(Token = "0x400330A")]
    [FieldOffset(Offset = "0x60")]
    private Coroutine characterSpeak;
    [Token(Token = "0x400330B")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    private GameObject dissolvePlayableDirectorRoot;
    [Token(Token = "0x400330C")]
    [FieldOffset(Offset = "0x70")]
    [SerializeField]
    private AssetCachedSpawner AssetCachedSpawner;
    [Token(Token = "0x400330D")]
    [FieldOffset(Offset = "0x78")]
    private List<PlayableDirector> dissolveCharacterPlayableDirectors;
    [Token(Token = "0x400330E")]
    [FieldOffset(Offset = "0x80")]
    private AssetBundleManager assetBundleManager;
    [Token(Token = "0x400330F")]
    [FieldOffset(Offset = "0x88")]
    [SerializeField]
    private GameObject homePlayableDirectorRoot;
    [Token(Token = "0x4003312")]
    [FieldOffset(Offset = "0x98")]
    private HomeCameraController homeCameraController;
    [Token(Token = "0x4003313")]
    [FieldOffset(Offset = "0xA0")]
    private HomeCharacterTouchController homeCharacterTouchController;
    [Token(Token = "0x4003314")]
    [FieldOffset(Offset = "0xA8")]
    private HomeCharacterSpeakController homeCharacterSpeakController;
    [Token(Token = "0x4003315")]
    [FieldOffset(Offset = "0xB0")]
    private HomeAFKController homeAfkController;
    [Token(Token = "0x4003316")]
    [FieldOffset(Offset = "0xB8")]
    private HomeVoiceManager homeVoiceManager;
    [Token(Token = "0x4003317")]
    [FieldOffset(Offset = "0xC0")]
    public float cameraSwipeSpeed;
    [Token(Token = "0x4003318")]
    [FieldOffset(Offset = "0xC4")]
    public float cameraSwipeLimitAngle;
    [Token(Token = "0x400331B")]
    private const string homeBGSceneAssetbundleNamePrefix = "content_bg_area_";
    [Token(Token = "0x400331C")]
    [FieldOffset(Offset = "0xD0")]
    [SerializeField]
    private TimelineAsset homeCharacterDissolveTL_Sub1;
    [Token(Token = "0x400331D")]
    [FieldOffset(Offset = "0xD8")]
    [SerializeField]
    private TimelineAsset homeCharacterDissolveTL_Sub2;
    [Token(Token = "0x400331E")]
    [FieldOffset(Offset = "0xE0")]
    [SerializeField]
    private TimelineAsset homeCharacterDissolveTL_Sub3;
    [Token(Token = "0x400331F")]
    [FieldOffset(Offset = "0xE8")]
    private HomeTransitionContoller homeTransitionContoller;
    [Token(Token = "0x4003321")]
    [FieldOffset(Offset = "0xF8")]
    public bool isBootTutorialSeq;
    [Token(Token = "0x4003322")]
    [FieldOffset(Offset = "0x100")]
    public Action bootTutorialAction;
    [Token(Token = "0x4003324")]
    [FieldOffset(Offset = "0x108")]
    public bool isHoldEvent;
    [Token(Token = "0x4003325")]
    [FieldOffset(Offset = "0x110")]
    public HomeEventData homeEvent;
    [Token(Token = "0x4003327")]
    private const string HOME_BGM_NAME = "BGM_Home_Always";
    [Token(Token = "0x4003328")]
    [FieldOffset(Offset = "0x120")]
    public bool isError;
    [Token(Token = "0x4003329")]
    [FieldOffset(Offset = "0x121")]
    public bool isAlreadyHomeApi;
    [Token(Token = "0x400332C")]
    [FieldOffset(Offset = "0x130")]
    private bool isHomeAPIConnecting;
    [Token(Token = "0x400332D")]
    [FieldOffset(Offset = "0x138")]
    private DateTime? lastHomeAPIAt;
    [Token(Token = "0x400332E")]
    private const string RESOURCE_TRACK_NAME_DISSOLVE = "Act_Anim_Track_Dissolve";

    [Token(Token = "0x17000935")]
    public HomeSet HomeSet
    {
      [Token(Token = "0x6003F79"), Address(RVA = "0x2C1D4C0", Offset = "0x2C1D4C0", VA = "0x2C1D4C0")] get
      {
        return (HomeSet) null;
      }
      [Token(Token = "0x6003F7A"), Address(RVA = "0x2C1D4C8", Offset = "0x2C1D4C8", VA = "0x2C1D4C8")] private set
      {
      }
    }

    [Token(Token = "0x17000936")]
    public HomeCharacterSelectingState CharacterSelectingState
    {
      [Token(Token = "0x6003F7B"), Address(RVA = "0x2C1D4D0", Offset = "0x2C1D4D0", VA = "0x2C1D4D0")] get
      {
        return new HomeCharacterSelectingState();
      }
      [Token(Token = "0x6003F7C"), Address(RVA = "0x2C1D4D8", Offset = "0x2C1D4D8", VA = "0x2C1D4D8")] private set
      {
      }
    }

    [Token(Token = "0x17000937")]
    public HomeCameraState CameraState
    {
      [Token(Token = "0x6003F7D"), Address(RVA = "0x2C1D4E0", Offset = "0x2C1D4E0", VA = "0x2C1D4E0")] get
      {
        return new HomeCameraState();
      }
      [Token(Token = "0x6003F7E"), Address(RVA = "0x2C1D4E8", Offset = "0x2C1D4E8", VA = "0x2C1D4E8")] private set
      {
      }
    }

    [Token(Token = "0x17000938")]
    public bool HomeActionEnabled
    {
      [Token(Token = "0x6003F7F"), Address(RVA = "0x2C1D4F0", Offset = "0x2C1D4F0", VA = "0x2C1D4F0")] get
      {
        return new bool();
      }
      [Token(Token = "0x6003F80"), Address(RVA = "0x2C1D4F8", Offset = "0x2C1D4F8", VA = "0x2C1D4F8")] private set
      {
      }
    }

    [Token(Token = "0x17000939")]
    public bool CameraSwitchable
    {
      [Token(Token = "0x6003F81"), Address(RVA = "0x2C1D504", Offset = "0x2C1D504", VA = "0x2C1D504")] get
      {
        return new bool();
      }
      [Token(Token = "0x6003F82"), Address(RVA = "0x2C1D50C", Offset = "0x2C1D50C", VA = "0x2C1D50C")] set
      {
      }
    }

    [Token(Token = "0x1700093A")]
    public HomeScene.Parameter SceneParameter
    {
      [Token(Token = "0x6003F83"), Address(RVA = "0x2C1D518", Offset = "0x2C1D518", VA = "0x2C1D518")] get
      {
        return (HomeScene.Parameter) null;
      }
      [Token(Token = "0x6003F84"), Address(RVA = "0x2C1D520", Offset = "0x2C1D520", VA = "0x2C1D520")] set
      {
      }
    }

    [Token(Token = "0x1700093B")]
    public static HomeManager Instance
    {
      [Token(Token = "0x6003F85"), Address(RVA = "0x2C1D528", Offset = "0x2C1D528", VA = "0x2C1D528")] get
      {
        return (HomeManager) null;
      }
      [Token(Token = "0x6003F86"), Address(RVA = "0x2C1D570", Offset = "0x2C1D570", VA = "0x2C1D570")] private set
      {
      }
    }

    [Token(Token = "0x1700093C")]
    public HomeEventPosterTouchController homeEventPosterTouchController
    {
      [Token(Token = "0x6003F87"), Address(RVA = "0x2C1D5BC", Offset = "0x2C1D5BC", VA = "0x2C1D5BC")] get
      {
        return (HomeEventPosterTouchController) null;
      }
      [Token(Token = "0x6003F88"), Address(RVA = "0x2C1D5C4", Offset = "0x2C1D5C4", VA = "0x2C1D5C4")] private set
      {
      }
    }

    [Token(Token = "0x6003F89")]
    [Address(RVA = "0x2C1D5CC", Offset = "0x2C1D5CC", VA = "0x2C1D5CC")]
    public static string GetBGMName() => (string) null;

    [Token(Token = "0x6003F8A")]
    [Address(RVA = "0x2C1D60C", Offset = "0x2C1D60C", VA = "0x2C1D60C")]
    public void Awake()
    {
    }

    [Token(Token = "0x6003F8B")]
    [Address(RVA = "0x2C1D658", Offset = "0x2C1D658", VA = "0x2C1D658")]
    public void Start()
    {
    }

    [Token(Token = "0x6003F8C")]
    [Address(RVA = "0x2C1D718", Offset = "0x2C1D718", VA = "0x2C1D718")]
    private IEnumerator HomeStartCoroutine() => (IEnumerator) null;

    [Token(Token = "0x6003F8D")]
    [Address(RVA = "0x2C1D780", Offset = "0x2C1D780", VA = "0x2C1D780")]
    public void Reconstruct()
    {
    }

    [Token(Token = "0x6003F8E")]
    [Address(RVA = "0x2C1D808", Offset = "0x2C1D808", VA = "0x2C1D808")]
    public void SetActiveHomeControl(bool value)
    {
    }

    [Token(Token = "0x6003F8F")]
    [Address(RVA = "0x2C1D7A0", Offset = "0x2C1D7A0", VA = "0x2C1D7A0")]
    private IEnumerator ReconstructAsync() => (IEnumerator) null;

    [Token(Token = "0x6003F90")]
    [Address(RVA = "0x2C1D83C", Offset = "0x2C1D83C", VA = "0x2C1D83C")]
    private void DestroyCharaters()
    {
    }

    [Token(Token = "0x6003F91")]
    [Address(RVA = "0x2C1D9F4", Offset = "0x2C1D9F4", VA = "0x2C1D9F4")]
    private IEnumerator Initialize() => (IEnumerator) null;

    [Token(Token = "0x1700093D")]
    public bool IsForceHomeAPI
    {
      [Token(Token = "0x6003F92"), Address(RVA = "0x2C1DA5C", Offset = "0x2C1DA5C", VA = "0x2C1DA5C")] get
      {
        return new bool();
      }
      [Token(Token = "0x6003F93"), Address(RVA = "0x2C1DA64", Offset = "0x2C1DA64", VA = "0x2C1DA64")] set
      {
      }
    }

    [Token(Token = "0x1700093E")]
    public APIHome APIHome
    {
      [Token(Token = "0x6003F94"), Address(RVA = "0x2C1DA70", Offset = "0x2C1DA70", VA = "0x2C1DA70")] get
      {
        return (APIHome) null;
      }
      [Token(Token = "0x6003F95"), Address(RVA = "0x2C1DA78", Offset = "0x2C1DA78", VA = "0x2C1DA78")] private set
      {
      }
    }

    [Token(Token = "0x6003F96")]
    [Address(RVA = "0x2C1DA80", Offset = "0x2C1DA80", VA = "0x2C1DA80")]
    public bool IsHomeAPIConnecting() => new bool();

    [Token(Token = "0x6003F97")]
    [Address(RVA = "0x2C1DA88", Offset = "0x2C1DA88", VA = "0x2C1DA88")]
    public void StartHomeAPI()
    {
    }

    [Token(Token = "0x6003F98")]
    [Address(RVA = "0x2C1DCD0", Offset = "0x2C1DCD0", VA = "0x2C1DCD0")]
    private IEnumerator HomeAPI() => (IEnumerator) null;

    [Token(Token = "0x6003F99")]
    [Address(RVA = "0x2C1DD38", Offset = "0x2C1DD38", VA = "0x2C1DD38")]
    private IEnumerator OnError(NetworkErrorResult result) => (IEnumerator) null;

    [Token(Token = "0x6003F9A")]
    [Address(RVA = "0x2C1DDA0", Offset = "0x2C1DDA0", VA = "0x2C1DDA0")]
    private IEnumerator HomeMain(HomeManager.TransitionState transitionState) => (IEnumerator) null;

    [Token(Token = "0x6003F9B")]
    [Address(RVA = "0x2C1DE18", Offset = "0x2C1DE18", VA = "0x2C1DE18")]
    private HomeManager.TransitionState GetTransitionState() => new HomeManager.TransitionState();

    [Token(Token = "0x6003F9C")]
    [Address(RVA = "0x2C1D0CC", Offset = "0x2C1D0CC", VA = "0x2C1D0CC")]
    public void SwitchCameraState(HomeCameraState cameraState)
    {
    }

    [Token(Token = "0x6003F9D")]
    [Address(RVA = "0x2C1DF14", Offset = "0x2C1DF14", VA = "0x2C1DF14")]
    private IEnumerator InitializeBgScene() => (IEnumerator) null;

    [Token(Token = "0x6003F9E")]
    [Address(RVA = "0x2C1DF7C", Offset = "0x2C1DF7C", VA = "0x2C1DF7C")]
    private List<int> GetHomeStyleIdList() => (List<int>) null;

    [Token(Token = "0x6003F9F")]
    [Address(RVA = "0x2C1E190", Offset = "0x2C1E190", VA = "0x2C1E190")]
    private IEnumerator LoadCharacterSettings() => (IEnumerator) null;

    [Token(Token = "0x6003FA0")]
    [Address(RVA = "0x2C1E1F8", Offset = "0x2C1E1F8", VA = "0x2C1E1F8")]
    private IEnumerator InitializeCharacters() => (IEnumerator) null;

    [Token(Token = "0x6003FA1")]
    [Address(RVA = "0x2C1E260", Offset = "0x2C1E260", VA = "0x2C1E260")]
    private IEnumerator LoadCharacter(
      HomeCharacterSettingsAsset characterSettingsAsset,
      GameObject parent,
      int characterIndex,
      int styleId)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6003FA2")]
    [Address(RVA = "0x2C1E2F0", Offset = "0x2C1E2F0", VA = "0x2C1E2F0")]
    private void InitializeVoice()
    {
    }

    [Token(Token = "0x6003FA3")]
    [Address(RVA = "0x2C1E368", Offset = "0x2C1E368", VA = "0x2C1E368")]
    private void InitializeCameraHeight()
    {
    }

    [Token(Token = "0x6003FA4")]
    [Address(RVA = "0x2C1E604", Offset = "0x2C1E604", VA = "0x2C1E604")]
    private void InitializeDissolve()
    {
    }

    [Token(Token = "0x6003FA5")]
    [Address(RVA = "0x2C1EC90", Offset = "0x2C1EC90", VA = "0x2C1EC90")]
    private void DissolveCharacters()
    {
    }

    [Token(Token = "0x6003FA6")]
    [Address(RVA = "0x2C1EDDC", Offset = "0x2C1EDDC", VA = "0x2C1EDDC")]
    private IEnumerator PlayDissolveCharacters() => (IEnumerator) null;

    [Token(Token = "0x6003FA7")]
    [Address(RVA = "0x2C1EE44", Offset = "0x2C1EE44", VA = "0x2C1EE44")]
    private void InitializeCameraControl()
    {
    }

    [Token(Token = "0x6003FA8")]
    [Address(RVA = "0x2C1EEA4", Offset = "0x2C1EEA4", VA = "0x2C1EEA4")]
    private void InitializeCharacterTouchControl()
    {
    }

    [Token(Token = "0x6003FA9")]
    [Address(RVA = "0x2C1EF08", Offset = "0x2C1EF08", VA = "0x2C1EF08")]
    private void InitializeCharacterSpeakControl()
    {
    }

    [Token(Token = "0x6003FAA")]
    [Address(RVA = "0x2C1EF74", Offset = "0x2C1EF74", VA = "0x2C1EF74")]
    private void InitializeAFK()
    {
    }

    [Token(Token = "0x6003FAB")]
    [Address(RVA = "0x2C1EFD4", Offset = "0x2C1EFD4", VA = "0x2C1EFD4")]
    private void InitializeHomeTimeAnnouncementClock()
    {
    }

    [Token(Token = "0x6003FAC")]
    [Address(RVA = "0x2C1F060", Offset = "0x2C1F060", VA = "0x2C1F060")]
    private void InitializeStoryData()
    {
    }

    [Token(Token = "0x6003FAD")]
    [Address(RVA = "0x2C1F1B4", Offset = "0x2C1F1B4", VA = "0x2C1F1B4")]
    private void Update()
    {
    }

    [Token(Token = "0x6003FAE")]
    [Address(RVA = "0x2C066D4", Offset = "0x2C066D4", VA = "0x2C066D4")]
    public HomeCharacterController GetMainCharacter() => (HomeCharacterController) null;

    [Token(Token = "0x6003FAF")]
    [Address(RVA = "0x2C1F500", Offset = "0x2C1F500", VA = "0x2C1F500", Slot = "4")]
    public void PlayLoginBonusEffect(Action onComplete)
    {
    }

    [Token(Token = "0x6003FB0")]
    [Address(RVA = "0x2C1F594", Offset = "0x2C1F594", VA = "0x2C1F594", Slot = "5")]
    public void PlayHomeEnterEffect(Action onComplete)
    {
    }

    [Token(Token = "0x6003FB1")]
    [Address(RVA = "0x2C1F520", Offset = "0x2C1F520", VA = "0x2C1F520")]
    private IEnumerator PlayLoginBonusEffectImple(Action onEffectComplete) => (IEnumerator) null;

    [Token(Token = "0x6003FB2")]
    [Address(RVA = "0x2C1F5B4", Offset = "0x2C1F5B4", VA = "0x2C1F5B4")]
    private IEnumerator PlayHomeEnterEffectImple(Action onEffectComplete) => (IEnumerator) null;

    [Token(Token = "0x6003FB3")]
    [Address(RVA = "0x2C1F628", Offset = "0x2C1F628", VA = "0x2C1F628")]
    public void SetActiveHomeBg(bool value, bool isResolve = true)
    {
    }

    [Token(Token = "0x6003FB4")]
    [Address(RVA = "0x2C1F9BC", Offset = "0x2C1F9BC", VA = "0x2C1F9BC")]
    public void SetActiveHomeCharacter(bool value)
    {
    }

    [Token(Token = "0x6003FB5")]
    [Address(RVA = "0x2C1D484", Offset = "0x2C1D484", VA = "0x2C1D484")]
    public void SpeakCharacter(
      HomeCharacterPosition homeCharacterPosition,
      HomeCharacterSerifType serifType,
      MotionType motionType = MotionType.Timeline,
      bool cameraUpdate = true)
    {
    }

    [Token(Token = "0x6003FB6")]
    [Address(RVA = "0x2C1FC18", Offset = "0x2C1FC18", VA = "0x2C1FC18")]
    public void StopSpeakCharacter()
    {
    }

    [Token(Token = "0x6003FB7")]
    [Address(RVA = "0x2C1D0B0", Offset = "0x2C1D0B0", VA = "0x2C1D0B0")]
    public HomeVoicePack GetVoicePack(int styleId, HomeCharacterSerifType serifType)
    {
      return (HomeVoicePack) null;
    }

    [Token(Token = "0x6003FB8")]
    [Address(RVA = "0x2C1CFD4", Offset = "0x2C1CFD4", VA = "0x2C1CFD4")]
    public HomeCharacterController GetCharacter(HomeCharacterPosition position)
    {
      return (HomeCharacterController) null;
    }

    [Token(Token = "0x6003FB9")]
    [Address(RVA = "0x2C1FC4C", Offset = "0x2C1FC4C", VA = "0x2C1FC4C")]
    public GameObject GetPlayableDirectorRoot() => (GameObject) null;

    [Token(Token = "0x6003FBA")]
    [Address(RVA = "0x2C1F3A0", Offset = "0x2C1F3A0", VA = "0x2C1F3A0")]
    private HomeCharacterPosition GetRandomPosition() => new HomeCharacterPosition();

    [Token(Token = "0x6003FBB")]
    [Address(RVA = "0x2C06628", Offset = "0x2C06628", VA = "0x2C06628")]
    public void NormalizeMainCharacterDynamicBone()
    {
    }

    [Token(Token = "0x6003FBC")]
    [Address(RVA = "0x2C1FC54", Offset = "0x2C1FC54", VA = "0x2C1FC54")]
    public HomeManager()
    {
    }

    [Token(Token = "0x2000B2D")]
    private enum TransitionState
    {
      [Token(Token = "0x4003330")] Normal,
      [Token(Token = "0x4003331")] Tutorial,
      [Token(Token = "0x4003332")] LoginBonus,
      [Token(Token = "0x4003333")] FromBattle,
      [Token(Token = "0x4003334")] SuspendResume,
      [Token(Token = "0x4003335")] ScoreAttackResult,
      [Token(Token = "0x4003336")] FromStoryArchive,
      [Token(Token = "0x4003337")] StorySinarioBattleCancel,
    }
  }
}
