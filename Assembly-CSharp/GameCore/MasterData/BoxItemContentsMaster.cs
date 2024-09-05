// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.BoxItemContentsMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001044")]
  [Serializable]
  public sealed class BoxItemContentsMaster : BaseMaster<BoxItemContentsData>
  {
    [Token(Token = "0x6005E79")]
    [Address(RVA = "0x28C3C98", Offset = "0x28C3C98", VA = "0x28C3C98")]
    public IReadOnlyDictionary<int, BoxItemContentsData> GetEntities()
    {
      return (IReadOnlyDictionary<int, BoxItemContentsData>) null;
    }

    [Token(Token = "0x6005E7A")]
    [Address(RVA = "0x28C3CA0", Offset = "0x28C3CA0", VA = "0x28C3CA0", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6005E7B")]
    [Address(RVA = "0x28C3D00", Offset = "0x28C3D00", VA = "0x28C3D00", Slot = "5")]
    protected override BoxItemContentsData LoadEntity(IMasterDataReader reader)
    {
      return (BoxItemContentsData) null;
    }

    [Token(Token = "0x6005E7C")]
    [Address(RVA = "0x28C3D58", Offset = "0x28C3D58", VA = "0x28C3D58")]
    public BoxItemContentsMaster()
    {
    }
  }
}
