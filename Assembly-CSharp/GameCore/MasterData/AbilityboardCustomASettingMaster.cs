// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.AbilityboardCustomASettingMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001340")]
  [Serializable]
  public sealed class AbilityboardCustomASettingMaster : BaseMaster<AbilityboardCustomASettingData>
  {
    [Token(Token = "0x6006C94")]
    [Address(RVA = "0x46F5098", Offset = "0x46F5098", VA = "0x46F5098")]
    public IReadOnlyDictionary<int, AbilityboardCustomASettingData> GetEntities()
    {
      return (IReadOnlyDictionary<int, AbilityboardCustomASettingData>) null;
    }

    [Token(Token = "0x6006C95")]
    [Address(RVA = "0x46F50A0", Offset = "0x46F50A0", VA = "0x46F50A0", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6006C96")]
    [Address(RVA = "0x46F5100", Offset = "0x46F5100", VA = "0x46F5100", Slot = "5")]
    protected override AbilityboardCustomASettingData LoadEntity(IMasterDataReader reader)
    {
      return (AbilityboardCustomASettingData) null;
    }

    [Token(Token = "0x6006C97")]
    [Address(RVA = "0x46F5158", Offset = "0x46F5158", VA = "0x46F5158")]
    public AbilityboardCustomASettingMaster()
    {
    }
  }
}
