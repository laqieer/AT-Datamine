// Decompiled with JetBrains decompiler
// Type: Alonedite.BranchSelectionManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using ADV2;
using Il2CppDummyDll;
using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UI.Direction;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.UI;
using UnityEngine.Video;

#nullable disable
namespace Alonedite
{
  [Token(Token = "0x200286E")]
  public class BranchSelectionManager : MonoBehaviour
  {
    [Token(Token = "0x400AC4C")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private PlayableDirector whiteInPlayableDirector;
    [Token(Token = "0x400AC4D")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private PlayableDirector whiteOutPlayableDirector;
    [Token(Token = "0x400AC4E")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private AlonediteSettingsAsset settingsAsset;
    [Token(Token = "0x400AC4F")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private AlonediteSceneObjectSet objectSet;
    [Token(Token = "0x400AC50")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private CommonGesturePanel commonGesturePanel;
    [Token(Token = "0x400AC51")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private UITimelineController branchSelectTmelineController;
    [Token(Token = "0x400AC52")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private Text charaName;
    [Token(Token = "0x400AC53")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private RawImage branchSelectFaceImage;
    [Token(Token = "0x400AC54")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private int movieWidth;
    [Token(Token = "0x400AC55")]
    [FieldOffset(Offset = "0x5C")]
    [SerializeField]
    private int movieHeight;
    [Token(Token = "0x400AC56")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    private string guinevereFaceMoviePath;
    [Token(Token = "0x400AC57")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    private VideoPlayer guinevereFaceMovie;
    [Token(Token = "0x400AC58")]
    [FieldOffset(Offset = "0x70")]
    [SerializeField]
    private string lancelotFaceMoviePath;
    [Token(Token = "0x400AC59")]
    [FieldOffset(Offset = "0x78")]
    [SerializeField]
    private VideoPlayer lancelotFaceMovie;
    [Token(Token = "0x400AC5A")]
    [FieldOffset(Offset = "0x80")]
    [SerializeField]
    private string dinadanFaceMoviePath;
    [Token(Token = "0x400AC5B")]
    [FieldOffset(Offset = "0x88")]
    [SerializeField]
    private VideoPlayer dinadanFaceMovie;
    [Token(Token = "0x400AC5C")]
    [FieldOffset(Offset = "0x90")]
    [SerializeField]
    private GameObject[] characterSelectButtons;
    [Token(Token = "0x400AC5D")]
    [FieldOffset(Offset = "0x98")]
    [SerializeField]
    private UITimelineController popupTimelineController;
    [Token(Token = "0x400AC5E")]
    [FieldOffset(Offset = "0xA0")]
    [SerializeField]
    private TextMeshProUGUI[] popupTexts;
    [Token(Token = "0x400AC5F")]
    [FieldOffset(Offset = "0xA8")]
    [SerializeField]
    private GameObject debugUIRoot;
    [Token(Token = "0x400AC60")]
    [FieldOffset(Offset = "0xB0")]
    [SerializeField]
    private Camera rootCamera;
    [Token(Token = "0x400AC61")]
    [FieldOffset(Offset = "0xB8")]
    private List<AlonediteCharacterController> loadedCharacters;
    [Token(Token = "0x400AC62")]
    private const string WeaponPropAssetBundleName = "content_motion3d_branch_selection";
    [Token(Token = "0x400AC63")]
    private const string WeaponPropAssetName = "Branch_Selection_Wpn_01_swd";
    [Token(Token = "0x400AC64")]
    private const string AnimatorAssetBundleName = "content_motion3d_branch_selection_animator";
    [Token(Token = "0x400AC65")]
    [FieldOffset(Offset = "0xC0")]
    private int StartingCharacterId;
    [Token(Token = "0x400AC66")]
    [FieldOffset(Offset = "0xC4")]
    private int SecondayCharacterId;
    [Token(Token = "0x400AC67")]
    private const int STYLE_ID_LANSLOT = 101010001;
    [Token(Token = "0x400AC68")]
    private const int STYLE_ID_GUINEVIA = 101011001;
    [Token(Token = "0x400AC69")]
    private const int STYLE_ID_DINATAN = 101012001;
    [Token(Token = "0x400AC6A")]
    [FieldOffset(Offset = "0xC8")]
    private List<int> characterStyleIdList;
    [Token(Token = "0x400AC6B")]
    [FieldOffset(Offset = "0xD0")]
    private int currentSelectionIndex;
    [Token(Token = "0x400AC6E")]
    [FieldOffset(Offset = "0xD8")]
    private Coroutine checkTimelineCoroutine;
    [Token(Token = "0x400AC6F")]
    [FieldOffset(Offset = "0xE0")]
    private RenderTexture faceMovieRenderTexture;
    [Token(Token = "0x400AC70")]
    [FieldOffset(Offset = "0x0")]
    private static readonly string TEXT_AB;
    [Token(Token = "0x400AC71")]
    [FieldOffset(Offset = "0xE8")]
    private bool isPrePlayed;
    [Token(Token = "0x400AC72")]
    [FieldOffset(Offset = "0x8")]
    public static bool AutoRun;
    [Token(Token = "0x400AC73")]
    [FieldOffset(Offset = "0xF0")]
    private Adv2Manager.OnProccessSignal prePlayProcessSignal;
    [Token(Token = "0x400AC74")]
    [FieldOffset(Offset = "0xF8")]
    private Adv2Manager.OnProccessSignal playProcessSignal;

    [Token(Token = "0x1700380D")]
    private bool FlickEnabled
    {
      [Token(Token = "0x600FEA8"), Address(RVA = "0x40F06D8", Offset = "0x40F06D8", VA = "0x40F06D8")] get
      {
        return new bool();
      }
      [Token(Token = "0x600FEA9"), Address(RVA = "0x40F06E0", Offset = "0x40F06E0", VA = "0x40F06E0")] set
      {
      }
    }

    [Token(Token = "0x1700380E")]
    private bool InputEnabled
    {
      [Token(Token = "0x600FEAA"), Address(RVA = "0x40F06EC", Offset = "0x40F06EC", VA = "0x40F06EC")] get
      {
        return new bool();
      }
      [Token(Token = "0x600FEAB"), Address(RVA = "0x40F06F4", Offset = "0x40F06F4", VA = "0x40F06F4")] set
      {
      }
    }

    [Token(Token = "0x600FEAC")]
    [Address(RVA = "0x40F0700", Offset = "0x40F0700", VA = "0x40F0700")]
    private void Awake()
    {
    }

    [Token(Token = "0x600FEAD")]
    [Address(RVA = "0x40F0740", Offset = "0x40F0740", VA = "0x40F0740")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x600FEAE")]
    [Address(RVA = "0x40F0844", Offset = "0x40F0844", VA = "0x40F0844")]
    public IEnumerator Start() => (IEnumerator) null;

    [Token(Token = "0x600FEAF")]
    [Address(RVA = "0x40F08D4", Offset = "0x40F08D4", VA = "0x40F08D4")]
    public void Initialize(List<int> styleIdList, Adv2Manager.OnProccessSignal onProccessSignal)
    {
    }

    [Token(Token = "0x600FEB0")]
    [Address(RVA = "0x40F09A4", Offset = "0x40F09A4", VA = "0x40F09A4")]
    public void PrePlayBranchSelect(Adv2Manager.OnProccessSignal onProccessSignal)
    {
    }

    [Token(Token = "0x600FEB1")]
    [Address(RVA = "0x40F0A50", Offset = "0x40F0A50", VA = "0x40F0A50")]
    public void PlayBranchSelect(Adv2Manager.OnProccessSignal onProccessSignal)
    {
    }

    [Token(Token = "0x600FEB2")]
    [Address(RVA = "0x40F0AFC", Offset = "0x40F0AFC", VA = "0x40F0AFC")]
    public int GetSelectedStyleId() => new int();

    [Token(Token = "0x600FEB3")]
    [Address(RVA = "0x40F0928", Offset = "0x40F0928", VA = "0x40F0928")]
    private IEnumerator InitializeAsync(
      List<int> styleIdList,
      Adv2Manager.OnProccessSignal onProccessSignal)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x600FEB4")]
    [Address(RVA = "0x40F0C38", Offset = "0x40F0C38", VA = "0x40F0C38")]
    private void RequestMovieDownload(string moviePath)
    {
    }

    [Token(Token = "0x600FEB5")]
    [Address(RVA = "0x40F0DB8", Offset = "0x40F0DB8", VA = "0x40F0DB8")]
    private void SetupWhiteOut()
    {
    }

    [Token(Token = "0x600FEB6")]
    [Address(RVA = "0x40F09E8", Offset = "0x40F09E8", VA = "0x40F09E8")]
    public IEnumerator PrePlay() => (IEnumerator) null;

    [Token(Token = "0x600FEB7")]
    [Address(RVA = "0x40F0A94", Offset = "0x40F0A94", VA = "0x40F0A94")]
    public IEnumerator Play() => (IEnumerator) null;

    [Token(Token = "0x600FEB8")]
    [Address(RVA = "0x40F040C", Offset = "0x40F040C", VA = "0x40F040C")]
    public void HideSideCharacters()
    {
    }

    [Token(Token = "0x600FEB9")]
    [Address(RVA = "0x40F0E70", Offset = "0x40F0E70", VA = "0x40F0E70")]
    private IEnumerator LoadCharacters(List<int> styleIdList) => (IEnumerator) null;

    [Token(Token = "0x600FEBA")]
    [Address(RVA = "0x40F0F0C", Offset = "0x40F0F0C", VA = "0x40F0F0C")]
    private int StyleIdToCharacterId(int styleId) => new int();

    [Token(Token = "0x600FEBB")]
    [Address(RVA = "0x40F0F94", Offset = "0x40F0F94", VA = "0x40F0F94")]
    private int CharacterIdToStyleId(int characterId) => new int();

    [Token(Token = "0x600FEBC")]
    [Address(RVA = "0x40F1004", Offset = "0x40F1004", VA = "0x40F1004")]
    private string GetStartUITimelineNameFromCharacterId(int characterId) => (string) null;

    [Token(Token = "0x600FEBD")]
    [Address(RVA = "0x40F10CC", Offset = "0x40F10CC", VA = "0x40F10CC")]
    private string GetHideUITimelineNameFromCharacterId(int characterId) => (string) null;

    [Token(Token = "0x600FEBE")]
    [Address(RVA = "0x40F1194", Offset = "0x40F1194", VA = "0x40F1194")]
    private VideoPlayer GetFaceVideoPlayerFromCharacterId(int characterId) => (VideoPlayer) null;

    [Token(Token = "0x600FEBF")]
    [Address(RVA = "0x40F120C", Offset = "0x40F120C", VA = "0x40F120C")]
    private string GetCharacterNameIDFromCharacterId(int characterId) => (string) null;

    [Token(Token = "0x600FEC0")]
    [Address(RVA = "0x40F12D4", Offset = "0x40F12D4", VA = "0x40F12D4")]
    private string GetLeftOutUITimelineNameFromCharacterId(int characterId) => (string) null;

    [Token(Token = "0x600FEC1")]
    [Address(RVA = "0x40F139C", Offset = "0x40F139C", VA = "0x40F139C")]
    private string GetLeftInUITimelineNameFromCharacterId(int characterId) => (string) null;

    [Token(Token = "0x600FEC2")]
    [Address(RVA = "0x40F1464", Offset = "0x40F1464", VA = "0x40F1464")]
    private string GetRightOutUITimelineNameFromCharacterId(int characterId) => (string) null;

    [Token(Token = "0x600FEC3")]
    [Address(RVA = "0x40F152C", Offset = "0x40F152C", VA = "0x40F152C")]
    private string GetRightInUITimelineNameFromCharacterId(int characterId) => (string) null;

    [Token(Token = "0x600FEC4")]
    [Address(RVA = "0x40F15F4", Offset = "0x40F15F4", VA = "0x40F15F4")]
    private string GetLoopUITimelineNameFromCharacterId(int characterId) => (string) null;

    [Token(Token = "0x600FEC5")]
    [Address(RVA = "0x40F16A0", Offset = "0x40F16A0", VA = "0x40F16A0")]
    private string GetTextIdFromCharacterId(int characterId) => (string) null;

    [Token(Token = "0x600FEC6")]
    [Address(RVA = "0x40F1768", Offset = "0x40F1768", VA = "0x40F1768")]
    private void SetupCamera()
    {
    }

    [Token(Token = "0x600FEC7")]
    [Address(RVA = "0x40F0B18", Offset = "0x40F0B18", VA = "0x40F0B18")]
    private AlonediteCharacterController GetCurrentSelectionController()
    {
      return (AlonediteCharacterController) null;
    }

    [Token(Token = "0x600FEC8")]
    [Address(RVA = "0x40F17E4", Offset = "0x40F17E4", VA = "0x40F17E4")]
    private void OnFlick(CommonGesturePanel.Direction direction, Vector2 speed)
    {
    }

    [Token(Token = "0x600FEC9")]
    [Address(RVA = "0x40F1810", Offset = "0x40F1810", VA = "0x40F1810")]
    public void FlickLeft()
    {
    }

    [Token(Token = "0x600FECA")]
    [Address(RVA = "0x40F1B38", Offset = "0x40F1B38", VA = "0x40F1B38")]
    public void FlickRight()
    {
    }

    [Token(Token = "0x600FECB")]
    [Address(RVA = "0x40F1E84", Offset = "0x40F1E84", VA = "0x40F1E84")]
    private IEnumerator CheckTimeline(Action action) => (IEnumerator) null;

    [Token(Token = "0x600FECC")]
    [Address(RVA = "0x40F1F28", Offset = "0x40F1F28", VA = "0x40F1F28")]
    public void OnSelectCharactor(Vector2 pos)
    {
    }

    [Token(Token = "0x600FECD")]
    [Address(RVA = "0x40F1E68", Offset = "0x40F1E68", VA = "0x40F1E68")]
    public int GetCurrentSelectingCharacterId() => new int();

    [Token(Token = "0x600FECE")]
    [Address(RVA = "0x40F2074", Offset = "0x40F2074", VA = "0x40F2074")]
    public void Cancel()
    {
    }

    [Token(Token = "0x600FECF")]
    [Address(RVA = "0x40F2120", Offset = "0x40F2120", VA = "0x40F2120")]
    public void Decide()
    {
    }

    [Token(Token = "0x600FED0")]
    [Address(RVA = "0x40F22E8", Offset = "0x40F22E8", VA = "0x40F22E8")]
    private IEnumerator CheckStopWhiteOutPlayableDirector(PlayableDirector playableDirector)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x600FED1")]
    [Address(RVA = "0x40F2384", Offset = "0x40F2384", VA = "0x40F2384")]
    public void Reset()
    {
    }

    [Token(Token = "0x600FED2")]
    [Address(RVA = "0x40F25B0", Offset = "0x40F25B0", VA = "0x40F25B0")]
    public BranchSelectionManager()
    {
    }

    [Token(Token = "0x600FED3")]
    [Address(RVA = "0x40F26E0", Offset = "0x40F26E0", VA = "0x40F26E0")]
    static BranchSelectionManager()
    {
    }
  }
}
