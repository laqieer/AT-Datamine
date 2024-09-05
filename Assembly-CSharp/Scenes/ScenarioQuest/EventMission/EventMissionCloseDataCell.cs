// Decompiled with JetBrains decompiler
// Type: Scenes.ScenarioQuest.EventMission.EventMissionCloseDataCell
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using TMPro;
using UnityEngine;

#nullable disable
namespace Scenes.ScenarioQuest.EventMission
{
  [Token(Token = "0x200297F")]
  public class EventMissionCloseDataCell : MonoBehaviour
  {
    [Token(Token = "0x400B0C0")]
    [FieldOffset(Offset = "0x18")]
    private EventMissionCellData _cellData;
    [Token(Token = "0x400B0C1")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private TextMeshProUGUI missionSummary;
    [Token(Token = "0x400B0C2")]
    private const string DayTextSuffix = "にミッション開放";

    [Token(Token = "0x60104FA")]
    [Address(RVA = "0x475C9CC", Offset = "0x475C9CC", VA = "0x475C9CC")]
    public void Initialize(EventMissionCellData cellData)
    {
    }

    [Token(Token = "0x60104FB")]
    [Address(RVA = "0x475CA68", Offset = "0x475CA68", VA = "0x475CA68")]
    public EventMissionCloseDataCell()
    {
    }
  }
}
