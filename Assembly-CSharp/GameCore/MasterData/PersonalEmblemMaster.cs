// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.PersonalEmblemMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001064")]
  [Serializable]
  public sealed class PersonalEmblemMaster : BaseMaster<PersonalEmblemData>
  {
    [Token(Token = "0x6005F22")]
    [Address(RVA = "0x28CB114", Offset = "0x28CB114", VA = "0x28CB114")]
    public IReadOnlyDictionary<int, PersonalEmblemData> GetEntities()
    {
      return (IReadOnlyDictionary<int, PersonalEmblemData>) null;
    }

    [Token(Token = "0x6005F23")]
    [Address(RVA = "0x28CB11C", Offset = "0x28CB11C", VA = "0x28CB11C", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6005F24")]
    [Address(RVA = "0x28CB17C", Offset = "0x28CB17C", VA = "0x28CB17C", Slot = "5")]
    protected override PersonalEmblemData LoadEntity(IMasterDataReader reader)
    {
      return (PersonalEmblemData) null;
    }

    [Token(Token = "0x6005F25")]
    [Address(RVA = "0x28CB1D4", Offset = "0x28CB1D4", VA = "0x28CB1D4")]
    public PersonalEmblemMaster()
    {
    }
  }
}
