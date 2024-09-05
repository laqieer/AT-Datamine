// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StoryCharacterBuildDataMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x20011E8")]
  [Serializable]
  public sealed class StoryCharacterBuildDataMaster : BaseMaster<StoryCharacterBuildDataData>
  {
    [Token(Token = "0x6006651")]
    [Address(RVA = "0x4D245EC", Offset = "0x4D245EC", VA = "0x4D245EC")]
    public IReadOnlyDictionary<int, StoryCharacterBuildDataData> GetEntities()
    {
      return (IReadOnlyDictionary<int, StoryCharacterBuildDataData>) null;
    }

    [Token(Token = "0x6006652")]
    [Address(RVA = "0x4D245F4", Offset = "0x4D245F4", VA = "0x4D245F4", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6006653")]
    [Address(RVA = "0x4D24654", Offset = "0x4D24654", VA = "0x4D24654", Slot = "5")]
    protected override StoryCharacterBuildDataData LoadEntity(IMasterDataReader reader)
    {
      return (StoryCharacterBuildDataData) null;
    }

    [Token(Token = "0x6006654")]
    [Address(RVA = "0x4D246AC", Offset = "0x4D246AC", VA = "0x4D246AC")]
    public StoryCharacterBuildDataMaster()
    {
    }
  }
}
