// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.AdvDemoInfoMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000DAA")]
  [Serializable]
  public sealed class AdvDemoInfoMaster : BaseMaster<AdvDemoInfoData>
  {
    [Token(Token = "0x60053A7")]
    [Address(RVA = "0x3A9BD44", Offset = "0x3A9BD44", VA = "0x3A9BD44")]
    public IReadOnlyDictionary<int, AdvDemoInfoData> GetEntities()
    {
      return (IReadOnlyDictionary<int, AdvDemoInfoData>) null;
    }

    [Token(Token = "0x60053A8")]
    [Address(RVA = "0x3A9BD4C", Offset = "0x3A9BD4C", VA = "0x3A9BD4C", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x60053A9")]
    [Address(RVA = "0x3A9BDAC", Offset = "0x3A9BDAC", VA = "0x3A9BDAC", Slot = "5")]
    protected override AdvDemoInfoData LoadEntity(IMasterDataReader reader)
    {
      return (AdvDemoInfoData) null;
    }

    [Token(Token = "0x60053AA")]
    [Address(RVA = "0x3A9BE04", Offset = "0x3A9BE04", VA = "0x3A9BE04")]
    public AdvDemoInfoData GetByName(string name) => (AdvDemoInfoData) null;

    [Token(Token = "0x60053AB")]
    [Address(RVA = "0x3A9BFA4", Offset = "0x3A9BFA4", VA = "0x3A9BFA4")]
    public AdvDemoInfoData GetById(int id) => (AdvDemoInfoData) null;

    [Token(Token = "0x60053AC")]
    [Address(RVA = "0x3A9C138", Offset = "0x3A9C138", VA = "0x3A9C138")]
    public List<string> CreatePlayList() => (List<string>) null;

    [Token(Token = "0x60053AD")]
    [Address(RVA = "0x3A9C370", Offset = "0x3A9C370", VA = "0x3A9C370")]
    public AdvDemoInfoMaster()
    {
    }
  }
}
