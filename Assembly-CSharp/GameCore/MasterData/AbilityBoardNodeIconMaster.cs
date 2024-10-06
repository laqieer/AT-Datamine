// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.AbilityBoardNodeIconMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001350")]
  [Serializable]
  public sealed class AbilityBoardNodeIconMaster : BaseMaster<AbilityBoardNodeIconData>
  {
    [Token(Token = "0x6006CDA")]
    [Address(RVA = "0x46F7738", Offset = "0x46F7738", VA = "0x46F7738")]
    public IReadOnlyDictionary<int, AbilityBoardNodeIconData> GetEntities()
    {
      return (IReadOnlyDictionary<int, AbilityBoardNodeIconData>) null;
    }

    [Token(Token = "0x6006CDB")]
    [Address(RVA = "0x46F7740", Offset = "0x46F7740", VA = "0x46F7740", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6006CDC")]
    [Address(RVA = "0x46F77A0", Offset = "0x46F77A0", VA = "0x46F77A0", Slot = "5")]
    protected override AbilityBoardNodeIconData LoadEntity(IMasterDataReader reader)
    {
      return (AbilityBoardNodeIconData) null;
    }

    [Token(Token = "0x6006CDD")]
    [Address(RVA = "0x46F77F8", Offset = "0x46F77F8", VA = "0x46F77F8")]
    public AbilityBoardNodeIconMaster()
    {
    }
  }
}
