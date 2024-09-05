// Decompiled with JetBrains decompiler
// Type: Scenes.ScenarioQuest.EventMission.EventMissionTwoCharacterView
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
  [Token(Token = "0x200299E")]
  public class EventMissionTwoCharacterView : EventMissionCharacter
  {
    [Token(Token = "0x400B147")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    [Header("キャラクタ画像")]
    private Image firstCharacterImage;
    [Token(Token = "0x400B148")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private Image secondCharacterImage;

    [Token(Token = "0x6010595")]
    [Address(RVA = "0x4881068", Offset = "0x4881068", VA = "0x4881068", Slot = "4")]
    public override void Initialize(
      AssetCachedSpawner spawner,
      int firstStyleId = 0,
      int secondStyleId = 0,
      int thirdStyleId = 0)
    {
    }

    [Token(Token = "0x6010596")]
    [Address(RVA = "0x48810CC", Offset = "0x48810CC", VA = "0x48810CC")]
    public EventMissionTwoCharacterView()
    {
    }
  }
}
