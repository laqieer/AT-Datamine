// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.ScenarioQuest.SelectScenarioQuestSubScene
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using GameCore.Scene;
using Il2CppDummyDll;
using System.Collections;
using System.Collections.Generic;
using UI.Direction;
using UnityEngine;

#nullable disable
namespace Scenes.OutGame.ScenarioQuest
{
  [Token(Token = "0x20034E3")]
  public class SelectScenarioQuestSubScene : SubScene
  {
    [Token(Token = "0x400E624")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private UITimelineController timeLine;
    [Token(Token = "0x400E625")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    private CommonButton backButton;
    [Token(Token = "0x400E626")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    private ScenarioEventQuestSubSceneBanner bannerObject;
    [Token(Token = "0x400E627")]
    [FieldOffset(Offset = "0x70")]
    [SerializeField]
    private Transform bannerObjectRoot;
    [Token(Token = "0x400E628")]
    private const string bannerServerPath = "Image/ScenarioEvent/{0}/ScenarioEventBanner/{0}_ScenarioEventBanner.png";
    [Token(Token = "0x400E629")]
    [FieldOffset(Offset = "0x78")]
    private List<ScenarioEventQuestSubSceneBanner> bannerList;
    [Token(Token = "0x400E62A")]
    [FieldOffset(Offset = "0x80")]
    private Dictionary<int, Texture2D> textureDic;
    [Token(Token = "0x400E62B")]
    [FieldOffset(Offset = "0x88")]
    private List<StoryScenarioQuestData> questDatas;

    [Token(Token = "0x6014BED")]
    [Address(RVA = "0x1D71DD0", Offset = "0x1D71DD0", VA = "0x1D71DD0")]
    public static void ChangeScene(bool isCreatedBack = false)
    {
    }

    [Token(Token = "0x170044C7")]
    private List<StoryScenarioQuestData> QuestDatas
    {
      [Token(Token = "0x6014BEE"), Address(RVA = "0x1D71EA4", Offset = "0x1D71EA4", VA = "0x1D71EA4")] get
      {
        return (List<StoryScenarioQuestData>) null;
      }
    }

    [Token(Token = "0x6014BEF")]
    [Address(RVA = "0x1D71F24", Offset = "0x1D71F24", VA = "0x1D71F24")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x6014BF0")]
    [Address(RVA = "0x1D71F2C", Offset = "0x1D71F2C", VA = "0x1D71F2C", Slot = "6")]
    public override void Initialize(ChangeSceneParameter param = null)
    {
    }

    [Token(Token = "0x6014BF1")]
    [Address(RVA = "0x1D72020", Offset = "0x1D72020", VA = "0x1D72020", Slot = "7")]
    public override IEnumerator InitializeAsync() => (IEnumerator) null;

    [Token(Token = "0x6014BF2")]
    [Address(RVA = "0x1D720B0", Offset = "0x1D720B0", VA = "0x1D720B0")]
    private void LoadBanner()
    {
    }

    [Token(Token = "0x6014BF3")]
    [Address(RVA = "0x1D723C0", Offset = "0x1D723C0", VA = "0x1D723C0")]
    private void CreateScenarioEventData()
    {
    }

    [Token(Token = "0x6014BF4")]
    [Address(RVA = "0x1D726B4", Offset = "0x1D726B4", VA = "0x1D726B4")]
    private void BackButtonEvent()
    {
    }

    [Token(Token = "0x6014BF5")]
    [Address(RVA = "0x1D726C0", Offset = "0x1D726C0", VA = "0x1D726C0", Slot = "20")]
    public override void BackKeyDownAction()
    {
    }

    [Token(Token = "0x6014BF6")]
    [Address(RVA = "0x1D726CC", Offset = "0x1D726CC", VA = "0x1D726CC", Slot = "21")]
    public override IEnumerator EnableEffect() => (IEnumerator) null;

    [Token(Token = "0x6014BF7")]
    [Address(RVA = "0x1D7275C", Offset = "0x1D7275C", VA = "0x1D7275C", Slot = "22")]
    public override IEnumerator DisableEffect() => (IEnumerator) null;

    [Token(Token = "0x6014BF8")]
    [Address(RVA = "0x1D727EC", Offset = "0x1D727EC", VA = "0x1D727EC", Slot = "26")]
    public override IEnumerator OnBackSceneAsync() => (IEnumerator) null;

    [Token(Token = "0x6014BF9")]
    [Address(RVA = "0x1D7287C", Offset = "0x1D7287C", VA = "0x1D7287C")]
    public SelectScenarioQuestSubScene()
    {
    }
  }
}
