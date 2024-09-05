// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.MissionConstMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001099")]
  [Serializable]
  public sealed class MissionConstMaster : BaseMaster<MissionConstData>
  {
    [Token(Token = "0x6006020")]
    [Address(RVA = "0x28D4BCC", Offset = "0x28D4BCC", VA = "0x28D4BCC")]
    public IReadOnlyDictionary<int, MissionConstData> GetEntities()
    {
      return (IReadOnlyDictionary<int, MissionConstData>) null;
    }

    [Token(Token = "0x6006021")]
    [Address(RVA = "0x28D4BD4", Offset = "0x28D4BD4", VA = "0x28D4BD4", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6006022")]
    [Address(RVA = "0x28D4C34", Offset = "0x28D4C34", VA = "0x28D4C34", Slot = "5")]
    protected override MissionConstData LoadEntity(IMasterDataReader reader)
    {
      return (MissionConstData) null;
    }

    [Token(Token = "0x6006023")]
    [Address(RVA = "0x28D4C8C", Offset = "0x28D4C8C", VA = "0x28D4C8C")]
    public MissionConstData Current() => (MissionConstData) null;

    [Token(Token = "0x6006024")]
    [Address(RVA = "0x28D4CE8", Offset = "0x28D4CE8", VA = "0x28D4CE8")]
    public int DailyGroupId() => new int();

    [Token(Token = "0x6006025")]
    [Address(RVA = "0x28D4D08", Offset = "0x28D4D08", VA = "0x28D4D08")]
    public int WeeklyGroupId() => new int();

    [Token(Token = "0x6006026")]
    [Address(RVA = "0x28D4D28", Offset = "0x28D4D28", VA = "0x28D4D28")]
    public int MainGroupId() => new int();

    [Token(Token = "0x6006027")]
    [Address(RVA = "0x28D4D48", Offset = "0x28D4D48", VA = "0x28D4D48")]
    public int EventGroupId() => new int();

    [Token(Token = "0x6006028")]
    [Address(RVA = "0x28D4D68", Offset = "0x28D4D68", VA = "0x28D4D68")]
    public MissionConstMaster()
    {
    }
  }
}
