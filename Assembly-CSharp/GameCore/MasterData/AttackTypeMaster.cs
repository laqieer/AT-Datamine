// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.AttackTypeMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000EB5")]
  [Serializable]
  public sealed class AttackTypeMaster : BaseMaster<AttackTypeData>
  {
    [Token(Token = "0x6005921")]
    [Address(RVA = "0x3C30600", Offset = "0x3C30600", VA = "0x3C30600")]
    public IReadOnlyDictionary<int, AttackTypeData> GetEntities()
    {
      return (IReadOnlyDictionary<int, AttackTypeData>) null;
    }

    [Token(Token = "0x6005922")]
    [Address(RVA = "0x3C30608", Offset = "0x3C30608", VA = "0x3C30608", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6005923")]
    [Address(RVA = "0x3C30668", Offset = "0x3C30668", VA = "0x3C30668", Slot = "5")]
    protected override AttackTypeData LoadEntity(IMasterDataReader reader) => (AttackTypeData) null;

    [Token(Token = "0x6005924")]
    [Address(RVA = "0x3C306C0", Offset = "0x3C306C0", VA = "0x3C306C0")]
    public AttackTypeMaster()
    {
    }
  }
}
