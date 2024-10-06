// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.LandformTypeMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000EF5")]
  [Serializable]
  public sealed class LandformTypeMaster : BaseMaster<LandformTypeData>
  {
    [Token(Token = "0x6005962")]
    [Address(RVA = "0x3C31D0C", Offset = "0x3C31D0C", VA = "0x3C31D0C")]
    public IReadOnlyDictionary<int, LandformTypeData> GetEntities()
    {
      return (IReadOnlyDictionary<int, LandformTypeData>) null;
    }

    [Token(Token = "0x6005963")]
    [Address(RVA = "0x3C31D14", Offset = "0x3C31D14", VA = "0x3C31D14", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6005964")]
    [Address(RVA = "0x3C31D74", Offset = "0x3C31D74", VA = "0x3C31D74", Slot = "5")]
    protected override LandformTypeData LoadEntity(IMasterDataReader reader)
    {
      return (LandformTypeData) null;
    }

    [Token(Token = "0x6005965")]
    [Address(RVA = "0x3C31DCC", Offset = "0x3C31DCC", VA = "0x3C31DCC")]
    public LandformTypeMaster()
    {
    }
  }
}
