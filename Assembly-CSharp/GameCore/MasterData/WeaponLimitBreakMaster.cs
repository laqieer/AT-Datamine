// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.WeaponLimitBreakMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000F77")]
  [Serializable]
  public sealed class WeaponLimitBreakMaster : BaseMaster<WeaponLimitBreakData>
  {
    [Token(Token = "0x6005AFB")]
    [Address(RVA = "0x277C5D0", Offset = "0x277C5D0", VA = "0x277C5D0")]
    public IReadOnlyDictionary<int, WeaponLimitBreakData> GetEntities()
    {
      return (IReadOnlyDictionary<int, WeaponLimitBreakData>) null;
    }

    [Token(Token = "0x6005AFC")]
    [Address(RVA = "0x277C5D8", Offset = "0x277C5D8", VA = "0x277C5D8", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6005AFD")]
    [Address(RVA = "0x277C638", Offset = "0x277C638", VA = "0x277C638", Slot = "5")]
    protected override WeaponLimitBreakData LoadEntity(IMasterDataReader reader)
    {
      return (WeaponLimitBreakData) null;
    }

    [Token(Token = "0x6005AFE")]
    [Address(RVA = "0x277C690", Offset = "0x277C690", VA = "0x277C690")]
    public WeaponLimitBreakMaster()
    {
    }
  }
}
