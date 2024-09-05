// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StoryFreeActionTimeElapseLayoutMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x200128C")]
  [Serializable]
  public sealed class StoryFreeActionTimeElapseLayoutMaster : 
    BaseMaster<StoryFreeActionTimeElapseLayoutData>
  {
    [Token(Token = "0x6006969")]
    [Address(RVA = "0x48CFF74", Offset = "0x48CFF74", VA = "0x48CFF74")]
    public IReadOnlyDictionary<int, StoryFreeActionTimeElapseLayoutData> GetEntities()
    {
      return (IReadOnlyDictionary<int, StoryFreeActionTimeElapseLayoutData>) null;
    }

    [Token(Token = "0x600696A")]
    [Address(RVA = "0x48CFF7C", Offset = "0x48CFF7C", VA = "0x48CFF7C", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x600696B")]
    [Address(RVA = "0x48CFFDC", Offset = "0x48CFFDC", VA = "0x48CFFDC", Slot = "5")]
    protected override StoryFreeActionTimeElapseLayoutData LoadEntity(IMasterDataReader reader)
    {
      return (StoryFreeActionTimeElapseLayoutData) null;
    }

    [Token(Token = "0x600696C")]
    [Address(RVA = "0x48D0034", Offset = "0x48D0034", VA = "0x48D0034")]
    public StoryFreeActionTimeElapseLayoutMaster()
    {
    }
  }
}
