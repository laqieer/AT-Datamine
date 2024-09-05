// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.CharacterConstMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001360")]
  [Serializable]
  public sealed class CharacterConstMaster : BaseMaster<CharacterConstData>
  {
    [Token(Token = "0x6006D23")]
    [Address(RVA = "0x46FA418", Offset = "0x46FA418", VA = "0x46FA418")]
    public IReadOnlyDictionary<int, CharacterConstData> GetEntities()
    {
      return (IReadOnlyDictionary<int, CharacterConstData>) null;
    }

    [Token(Token = "0x6006D24")]
    [Address(RVA = "0x46FA420", Offset = "0x46FA420", VA = "0x46FA420", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6006D25")]
    [Address(RVA = "0x46FA4FC", Offset = "0x46FA4FC", VA = "0x46FA4FC", Slot = "5")]
    protected override CharacterConstData LoadEntity(IMasterDataReader reader)
    {
      return (CharacterConstData) null;
    }

    [Token(Token = "0x6006D26")]
    [Address(RVA = "0x46FA488", Offset = "0x46FA488", VA = "0x46FA488")]
    private void OnCompletedLoading()
    {
    }

    [Token(Token = "0x17001072")]
    public CharacterConstData Data
    {
      [Token(Token = "0x6006D27"), Address(RVA = "0x46FA554", Offset = "0x46FA554", VA = "0x46FA554")] get
      {
        return (CharacterConstData) null;
      }
      [Token(Token = "0x6006D28"), Address(RVA = "0x46FA55C", Offset = "0x46FA55C", VA = "0x46FA55C")] private set
      {
      }
    }

    [Token(Token = "0x6006D29")]
    [Address(RVA = "0x46FA564", Offset = "0x46FA564", VA = "0x46FA564")]
    public CharacterConstMaster()
    {
    }
  }
}
