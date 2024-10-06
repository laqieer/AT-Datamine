// Decompiled with JetBrains decompiler
// Type: Scenes.GlobalMenuFrontView.GlobalMenuFrontView
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.Scene;
using GameCore.Tween;
using Il2CppDummyDll;
using System;
using System.Collections;
using System.Collections.Generic;
using UI.Direction;
using UnityEngine;
using UnityEngine.Playables;

#nullable disable
namespace Scenes.GlobalMenuFrontView
{
  [Token(Token = "0x2002A4D")]
  public class GlobalMenuFrontView : SubScene
  {
    [Token(Token = "0x400B40C")]
    [FieldOffset(Offset = "0x58")]
    private Dictionary<Scenes.GlobalMenuFrontView.GlobalMenuFrontView.CONTENTTYPE, string[]> contentDic;
    [Token(Token = "0x400B40D")]
    [FieldOffset(Offset = "0x60")]
    private string SubSceneContentPath;
    [Token(Token = "0x400B40E")]
    [FieldOffset(Offset = "0x68")]
    private string SubSceneContentPrefabName;
    [Token(Token = "0x400B40F")]
    [FieldOffset(Offset = "0x70")]
    [SerializeField]
    private CanvasGroup canvasGroup;
    [Token(Token = "0x400B410")]
    [FieldOffset(Offset = "0x78")]
    [SerializeField]
    private UITweenGroup tweenGroup;
    [Token(Token = "0x400B411")]
    [FieldOffset(Offset = "0x80")]
    [SerializeField]
    private Transform content;
    [Token(Token = "0x400B412")]
    [FieldOffset(Offset = "0x88")]
    [SerializeField]
    private Transform left;
    [Token(Token = "0x400B413")]
    [FieldOffset(Offset = "0x90")]
    [SerializeField]
    private UITimelineController timeLineController;
    [Token(Token = "0x400B414")]
    [FieldOffset(Offset = "0x98")]
    [SerializeField]
    private PlayableDirector timeLinePlayableDirector;
    [Token(Token = "0x400B415")]
    private const string TimeLineAssetbundleName = "ui_page_outgame_timeline";
    [Token(Token = "0x400B416")]
    [FieldOffset(Offset = "0xA0")]
    private bool isTimelineDirection;
    [Token(Token = "0x400B417")]
    [FieldOffset(Offset = "0xA4")]
    private Scenes.GlobalMenuFrontView.GlobalMenuFrontView.CONTENTTYPE currContentType;
    [Token(Token = "0x400B418")]
    public const string SubSceneAssetBundleName = "ui_page_outgame";
    [Token(Token = "0x400B419")]
    public const string SubScenePrefabName = "Com_GlobalMenuFront_View";
    [Token(Token = "0x400B41A")]
    public const string AnimationKeyIn = "Open";
    [Token(Token = "0x400B41B")]
    public const string AnimationKeyOut = "Close";
    [Token(Token = "0x400B41C")]
    [FieldOffset(Offset = "0xA8")]
    private bool isLoadedAssetBundle;
    [Token(Token = "0x400B41D")]
    [FieldOffset(Offset = "0xA9")]
    private bool isTimeLineOver;
    [Token(Token = "0x400B41E")]
    [FieldOffset(Offset = "0xAA")]
    private bool isClickClose;
    [Token(Token = "0x400B41F")]
    [FieldOffset(Offset = "0xB0")]
    private GlobalMenuFrontContentsBase contentsBase;

    [Token(Token = "0x60108F8")]
    [Address(RVA = "0x4C2AADC", Offset = "0x4C2AADC", VA = "0x4C2AADC", Slot = "9")]
    public override void Destroy()
    {
    }

    [Token(Token = "0x60108F9")]
    [Address(RVA = "0x4C2AAE4", Offset = "0x4C2AAE4", VA = "0x4C2AAE4")]
    protected IEnumerator PlayAnimation(string animationGroupID) => (IEnumerator) null;

    [Token(Token = "0x60108FA")]
    [Address(RVA = "0x4C2AB80", Offset = "0x4C2AB80", VA = "0x4C2AB80")]
    private void SetInteractable(bool value)
    {
    }

    [Token(Token = "0x60108FB")]
    [Address(RVA = "0x4C25F58", Offset = "0x4C25F58", VA = "0x4C25F58")]
    public void DisableInteractable()
    {
    }

    [Token(Token = "0x60108FC")]
    [Address(RVA = "0x4C25F8C", Offset = "0x4C25F8C", VA = "0x4C25F8C")]
    public void EnableInteractable()
    {
    }

