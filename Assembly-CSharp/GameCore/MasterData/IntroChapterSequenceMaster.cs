// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.IntroChapterSequenceMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001037")]
  [Serializable]
  public sealed class IntroChapterSequenceMaster : BaseMaster<IntroChapterSequenceData>
  {
    [Token(Token = "0x4005069")]
    [FieldOffset(Offset = "0x18")]
    private List<IntroChapterSequenceData> progressOrderList;
    [Token(Token = "0x400506A")]
    [FieldOffset(Offset = "0x20")]
    private int maxSequenceProgressValue;
    [Token(Token = "0x400506B")]
    [FieldOffset(Offset = "0x24")]
    private int homeTutorialSequenceProgressValue;
    [Token(Token = "0x400506C")]
    [FieldOffset(Offset = "0x28")]
    private int freeMoveTutorialSequenceProgressValue;

    [Token(Token = "0x6005E3C")]
    [Address(RVA = "0x279AD70", Offset = "0x279AD70", VA = "0x279AD70")]
    public IReadOnlyDictionary<int, IntroChapterSequenceData> GetEntities()
    {
      return (IReadOnlyDictionary<int, IntroChapterSequenceData>) null;
    }

    [Token(Token = "0x6005E3D")]
    [Address(RVA = "0x279AD78", Offset = "0x279AD78", VA = "0x279AD78", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6005E3E")]
    [Address(RVA = "0x279B19C", Offset = "0x279B19C", VA = "0x279B19C", Slot = "5")]
    protected override IntroChapterSequenceData LoadEntity(IMasterDataReader reader)
    {
      return (IntroChapterSequenceData) null;
    }

    [Token(Token = "0x6005E3F")]
    [Address(RVA = "0x279ADE0", Offset = "0x279ADE0", VA = "0x279ADE0")]
    private void OnCompletedLoading()
    {
    }

    [Token(Token = "0x6005E40")]
    [Address(RVA = "0x279B1F4", Offset = "0x279B1F4", VA = "0x279B1F4")]
    public IReadOnlyList<IntroChapterSequenceData> GetSequenceProgressOrderList()
    {
      return (IReadOnlyList<IntroChapterSequenceData>) null;
    }

    [Token(Token = "0x6005E41")]
    [Address(RVA = "0x279B1FC", Offset = "0x279B1FC", VA = "0x279B1FC")]
    public int GetMaxSequenceProgressValue() => new int();

    [Token(Token = "0x6005E42")]
    [Address(RVA = "0x279B204", Offset = "0x279B204", VA = "0x279B204")]
    public int GetHomeTutorialSequenceProgressValue() => new int();

    [Token(Token = "0x6005E43")]
    [Address(RVA = "0x279B20C", Offset = "0x279B20C", VA = "0x279B20C")]
    public bool IsNeedMainAssetDownload(int tagetProgress) => new bool();

    [Token(Token = "0x6005E44")]
    [Address(RVA = "0x279B540", Offset = "0x279B540", VA = "0x279B540")]
    public int GetFreeMoveTutorialSequenceProgressValue() => new int();

    [Token(Token = "0x6005E45")]
    [Address(RVA = "0x279B548", Offset = "0x279B548", VA = "0x279B548")]
    public IntroChapterSequenceMaster()
    {
    }
  }
}
