// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.ElementTypeMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000EE6")]
  [Serializable]
  public sealed class ElementTypeMaster : BaseMaster<ElementTypeData>
  {
    [Token(Token = "0x600595A")]
    [Address(RVA = "0x3C319EC", Offset = "0x3C319EC", VA = "0x3C319EC")]
    public IReadOnlyDictionary<int, ElementTypeData> GetEntities()
    {
      return (IReadOnlyDictionary<int, ElementTypeData>) null;
    }

    [Token(Token = "0x600595B")]
    [Address(RVA = "0x3C319F4", Offset = "0x3C319F4", VA = "0x3C319F4", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x600595C")]
    [Address(RVA = "0x3C31A54", Offset = "0x3C31A54", VA = "0x3C31A54", Slot = "5")]
    protected override ElementTypeData LoadEntity(IMasterDataReader reader)
    {
      return (ElementTypeData) null;
    }

    [Token(Token = "0x600595D")]
    [Address(RVA = "0x3C31AAC", Offset = "0x3C31AAC", VA = "0x3C31AAC")]
    public ElementTypeMaster()
    {
    }
  }
}
