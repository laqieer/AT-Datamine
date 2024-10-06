// Decompiled with JetBrains decompiler
// Type: Story.Chart.StoryChartSubScene
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using GameCore.Scene;
using Il2CppDummyDll;
using StaqData;
using System.Collections;
using UnityEngine;

#nullable disable
namespace Story.Chart
{
  [Token(Token = "0x20006D9")]
  public class StoryChartSubScene : SubScene
  {
    [Token(Token = "0x4002068")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private ChartUI chartUI;
    [Token(Token = "0x4002069")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    private ChartParameter chartParameter;
    [Token(Token = "0x400206A")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    private AssetCachedSpawner spawner;
    [Token(Token = "0x400206B")]
    [FieldOffset(Offset = "0x70")]
    private ChartViewer chartViewer;
    [Token(Token = "0x400206C")]
    [FieldOffset(Offset = "0x78")]
    private int chapterID;
    [Token(Token = "0x400206D")]
    [FieldOffset(Offset = "0x80")]
    private INodeStatus nodeStatus;
    [Token(Token = "0x400206E")]
    [FieldOffset(Offset = "0x88")]
    private RememberTrackModify rememberTrackModify;

    [Token(Token = "0x60026D7")]
    [Address(RVA = "0x2F45BF0", Offset = "0x2F45BF0", VA = "0x2F45BF0", Slot = "21")]
    public override IEnumerator EnableEffect() => (IEnumerator) null;

    [Token(Token = "0x60026D8")]
    [Address(RVA = "0x2F45C58", Offset = "0x2F45C58", VA = "0x2F45C58", Slot = "22")]
    public override IEnumerator DisableEffect() => (IEnumerator) null;

    [Token(Token = "0x60026D9")]
    [Address(RVA = "0x2F45CE8", Offset = "0x2F45CE8", VA = "0x2F45CE8")]
    private void OnExit()
    {
    }

    [Token(Token = "0x60026DA")]
    [Address(RVA = "0x2F45D10", Offset = "0x2F45D10", VA = "0x2F45D10")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x60026DB")]
    [Address(RVA = "0x2F45D30", Offset = "0x2F45D30", VA = "0x2F45D30")]
    public void OnClickBackButton()
    {
    }

    [Token(Token = "0x60026DC")]
    [Address(RVA = "0x2F45E00", Offset = "0x2F45E00", VA = "0x2F45E00", Slot = "6")]
    public override void Initialize(ChangeSceneParameter changeSceneParameter = null)
    {
    }

    [Token(Token = "0x60026DD")]
    [Address(RVA = "0x2F45EE0", Offset = "0x2F45EE0", VA = "0x2F45EE0", Slot = "7")]
    public override IEnumerator InitializeAsync() => (IEnumerator) null;

    [Token(Token = "0x60026DE")]
    [Address(RVA = "0x2F45F48", Offset = "0x2F45F48", VA = "0x2F45F48")]
    private IEnumerator InitializeInternal() => (IEnumerator) null;

    [Token(Token = "0x60026DF")]
    [Address(RVA = "0x2F45FB0", Offset = "0x2F45FB0", VA = "0x2F45FB0")]
    private IEnumerator InitializeChartViewer(int chapterID) => (IEnumerator) null;

    [Token(Token = "0x60026E0")]
    [Address(RVA = "0x2F46028", Offset = "0x2F46028", VA = "0x2F46028")]
    private IEnumerator OnInitializedAfter() => (IEnumerator) null;

    [Token(Token = "0x60026E1")]
    [Address(RVA = "0x2F46090", Offset = "0x2F46090", VA = "0x2F46090")]
    private void OutGameMenuIn()
    {
    }

    [Token(Token = "0x60026E2")]
    [Address(RVA = "0x2F460F8", Offset = "0x2F460F8", VA = "0x2F460F8")]
    private void OutGameMenuOut()
    {
    }

    [Token(Token = "0x60026E3")]
    [Address(RVA = "0x2F46160", Offset = "0x2F46160", VA = "0x2F46160")]
    private void ChartIn()
    {
    }

    [Token(Token = "0x60026E4")]
    [Address(RVA = "0x2F4618C", Offset = "0x2F4618C", VA = "0x2F4618C")]
    private void ChartOut()
    {
    }

    [Token(Token = "0x60026E5")]
    [Address(RVA = "0x2F461B8", Offset = "0x2F461B8", VA = "0x2F461B8")]
    public static void ChangeSubSceneMainStoryChartCurrentLoop()
    {
    }

    [Token(Token = "0x60026E6")]
    [Address(RVA = "0x2F462F0", Offset = "0x2F462F0", VA = "0x2F462F0")]
    public static void ChangeSubSceneMainStoryChartAllLoop()
    {
    }

    [Token(Token = "0x60026E7")]
    [Address(RVA = "0x2F463FC", Offset = "0x2F463FC", VA = "0x2F463FC")]
    public static void ChangeSubScene(StoryChartSubScene.SceneParam changeSceneParam)
    {
    }

    [Token(Token = "0x60026E8")]
    [Address(RVA = "0x2F464AC", Offset = "0x2F464AC", VA = "0x2F464AC")]
    public StoryChartSubScene()
    {
    }

    [Token(Token = "0x20006DA")]
    public class SceneParam : ChangeSceneParameter
    {
      [Token(Token = "0x170005C3")]
      public StoryID StoryID
      {
        [Token(Token = "0x60026EB"), Address(RVA = "0x2F46564", Offset = "0x2F46564", VA = "0x2F46564")] get
        {
          return new StoryID();
        }
        [Token(Token = "0x60026EC"), Address(RVA = "0x2F4656C", Offset = "0x2F4656C", VA = "0x2F4656C")] set
        {
        }
      }

      [Token(Token = "0x170005C4")]
      public ChartViewerOption.ViewType ViewType
      {
        [Token(Token = "0x60026ED"), Address(RVA = "0x2F46574", Offset = "0x2F46574", VA = "0x2F46574")] get
        {
          return new ChartViewerOption.ViewType();
        }
        [Token(Token = "0x60026EE"), Address(RVA = "0x2F4657C", Offset = "0x2F4657C", VA = "0x2F4657C")] set
        {
        }
      }

      [Token(Token = "0x60026EF")]
      [Address(RVA = "0x2F462C0", Offset = "0x2F462C0", VA = "0x2F462C0")]
      public SceneParam()
      {
      }
    }
  }
}
