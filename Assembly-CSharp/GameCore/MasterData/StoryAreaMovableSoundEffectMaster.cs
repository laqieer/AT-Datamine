// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StoryAreaMovableSoundEffectMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x20011CF")]
  [Serializable]
  public sealed class StoryAreaMovableSoundEffectMaster : BaseMaster<StoryAreaMovableSoundEffectData>
  {
    [Token(Token = "0x40055A6")]
    [FieldOffset(Offset = "0x18")]
    private Dictionary<int, List<StoryAreaMovableSoundEffectData>> groupDic;

    [Token(Token = "0x60065E7")]
    [Address(RVA = "0x4D20584", Offset = "0x4D20584", VA = "0x4D20584")]
    public IReadOnlyDictionary<int, StoryAreaMovableSoundEffectData> GetEntities()
    {
      return (IReadOnlyDictionary<int, StoryAreaMovableSoundEffectData>) null;
    }

    [Token(Token = "0x60065E8")]
    [Address(RVA = "0x4D2058C", Offset = "0x4D2058C", VA = "0x4D2058C", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x60065E9")]
    [Address(RVA = "0x4D20644", Offset = "0x4D20644", VA = "0x4D20644", Slot = "5")]
    protected override StoryAreaMovableSoundEffectData LoadEntity(IMasterDataReader reader)
    {
      return (StoryAreaMovableSoundEffectData) null;
    }

    [Token(Token = "0x60065EA")]
    [Address(RVA = "0x4D205F4", Offset = "0x4D205F4", VA = "0x4D205F4")]
    private void OnAwakeLoading()
    {
    }

    [Token(Token = "0x60065EB")]
    [Address(RVA = "0x4D206B4", Offset = "0x4D206B4", VA = "0x4D206B4")]
    private void OnLoadEntity(StoryAreaMovableSoundEffectData entity)
    {
    }

    [Token(Token = "0x60065EC")]
    [Address(RVA = "0x4D20830", Offset = "0x4D20830", VA = "0x4D20830")]
    public int GetSoundObjectID(int groupLabel, int mobGroupPatternID) => new int();

    [Token(Token = "0x60065ED")]
    [Address(RVA = "0x4D20950", Offset = "0x4D20950", VA = "0x4D20950")]
    public StoryAreaMovableSoundEffectMaster()
    {
    }
  }
}
