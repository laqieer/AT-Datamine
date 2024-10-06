// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.PersonalEmblemCategoryMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001062")]
  [Serializable]
  public sealed class PersonalEmblemCategoryMaster : BaseMaster<PersonalEmblemCategoryData>
  {
    [Token(Token = "0x6005F1A")]
    [Address(RVA = "0x28CADF8", Offset = "0x28CADF8", VA = "0x28CADF8")]
    public IReadOnlyDictionary<int, PersonalEmblemCategoryData> GetEntities()
    {
      return (IReadOnlyDictionary<int, PersonalEmblemCategoryData>) null;
    }

    [Token(Token = "0x6005F1B")]
    [Address(RVA = "0x28CAE00", Offset = "0x28CAE00", VA = "0x28CAE00", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6005F1C")]
    [Address(RVA = "0x28CAE60", Offset = "0x28CAE60", VA = "0x28CAE60", Slot = "5")]
    protected override PersonalEmblemCategoryData LoadEntity(IMasterDataReader reader)
    {
      return (PersonalEmblemCategoryData) null;
    }

    [Token(Token = "0x6005F1D")]
    [Address(RVA = "0x28CAEB8", Offset = "0x28CAEB8", VA = "0x28CAEB8")]
    public PersonalEmblemCategoryMaster()
    {
    }
  }
}
