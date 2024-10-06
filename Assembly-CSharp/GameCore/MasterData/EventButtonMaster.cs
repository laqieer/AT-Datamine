// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.EventButtonMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x200101F")]
  [Serializable]
  public sealed class EventButtonMaster : BaseMaster<EventButtonData>
  {
    [Token(Token = "0x4005020")]
    public const string TEXT_AB = "text_masterdata_home";

    [Token(Token = "0x6005DD5")]
    [Address(RVA = "0x279759C", Offset = "0x279759C", VA = "0x279759C")]
    public IReadOnlyDictionary<int, EventButtonData> GetEntities()
    {
      return (IReadOnlyDictionary<int, EventButtonData>) null;
    }

    [Token(Token = "0x6005DD6")]
    [Address(RVA = "0x27975A4", Offset = "0x27975A4", VA = "0x27975A4", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6005DD7")]
    [Address(RVA = "0x2797604", Offset = "0x2797604", VA = "0x2797604", Slot = "5")]
    protected override EventButtonData LoadEntity(IMasterDataReader reader)
    {
      return (EventButtonData) null;
    }

    [Token(Token = "0x6005DD8")]
    [Address(RVA = "0x279765C", Offset = "0x279765C", VA = "0x279765C")]
    public EventButtonMaster()
    {
    }
  }
}
