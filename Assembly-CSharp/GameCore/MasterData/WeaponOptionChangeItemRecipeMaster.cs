// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.WeaponOptionChangeItemRecipeMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000F87")]
  [Serializable]
  public sealed class WeaponOptionChangeItemRecipeMaster : 
    BaseMaster<WeaponOptionChangeItemRecipeData>
  {
    [Token(Token = "0x6005B4E")]
    [Address(RVA = "0x278134C", Offset = "0x278134C", VA = "0x278134C")]
    public IReadOnlyDictionary<int, WeaponOptionChangeItemRecipeData> GetEntities()
    {
      return (IReadOnlyDictionary<int, WeaponOptionChangeItemRecipeData>) null;
    }

    [Token(Token = "0x6005B4F")]
    [Address(RVA = "0x2781354", Offset = "0x2781354", VA = "0x2781354", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6005B50")]
    [Address(RVA = "0x27813B4", Offset = "0x27813B4", VA = "0x27813B4", Slot = "5")]
    protected override WeaponOptionChangeItemRecipeData LoadEntity(IMasterDataReader reader)
    {
      return (WeaponOptionChangeItemRecipeData) null;
    }

    [Token(Token = "0x6005B51")]
    [Address(RVA = "0x278140C", Offset = "0x278140C", VA = "0x278140C")]
    public IReadOnlyCollection<WeaponOptionChangeItemRecipeData> GetList()
    {
      return (IReadOnlyCollection<WeaponOptionChangeItemRecipeData>) null;
    }

    [Token(Token = "0x6005B52")]
    [Address(RVA = "0x278145C", Offset = "0x278145C", VA = "0x278145C")]
    public WeaponOptionChangeItemRecipeMaster()
    {
    }
  }
}
