// Decompiled with JetBrains decompiler
// Type: FreeMap.FootMoveSoundControl
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace FreeMap
{
  [Token(Token = "0x20015DC")]
  public class FootMoveSoundControl : MonoBehaviour
  {
    [Token(Token = "0x40063BD")]
    [FieldOffset(Offset = "0x18")]
    private readonly string[] FOOTMOVESOUNDS;
    [Token(Token = "0x40063BE")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private FootMoveAnimtionEventReceiver footEventReceiver;
    [Token(Token = "0x40063BF")]
    [FieldOffset(Offset = "0x28")]
    private RaycastHit[] floorRayHitBufferArray;
    [Token(Token = "0x40063C0")]
    private const float FLOOR_RAY_HEIGHT_OFFSET = 0.1f;
    [Token(Token = "0x40063C1")]
    private const float FLOOR_RAY_DISTANCE = 0.3f;

    [Token(Token = "0x6007B96")]
    [Address(RVA = "0x22A29EC", Offset = "0x22A29EC", VA = "0x22A29EC")]
    private void Awake()
    {
    }

    [Token(Token = "0x6007B97")]
    [Address(RVA = "0x22A29F4", Offset = "0x22A29F4", VA = "0x22A29F4")]
    public void SetFootRecevier(FootMoveAnimtionEventReceiver receiver)
    {
    }

    [Token(Token = "0x6007B98")]
    [Address(RVA = "0x22A2B50", Offset = "0x22A2B50", VA = "0x22A2B50")]
    public void CheckHitFloor(ref RaycastHit[] result, out int hitNum)
    {
    }

    [Token(Token = "0x6007B99")]
    [Address(RVA = "0x22A2CC4", Offset = "0x22A2CC4", VA = "0x22A2CC4")]
    private void CheckAndRunFootSoundFloorSwitch()
    {
    }

    [Token(Token = "0x6007B9A")]
    [Address(RVA = "0x22A2E4C", Offset = "0x22A2E4C", VA = "0x22A2E4C")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x6007B9B")]
    [Address(RVA = "0x22A2F14", Offset = "0x22A2F14", VA = "0x22A2F14")]
    private void FootMoveTiming(
      FootMoveAnimtionEventReceiver.FootMoveTimingType type)
    {
    }

    [Token(Token = "0x6007B9C")]
    [Address(RVA = "0x22A2FD8", Offset = "0x22A2FD8", VA = "0x22A2FD8")]
    public FootMoveSoundControl()
    {
    }

    [Token(Token = "0x20015DD")]
    private enum MoveType
    {
      [Token(Token = "0x40063C3")] Walk,
      [Token(Token = "0x40063C4")] Run,
    }

    [Token(Token = "0x20015DE")]
    private class NearDistanceCompare : IComparer<RaycastHit>
    {
      [Token(Token = "0x6007B9D")]
      [Address(RVA = "0x22A30EC", Offset = "0x22A30EC", VA = "0x22A30EC", Slot = "4")]
      public int Compare(RaycastHit x, RaycastHit y) => new int();

      [Token(Token = "0x6007B9E")]
      [Address(RVA = "0x22A2CBC", Offset = "0x22A2CBC", VA = "0x22A2CBC")]
      public NearDistanceCompare()
      {
      }
    }
  }
}
