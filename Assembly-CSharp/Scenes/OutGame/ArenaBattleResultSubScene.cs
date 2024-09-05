// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.ArenaBattleResultSubScene
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using GameCore.Scene;
using GameCore.Tween;
using GameCore.UIControls;
using Il2CppDummyDll;
using Network.API;
using Network.Param;
using Scenes.Arena;
using Scenes.OutGame.Battle;
using Scenes.OutGame.OutGameMenu;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UI.Direction;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.UI;

#nullable disable
namespace Scenes.OutGame
{
  [Token(Token = "0x2003189")]
  public class ArenaBattleResultSubScene : SubScene
  {
    [Token(Token = "0x400D2D7")]
    private const string ResultUIAssetBundleName = "2dassets_ui_result";
    [Token(Token = "0x400D2D8")]
    private const string ThumbBaseAssetbundleName = "ui_common";
    [Token(Token = "0x400D2D9")]
    private const string ThumbRarityTextAssetbundleName = "ui_common_thumb";
    [Token(Token = "0x400D2DA")]
    private const string CommonAssetBundleName = "2dassets_ui_common";
    [Token(Token = "0x400D2DB")]
    private const string directAssetBundleName = "content_effect_common_ui_effect_stylelvup_prefab";
    [Token(Token = "0x400D2DC")]
    private const string ApRecoverAssetBundleName = "ui_page_aprecover_prefab";
    [Token(Token = "0x400D2DD")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private UITweenGroup tweenGroup;
    [Token(Token = "0x400D2DE")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    private Transform safeArea;
    [Token(Token = "0x400D2DF")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    private CommonButton screenButton;
    [Token(Token = "0x400D2E0")]
    [FieldOffset(Offset = "0x70")]
    [SerializeField]
    private CommonButton newRecordScreenButton;
    [Token(Token = "0x400D2E1")]
    [FieldOffset(Offset = "0x78")]
    [SerializeField]
    private GameObject arenaResultObj;
    [Token(Token = "0x400D2E2")]
    [FieldOffset(Offset = "0x80")]
    [SerializeField]
    private CommonButton battleHistoryButton;
    [Token(Token = "0x400D2E3")]
    [FieldOffset(Offset = "0x88")]
    [SerializeField]
    private UITimelineController timelineController;
    [Token(Token = "0x400D2E4")]
    [FieldOffset(Offset = "0x90")]
    [Header("表示物系")]
    [SerializeField]
    private TextMeshProUGUI rankText;
    [Token(Token = "0x400D2E5")]
    [FieldOffset(Offset = "0x98")]
    [SerializeField]
    private StyleThumb[] styleList;
    [Token(Token = "0x400D2E6")]
    [FieldOffset(Offset = "0xA0")]
    [SerializeField]
    private GameObject[] ExpeditionStyleList;
    [Token(Token = "0x400D2E7")]
    [FieldOffset(Offset = "0xA8")]
    [SerializeField]
    [Header("NewRecord関連")]
    private GameObject newRecordObj;
    [Token(Token = "0x400D2E8")]
    [FieldOffset(Offset = "0xB0")]
    [SerializeField]
    private UITimelineController newRecordTimelineController;
    [Token(Token = "0x400D2E9")]
    [FieldOffset(Offset = "0xB8")]
    [SerializeField]
    private PlayableDirector newRecordPlayableDirector;
    [Token(Token = "0x400D2EA")]
    [FieldOffset(Offset = "0xC0")]
    [SerializeField]
    private Text newRecordItemName;
    [Token(Token = "0x400D2EB")]
    [FieldOffset(Offset = "0xC8")]
    [SerializeField]
    private TextMeshProUGUI newRecordRanking;
    [Token(Token = "0x400D2EC")]
    [FieldOffset(Offset = "0xD0")]
    [SerializeField]
    private GameObject newRank1;
    [Token(Token = "0x400D2ED")]
    [FieldOffset(Offset = "0xD8")]
    [SerializeField]
    private GameObject newRank2;
    [Token(Token = "0x400D2EE")]
    [FieldOffset(Offset = "0xE0")]
    [SerializeField]
    private GameObject newRank3;
    [Token(Token = "0x400D2EF")]
    [FieldOffset(Offset = "0xE8")]
    [SerializeField]
    private GameObject newRank10;
    [Token(Token = "0x400D2F0")]
    [FieldOffset(Offset = "0xF0")]
    [SerializeField]
    private GameObject newRank100;
    [Token(Token = "0x400D2F1")]
    [FieldOffset(Offset = "0xF8")]
    [SerializeField]
    private GameObject newRank101;
    [Token(Token = "0x400D2F2")]
    [FieldOffset(Offset = "0x100")]
    [SerializeField]
    private ItemIcon rewardItemIcon;
    [Token(Token = "0x400D2F3")]
    [FieldOffset(Offset = "0x108")]
    [SerializeField]
    private TextMeshProUGUI rankUpNum;
    [Token(Token = "0x400D2F4")]
    [FieldOffset(Offset = "0x110")]
    [SerializeField]
    private CanvasGroup objAllCanvas;
    [Token(Token = "0x400D2F5")]
    [FieldOffset(Offset = "0x118")]
    [SerializeField]
    private AssetCachedSpawner assetCachedSpawner;
    [Token(Token = "0x400D2F6")]
    [FieldOffset(Offset = "0x120")]
    [SerializeField]
    private GameObject[] NewRecordItems;
    [Token(Token = "0x400D2F7")]
    [FieldOffset(Offset = "0x128")]
    private ArenaBattleResultSubScene.Parameter sceneParameter;
    [Token(Token = "0x400D2F8")]
    [FieldOffset(Offset = "0x130")]
    private Queue<ResultViewBase> viewBaseQueue;
    [Token(Token = "0x400D2F9")]
    [FieldOffset(Offset = "0x138")]
    public bool isLoadingAssetBundle;
    [Token(Token = "0x400D2FA")]
    [FieldOffset(Offset = "0x140")]
    private List<string>[] loadWaitAssetbundleNameList;
    [Token(Token = "0x400D2FB")]
    [FieldOffset(Offset = "0x148")]
    private int loadWaitAssetbundleNameListOfs;
    [Token(Token = "0x400D2FC")]
    [FieldOffset(Offset = "0x150")]
    private Coroutine loadAssetBundleCoroutine;
    [Token(Token = "0x400D2FD")]
    [FieldOffset(Offset = "0x158")]
    private List<ArenaBattleHistoryType> arenaBattleHistories;
    [Token(Token = "0x400D2FE")]
    [FieldOffset(Offset = "0x160")]
    private ArenaLoader ArenaLoader;
    [Token(Token = "0x400D2FF")]
    [FieldOffset(Offset = "0x168")]
    private bool isDubugMode;

    [Token(Token = "0x601353C")]
    [Address(RVA = "0x4A30994", Offset = "0x4A30994", VA = "0x4A30994", Slot = "6")]
    public override void Initialize(ChangeSceneParameter param = null)
    {
    }

    [Token(Token = "0x601353D")]
    [Address(RVA = "0x4A31124", Offset = "0x4A31124", VA = "0x4A31124", Slot = "7")]
    public override IEnumerator InitializeAsync() => (IEnumerator) null;

    [Token(Token = "0x601353E")]
    [Address(RVA = "0x4A311B4", Offset = "0x4A311B4", VA = "0x4A311B4", Slot = "9")]
    public override void Destroy()
    {
    }

    [Token(Token = "0x601353F")]
    [Address(RVA = "0x4A316B4", Offset = "0x4A316B4", VA = "0x4A316B4")]
    private IEnumerator RequestArenaBattleHistory(long arenaId) => (IEnumerator) null;

    [Token(Token = "0x6013540")]
    [Address(RVA = "0x4A31750", Offset = "0x4A31750", VA = "0x4A31750")]
    public void OnClickExitResult()
    {
    }

    [Token(Token = "0x6013541")]
    [Address(RVA = "0x4A31828", Offset = "0x4A31828", VA = "0x4A31828")]
    public void OnClickNextButton()
    {
    }

    [Token(Token = "0x6013542")]
    [Address(RVA = "0x4A31FFC", Offset = "0x4A31FFC", VA = "0x4A31FFC")]
    public void OnClickBattleHistoryButton()
    {
    }

    [Token(Token = "0x6013543")]
    [Address(RVA = "0x4A32158", Offset = "0x4A32158", VA = "0x4A32158")]
    private IEnumerator StartAnimation(bool isWin) => (IEnumerator) null;

    [Token(Token = "0x6013544")]
    [Address(RVA = "0x4A321FC", Offset = "0x4A321FC", VA = "0x4A321FC")]
    private IEnumerator PlayTimeline(bool win) => (IEnumerator) null;

    [Token(Token = "0x6013545")]
    [Address(RVA = "0x4A31888", Offset = "0x4A31888", VA = "0x4A31888")]
    private void NewRecordTimeline()
    {
    }

    [Token(Token = "0x6013546")]
    [Address(RVA = "0x4A322A0", Offset = "0x4A322A0", VA = "0x4A322A0")]
    public void AddLoadAssetBundle(string name)
    {
    }

    [Token(Token = "0x6013547")]
    [Address(RVA = "0x4A310BC", Offset = "0x4A310BC", VA = "0x4A310BC")]
    public IEnumerator SetLoadingAssetBundle() => (IEnumerator) null;

    [Token(Token = "0x6013548")]
    [Address(RVA = "0x4A323A0", Offset = "0x4A323A0", VA = "0x4A323A0")]
    public ArenaBattleResultSubScene()
    {
    }

    [Token(Token = "0x200318A")]
    public sealed class Parameter : ChangeSceneParameter
    {
      [Token(Token = "0x400D300")]
      [FieldOffset(Offset = "0x18")]
      public APIArenaBattleEndResponse endApiResponse;

      [Token(Token = "0x601354A")]
      [Address(RVA = "0x4A310B0", Offset = "0x4A310B0", VA = "0x4A310B0")]
      public Parameter()
      {
      }
    }
  }
}
