// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.AccessoryOptionMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000F43")]
  [Serializable]
  public sealed class AccessoryOptionMaster : BaseMaster<AccessoryOptionData>
  {
    [Token(Token = "0x60059F5")]
    [Address(RVA = "0x3C3A530", Offset = "0x3C3A530", VA = "0x3C3A530")]
    public IReadOnlyDictionary<int, AccessoryOptionData> GetEntities()
    {
      return (IReadOnlyDictionary<int, AccessoryOptionData>) null;
    }

    [Token(Token = "0x60059F6")]
    [Address(RVA = "0x3C3A538", Offset = "0x3C3A538", VA = "0x3C3A538", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x60059F7")]
    [Address(RVA = "0x3C3A598", Offset = "0x3C3A598", VA = "0x3C3A598", Slot = "5")]
    protected override AccessoryOptionData LoadEntity(IMasterDataReader reader)
    {
      return (AccessoryOptionData) null;
    }

    [Token(Token = "0x60059F8")]
    [Address(RVA = "0x3C3A5F0", Offset = "0x3C3A5F0", VA = "0x3C3A5F0")]
    public int GetSpriteId(int id) => new int();

    [Token(Token = "0x60059F9")]
    [Address(RVA = "0x3C3A6D0", Offset = "0x3C3A6D0", VA = "0x3C3A6D0")]
    public AccessoryOptionMaster()
    {
    }
  }
}
