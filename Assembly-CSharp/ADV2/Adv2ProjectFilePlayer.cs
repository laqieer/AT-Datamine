// Decompiled with JetBrains decompiler
// Type: ADV2.Adv2ProjectFilePlayer
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using ADV2.Log;
using ADV2.LuaScript;
using ADV2.PsBattleAdv;
using GameCore.MasterData;
using GameCore.Popup;
using Il2CppDummyDll;
using Lua;
using StaqData;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.SceneManagement;

#nullable disable
namespace ADV2
{
  [Token(Token = "0x2003DFC")]
  public class Adv2ProjectFilePlayer : Adv2LuaPlayer
  {
    [Token(Token = "0x4010FBA")]
    [FieldOffset(Offset = "0xC0")]
    private Dictionary<string, Sprite> cacheSprites;
    [Token(Token = "0x4010FBF")]
    [FieldOffset(Offset = "0xE8")]
    private GameObject skipEffectGo;
    [Token(Token = "0x4010FC0")]
    [FieldOffset(Offset = "0xF0")]
    private PlayableDirector skipEffectDirector;
    [Token(Token = "0x4010FC1")]
    [FieldOffset(Offset = "0xF8")]
    public List<Adv2ProjectFilePlayer.RewardData> RewardDataList;
    [Token(Token = "0x4010FC2")]
    [FieldOffset(Offset = "0x100")]
    public Adv2LogScrollPane adv2LogScrollPane;
    [Token(Token = "0x4010FC3")]
    [FieldOffset(Offset = "0x108")]
    private bool pausedAdvPlayableDirector;
    [Token(Token = "0x4010FC4")]
    [FieldOffset(Offset = "0x110")]
    public PlayableDirector advPlayableDirector;
    [Token(Token = "0x4010FC5")]
    [FieldOffset(Offset = "0x118")]
    public Scene advTimelineScene;
    [Token(Token = "0x4010FC6")]
    [FieldOffset(Offset = "0x120")]
    public PsBattleAdvMain psBattleAdvMain;
    [Token(Token = "0x4010FC7")]
    [FieldOffset(Offset = "0x128")]
    public List<LuaObject> luaObjects;
    [Token(Token = "0x4010FC8")]
    [FieldOffset(Offset = "0x130")]
    public List<LuaUI> luaUIs;
    [Token(Token = "0x4010FC9")]
    [FieldOffset(Offset = "0x138")]
    private List<PopupHandle> closePopupsOnEnd;
    [Token(Token = "0x4010FCA")]
    [FieldOffset(Offset = "0x140")]
    private Transform[] initialPutObjects;
    [Token(Token = "0x4010FCB")]
    [FieldOffset(Offset = "0x148")]
    private int initialChildCount;

    [Token(Token = "0x1700511B")]
    public GameObject RootObject
    {
      [Token(Token = "0x6018ED3"), Address(RVA = "0x2CAE20C", Offset = "0x2CAE20C", VA = "0x2CAE20C")] get
      {
        return (GameObject) null;
      }
      [Token(Token = "0x6018ED4"), Address(RVA = "0x2CAE214", Offset = "0x2CAE214", VA = "0x2CAE214")] protected set
      {
      }
    }

    [Token(Token = "0x1700511C")]
    public Canvas RootCanvas
    {
      [Token(Token = "0x6018ED5"), Address(RVA = "0x2CAE21C", Offset = "0x2CAE21C", VA = "0x2CAE21C")] get
      {
        return (Canvas) null;
      }
      [Token(Token = "0x6018ED6"), Address(RVA = "0x2CAE224", Offset = "0x2CAE224", VA = "0x2CAE224")] protected set
      {
      }
    }

    [Token(Token = "0x1700511D")]
    public Canvas RootBackCanvas
    {
      [Token(Token = "0x6018ED7"), Address(RVA = "0x2CAE22C", Offset = "0x2CAE22C", VA = "0x2CAE22C")] get
      {
        return (Canvas) null;
      }
      [Token(Token = "0x6018ED8"), Address(RVA = "0x2CAE234", Offset = "0x2CAE234", VA = "0x2CAE234")] protected set
      {
      }
    }

    [Token(Token = "0x1700511E")]
    public Canvas RootFrontCanvas
    {
      [Token(Token = "0x6018ED9"), Address(RVA = "0x2CAE23C", Offset = "0x2CAE23C", VA = "0x2CAE23C")] get
      {
        return (Canvas) null;
      }
      [Token(Token = "0x6018EDA"), Address(RVA = "0x2CAE244", Offset = "0x2CAE244", VA = "0x2CAE244")] protected set
      {
      }
    }

