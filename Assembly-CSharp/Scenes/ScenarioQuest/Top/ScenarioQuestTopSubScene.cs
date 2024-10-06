// Decompiled with JetBrains decompiler
// Type: Scenes.ScenarioQuest.Top.ScenarioQuestTopSubScene
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using GameCore.MasterData;
using GameCore.Scene;
using Il2CppDummyDll;
using Scenes.ScenarioQuest.UI.Top;
using System.Collections;
using UI.Direction;
using UnityEngine;

#nullable disable
namespace Scenes.ScenarioQuest.Top
{
  [Token(Token = "0x2002957")]
  public class ScenarioQuestTopSubScene : SubScene
  {
    [Token(Token = "0x400B035")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private UITimelineController timeline;
    [Token(Token = "0x400B036")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    private ScenarioQuestTopUI topUI;
    [Token(Token = "0x400B037")]
    [FieldOffset(Offset = "0x68")]
    private readonly TransitionTopView transitionTopView;
    [Token(Token = "0x400B038")]
    [FieldOffset(Offset = "0x70")]
    private TopViewModel topviewModel;
    [Token(Token = "0x400B039")]
    [FieldOffset(Offset = "0x78")]
    private TransitionEffect transitionEffect;
    [Token(Token = "0x400B03A")]
    [FieldOffset(Offset = "0x80")]
    private UITImelineControllerFacade timelineFacade;
    [Token(Token = "0x400B03B")]
    [FieldOffset(Offset = "0x88")]
    private AssetCachedSpawner spawner;
    [Token(Token = "0x400B03C")]
    [FieldOffset(Offset = "0x90")]
    private BannerCache bannerCache;
    [Token(Token = "0x400B03D")]
    [FieldOffset(Offset = "0x98")]
    private ScenarioQuestTopSubScene.SceneParam sceneparam;
    [Token(Token = "0x400B03E")]
    [FieldOffset(Offset = "0xA0")]
    private bool isClicked;

    [Token(Token = "0x6010407")]
    [Address(RVA = "0x4753410", Offset = "0x4753410", VA = "0x4753410")]
    public static void ChangeSubScene()
    {
    }

    [Token(Token = "0x6010408")]
    [Address(RVA = "0x47534C4", Offset = "0x47534C4", VA = "0x47534C4")]
    public static void ChangeSubScene(int scenarioquestID, bool isCratedBack = false)
    {
    }

    [Token(Token = "0x6010409")]
    [Address(RVA = "0x4753760", Offset = "0x4753760", VA = "0x4753760")]
    public static bool TryBackScenarioQuestTop(
      StoryScenarioQuestData scenarioquest,
      bool isCreatedBack = false)
    {
      return new bool();
    }

    [Token(Token = "0x601040A")]
    [Address(RVA = "0x47535E8", Offset = "0x47535E8", VA = "0x47535E8")]
    private static void OutSidePeriod()
    {
    }

    [Token(Token = "0x601040B")]
    [Address(RVA = "0x47537EC", Offset = "0x47537EC", VA = "0x47537EC", Slot = "6")]
    public override void Initialize(ChangeSceneParameter param = null)
    {
    }

    [Token(Token = "0x601040C")]
    [Address(RVA = "0x4753A1C", Offset = "0x4753A1C", VA = "0x4753A1C", Slot = "7")]
    public override IEnumerator InitializeAsync() => (IEnumerator) null;

    [Token(Token = "0x601040D")]
    [Address(RVA = "0x4753AAC", Offset = "0x4753AAC", VA = "0x4753AAC", Slot = "20")]
    public override void BackKeyDownAction()
    {
    }

    [Token(Token = "0x601040E")]
    [Address(RVA = "0x4753AF4", Offset = "0x4753AF4", VA = "0x4753AF4")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x601040F")]
    [Address(RVA = "0x4753B18", Offset = "0x4753B18", VA = "0x4753B18")]
    private void OnEnable()
    {
    }

    [Token(Token = "0x6010410")]
    [Address(RVA = "0x4753DDC", Offset = "0x4753DDC", VA = "0x4753DDC")]
    private void OnDisable()
    {
    }

    [Token(Token = "0x6010411")]
    [Address(RVA = "0x475409C", Offset = "0x475409C", VA = "0x475409C", Slot = "25")]
    public override void OnBackScene()
    {
    }

    [Token(Token = "0x6010412")]
    [Address(RVA = "0x4754100", Offset = "0x4754100", VA = "0x4754100", Slot = "26")]
    public override IEnumerator OnBackSceneAsync() => (IEnumerator) null;

    [Token(Token = "0x6010413")]
    [Address(RVA = "0x4754190", Offset = "0x4754190", VA = "0x4754190", Slot = "21")]
    public override IEnumerator EnableEffect() => (IEnumerator) null;

    [Token(Token = "0x6010414")]
    [Address(RVA = "0x4754220", Offset = "0x4754220", VA = "0x4754220", Slot = "22")]
    public override IEnumerator DisableEffect() => (IEnumerator) null;

    [Token(Token = "0x6010415")]
    [Address(RVA = "0x47542B0", Offset = "0x47542B0", VA = "0x47542B0")]
    private void OnClickStart()
    {
    }

    [Token(Token = "0x6010416")]
    [Address(RVA = "0x4753AB0", Offset = "0x4753AB0", VA = "0x4753AB0")]
    public void OnBack()
    {
    }

    [Token(Token = "0x6010417")]
    [Address(RVA = "0x47544F4", Offset = "0x47544F4", VA = "0x47544F4")]
    private void OnSpecialBattle(bool isOpen)
    {
    }

    [Token(Token = "0x6010418")]
    [Address(RVA = "0x47546B4", Offset = "0x47546B4", VA = "0x47546B4")]
    private void OnScoreAttack()
    {
    }

    [Token(Token = "0x6010419")]
    [Address(RVA = "0x475477C", Offset = "0x475477C", VA = "0x475477C")]
    private void OnFreeBattle(bool isOpen)
    {
    }

    [Token(Token = "0x601041A")]
    [Address(RVA = "0x47549B0", Offset = "0x47549B0", VA = "0x47549B0")]
    private void OnEventMission()
    {
    }

    [Token(Token = "0x601041B")]
    [Address(RVA = "0x4754A40", Offset = "0x4754A40", VA = "0x4754A40")]
    private void OnExchangeStore()
    {
    }

    [Token(Token = "0x601041C")]
    [Address(RVA = "0x4754ED4", Offset = "0x4754ED4", VA = "0x4754ED4")]
    public ScenarioQuestTopSubScene()
    {
    }

    [Token(Token = "0x2002958")]
    private class SceneParam : ChangeSceneParameter
    {
      [Token(Token = "0x170038E3")]
      public int ScenarioQuestID
      {
        [Token(Token = "0x601041F"), Address(RVA = "0x4755054", Offset = "0x4755054", VA = "0x4755054")] get
        {
          return new int();
        }
        [Token(Token = "0x6010420"), Address(RVA = "0x475505C", Offset = "0x475505C", VA = "0x475505C")] set
        {
        }
      }

      [Token(Token = "0x6010421")]
      [Address(RVA = "0x4753728", Offset = "0x4753728", VA = "0x4753728")]
      public SceneParam(int scenarioQuestID, bool isCreatedBack)
      {
      }
    }
  }
}
