// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.EventQuest.EventHomeSubScene
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using GameCore.MasterData;
using GameCore.Scene;
using GameCore.UIControls;
using Il2CppDummyDll;
using Scenes.OutGame.QuestSelect;
using StaqData;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace Scenes.OutGame.EventQuest
{
  [Token(Token = "0x2003658")]
  public class EventHomeSubScene : SubScene
  {
    [Token(Token = "0x400EC71")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private RectTransform rtsQuestSelectCanvas;
    [Token(Token = "0x400EC72")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    private UISafeAreaInsets questSelectSafeArea;
    [Token(Token = "0x400EC73")]
    [FieldOffset(Offset = "0x68")]
    private Scenes.OutGame.EventQuest.EventQuest eventQuestSelect;
    [Token(Token = "0x400EC74")]
    [FieldOffset(Offset = "0x70")]
    private QuestSelectBg questSelectBg;
    [Token(Token = "0x400EC75")]
    [FieldOffset(Offset = "0x78")]
    private IList<QuestInfo> questInfoList;
    [Token(Token = "0x400EC76")]
    [FieldOffset(Offset = "0x80")]
    private string mapCategoryName;
    [Token(Token = "0x400EC77")]
    [FieldOffset(Offset = "0x88")]
    private bool isMapLoaded;
    [Token(Token = "0x400EC78")]
    [FieldOffset(Offset = "0x8C")]
    private QuestTypeEnum questTypeEnum;
    [Token(Token = "0x400EC79")]
    [FieldOffset(Offset = "0x90")]
    private RenderTexture dotUnitRenderTexture;
    [Token(Token = "0x400EC7A")]
    [FieldOffset(Offset = "0x98")]
    private int nowChapter;
    [Token(Token = "0x400EC7B")]
    [FieldOffset(Offset = "0xA0")]
    private QuestAssetLoader assetLoader;
    [Token(Token = "0x400EC7C")]
    [FieldOffset(Offset = "0xA8")]
    private AssetCachedSpawner assetCachedSpawner;
    [Token(Token = "0x400EC7D")]
    [FieldOffset(Offset = "0xB0")]
    private QuestDetailPopup questDetailPopup;

    [Token(Token = "0x6015648")]
    [Address(RVA = "0x18DAC08", Offset = "0x18DAC08", VA = "0x18DAC08", Slot = "6")]
    public override void Initialize(ChangeSceneParameter param = null)
    {
    }

    [Token(Token = "0x6015649")]
    [Address(RVA = "0x18DACEC", Offset = "0x18DACEC", VA = "0x18DACEC")]
    public void LoadFreeQusetMap(int chapter, bool isAnimation)
    {
    }

    [Token(Token = "0x601564A")]
    [Address(RVA = "0x18DAD10", Offset = "0x18DAD10", VA = "0x18DAD10")]
    private IEnumerator LoadFreeQuestMapInternal(int chapter, bool isAnimation)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x601564B")]
    [Address(RVA = "0x18DADBC", Offset = "0x18DADBC", VA = "0x18DADBC")]
    private void CreateDotUnit(int chapterId)
    {
    }

    [Token(Token = "0x601564C")]
    [Address(RVA = "0x18DAF24", Offset = "0x18DAF24", VA = "0x18DAF24", Slot = "7")]
    public override IEnumerator InitializeAsync() => (IEnumerator) null;

    [Token(Token = "0x601564D")]
    [Address(RVA = "0x18DAFB4", Offset = "0x18DAFB4", VA = "0x18DAFB4")]
    private void Update()
    {
    }

    [Token(Token = "0x601564E")]
    [Address(RVA = "0x18DAFD0", Offset = "0x18DAFD0", VA = "0x18DAFD0")]
    private void CreateBackground()
    {
    }

    [Token(Token = "0x601564F")]
    [Address(RVA = "0x18DB2AC", Offset = "0x18DB2AC", VA = "0x18DB2AC")]
    private void CreateEventQuestSelect(GameObject createdListitemObj)
    {
    }

    [Token(Token = "0x6015650")]
    [Address(RVA = "0x18DB824", Offset = "0x18DB824", VA = "0x18DB824")]
    public void SetupMapIconPosition(IList<QuestInfo> questInfos)
    {
    }

    [Token(Token = "0x6015651")]
    [Address(RVA = "0x18DB994", Offset = "0x18DB994", VA = "0x18DB994")]
    public void OnClickToChapter(StoryChapterData chapterData)
    {
    }

    [Token(Token = "0x6015652")]
    [Address(RVA = "0x18DBBD0", Offset = "0x18DBBD0", VA = "0x18DBBD0")]
    public void OnClickToQuestDetail(int index)
    {
    }

    [Token(Token = "0x6015653")]
    [Address(RVA = "0x18DBBF0", Offset = "0x18DBBF0", VA = "0x18DBBF0")]
    private IEnumerator OpenQuestDetailPopup(int index) => (IEnumerator) null;

    [Token(Token = "0x6015654")]
    [Address(RVA = "0x18DBC90", Offset = "0x18DBC90", VA = "0x18DBC90")]
    public void OnClickToQuestListItem(int index)
    {
    }

    [Token(Token = "0x6015655")]
    [Address(RVA = "0x18DBCB4", Offset = "0x18DBCB4", VA = "0x18DBCB4")]
    private IEnumerator ChangeSceneByQuestPrepare(int questIndex, int mapIndex)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6015656")]
    [Address(RVA = "0x18DBD58", Offset = "0x18DBD58", VA = "0x18DBD58", Slot = "21")]
    public override IEnumerator EnableEffect() => (IEnumerator) null;

    [Token(Token = "0x6015657")]
    [Address(RVA = "0x18DBDE8", Offset = "0x18DBDE8", VA = "0x18DBDE8", Slot = "22")]
    public override IEnumerator DisableEffect() => (IEnumerator) null;

    [Token(Token = "0x6015658")]
    [Address(RVA = "0x18DBE78", Offset = "0x18DBE78", VA = "0x18DBE78", Slot = "26")]
    public override IEnumerator OnBackSceneAsync() => (IEnumerator) null;

    [Token(Token = "0x6015659")]
    [Address(RVA = "0x18DBF08", Offset = "0x18DBF08", VA = "0x18DBF08")]
    public void Reset()
    {
    }

    [Token(Token = "0x601565A")]
    [Address(RVA = "0x18DC044", Offset = "0x18DC044", VA = "0x18DC044")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x601565B")]
    [Address(RVA = "0x18DC1FC", Offset = "0x18DC1FC", VA = "0x18DC1FC")]
    public EventHomeSubScene()
    {
    }
  }
}
