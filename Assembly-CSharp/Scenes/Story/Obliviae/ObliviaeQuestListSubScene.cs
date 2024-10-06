// Decompiled with JetBrains decompiler
// Type: Scenes.Story.Obliviae.ObliviaeQuestListSubScene
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using GameCore.MasterData;
using GameCore.Scene;
using Il2CppDummyDll;
using Scenes.OutGame.Utility;
using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UI.Direction;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.Story.Obliviae
{
  [Token(Token = "0x2002E5B")]
  public class ObliviaeQuestListSubScene : SubScene
  {
    [Token(Token = "0x400C6E0")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private UITimelineController timelineController;
    [Token(Token = "0x400C6E1")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    private CommonButton backButton;
    [Token(Token = "0x400C6E2")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    private Text challengeCountText;
    [Token(Token = "0x400C6E3")]
    [FieldOffset(Offset = "0x70")]
    [SerializeField]
    private TextMeshProUGUI unitNameText;
    [Token(Token = "0x400C6E4")]
    [FieldOffset(Offset = "0x78")]
    [SerializeField]
    private ScrollRect scrollRect;
    [Token(Token = "0x400C6E5")]
    [FieldOffset(Offset = "0x80")]
    [SerializeField]
    private Transform scrollRoot;
    [Token(Token = "0x400C6E6")]
    [FieldOffset(Offset = "0x88")]
    [SerializeField]
    private ObliviaeQuestContainerColum scrollObject;
    [Token(Token = "0x400C6E7")]
    [FieldOffset(Offset = "0x90")]
    [SerializeField]
    private Image imgUnit;
    [Token(Token = "0x400C6E8")]
    [FieldOffset(Offset = "0x98")]
    [SerializeField]
    private ObliviaeQuestStageDetailPanel questDetail;
    [Token(Token = "0x400C6E9")]
    [FieldOffset(Offset = "0xA0")]
    [SerializeField]
    private GameObject storongEnemyObject;
    [Token(Token = "0x400C6EA")]
    [FieldOffset(Offset = "0xA8")]
    [Header("タイムライン対象のCanvasGropusリスト")]
    [SerializeField]
    private CanvasGroup[] timelineTargetCanvases;
    [Token(Token = "0x400C6EB")]
    [FieldOffset(Offset = "0xB0")]
    private AssetCachedSpawner assetCachedSpawner;
    [Token(Token = "0x400C6EC")]
    [FieldOffset(Offset = "0xB8")]
    private ObliviaeQuestListSubScene.SceneParam sceneParam;
    [Token(Token = "0x400C6ED")]
    [FieldOffset(Offset = "0xC0")]
    private NewBadgeProxy newBadgeProxy;
    [Token(Token = "0x400C6EE")]
    [FieldOffset(Offset = "0xC8")]
    private StoryObliviaeQuestData[] obliviaeQuestList;
    [Token(Token = "0x400C6EF")]
    [FieldOffset(Offset = "0xD0")]
    private List<ObliviaeQuestContainerColum> questContainerObjects;
    [Token(Token = "0x400C6F0")]
    [FieldOffset(Offset = "0xD8")]
    private StoryObliviaeDetailData obliviaeDetailData;
    [Token(Token = "0x400C6F1")]
    [FieldOffset(Offset = "0xE0")]
    private StyleData obliviaeStyleData;
    [Token(Token = "0x400C6F2")]
    [FieldOffset(Offset = "0xE8")]
    private CharacterData obliviaeCharacterData;

    [Token(Token = "0x60121D0")]
    [Address(RVA = "0x4588608", Offset = "0x4588608", VA = "0x4588608")]
    public static void ChangeSubSceneSimple(ObliviaeQuestListSubScene.SceneParam param)
    {
    }

    [Token(Token = "0x60121D1")]
    [Address(RVA = "0x45886B8", Offset = "0x45886B8", VA = "0x45886B8", Slot = "21")]
    public override IEnumerator EnableEffect() => (IEnumerator) null;

    [Token(Token = "0x60121D2")]
    [Address(RVA = "0x4588748", Offset = "0x4588748", VA = "0x4588748", Slot = "22")]
    public override IEnumerator DisableEffect() => (IEnumerator) null;

    [Token(Token = "0x60121D3")]
    [Address(RVA = "0x45887D8", Offset = "0x45887D8", VA = "0x45887D8", Slot = "25")]
    public override void OnBackScene()
    {
    }

    [Token(Token = "0x60121D4")]
    [Address(RVA = "0x4588940", Offset = "0x4588940", VA = "0x4588940", Slot = "26")]
    public override IEnumerator OnBackSceneAsync() => (IEnumerator) null;

    [Token(Token = "0x60121D5")]
    [Address(RVA = "0x45889D0", Offset = "0x45889D0", VA = "0x45889D0", Slot = "6")]
    public override void Initialize(ChangeSceneParameter param = null)
    {
    }

    [Token(Token = "0x60121D6")]
    [Address(RVA = "0x4588E4C", Offset = "0x4588E4C", VA = "0x4588E4C", Slot = "7")]
    public override IEnumerator InitializeAsync() => (IEnumerator) null;

    [Token(Token = "0x60121D7")]
    [Address(RVA = "0x4588EDC", Offset = "0x4588EDC", VA = "0x4588EDC")]
    private void Awake()
    {
    }

    [Token(Token = "0x60121D8")]
    [Address(RVA = "0x4588F08", Offset = "0x4588F08", VA = "0x4588F08")]
    private void Update()
    {
    }

    [Token(Token = "0x60121D9")]
    [Address(RVA = "0x4588CAC", Offset = "0x4588CAC", VA = "0x4588CAC")]
    private IEnumerable<StoryObliviaeQuestData> GetQuests(int obliviaeDetailsID)
    {
      return (IEnumerable<StoryObliviaeQuestData>) null;
    }

    [Token(Token = "0x60121DA")]
    [Address(RVA = "0x4588F94", Offset = "0x4588F94", VA = "0x4588F94")]
    private void SetupScroll()
    {
    }

    [Token(Token = "0x60121DB")]
    [Address(RVA = "0x4589560", Offset = "0x4589560", VA = "0x4589560")]
    private void OnClickThumbnail(int questId)
    {
    }

    [Token(Token = "0x60121DC")]
    [Address(RVA = "0x458989C", Offset = "0x458989C", VA = "0x458989C")]
    private void Back()
    {
    }

    [Token(Token = "0x60121DD")]
    [Address(RVA = "0x45887F4", Offset = "0x45887F4", VA = "0x45887F4")]
    private void UpdateScrollObjects()
    {
    }

    [Token(Token = "0x60121DE")]
    [Address(RVA = "0x45893A8", Offset = "0x45893A8", VA = "0x45893A8")]
    private void DestroyScrollObjects()
    {
    }

    [Token(Token = "0x60121DF")]
    [Address(RVA = "0x458996C", Offset = "0x458996C", VA = "0x458996C")]
    private void SetStyleImage()
    {
    }

    [Token(Token = "0x60121E0")]
    [Address(RVA = "0x4589A70", Offset = "0x4589A70", VA = "0x4589A70")]
    private void SetupStrongEnemyDisplay()
    {
    }

    [Token(Token = "0x60121E1")]
    [Address(RVA = "0x4589B38", Offset = "0x4589B38", VA = "0x4589B38")]
    private static bool IsShowStrongEnemyInformation(
      int obliviaeDetailID,
      (BattleTimeTypeEnum timeslot, BattleWeatherTypeEnum weather) storyInfo)
    {
      return new bool();
    }

    [Token(Token = "0x60121E2")]
    [Address(RVA = "0x458A31C", Offset = "0x458A31C", VA = "0x458A31C")]
    public ObliviaeQuestListSubScene()
    {
    }

    [Token(Token = "0x2002E5C")]
    public class SceneParam : ChangeSceneParameter
    {
      [Token(Token = "0x400C6F3")]
      [FieldOffset(Offset = "0x18")]
      public Action OnBackScene;
      [Token(Token = "0x400C6F4")]
      [FieldOffset(Offset = "0x20")]
      public int TotalClearCount;
      [Token(Token = "0x400C6F5")]
      [FieldOffset(Offset = "0x24")]
      public int ObliviaeDetailID;

      [Token(Token = "0x60121EC")]
      [Address(RVA = "0x458A4E4", Offset = "0x458A4E4", VA = "0x458A4E4")]
      public SceneParam()
      {
      }
    }
  }
}
