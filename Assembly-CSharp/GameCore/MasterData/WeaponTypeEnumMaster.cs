// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.WeaponTypeEnumMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000F36")]
  [Serializable]
  public sealed class WeaponTypeEnumMaster : BaseMaster<WeaponTypeEnumData>
  {
    [Token(Token = "0x60059AD")]
    [Address(RVA = "0x3C339F0", Offset = "0x3C339F0", VA = "0x3C339F0")]
    public IReadOnlyDictionary<int, WeaponTypeEnumData> GetEntities()
    {
      return (IReadOnlyDictionary<int, WeaponTypeEnumData>) null;
    }

    [Token(Token = "0x60059AE")]
    [Address(RVA = "0x3C339F8", Offset = "0x3C339F8", VA = "0x3C339F8", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x60059AF")]
    [Address(RVA = "0x3C33A58", Offset = "0x3C33A58", VA = "0x3C33A58", Slot = "5")]
    protected override WeaponTypeEnumData LoadEntity(IMasterDataReader reader)
    {
      return (WeaponTypeEnumData) null;
    }

    [Token(Token = "0x60059B0")]
    [Address(RVA = "0x3C33AB0", Offset = "0x3C33AB0", VA = "0x3C33AB0")]
    public WeaponTypeEnumMaster()
    {
    }
  }
}
