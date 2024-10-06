// Decompiled with JetBrains decompiler
// Type: Scenes.Story.Date.TimeElapsedTestScene
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;

#nullable disable
namespace Scenes.Story.Date
{
  [Token(Token = "0x2002EB3")]
  public class TimeElapsedTestScene : MonoBehaviour
  {
    [Token(Token = "0x400C82D")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private StoryTimeSlotTypeEnum from;
    [Token(Token = "0x400C82E")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private StoryTimeSlotTypeEnum to;
    [Token(Token = "0x400C82F")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private bool weekday;
    [Token(Token = "0x400C830")]
    [FieldOffset(Offset = "0x28")]
    private TimeElapsedContainer timeElapsed;

    [Token(Token = "0x60123A0")]
    [Address(RVA = "0x45981F0", Offset = "0x45981F0", VA = "0x45981F0")]
    private void OnEnable()
    {
    }

    [Token(Token = "0x60123A1")]
    [Address(RVA = "0x45982D8", Offset = "0x45982D8", VA = "0x45982D8")]
    private void OnStopped(PlayableDirector dir)
    {
    }

    [Token(Token = "0x60123A2")]
    [Address(RVA = "0x45982E4", Offset = "0x45982E4", VA = "0x45982E4")]
    private void OnDisable()
    {
    }

    [Token(Token = "0x60123A3")]
    [Address(RVA = "0x4598304", Offset = "0x4598304", VA = "0x4598304")]
    public TimeElapsedTestScene()
    {
    }
  }
}
