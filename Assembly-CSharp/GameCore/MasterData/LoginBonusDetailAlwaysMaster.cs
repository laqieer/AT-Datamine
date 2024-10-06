// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.LoginBonusDetailAlwaysMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x200108F")]
  [Serializable]
  public sealed class LoginBonusDetailAlwaysMaster : BaseMaster<LoginBonusDetailAlwaysData>
  {
    [Token(Token = "0x6005FF6")]
    [Address(RVA = "0x28D36B8", Offset = "0x28D36B8", VA = "0x28D36B8")]
    public IReadOnlyDictionary<int, LoginBonusDetailAlwaysData> GetEntities()
    {
      return (IReadOnlyDictionary<int, LoginBonusDetailAlwaysData>) null;
    }

    [Token(Token = "0x6005FF7")]
    [Address(RVA = "0x28D36C0", Offset = "0x28D36C0", VA = "0x28D36C0", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6005FF8")]
    [Address(RVA = "0x28D3720", Offset = "0x28D3720", VA = "0x28D3720", Slot = "5")]
    protected override LoginBonusDetailAlwaysData LoadEntity(IMasterDataReader reader)
    {
      return (LoginBonusDetailAlwaysData) null;
    }

    [Token(Token = "0x6005FF9")]
    [Address(RVA = "0x28D3778", Offset = "0x28D3778", VA = "0x28D3778")]
    public LoginBonusDetailAlwaysMaster()
    {
    }
  }
}
