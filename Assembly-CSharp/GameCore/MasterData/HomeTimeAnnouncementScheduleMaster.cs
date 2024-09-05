// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.HomeTimeAnnouncementScheduleMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x200102A")]
  [Serializable]
  public sealed class HomeTimeAnnouncementScheduleMaster : 
    BaseMaster<HomeTimeAnnouncementScheduleData>
  {
    [Token(Token = "0x6005E09")]
    [Address(RVA = "0x279978C", Offset = "0x279978C", VA = "0x279978C")]
    public IReadOnlyDictionary<int, HomeTimeAnnouncementScheduleData> GetEntities()
    {
      return (IReadOnlyDictionary<int, HomeTimeAnnouncementScheduleData>) null;
    }

    [Token(Token = "0x6005E0A")]
    [Address(RVA = "0x2799794", Offset = "0x2799794", VA = "0x2799794", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6005E0B")]
    [Address(RVA = "0x27997F4", Offset = "0x27997F4", VA = "0x27997F4", Slot = "5")]
    protected override HomeTimeAnnouncementScheduleData LoadEntity(IMasterDataReader reader)
    {
      return (HomeTimeAnnouncementScheduleData) null;
    }

    [Token(Token = "0x6005E0C")]
    [Address(RVA = "0x279984C", Offset = "0x279984C", VA = "0x279984C")]
    public HomeTimeAnnouncementScheduleMaster()
    {
    }
  }
}
