// Decompiled with JetBrains decompiler
// Type: Story.StoryCharacterMoveBehaviour
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace Story
{
  [Token(Token = "0x2000536")]
  public class StoryCharacterMoveBehaviour : StateMachineBehaviour
  {
    [Token(Token = "0x4001B6A")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    [Header("参照する移動速度の種類")]
    private StoryCharacterMoveBehaviour.MoveSpeedType speedType;
    [Token(Token = "0x4001B6B")]
    [FieldOffset(Offset = "0x1C")]
    private bool isExitTransition;

    [Token(Token = "0x6001E35")]
    [Address(RVA = "0x29FC15C", Offset = "0x29FC15C", VA = "0x29FC15C", Slot = "4")]
    public override void OnStateEnter(
      Animator animator,
      AnimatorStateInfo stateInfo,
      int layerIndex)
    {
    }

    [Token(Token = "0x6001E36")]
    [Address(RVA = "0x29FC288", Offset = "0x29FC288", VA = "0x29FC288", Slot = "5")]
    public override void OnStateUpdate(
      Animator animator,
      AnimatorStateInfo stateInfo,
      int layerIndex)
    {
    }

    [Token(Token = "0x6001E37")]
    [Address(RVA = "0x29FC3E4", Offset = "0x29FC3E4", VA = "0x29FC3E4")]
    public StoryCharacterMoveBehaviour()
    {
    }

    [Token(Token = "0x2000537")]
    public enum MoveSpeedType
    {
      [Token(Token = "0x4001B6D")] None,
      [Token(Token = "0x4001B6E")] Walk,
      [Token(Token = "0x4001B6F")] Run,
      [Token(Token = "0x4001B70")] Timeline,
    }
  }
}