    [Token(Token = "0x1700511F")]
    public Transform Root2D
    {
      [Token(Token = "0x6018EDB"), Address(RVA = "0x2CAE24C", Offset = "0x2CAE24C", VA = "0x2CAE24C")] get
      {
        return (Transform) null;
      }
      [Token(Token = "0x6018EDC"), Address(RVA = "0x2CAE254", Offset = "0x2CAE254", VA = "0x2CAE254")] protected set
      {
      }
    }

    [Token(Token = "0x17005120")]
    public Transform RootBack2D
    {
      [Token(Token = "0x6018EDD"), Address(RVA = "0x2CAE25C", Offset = "0x2CAE25C", VA = "0x2CAE25C")] get
      {
        return (Transform) null;
      }
      [Token(Token = "0x6018EDE"), Address(RVA = "0x2CAE264", Offset = "0x2CAE264", VA = "0x2CAE264")] protected set
      {
      }
    }

    [Token(Token = "0x17005121")]
    public Transform RootFront2D
    {
      [Token(Token = "0x6018EDF"), Address(RVA = "0x2CAE26C", Offset = "0x2CAE26C", VA = "0x2CAE26C")] get
      {
        return (Transform) null;
      }
      [Token(Token = "0x6018EE0"), Address(RVA = "0x2CAE274", Offset = "0x2CAE274", VA = "0x2CAE274")] protected set
      {
      }
    }

    [Token(Token = "0x17005122")]
    public Canvas RootTutorialCanvas
    {
      [Token(Token = "0x6018EE1"), Address(RVA = "0x2CAE27C", Offset = "0x2CAE27C", VA = "0x2CAE27C")] get
      {
        return (Canvas) null;
      }
      [Token(Token = "0x6018EE2"), Address(RVA = "0x2CAE284", Offset = "0x2CAE284", VA = "0x2CAE284")] protected set
      {
      }
    }

    [Token(Token = "0x17005123")]
    public Transform RootTutorial2DRoot
    {
      [Token(Token = "0x6018EE3"), Address(RVA = "0x2CAE28C", Offset = "0x2CAE28C", VA = "0x2CAE28C")] get
      {
        return (Transform) null;
      }
      [Token(Token = "0x6018EE4"), Address(RVA = "0x2CAE294", Offset = "0x2CAE294", VA = "0x2CAE294")] protected set
      {
      }
    }

    [Token(Token = "0x17005124")]
    public Transform RootTutorial2D
    {
      [Token(Token = "0x6018EE5"), Address(RVA = "0x2CAE29C", Offset = "0x2CAE29C", VA = "0x2CAE29C")] get
      {
        return (Transform) null;
      }
      [Token(Token = "0x6018EE6"), Address(RVA = "0x2CAE2A4", Offset = "0x2CAE2A4", VA = "0x2CAE2A4")] protected set
      {
      }
    }

    [Token(Token = "0x17005125")]
    public Transform TutorialUICamera
    {
      [Token(Token = "0x6018EE7"), Address(RVA = "0x2CAE2AC", Offset = "0x2CAE2AC", VA = "0x2CAE2AC")] get
      {
        return (Transform) null;
      }
      [Token(Token = "0x6018EE8"), Address(RVA = "0x2CAE2B4", Offset = "0x2CAE2B4", VA = "0x2CAE2B4")] protected set
      {
      }
    }

    [Token(Token = "0x17005126")]
    public Dictionary<string, GameObject> StackObjects
    {
      [Token(Token = "0x6018EE9"), Address(RVA = "0x2CAE2BC", Offset = "0x2CAE2BC", VA = "0x2CAE2BC")] get
      {
        return (Dictionary<string, GameObject>) null;
      }
      [Token(Token = "0x6018EEA"), Address(RVA = "0x2CAE2C4", Offset = "0x2CAE2C4", VA = "0x2CAE2C4")] set
      {
      }
    }

    [Token(Token = "0x17005127")]
    public Dictionary<string, Object> StackAssets
    {
      [Token(Token = "0x6018EEB"), Address(RVA = "0x2CAE2CC", Offset = "0x2CAE2CC", VA = "0x2CAE2CC")] get
      {
        return (Dictionary<string, Object>) null;
      }
      [Token(Token = "0x6018EEC"), Address(RVA = "0x2CAE2D4", Offset = "0x2CAE2D4", VA = "0x2CAE2D4")] set
      {
      }
    }

