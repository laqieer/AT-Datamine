// Decompiled with JetBrains decompiler
// Type: Scenes.ScenarioQuest.EventMission.EventMissionThreeCharacterView
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.ScenarioQuest.EventMission
{
  [Token(Token = "0x2002999")]
  public class EventMissionThreeCharacterView : EventMissionCharacter
  {
    [Token(Token = "0x400B12F")]
    [FieldOffset(Offset = "0x20")]
    [Header("キャラクタ画像")]
    [SerializeField]
    private Image firstCharacterImage;
    [Token(Token = "0x400B130")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private Image secondCharacterImage;
    [Token(Token = "0x400B131")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private Image thirdCharacterImage;

    [Token(Token = "0x6010575")]
    [Address(RVA = "0x4762A60", Offset = "0x4762A60", VA = "0x4762A60", Slot = "4")]
    public override void Initialize(
      AssetCachedSpawner spawner,
      int firstStyleId = 0,
      int secondStyleId = 0,
      int thirdStyleId = 0)
    {
    }

    [Token(Token = "0x6010576")]
    [Address(RVA = "0x4762AD8", Offset = "0x4762AD8", VA = "0x4762AD8")]
    public EventMissionThreeCharacterView()
    {
    }
  }
}
