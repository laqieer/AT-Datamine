// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.IntroChapterSequenceHomeTutorialSettingMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001035")]
  [Serializable]
  public sealed class IntroChapterSequenceHomeTutorialSettingMaster : 
    BaseMaster<IntroChapterSequenceHomeTutorialSettingData>
  {
    [Token(Token = "0x6005E34")]
    [Address(RVA = "0x279A8F4", Offset = "0x279A8F4", VA = "0x279A8F4")]
    public IReadOnlyDictionary<int, IntroChapterSequenceHomeTutorialSettingData> GetEntities()
    {
      return (IReadOnlyDictionary<int, IntroChapterSequenceHomeTutorialSettingData>) null;
    }

    [Token(Token = "0x6005E35")]
    [Address(RVA = "0x279A8FC", Offset = "0x279A8FC", VA = "0x279A8FC", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6005E36")]
    [Address(RVA = "0x279A95C", Offset = "0x279A95C", VA = "0x279A95C", Slot = "5")]
    protected override IntroChapterSequenceHomeTutorialSettingData LoadEntity(
      IMasterDataReader reader)
    {
      return (IntroChapterSequenceHomeTutorialSettingData) null;
    }

    [Token(Token = "0x6005E37")]
    [Address(RVA = "0x279A9B4", Offset = "0x279A9B4", VA = "0x279A9B4")]
    public IntroChapterSequenceHomeTutorialSettingMaster()
    {
    }
  }
}
