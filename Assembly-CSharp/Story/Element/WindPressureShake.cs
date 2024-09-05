// Decompiled with JetBrains decompiler
// Type: Story.Element.WindPressureShake
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace Story.Element
{
  [Token(Token = "0x20006B2")]
  public class WindPressureShake : MonoBehaviour
  {
    [Token(Token = "0x4002001")]
    [FieldOffset(Offset = "0x18")]
    public Vector3 MoveDirection;
    [Token(Token = "0x4002002")]
    [FieldOffset(Offset = "0x24")]
    public float MovePower;
    [Token(Token = "0x4002003")]
    [FieldOffset(Offset = "0x28")]
    public float MoveSizeMin;
    [Token(Token = "0x4002004")]
    [FieldOffset(Offset = "0x2C")]
    public float MoveSizeMax;
    [Token(Token = "0x4002005")]
    [FieldOffset(Offset = "0x30")]
    protected Vector3 startLocalPosition;
    [Token(Token = "0x4002006")]
    [FieldOffset(Offset = "0x3C")]
    protected float moveSizeNow;
    [Token(Token = "0x4002007")]
    [FieldOffset(Offset = "0x40")]
    protected float moveSize;

    [Token(Token = "0x60025F0")]
    [Address(RVA = "0x2F3F5A4", Offset = "0x2F3F5A4", VA = "0x2F3F5A4")]
    private void Awake()
    {
    }

    [Token(Token = "0x60025F1")]
    [Address(RVA = "0x2F3F5B0", Offset = "0x2F3F5B0", VA = "0x2F3F5B0")]
    private void OnEnable()
    {
    }

    [Token(Token = "0x60025F2")]
    [Address(RVA = "0x2F3F640", Offset = "0x2F3F640", VA = "0x2F3F640")]
    private void Update()
    {
    }

    [Token(Token = "0x60025F3")]
    [Address(RVA = "0x2F3F60C", Offset = "0x2F3F60C", VA = "0x2F3F60C")]
    protected float GetMoveSize() => new float();

    [Token(Token = "0x60025F4")]
    [Address(RVA = "0x2F3F7BC", Offset = "0x2F3F7BC", VA = "0x2F3F7BC")]
    public WindPressureShake()
    {
    }
  }
}
