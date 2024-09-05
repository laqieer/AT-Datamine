// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.LoginBonusRewardDetailMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001091")]
  [Serializable]
  public sealed class LoginBonusRewardDetailMaster : BaseMaster<LoginBonusRewardDetailData>
  {
    [Token(Token = "0x40051D0")]
    public const string TEXT_AB = "text_masterdata_loginbonus";

    [Token(Token = "0x6005FFE")]
    [Address(RVA = "0x28D39D4", Offset = "0x28D39D4", VA = "0x28D39D4")]
    public IReadOnlyDictionary<int, LoginBonusRewardDetailData> GetEntities()
    {
      return (IReadOnlyDictionary<int, LoginBonusRewardDetailData>) null;
    }

    [Token(Token = "0x6005FFF")]
    [Address(RVA = "0x28D39DC", Offset = "0x28D39DC", VA = "0x28D39DC", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6006000")]
    [Address(RVA = "0x28D3A3C", Offset = "0x28D3A3C", VA = "0x28D3A3C", Slot = "5")]
    protected override LoginBonusRewardDetailData LoadEntity(IMasterDataReader reader)
    {
      return (LoginBonusRewardDetailData) null;
    }

    [Token(Token = "0x6006001")]
    [Address(RVA = "0x28D3A94", Offset = "0x28D3A94", VA = "0x28D3A94")]
    public LoginBonusRewardDetailMaster()
    {
    }
  }
}
