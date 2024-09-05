// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.QuestSelect.QuestSelectSubScene
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using GameCore.MasterData;
using GameCore.Scene;
using Il2CppDummyDll;
using StaqData;
using System.Collections;
using System.Collections.Generic;

#nullable disable
namespace Scenes.OutGame.QuestSelect
{
  [Token(Token = "0x20033F0")]
  public class QuestSelectSubScene : SubScene
  {
    [Token(Token = "0x400E1C2")]
    public const string SUBSCENE_ABNAME = "page_questselect_stroyquest";
    [Token(Token = "0x400E1C3")]
    public const string SUBSCENE_ASSETNAME = "QuestSelectSubScene";
    [Token(Token = "0x400E1C4")]
    [FieldOffset(Offset = "0x58")]
    private List<QuestInfo> questInfoList;
    [Token(Token = "0x400E1C5")]
    [FieldOffset(Offset = "0x60")]
    private QuestStageSelectScene questSelect;
    [Token(Token = "0x400E1C6")]
    [FieldOffset(Offset = "0x68")]
    private bool showHeaderDate;
    [Token(Token = "0x400E1C7")]
    [FieldOffset(Offset = "0x6C")]
    private QuestTypeEnum questTypeEnum;
    [Token(Token = "0x400E1C8")]
    [FieldOffset(Offset = "0x70")]
    private QuestAssetLoader assetLoader;
    [Token(Token = "0x400E1C9")]
    [FieldOffset(Offset = "0x78")]
    private int? initQuestId;
    [Token(Token = "0x400E1CA")]
    [FieldOffset(Offset = "0x80")]
    private AssetCachedSpawner assetCachedSpawner;
    [Token(Token = "0x400E1CB")]
    [FieldOffset(Offset = "0x88")]
    private QuestDetailPopup questDetailPopup;
    [Token(Token = "0x400E1CC")]
    [FieldOffset(Offset = "0x90")]
    private bool needFadeOnInitialize;
    [Token(Token = "0x400E1CD")]
    [FieldOffset(Offset = "0x98")]
    private MapWorldManager mapManager;
    [Token(Token = "0x400E1CE")]
    private const int MAP_WORLD_RESOURCE_ID = 1001;
    [Token(Token = "0x400E1CF")]
    [FieldOffset(Offset = "0xA0")]
    private int dotCharaStyleId;

    [Token(Token = "0x6014693")]
    [Address(RVA = "0x188C2A8", Offset = "0x188C2A8", VA = "0x188C2A8")]
    public static void ChangeScene(QuestTypeEnum questType, int questId, bool needFade = false)
    {
    }

    [Token(Token = "0x6014694")]
    [Address(RVA = "0x188C5C4", Offset = "0x188C5C4", VA = "0x188C5C4", Slot = "6")]
    public override void Initialize(ChangeSceneParameter param = null)
    {
    }

    [Token(Token = "0x6014695")]
    [Address(RVA = "0x188D114", Offset = "0x188D114", VA = "0x188D114", Slot = "7")]
    public override IEnumerator InitializeAsync() => (IEnumerator) null;

    [Token(Token = "0x6014696")]
    [Address(RVA = "0x188D1A4", Offset = "0x188D1A4", VA = "0x188D1A4")]
    private void OnEventQuestSelectAction(int questIdx)
    {
    }

    [Token(Token = "0x6014697")]
    [Address(RVA = "0x188D1BC", Offset = "0x188D1BC", VA = "0x188D1BC")]
    private void OnDecidedQuest(QuestInfo info)
    {
    }

    [Token(Token = "0x6014698")]
    [Address(RVA = "0x188D3B4", Offset = "0x188D3B4", VA = "0x188D3B4")]
    private void OnDecidedQuestStageBack()
    {
    }

    [Token(Token = "0x6014699")]
    [Address(RVA = "0x188D5C0", Offset = "0x188D5C0", VA = "0x188D5C0")]
    private void OnDecidedCallback(string s)
    {
    }

    [Token(Token = "0x601469A")]
    [Address(RVA = "0x188D704", Offset = "0x188D704", VA = "0x188D704")]
    public void OnOpenGlobaleMenu()
    {
    }

    [Token(Token = "0x601469B")]
    [Address(RVA = "0x188DC54", Offset = "0x188DC54", VA = "0x188DC54")]
    private void Update()
    {
    }

    [Token(Token = "0x601469C")]
    [Address(RVA = "0x188DC70", Offset = "0x188DC70", VA = "0x188DC70")]
    private void OnOpenDetail(QuestInfo info)
    {
    }

    [Token(Token = "0x601469D")]
    [Address(RVA = "0x188DC90", Offset = "0x188DC90", VA = "0x188DC90")]
    private IEnumerator OpenQuestDetailPopup(QuestInfo info) => (IEnumerator) null;

    [Token(Token = "0x601469E")]
    [Address(RVA = "0x188DD30", Offset = "0x188DD30", VA = "0x188DD30", Slot = "26")]
    public override IEnumerator OnBackSceneAsync() => (IEnumerator) null;

    [Token(Token = "0x601469F")]
    [Address(RVA = "0x188DDC0", Offset = "0x188DDC0", VA = "0x188DDC0", Slot = "22")]
    public override IEnumerator DisableEffect() => (IEnumerator) null;

    [Token(Token = "0x60146A0")]
    [Address(RVA = "0x188DE50", Offset = "0x188DE50", VA = "0x188DE50")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x60146A1")]
    [Address(RVA = "0x188DF14", Offset = "0x188DF14", VA = "0x188DF14")]
    public QuestSelectSubScene()
    {
    }
  }
}
