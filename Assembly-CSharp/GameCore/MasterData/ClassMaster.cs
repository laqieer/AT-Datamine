// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.ClassMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x200137A")]
  [Serializable]
  public sealed class ClassMaster : BaseMaster<ClassData>
  {
    [Token(Token = "0x4005B39")]
    public const string TEXT_AB = "text_masterdata_unit";

    [Token(Token = "0x6006D97")]
    [Address(RVA = "0x46FE154", Offset = "0x46FE154", VA = "0x46FE154")]
    public IReadOnlyDictionary<int, ClassData> GetEntities()
    {
      return (IReadOnlyDictionary<int, ClassData>) null;
    }

    [Token(Token = "0x6006D98")]
    [Address(RVA = "0x46FE15C", Offset = "0x46FE15C", VA = "0x46FE15C", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6006D99")]
    [Address(RVA = "0x46FE1BC", Offset = "0x46FE1BC", VA = "0x46FE1BC", Slot = "5")]
    protected override ClassData LoadEntity(IMasterDataReader reader) => (ClassData) null;

    [Token(Token = "0x6006D9A")]
    [Address(RVA = "0x46FE214", Offset = "0x46FE214", VA = "0x46FE214")]
    public ClassMaster()
    {
    }
  }
}
