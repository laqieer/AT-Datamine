// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.AreaQuestAreaNodeShortcutMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x20010F7")]
  [Serializable]
  public sealed class AreaQuestAreaNodeShortcutMaster : BaseMaster<AreaQuestAreaNodeShortcutData>
  {
    [Token(Token = "0x60061D4")]
    [Address(RVA = "0x4AD8AD8", Offset = "0x4AD8AD8", VA = "0x4AD8AD8")]
    public IReadOnlyDictionary<int, AreaQuestAreaNodeShortcutData> GetEntities()
    {
      return (IReadOnlyDictionary<int, AreaQuestAreaNodeShortcutData>) null;
    }

    [Token(Token = "0x60061D5")]
    [Address(RVA = "0x4AD8AE0", Offset = "0x4AD8AE0", VA = "0x4AD8AE0", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x60061D6")]
    [Address(RVA = "0x4AD8B40", Offset = "0x4AD8B40", VA = "0x4AD8B40", Slot = "5")]
    protected override AreaQuestAreaNodeShortcutData LoadEntity(IMasterDataReader reader)
    {
      return (AreaQuestAreaNodeShortcutData) null;
    }

    [Token(Token = "0x60061D7")]
    [Address(RVA = "0x4AD8B98", Offset = "0x4AD8B98", VA = "0x4AD8B98")]
    public IEnumerable<AreaQuestAreaNodeShortcutData> GetDataByShortcutGroupId(int shortcutGroupId)
    {
      return (IEnumerable<AreaQuestAreaNodeShortcutData>) null;
    }

    [Token(Token = "0x60061D8")]
    [Address(RVA = "0x4AD8CA0", Offset = "0x4AD8CA0", VA = "0x4AD8CA0")]
    public AreaQuestAreaNodeShortcutMaster()
    {
    }
  }
}
