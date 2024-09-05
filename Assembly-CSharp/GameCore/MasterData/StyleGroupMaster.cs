// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StyleGroupMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x20013B6")]
  [Serializable]
  public sealed class StyleGroupMaster : BaseMaster<StyleGroupData>
  {
    [Token(Token = "0x6006EB6")]
    [Address(RVA = "0x47092D4", Offset = "0x47092D4", VA = "0x47092D4")]
    public IReadOnlyDictionary<int, StyleGroupData> GetEntities()
    {
      return (IReadOnlyDictionary<int, StyleGroupData>) null;
    }

    [Token(Token = "0x6006EB7")]
    [Address(RVA = "0x47092DC", Offset = "0x47092DC", VA = "0x47092DC", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6006EB8")]
    [Address(RVA = "0x470933C", Offset = "0x470933C", VA = "0x470933C", Slot = "5")]
    protected override StyleGroupData LoadEntity(IMasterDataReader reader) => (StyleGroupData) null;

    [Token(Token = "0x6006EB9")]
    [Address(RVA = "0x4709394", Offset = "0x4709394", VA = "0x4709394")]
    public StyleGroupMaster()
    {
    }
  }
}
