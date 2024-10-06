// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.AbilityBoardNodeMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001352")]
  [Serializable]
  public sealed class AbilityBoardNodeMaster : BaseMaster<AbilityBoardNodeData>
  {
    [Token(Token = "0x6006CE2")]
    [Address(RVA = "0x46F79E0", Offset = "0x46F79E0", VA = "0x46F79E0")]
    public IReadOnlyDictionary<int, AbilityBoardNodeData> GetEntities()
    {
      return (IReadOnlyDictionary<int, AbilityBoardNodeData>) null;
    }

    [Token(Token = "0x6006CE3")]
    [Address(RVA = "0x46F79E8", Offset = "0x46F79E8", VA = "0x46F79E8", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6006CE4")]
    [Address(RVA = "0x46F7A48", Offset = "0x46F7A48", VA = "0x46F7A48", Slot = "5")]
    protected override AbilityBoardNodeData LoadEntity(IMasterDataReader reader)
    {
      return (AbilityBoardNodeData) null;
    }

    [Token(Token = "0x6006CE5")]
    [Address(RVA = "0x46F7AA0", Offset = "0x46F7AA0", VA = "0x46F7AA0")]
    public AbilityBoardNodeMaster()
    {
    }
  }
}
