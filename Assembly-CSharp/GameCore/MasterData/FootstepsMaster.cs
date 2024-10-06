// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.FootstepsMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000E92")]
  [Serializable]
  public sealed class FootstepsMaster : BaseMaster<FootstepsData>
  {
    [Token(Token = "0x60058A5")]
    [Address(RVA = "0x3C2CA74", Offset = "0x3C2CA74", VA = "0x3C2CA74")]
    public IReadOnlyDictionary<int, FootstepsData> GetEntities()
    {
      return (IReadOnlyDictionary<int, FootstepsData>) null;
    }

    [Token(Token = "0x60058A6")]
    [Address(RVA = "0x3C2CA7C", Offset = "0x3C2CA7C", VA = "0x3C2CA7C", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x60058A7")]
    [Address(RVA = "0x3C2CADC", Offset = "0x3C2CADC", VA = "0x3C2CADC", Slot = "5")]
    protected override FootstepsData LoadEntity(IMasterDataReader reader) => (FootstepsData) null;

    [Token(Token = "0x60058A8")]
    [Address(RVA = "0x3C2CB34", Offset = "0x3C2CB34", VA = "0x3C2CB34")]
    public FootstepsMaster()
    {
    }
  }
}
