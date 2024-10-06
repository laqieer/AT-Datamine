// Decompiled with JetBrains decompiler
// Type: Story.Chart.StructureLoader
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.DLC;
using GameCore.MasterData;
using Il2CppDummyDll;
using Story.Chart.StructureSave;
using System.Collections;
using System.Collections.Generic;

#nullable disable
namespace Story.Chart
{
  [Token(Token = "0x20006E8")]
  public class StructureLoader
  {
    [Token(Token = "0x4002091")]
    [FieldOffset(Offset = "0x10")]
    private Dictionary<int, Chapter> chapters;
    [Token(Token = "0x4002092")]
    private const string AB_LABEL = "story_chart_scriptableobjects";
    [Token(Token = "0x4002093")]
    [FieldOffset(Offset = "0x18")]
    private LoadedAssetBundle loadedAB;

    [Token(Token = "0x170005D4")]
    public IEnumerable<Chapter> Chapters
    {
      [Token(Token = "0x6002722"), Address(RVA = "0x366C3BC", Offset = "0x366C3BC", VA = "0x366C3BC")] get
      {
        return (IEnumerable<Chapter>) null;
      }
    }

    [Token(Token = "0x6002723")]
    [Address(RVA = "0x366B908", Offset = "0x366B908", VA = "0x366B908")]
    public Chapter GetChapter(int chapterID) => (Chapter) null;

    [Token(Token = "0x6002724")]
    [Address(RVA = "0x366B69C", Offset = "0x366B69C", VA = "0x366B69C")]
    public IEnumerator LoadAssetBundle() => (IEnumerator) null;

    [Token(Token = "0x6002725")]
    [Address(RVA = "0x366B704", Offset = "0x366B704", VA = "0x366B704")]
    public bool TryLoad(int chapterID) => new bool();

    [Token(Token = "0x6002726")]
    [Address(RVA = "0x366C434", Offset = "0x366C434", VA = "0x366C434")]
    private void LoadInsternal(StoryChapterData chapter, ChartStructureScriptableObject structure)
    {
    }

    [Token(Token = "0x6002727")]
    [Address(RVA = "0x366B620", Offset = "0x366B620", VA = "0x366B620")]
    public StructureLoader()
    {
    }
  }
}
