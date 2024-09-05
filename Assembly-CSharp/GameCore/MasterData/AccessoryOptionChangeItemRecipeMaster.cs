// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.AccessoryOptionChangeItemRecipeMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000F45")]
  [Serializable]
  public sealed class AccessoryOptionChangeItemRecipeMaster : 
    BaseMaster<AccessoryOptionChangeItemRecipeData>
  {
    [Token(Token = "0x60059FF")]
    [Address(RVA = "0x3C3AAEC", Offset = "0x3C3AAEC", VA = "0x3C3AAEC")]
    public IReadOnlyDictionary<int, AccessoryOptionChangeItemRecipeData> GetEntities()
    {
      return (IReadOnlyDictionary<int, AccessoryOptionChangeItemRecipeData>) null;
    }

    [Token(Token = "0x6005A00")]
    [Address(RVA = "0x3C3AAF4", Offset = "0x3C3AAF4", VA = "0x3C3AAF4", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6005A01")]
    [Address(RVA = "0x3C3AB54", Offset = "0x3C3AB54", VA = "0x3C3AB54", Slot = "5")]
    protected override AccessoryOptionChangeItemRecipeData LoadEntity(IMasterDataReader reader)
    {
      return (AccessoryOptionChangeItemRecipeData) null;
    }

    [Token(Token = "0x6005A02")]
    [Address(RVA = "0x3C3ABAC", Offset = "0x3C3ABAC", VA = "0x3C3ABAC")]
    public AccessoryOptionChangeItemRecipeMaster()
    {
    }
  }
}
