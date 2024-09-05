// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.LoginBonusRewardMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001093")]
  [Serializable]
  public sealed class LoginBonusRewardMaster : BaseMaster<LoginBonusRewardData>
  {
    [Token(Token = "0x6006007")]
    [Address(RVA = "0x28D3EA8", Offset = "0x28D3EA8", VA = "0x28D3EA8")]
    public IReadOnlyDictionary<int, LoginBonusRewardData> GetEntities()
    {
      return (IReadOnlyDictionary<int, LoginBonusRewardData>) null;
    }

    [Token(Token = "0x6006008")]
    [Address(RVA = "0x28D3EB0", Offset = "0x28D3EB0", VA = "0x28D3EB0", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6006009")]
    [Address(RVA = "0x28D3F10", Offset = "0x28D3F10", VA = "0x28D3F10", Slot = "5")]
    protected override LoginBonusRewardData LoadEntity(IMasterDataReader reader)
    {
      return (LoginBonusRewardData) null;
    }

    [Token(Token = "0x600600A")]
    [Address(RVA = "0x28D3F68", Offset = "0x28D3F68", VA = "0x28D3F68")]
    public LoginBonusRewardMaster()
    {
    }
  }
}
