// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StoryMainHardSelectConditionDescriptionMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x200115A")]
  [Serializable]
  public sealed class StoryMainHardSelectConditionDescriptionMaster : 
    BaseMaster<StoryMainHardSelectConditionDescriptionData>
  {
    [Token(Token = "0x60063C6")]
    [Address(RVA = "0x4AEB2C0", Offset = "0x4AEB2C0", VA = "0x4AEB2C0")]
    public IReadOnlyDictionary<int, StoryMainHardSelectConditionDescriptionData> GetEntities()
    {
      return (IReadOnlyDictionary<int, StoryMainHardSelectConditionDescriptionData>) null;
    }

    [Token(Token = "0x60063C7")]
    [Address(RVA = "0x4AEB2C8", Offset = "0x4AEB2C8", VA = "0x4AEB2C8", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x60063C8")]
    [Address(RVA = "0x4AEB328", Offset = "0x4AEB328", VA = "0x4AEB328", Slot = "5")]
    protected override StoryMainHardSelectConditionDescriptionData LoadEntity(
      IMasterDataReader reader)
    {
      return (StoryMainHardSelectConditionDescriptionData) null;
    }

    [Token(Token = "0x60063C9")]
    [Address(RVA = "0x4AEB380", Offset = "0x4AEB380", VA = "0x4AEB380")]
    public StoryMainHardSelectConditionDescriptionMaster()
    {
    }
  }
}
