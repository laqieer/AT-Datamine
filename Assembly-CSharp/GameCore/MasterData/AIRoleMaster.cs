// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.AIRoleMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000DCF")]
  [Serializable]
  public sealed class AIRoleMaster : BaseMaster<AIRoleData>
  {
    [Token(Token = "0x6005451")]
    [Address(RVA = "0x3AA44EC", Offset = "0x3AA44EC", VA = "0x3AA44EC")]
    public IReadOnlyDictionary<int, AIRoleData> GetEntities()
    {
      return (IReadOnlyDictionary<int, AIRoleData>) null;
    }

    [Token(Token = "0x6005452")]
    [Address(RVA = "0x3AA44F4", Offset = "0x3AA44F4", VA = "0x3AA44F4", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6005453")]
    [Address(RVA = "0x3AA4554", Offset = "0x3AA4554", VA = "0x3AA4554", Slot = "5")]
    protected override AIRoleData LoadEntity(IMasterDataReader reader) => (AIRoleData) null;

    [Token(Token = "0x6005454")]
    [Address(RVA = "0x3AA45AC", Offset = "0x3AA45AC", VA = "0x3AA45AC")]
    public IReadOnlyCollection<AIRoleData> GetAIRoleDatas()
    {
      return (IReadOnlyCollection<AIRoleData>) null;
    }

    [Token(Token = "0x6005455")]
    [Address(RVA = "0x3AA45FC", Offset = "0x3AA45FC", VA = "0x3AA45FC")]
    public AIRoleMaster()
    {
    }
  }
}
