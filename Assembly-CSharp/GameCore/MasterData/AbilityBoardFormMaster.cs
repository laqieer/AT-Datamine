// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.AbilityBoardFormMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001349")]
  [Serializable]
  public sealed class AbilityBoardFormMaster : BaseMaster<AbilityBoardFormData>
  {
    [Token(Token = "0x6006CBB")]
    [Address(RVA = "0x46F6814", Offset = "0x46F6814", VA = "0x46F6814")]
    public IReadOnlyDictionary<int, AbilityBoardFormData> GetEntities()
    {
      return (IReadOnlyDictionary<int, AbilityBoardFormData>) null;
    }

    [Token(Token = "0x6006CBC")]
    [Address(RVA = "0x46F681C", Offset = "0x46F681C", VA = "0x46F681C", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6006CBD")]
    [Address(RVA = "0x46F687C", Offset = "0x46F687C", VA = "0x46F687C", Slot = "5")]
    protected override AbilityBoardFormData LoadEntity(IMasterDataReader reader)
    {
      return (AbilityBoardFormData) null;
    }

    [Token(Token = "0x6006CBE")]
    [Address(RVA = "0x46F68D4", Offset = "0x46F68D4", VA = "0x46F68D4")]
    public AbilityBoardFormMaster()
    {
    }
  }
}