    [Token(Token = "0x17005128")]
    public Dictionary<string, Texture2D> StackImages
    {
      [Token(Token = "0x6018EED"), Address(RVA = "0x2CAE2DC", Offset = "0x2CAE2DC", VA = "0x2CAE2DC")] get
      {
        return (Dictionary<string, Texture2D>) null;
      }
      [Token(Token = "0x6018EEE"), Address(RVA = "0x2CAE2E4", Offset = "0x2CAE2E4", VA = "0x2CAE2E4")] set
      {
      }
    }

    [Token(Token = "0x17005129")]
    public AdvTextAccessManager TextManage
    {
      [Token(Token = "0x6018EEF"), Address(RVA = "0x2CAE2EC", Offset = "0x2CAE2EC", VA = "0x2CAE2EC")] get
      {
        return (AdvTextAccessManager) null;
      }
      [Token(Token = "0x6018EF0"), Address(RVA = "0x2CAE2F4", Offset = "0x2CAE2F4", VA = "0x2CAE2F4")] set
      {
      }
    }

    [Token(Token = "0x1700512A")]
    public Dictionary<string, Adv2Placement.HumanParam> HumanPlacements
    {
      [Token(Token = "0x6018EF1"), Address(RVA = "0x2CAE2FC", Offset = "0x2CAE2FC", VA = "0x2CAE2FC")] get
      {
        return (Dictionary<string, Adv2Placement.HumanParam>) null;
      }
      [Token(Token = "0x6018EF2"), Address(RVA = "0x2CAE304", Offset = "0x2CAE304", VA = "0x2CAE304")] set
      {
      }
    }

    [Token(Token = "0x1700512B")]
    public Dictionary<string, Adv2Placement.ObjectParam> ObjectPlacements
    {
      [Token(Token = "0x6018EF3"), Address(RVA = "0x2CAE30C", Offset = "0x2CAE30C", VA = "0x2CAE30C")] get
      {
        return (Dictionary<string, Adv2Placement.ObjectParam>) null;
      }
      [Token(Token = "0x6018EF4"), Address(RVA = "0x2CAE314", Offset = "0x2CAE314", VA = "0x2CAE314")] set
      {
      }
    }

    [Token(Token = "0x1700512C")]
    public List<Adv2Human> Humans
    {
      [Token(Token = "0x6018EF5"), Address(RVA = "0x2CAE31C", Offset = "0x2CAE31C", VA = "0x2CAE31C")] get
      {
        return (List<Adv2Human>) null;
      }
      [Token(Token = "0x6018EF6"), Address(RVA = "0x2CAE324", Offset = "0x2CAE324", VA = "0x2CAE324")] set
      {
      }
    }

    [Token(Token = "0x6018EF7")]
    [Address(RVA = "0x2CAE32C", Offset = "0x2CAE32C", VA = "0x2CAE32C")]
    private void Awake()
    {
    }

    [Token(Token = "0x6018EF8")]
    [Address(RVA = "0x2CAE418", Offset = "0x2CAE418", VA = "0x2CAE418")]
    private List<Transform> GetTransforms(int max) => (List<Transform>) null;

    [Token(Token = "0x6018EF9")]
    [Address(RVA = "0x2CAE524", Offset = "0x2CAE524", VA = "0x2CAE524")]
    private List<Transform> GetChildTransforms(Transform transform, int hCount, int max)
    {
      return (List<Transform>) null;
    }

    [Token(Token = "0x6018EFA")]
    [Address(RVA = "0x2CAE6A8", Offset = "0x2CAE6A8", VA = "0x2CAE6A8")]
    private void CreateRoot(bool isTurorial = false)
    {
    }

    [Token(Token = "0x6018EFB")]
    [Address(RVA = "0x2CAF840", Offset = "0x2CAF840", VA = "0x2CAF840")]
    public void SetupProjectStageProcess(bool isTurorial = false)
    {
    }

    [Token(Token = "0x6018EFC")]
    [Address(RVA = "0x2CAF848", Offset = "0x2CAF848", VA = "0x2CAF848")]
    public IEnumerator ClearProjectStageProcess() => (IEnumerator) null;

    [Token(Token = "0x6018EFD")]
    [Address(RVA = "0x2CAF8D8", Offset = "0x2CAF8D8", VA = "0x2CAF8D8")]
    public IEnumerator SetFile(LuaScriptableObject luaFile) => (IEnumerator) null;

    [Token(Token = "0x6018EFE")]
    [Address(RVA = "0x2CAF974", Offset = "0x2CAF974", VA = "0x2CAF974")]
    public void PreStart()
    {
    }

    [Token(Token = "0x6018EFF")]
    [Address(RVA = "0x2CAFD60", Offset = "0x2CAFD60", VA = "0x2CAFD60")]
    public Adv2Manager.OnProccessSignal PlayTimeline(string scenename)
    {
      return (Adv2Manager.OnProccessSignal) null;
    }

