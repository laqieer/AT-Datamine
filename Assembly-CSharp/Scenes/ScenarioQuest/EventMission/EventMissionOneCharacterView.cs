// Decompiled with JetBrains decompiler
// Type: Scenes.ScenarioQuest.EventMission.EventMissionOneCharacterView
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
  [Token(Token = "0x2002991")]
  public class EventMissionOneCharacterView : EventMissionCharacter
  {
    [Token(Token = "0x400B116")]
    [FieldOffset(Offset = "0x20")]
    [Header("キャラクタ画像")]
    [SerializeField]
    private Image firstCharacterImage;

    [Token(Token = "0x601054F")]
    [Address(RVA = "0x4760F40", Offset = "0x4760F40", VA = "0x4760F40", Slot = "4")]
    public override void Initialize(
      AssetCachedSpawner spawner,
      int firstStyleId = 0,
      int secondStyleId = 0,
      int thirdStyleId = 0)
    {
    }

    [Token(Token = "0x6010550")]
    [Address(RVA = "0x4760F88", Offset = "0x4760F88", VA = "0x4760F88")]
    public EventMissionOneCharacterView()
    {
    }
  }
}
