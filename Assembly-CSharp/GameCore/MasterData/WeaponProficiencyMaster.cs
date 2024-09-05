// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.WeaponProficiencyMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x200138B")]
  [Serializable]
  public sealed class WeaponProficiencyMaster : BaseMaster<WeaponProficiencyData>
  {
    [Token(Token = "0x6006DE7")]
    [Address(RVA = "0x4700B64", Offset = "0x4700B64", VA = "0x4700B64")]
    public IReadOnlyDictionary<int, WeaponProficiencyData> GetEntities()
    {
      return (IReadOnlyDictionary<int, WeaponProficiencyData>) null;
    }

    [Token(Token = "0x6006DE8")]
    [Address(RVA = "0x4700B6C", Offset = "0x4700B6C", VA = "0x4700B6C", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6006DE9")]
    [Address(RVA = "0x4700BCC", Offset = "0x4700BCC", VA = "0x4700BCC", Slot = "5")]
    protected override WeaponProficiencyData LoadEntity(IMasterDataReader reader)
    {
      return (WeaponProficiencyData) null;
    }

    [Token(Token = "0x6006DEA")]
    [Address(RVA = "0x4700C24", Offset = "0x4700C24", VA = "0x4700C24")]
    public WeaponProficiencyMaster()
    {
    }
  }
}
