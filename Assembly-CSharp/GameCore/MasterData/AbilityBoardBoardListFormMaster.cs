// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.AbilityBoardBoardListFormMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001324")]
  [Serializable]
  public sealed class AbilityBoardBoardListFormMaster : BaseMaster<AbilityBoardBoardListFormData>
  {
    [Token(Token = "0x6006C0E")]
    [Address(RVA = "0x48E8064", Offset = "0x48E8064", VA = "0x48E8064")]
    public IReadOnlyDictionary<int, AbilityBoardBoardListFormData> GetEntities()
    {
      return (IReadOnlyDictionary<int, AbilityBoardBoardListFormData>) null;
    }

    [Token(Token = "0x6006C0F")]
    [Address(RVA = "0x48E806C", Offset = "0x48E806C", VA = "0x48E806C", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6006C10")]
    [Address(RVA = "0x48E80CC", Offset = "0x48E80CC", VA = "0x48E80CC", Slot = "5")]
    protected override AbilityBoardBoardListFormData LoadEntity(IMasterDataReader reader)
    {
      return (AbilityBoardBoardListFormData) null;
    }

    [Token(Token = "0x6006C11")]
    [Address(RVA = "0x48E8124", Offset = "0x48E8124", VA = "0x48E8124")]
    public AbilityBoardBoardListFormMaster()
    {
    }
  }
}
