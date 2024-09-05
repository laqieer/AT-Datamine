// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StoryRouteMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x20012EF")]
  [Serializable]
  public sealed class StoryRouteMaster : BaseMaster<StoryRouteData>
  {
    [Token(Token = "0x6006B1D")]
    [Address(RVA = "0x48DF270", Offset = "0x48DF270", VA = "0x48DF270")]
    public IReadOnlyDictionary<int, StoryRouteData> GetEntities()
    {
      return (IReadOnlyDictionary<int, StoryRouteData>) null;
    }

    [Token(Token = "0x6006B1E")]
    [Address(RVA = "0x48DF278", Offset = "0x48DF278", VA = "0x48DF278", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6006B1F")]
    [Address(RVA = "0x48DF2D8", Offset = "0x48DF2D8", VA = "0x48DF2D8", Slot = "5")]
    protected override StoryRouteData LoadEntity(IMasterDataReader reader) => (StoryRouteData) null;

    [Token(Token = "0x6006B20")]
    [Address(RVA = "0x48DF330", Offset = "0x48DF330", VA = "0x48DF330")]
    public StoryRouteMaster()
    {
    }
  }
}
