// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.GuidelineMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000E94")]
  [Serializable]
  public sealed class GuidelineMaster : BaseMaster<GuidelineData>
  {
    [Token(Token = "0x60058AD")]
    [Address(RVA = "0x3C2CD94", Offset = "0x3C2CD94", VA = "0x3C2CD94")]
    public IReadOnlyDictionary<int, GuidelineData> GetEntities()
    {
      return (IReadOnlyDictionary<int, GuidelineData>) null;
    }

    [Token(Token = "0x60058AE")]
    [Address(RVA = "0x3C2CD9C", Offset = "0x3C2CD9C", VA = "0x3C2CD9C", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x60058AF")]
    [Address(RVA = "0x3C2CDFC", Offset = "0x3C2CDFC", VA = "0x3C2CDFC", Slot = "5")]
    protected override GuidelineData LoadEntity(IMasterDataReader reader) => (GuidelineData) null;

    [Token(Token = "0x60058B0")]
    [Address(RVA = "0x3C2CE54", Offset = "0x3C2CE54", VA = "0x3C2CE54")]
    public GuidelineMaster()
    {
    }
  }
}
