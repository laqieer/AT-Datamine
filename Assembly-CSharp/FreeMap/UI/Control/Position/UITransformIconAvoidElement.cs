// Decompiled with JetBrains decompiler
// Type: FreeMap.UI.Control.Position.UITransformIconAvoidElement
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FreeMap.UI.Entity;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.U2D;

#nullable disable
namespace FreeMap.UI.Control.Position
{
  [Token(Token = "0x20016B4")]
  [RequireComponent(typeof (BoxCollider2D))]
  [RequireComponent(typeof (Rigidbody2D))]
  public class UITransformIconAvoidElement : MonoBehaviour
  {
    [Token(Token = "0x40065BD")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private SpriteAtlas spriteAtlas;
    [Token(Token = "0x40065BE")]
    [FieldOffset(Offset = "0x20")]
    private RectTransform parentRectTransform;
    [Token(Token = "0x40065BF")]
    [FieldOffset(Offset = "0x28")]
    private Vector3 originLocalPosition;
    [Token(Token = "0x40065C0")]
    [FieldOffset(Offset = "0x34")]
    private Vector3 oldpos;
    [Token(Token = "0x40065C1")]
    [FieldOffset(Offset = "0x40")]
    private Rigidbody2D rigidbody2D;
    [Token(Token = "0x40065C3")]
    [FieldOffset(Offset = "0x50")]
    private BoxCollider2D boxCollider2D;
    [Token(Token = "0x40065C4")]
    [FieldOffset(Offset = "0x58")]
    private CircleCollider2D circleCollider;

    [Token(Token = "0x170013EC")]
    public FreeMapUIBase Owner
    {
      [Token(Token = "0x600807B"), Address(RVA = "0x41F447C", Offset = "0x41F447C", VA = "0x41F447C")] get
      {
        return (FreeMapUIBase) null;
      }
      [Token(Token = "0x600807C"), Address(RVA = "0x41F4484", Offset = "0x41F4484", VA = "0x41F4484")] private set
      {
      }
    }

    [Token(Token = "0x600807D")]
    [Address(RVA = "0x41F448C", Offset = "0x41F448C", VA = "0x41F448C")]
    private void Start()
    {
    }

    [Token(Token = "0x600807E")]
    [Address(RVA = "0x41F3CF4", Offset = "0x41F3CF4", VA = "0x41F3CF4")]
    public void Initialize(FreeMapUIBase owner)
    {
    }

    [Token(Token = "0x600807F")]
    [Address(RVA = "0x41F41FC", Offset = "0x41F41FC", VA = "0x41F41FC")]
    public void OnUpdate()
    {
    }

    [Token(Token = "0x6008080")]
    [Address(RVA = "0x41F44BC", Offset = "0x41F44BC", VA = "0x41F44BC")]
    private void ChangeRigidbodyConstraints()
    {
    }

    [Token(Token = "0x6008081")]
    [Address(RVA = "0x41F45B0", Offset = "0x41F45B0", VA = "0x41F45B0")]
    private void OnTriggerStay2D(Collider2D collision)
    {
    }

    [Token(Token = "0x6008082")]
    [Address(RVA = "0x41F46A0", Offset = "0x41F46A0", VA = "0x41F46A0")]
    private void AvoidLeftAndRightSideAxis(Collider2D collision)
    {
    }

    [Token(Token = "0x6008083")]
    [Address(RVA = "0x41F491C", Offset = "0x41F491C", VA = "0x41F491C")]
    private void AvoidTopAndBottomSideAxis(Collider2D collision)
    {
    }

    [Token(Token = "0x6008084")]
    [Address(RVA = "0x41F4B00", Offset = "0x41F4B00", VA = "0x41F4B00")]
    private bool IsOtherOverLap(Collider2D owner, Collider2D hitCollision) => new bool();

    [Token(Token = "0x6008085")]
    [Address(RVA = "0x41F4D60", Offset = "0x41F4D60", VA = "0x41F4D60")]
    public UITransformIconAvoidElement()
    {
    }
  }
}
