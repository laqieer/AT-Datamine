// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.ArmorMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001376")]
  [Serializable]
  public sealed class ArmorMaster : BaseMaster<ArmorData>
  {
    [Token(Token = "0x6006D86")]
    [Address(RVA = "0x46FD9F0", Offset = "0x46FD9F0", VA = "0x46FD9F0")]
    public IReadOnlyDictionary<int, ArmorData> GetEntities()
    {
      return (IReadOnlyDictionary<int, ArmorData>) null;
    }

    [Token(Token = "0x6006D87")]
    [Address(RVA = "0x46FD9F8", Offset = "0x46FD9F8", VA = "0x46FD9F8", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6006D88")]
    [Address(RVA = "0x46FDA58", Offset = "0x46FDA58", VA = "0x46FDA58", Slot = "5")]
    protected override ArmorData LoadEntity(IMasterDataReader reader) => (ArmorData) null;

    [Token(Token = "0x6006D89")]
    [Address(RVA = "0x46FDAB0", Offset = "0x46FDAB0", VA = "0x46FDAB0")]
    public ArmorMaster()
    {
    }
  }
}
