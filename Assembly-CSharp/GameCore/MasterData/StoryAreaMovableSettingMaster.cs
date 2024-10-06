// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StoryAreaMovableSettingMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x20011CD")]
  [Serializable]
  public sealed class StoryAreaMovableSettingMaster : BaseMaster<StoryAreaMovableSettingData>
  {
    [Token(Token = "0x4005596")]
    [FieldOffset(Offset = "0x18")]
    private Dictionary<int, List<StoryAreaMovableSettingData>> groupDic;

    [Token(Token = "0x60065DB")]
    [Address(RVA = "0x4D1F93C", Offset = "0x4D1F93C", VA = "0x4D1F93C")]
    public IReadOnlyDictionary<int, StoryAreaMovableSettingData> GetEntities()
    {
      return (IReadOnlyDictionary<int, StoryAreaMovableSettingData>) null;
    }

    [Token(Token = "0x60065DC")]
    [Address(RVA = "0x4D1F944", Offset = "0x4D1F944", VA = "0x4D1F944", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x60065DD")]
    [Address(RVA = "0x4D1F9FC", Offset = "0x4D1F9FC", VA = "0x4D1F9FC", Slot = "5")]
    protected override StoryAreaMovableSettingData LoadEntity(IMasterDataReader reader)
    {
      return (StoryAreaMovableSettingData) null;
    }

    [Token(Token = "0x60065DE")]
    [Address(RVA = "0x4D1F9AC", Offset = "0x4D1F9AC", VA = "0x4D1F9AC")]
    private void OnAwakeLoading()
    {
    }

    [Token(Token = "0x60065DF")]
    [Address(RVA = "0x4D1FA6C", Offset = "0x4D1FA6C", VA = "0x4D1FA6C")]
    private void OnLoadEntity(StoryAreaMovableSettingData entity)
    {
    }

    [Token(Token = "0x60065E0")]
    [Address(RVA = "0x4D1FBE8", Offset = "0x4D1FBE8", VA = "0x4D1FBE8")]
    public List<StoryAreaMovableSettingData> GetSettingDataList(int label)
    {
      return (List<StoryAreaMovableSettingData>) null;
    }

    [Token(Token = "0x60065E1")]
    [Address(RVA = "0x4D1FCA4", Offset = "0x4D1FCA4", VA = "0x4D1FCA4")]
    public StoryAreaMovableSettingMaster()
    {
    }
  }
}
