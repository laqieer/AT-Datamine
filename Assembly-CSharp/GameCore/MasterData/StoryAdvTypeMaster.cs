// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StoryAdvTypeMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000DCD")]
  [Serializable]
  public sealed class StoryAdvTypeMaster : BaseMaster<StoryAdvTypeData>
  {
    [Token(Token = "0x6005449")]
    [Address(RVA = "0x3AA4100", Offset = "0x3AA4100", VA = "0x3AA4100")]
    public IReadOnlyDictionary<int, StoryAdvTypeData> GetEntities()
    {
      return (IReadOnlyDictionary<int, StoryAdvTypeData>) null;
    }

    [Token(Token = "0x600544A")]
    [Address(RVA = "0x3AA4108", Offset = "0x3AA4108", VA = "0x3AA4108", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x600544B")]
    [Address(RVA = "0x3AA4168", Offset = "0x3AA4168", VA = "0x3AA4168", Slot = "5")]
    protected override StoryAdvTypeData LoadEntity(IMasterDataReader reader)
    {
      return (StoryAdvTypeData) null;
    }

    [Token(Token = "0x600544C")]
    [Address(RVA = "0x3AA41C0", Offset = "0x3AA41C0", VA = "0x3AA41C0")]
    public StoryAdvTypeMaster()
    {
    }
  }
}
