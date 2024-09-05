// Decompiled with JetBrains decompiler
// Type: Scenes.ScenarioQuest.EventMission.EventMissionDataCell
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace Scenes.ScenarioQuest.EventMission
{
  [Token(Token = "0x2002980")]
  public sealed class EventMissionDataCell : InfiniteCellBase
  {
    [Token(Token = "0x400B0C3")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private EventMissionOpenDataCell openPrefab;
    [Token(Token = "0x400B0C4")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private EventMissionCloseDataCell closePrefab;

    [Token(Token = "0x60104FC")]
    [Address(RVA = "0x475CA70", Offset = "0x475CA70", VA = "0x475CA70")]
    public void SetDataCell(EventMissionCellData data)
    {
    }

    [Token(Token = "0x60104FD")]
    [Address(RVA = "0x475CD2C", Offset = "0x475CD2C", VA = "0x475CD2C", Slot = "4")]
    public override void OnUpdate()
    {
    }

    [Token(Token = "0x60104FE")]
    [Address(RVA = "0x475CDC8", Offset = "0x475CDC8", VA = "0x475CDC8")]
    public EventMissionDataCell()
    {
    }
  }
}
