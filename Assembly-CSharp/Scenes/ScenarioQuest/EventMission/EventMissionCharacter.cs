// Decompiled with JetBrains decompiler
// Type: Scenes.ScenarioQuest.EventMission.EventMissionCharacter
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
  [Token(Token = "0x200297D")]
  public class EventMissionCharacter : MonoBehaviour
  {
    [Token(Token = "0x400B0BE")]
    [FieldOffset(Offset = "0x18")]
    protected AssetCachedSpawner Spawner;

    [Token(Token = "0x60104F2")]
    [Address(RVA = "0x475C870", Offset = "0x475C870", VA = "0x475C870", Slot = "4")]
    public virtual void Initialize(
      AssetCachedSpawner spawner,
      int firstStyleId = 0,
      int secondStyleId = 0,
      int thirdStyleId = 0)
    {
    }

    [Token(Token = "0x60104F3")]
    [Address(RVA = "0x475C874", Offset = "0x475C874", VA = "0x475C874")]
    protected void LoadCharacter(int styleId, Image image)
    {
    }

    [Token(Token = "0x60104F4")]
    [Address(RVA = "0x475C988", Offset = "0x475C988", VA = "0x475C988")]
    private string GetCharacterFullImageAssetBundleName(int styleId) => (string) null;

    [Token(Token = "0x60104F5")]
    [Address(RVA = "0x475C994", Offset = "0x475C994", VA = "0x475C994")]
    private string GetCharacterFullImageName(int styleId) => (string) null;

    [Token(Token = "0x60104F6")]
    [Address(RVA = "0x475C9A0", Offset = "0x475C9A0", VA = "0x475C9A0")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x60104F7")]
    [Address(RVA = "0x475C9A8", Offset = "0x475C9A8", VA = "0x475C9A8")]
    public EventMissionCharacter()
    {
    }
  }
}
