// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.LoginBonusMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001095")]
  [Serializable]
  public sealed class LoginBonusMaster : BaseMaster<LoginBonusData>
  {
    [Token(Token = "0x40051D9")]
    [FieldOffset(Offset = "0x18")]
    private DateTime defaultDate;

    [Token(Token = "0x600600F")]
    [Address(RVA = "0x28D41C0", Offset = "0x28D41C0", VA = "0x28D41C0")]
    public IReadOnlyDictionary<int, LoginBonusData> GetEntities()
    {
      return (IReadOnlyDictionary<int, LoginBonusData>) null;
    }

    [Token(Token = "0x6006010")]
    [Address(RVA = "0x28D41C8", Offset = "0x28D41C8", VA = "0x28D41C8", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6006011")]
    [Address(RVA = "0x28D4228", Offset = "0x28D4228", VA = "0x28D4228", Slot = "5")]
    protected override LoginBonusData LoadEntity(IMasterDataReader reader) => (LoginBonusData) null;

    [Token(Token = "0x6006012")]
    [Address(RVA = "0x28D4298", Offset = "0x28D4298", VA = "0x28D4298")]
    private void OnLoadEntity(LoginBonusData entity)
    {
    }

    [Token(Token = "0x6006013")]
    [Address(RVA = "0x28D4314", Offset = "0x28D4314", VA = "0x28D4314")]
    public LoginBonusMaster()
    {
    }
  }
}