    [Token(Token = "0x6018F00")]
    [Address(RVA = "0x2CB0134", Offset = "0x2CB0134", VA = "0x2CB0134")]
    public IEnumerator PlayTimelineCoroutine(string scenename, Adv2Manager.OnProccessSignal signal)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6018F01")]
    [Address(RVA = "0x2CB01D8", Offset = "0x2CB01D8", VA = "0x2CB01D8")]
    public bool IsPlayingTimeline() => new bool();

    [Token(Token = "0x6018F02")]
    [Address(RVA = "0x2CB0274", Offset = "0x2CB0274", VA = "0x2CB0274")]
    public void StopTimeline()
    {
    }

    [Token(Token = "0x6018F03")]
    [Address(RVA = "0x2CB02FC", Offset = "0x2CB02FC", VA = "0x2CB02FC")]
    public void PauseTimeline()
    {
    }

    [Token(Token = "0x6018F04")]
    [Address(RVA = "0x2CB0388", Offset = "0x2CB0388", VA = "0x2CB0388")]
    public void ResumeTimeline()
    {
    }

    [Token(Token = "0x6018F05")]
    [Address(RVA = "0x2CB0410", Offset = "0x2CB0410", VA = "0x2CB0410")]
    public void RegisterPopupOnEnd(PopupHandle handle)
    {
    }

    [Token(Token = "0x6018F06")]
    [Address(RVA = "0x2CB04E4", Offset = "0x2CB04E4", VA = "0x2CB04E4")]
    public void UnRegisterPopupOnEnd(PopupHandle handle)
    {
    }

    [Token(Token = "0x6018F07")]
    [Address(RVA = "0x2CB0574", Offset = "0x2CB0574", VA = "0x2CB0574")]
    public void LateUpdate()
    {
    }

    [Token(Token = "0x6018F08")]
    [Address(RVA = "0x2CB06B4", Offset = "0x2CB06B4", VA = "0x2CB06B4", Slot = "4")]
    public override void Clear()
    {
    }

    [Token(Token = "0x6018F09")]
    [Address(RVA = "0x2CB0D98", Offset = "0x2CB0D98", VA = "0x2CB0D98")]
    public void PreSkipEffect(GameObject go)
    {
    }

    [Token(Token = "0x6018F0A")]
    [Address(RVA = "0x2CB0E14", Offset = "0x2CB0E14", VA = "0x2CB0E14")]
    public bool CreateStackImageSprite(string stackTag, out Sprite createdSp, Vector2 pivot)
    {
      return new bool();
    }

    [Token(Token = "0x6018F0B")]
    [Address(RVA = "0x2CB0E34", Offset = "0x2CB0E34", VA = "0x2CB0E34")]
    public bool CreateStackImageSprite(
      string stackTag,
      out Sprite createdSp,
      Vector2 pivot,
      out int texWidth,
      out int texHeight)
    {
      return new bool();
    }

    [Token(Token = "0x6018F0C")]
    [Address(RVA = "0x2CB1080", Offset = "0x2CB1080", VA = "0x2CB1080")]
    public bool CreateStackPrefab(string stackTag, out GameObject createPrefab) => new bool();

    [Token(Token = "0x6018F0D")]
    [Address(RVA = "0x2CB1164", Offset = "0x2CB1164", VA = "0x2CB1164")]
    public string GetRewardName(int idx) => (string) null;

    [Token(Token = "0x6018F0E")]
    [Address(RVA = "0x2CB11D0", Offset = "0x2CB11D0", VA = "0x2CB11D0")]
    public ItemUtility.Parameter GetRewardParam(int idx) => new ItemUtility.Parameter();

    [Token(Token = "0x6018F0F")]
    [Address(RVA = "0x2CB1268", Offset = "0x2CB1268", VA = "0x2CB1268")]
    public RewardTypeEnum GetRewardType(int idx) => new RewardTypeEnum();

    [Token(Token = "0x6018F10")]
    [Address(RVA = "0x2CB12D4", Offset = "0x2CB12D4", VA = "0x2CB12D4")]
    public Adv2ProjectFilePlayer()
    {
    }

    [Token(Token = "0x2003DFD")]
    public struct RewardData
    {
      [Token(Token = "0x4010FCC")]
      [FieldOffset(Offset = "0x0")]
      public RewardTypeEnum type;
      [Token(Token = "0x4010FCD")]
      [FieldOffset(Offset = "0x8")]
      public string name;
      [Token(Token = "0x4010FCE")]
      [FieldOffset(Offset = "0x10")]
      public ItemUtility.Parameter param;
    }
  }
}
