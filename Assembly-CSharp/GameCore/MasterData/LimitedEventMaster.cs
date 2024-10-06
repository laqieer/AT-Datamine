// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.LimitedEventMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001123")]
  [Serializable]
  public sealed class LimitedEventMaster : BaseMaster<LimitedEventData>
  {
    [Token(Token = "0x60062A7")]
    [Address(RVA = "0x4AE0B80", Offset = "0x4AE0B80", VA = "0x4AE0B80")]
    public IReadOnlyDictionary<int, LimitedEventData> GetEntities()
    {
      return (IReadOnlyDictionary<int, LimitedEventData>) null;
    }

    [Token(Token = "0x60062A8")]
    [Address(RVA = "0x4AE0B88", Offset = "0x4AE0B88", VA = "0x4AE0B88", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x60062A9")]
    [Address(RVA = "0x4AE0BE8", Offset = "0x4AE0BE8", VA = "0x4AE0BE8", Slot = "5")]
    protected override LimitedEventData LoadEntity(IMasterDataReader reader)
    {
      return (LimitedEventData) null;
    }

    [Token(Token = "0x60062AA")]
    [Address(RVA = "0x4AE0C40", Offset = "0x4AE0C40", VA = "0x4AE0C40")]
    public bool IsOpen(int eventId) => new bool();

    [Token(Token = "0x60062AB")]
    [Address(RVA = "0x4AE0D50", Offset = "0x4AE0D50", VA = "0x4AE0D50")]
    private bool IsPlayAbleTime(LimitedEventData data) => new bool();

    [Token(Token = "0x60062AC")]
    [Address(RVA = "0x4AE0E28", Offset = "0x4AE0E28", VA = "0x4AE0E28")]
    public LimitedEventMaster()
    {
    }
  }
}
