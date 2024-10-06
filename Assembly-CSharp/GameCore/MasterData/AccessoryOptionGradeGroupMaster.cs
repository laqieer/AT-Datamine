// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.AccessoryOptionGradeGroupMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000F47")]
  [Serializable]
  public sealed class AccessoryOptionGradeGroupMaster : BaseMaster<AccessoryOptionGradeGroupData>
  {
    [Token(Token = "0x6005A07")]
    [Address(RVA = "0x3C3AE04", Offset = "0x3C3AE04", VA = "0x3C3AE04")]
    public IReadOnlyDictionary<int, AccessoryOptionGradeGroupData> GetEntities()
    {
      return (IReadOnlyDictionary<int, AccessoryOptionGradeGroupData>) null;
    }

    [Token(Token = "0x6005A08")]
    [Address(RVA = "0x3C3AE0C", Offset = "0x3C3AE0C", VA = "0x3C3AE0C", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6005A09")]
    [Address(RVA = "0x3C3AE6C", Offset = "0x3C3AE6C", VA = "0x3C3AE6C", Slot = "5")]
    protected override AccessoryOptionGradeGroupData LoadEntity(IMasterDataReader reader)
    {
      return (AccessoryOptionGradeGroupData) null;
    }

    [Token(Token = "0x6005A0A")]
    [Address(RVA = "0x3C3AEC4", Offset = "0x3C3AEC4", VA = "0x3C3AEC4")]
    public AccessoryOptionGradeGroupMaster()
    {
    }
  }
}