    [Token(Token = "0x60108FD")]
    [Address(RVA = "0x4C2AC18", Offset = "0x4C2AC18", VA = "0x4C2AC18", Slot = "6")]
    public override void Initialize(ChangeSceneParameter param = null)
    {
    }

    [Token(Token = "0x60108FE")]
    [Address(RVA = "0x4C2ACA8", Offset = "0x4C2ACA8", VA = "0x4C2ACA8", Slot = "7")]
    public override IEnumerator InitializeAsync() => (IEnumerator) null;

    [Token(Token = "0x60108FF")]
    [Address(RVA = "0x4C2AD38", Offset = "0x4C2AD38", VA = "0x4C2AD38")]
    private IEnumerator LoadWaitByAssetBundle(string label, Action<string, bool> successAction)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6010900")]
    [Address(RVA = "0x4C2ADDC", Offset = "0x4C2ADDC", VA = "0x4C2ADDC")]
    private string[] GetContentAssetPathName() => (string[]) null;

    [Token(Token = "0x6010901")]
    [Address(RVA = "0x4C2AEA0", Offset = "0x4C2AEA0", VA = "0x4C2AEA0")]
    private IEnumerator playTimeline(
      string timeLineSettingNameList,
      UITimelineController.DirectionType inout,
      Action finishAction)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6010902")]
    [Address(RVA = "0x4C2AF54", Offset = "0x4C2AF54", VA = "0x4C2AF54", Slot = "21")]
    public override IEnumerator EnableEffect() => (IEnumerator) null;

    [Token(Token = "0x6010903")]
    [Address(RVA = "0x4C2AFE4", Offset = "0x4C2AFE4", VA = "0x4C2AFE4", Slot = "22")]
    public override IEnumerator DisableEffect() => (IEnumerator) null;

    [Token(Token = "0x6010904")]
    [Address(RVA = "0x4C2B074", Offset = "0x4C2B074", VA = "0x4C2B074", Slot = "26")]
    public override IEnumerator OnBackSceneAsync() => (IEnumerator) null;

    [Token(Token = "0x6010905")]
    [Address(RVA = "0x4C2B104", Offset = "0x4C2B104", VA = "0x4C2B104", Slot = "30")]
    protected override void BackKeyDownActionInSubScene()
    {
    }

    [Token(Token = "0x6010906")]
    [Address(RVA = "0x4C2B154", Offset = "0x4C2B154", VA = "0x4C2B154")]
    private bool BackKeyDownActionMission_PresentBox() => new bool();

    [Token(Token = "0x6010907")]
    [Address(RVA = "0x4C2B47C", Offset = "0x4C2B47C", VA = "0x4C2B47C")]
    private bool BackKeyDownActionInformation() => new bool();

    [Token(Token = "0x6010908")]
    [Address(RVA = "0x4C2B7BC", Offset = "0x4C2B7BC", VA = "0x4C2B7BC")]
    public void OnClickBack()
    {
    }

    [Token(Token = "0x6010909")]
    [Address(RVA = "0x4C2B688", Offset = "0x4C2B688", VA = "0x4C2B688")]
    private void BackToPrevScene()
    {
    }

    [Token(Token = "0x601090A")]
    [Address(RVA = "0x4C2B7CC", Offset = "0x4C2B7CC", VA = "0x4C2B7CC")]
    public GlobalMenuFrontView()
    {
    }

    [Token(Token = "0x2002A4E")]
    public class Param : ChangeSceneParameter
    {
      [Token(Token = "0x17003987")]
      public Scenes.GlobalMenuFrontView.GlobalMenuFrontView.CONTENTTYPE contentType
      {
        [Token(Token = "0x601090F"), Address(RVA = "0x4C2BAD4", Offset = "0x4C2BAD4", VA = "0x4C2BAD4")] get
        {
          return new Scenes.GlobalMenuFrontView.GlobalMenuFrontView.CONTENTTYPE();
        }
        [Token(Token = "0x6010910"), Address(RVA = "0x4C2BADC", Offset = "0x4C2BADC", VA = "0x4C2BADC")] protected set
        {
        }
      }

      [Token(Token = "0x6010911")]
      [Address(RVA = "0x4C2BAE4", Offset = "0x4C2BAE4", VA = "0x4C2BAE4")]
      public Param(Scenes.GlobalMenuFrontView.GlobalMenuFrontView.CONTENTTYPE contentType)
      {
      }
    }

    [Token(Token = "0x2002A4F")]
    public enum CONTENTTYPE
    {
      [Token(Token = "0x400B422")] NONE,
      [Token(Token = "0x400B423")] PRESENTBOX,
      [Token(Token = "0x400B424")] MISSION,
      [Token(Token = "0x400B425")] INFORMATION,
    }
  }
}
