// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StoryCharacterSwitchingPatternMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x20011EC")]
  [Serializable]
  public sealed class StoryCharacterSwitchingPatternMaster : 
    BaseMaster<StoryCharacterSwitchingPatternData>
  {
    [Token(Token = "0x40055FD")]
    [FieldOffset(Offset = "0x18")]
    private Dictionary<int, StoryCharacterSwitchingPatternData> patternTable;

    [Token(Token = "0x600665C")]
    [Address(RVA = "0x4D24E70", Offset = "0x4D24E70", VA = "0x4D24E70")]
    public IReadOnlyDictionary<int, StoryCharacterSwitchingPatternData> GetEntities()
    {
      return (IReadOnlyDictionary<int, StoryCharacterSwitchingPatternData>) null;
    }

    [Token(Token = "0x600665D")]
    [Address(RVA = "0x4D24E78", Offset = "0x4D24E78", VA = "0x4D24E78", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x600665E")]
    [Address(RVA = "0x4D24F30", Offset = "0x4D24F30", VA = "0x4D24F30", Slot = "5")]
    protected override StoryCharacterSwitchingPatternData LoadEntity(IMasterDataReader reader)
    {
      return (StoryCharacterSwitchingPatternData) null;
    }

    [Token(Token = "0x600665F")]
    [Address(RVA = "0x4D24EE0", Offset = "0x4D24EE0", VA = "0x4D24EE0")]
    private void OnAwakeLoading()
    {
    }

    [Token(Token = "0x6006660")]
    [Address(RVA = "0x4D24FA0", Offset = "0x4D24FA0", VA = "0x4D24FA0")]
    private void OnLoadEntity(StoryCharacterSwitchingPatternData entity)
    {
    }

    [Token(Token = "0x6006661")]
    [Address(RVA = "0x4D25000", Offset = "0x4D25000", VA = "0x4D25000")]
    public StoryCharacterSwitchingPatternData GetData(int id)
    {
      return (StoryCharacterSwitchingPatternData) null;
    }

    [Token(Token = "0x6006662")]
    [Address(RVA = "0x4D25058", Offset = "0x4D25058", VA = "0x4D25058")]
    public StoryCharacterSwitchingPatternMaster()
    {
    }
  }
}
