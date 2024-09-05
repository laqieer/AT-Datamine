// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.IntroChapterSequenceFreeActionSettingMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001033")]
  [Serializable]
  public sealed class IntroChapterSequenceFreeActionSettingMaster : 
    BaseMaster<IntroChapterSequenceFreeActionSettingData>
  {
    [Token(Token = "0x6005E2C")]
    [Address(RVA = "0x279A39C", Offset = "0x279A39C", VA = "0x279A39C")]
    public IReadOnlyDictionary<int, IntroChapterSequenceFreeActionSettingData> GetEntities()
    {
      return (IReadOnlyDictionary<int, IntroChapterSequenceFreeActionSettingData>) null;
    }

    [Token(Token = "0x6005E2D")]
    [Address(RVA = "0x279A3A4", Offset = "0x279A3A4", VA = "0x279A3A4", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6005E2E")]
    [Address(RVA = "0x279A404", Offset = "0x279A404", VA = "0x279A404", Slot = "5")]
    protected override IntroChapterSequenceFreeActionSettingData LoadEntity(IMasterDataReader reader)
    {
      return (IntroChapterSequenceFreeActionSettingData) null;
    }

    [Token(Token = "0x6005E2F")]
    [Address(RVA = "0x279A45C", Offset = "0x279A45C", VA = "0x279A45C")]
    public IntroChapterSequenceFreeActionSettingMaster()
    {
    }
  }
}
