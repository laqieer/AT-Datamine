// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.LevelUpParameterMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x200138F")]
  [Serializable]
  public sealed class LevelUpParameterMaster : BaseMaster<LevelUpParameterData>
  {
    [Token(Token = "0x6006DF8")]
    [Address(RVA = "0x470111C", Offset = "0x470111C", VA = "0x470111C")]
    public IReadOnlyDictionary<int, LevelUpParameterData> GetEntities()
    {
      return (IReadOnlyDictionary<int, LevelUpParameterData>) null;
    }

    [Token(Token = "0x6006DF9")]
    [Address(RVA = "0x4701124", Offset = "0x4701124", VA = "0x4701124", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6006DFA")]
    [Address(RVA = "0x4701184", Offset = "0x4701184", VA = "0x4701184", Slot = "5")]
    protected override LevelUpParameterData LoadEntity(IMasterDataReader reader)
    {
      return (LevelUpParameterData) null;
    }

    [Token(Token = "0x6006DFB")]
    [Address(RVA = "0x47011DC", Offset = "0x47011DC", VA = "0x47011DC")]
    public LevelUpParameterMaster()
    {
    }
  }
}
