// Decompiled with JetBrains decompiler
// Type: ScrollBarSizeMinimumLimit
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

#nullable disable
[Token(Token = "0x20002E0")]
[RequireComponent(typeof (ScrollRect))]
public class ScrollBarSizeMinimumLimit : MonoBehaviour
{
  [Token(Token = "0x40010AD")]
  [FieldOffset(Offset = "0x18")]
  [Range(0.0f, 1f)]
  [SerializeField]
  [Tooltip("0を設定すると制限処理を行いません。")]
  private float verticalScrollbarLimitSize;
  [Token(Token = "0x40010AE")]
  [FieldOffset(Offset = "0x1C")]
  [Tooltip("0を設定すると制限処理を行いません。")]
  [Range(0.0f, 1f)]
  [SerializeField]
  private float horizontalScrollbarLimitSize;
  [Token(Token = "0x40010AF")]
  [FieldOffset(Offset = "0x20")]
  private ScrollRect scrollRect;
  [Token(Token = "0x40010B0")]
  [FieldOffset(Offset = "0x28")]
  private UnityAction<Vector2> valueChangeListener;
  [Token(Token = "0x40010B1")]
  [FieldOffset(Offset = "0x30")]
  private Vector2 contentSize;

  [Token(Token = "0x60011FD")]
  [Address(RVA = "0x27DAFAC", Offset = "0x27DAFAC", VA = "0x27DAFAC")]
  private void Awake()
  {
  }

  [Token(Token = "0x60011FE")]
  [Address(RVA = "0x27DB068", Offset = "0x27DB068", VA = "0x27DB068")]
  private void OnEnable()
  {
  }

  [Token(Token = "0x60011FF")]
  [Address(RVA = "0x27DB118", Offset = "0x27DB118", VA = "0x27DB118")]
  private void OnDisable()
  {
  }

  [Token(Token = "0x6001200")]
  [Address(RVA = "0x27DB184", Offset = "0x27DB184", VA = "0x27DB184")]
  private void Update()
  {
  }

  [Token(Token = "0x6001201")]
  [Address(RVA = "0x27DB2B8", Offset = "0x27DB2B8", VA = "0x27DB2B8")]
  private void LimitScrollHandle(Vector2 pos)
  {
  }

  [Token(Token = "0x6001202")]
  [Address(RVA = "0x27DB3CC", Offset = "0x27DB3CC", VA = "0x27DB3CC")]
  public ScrollBarSizeMinimumLimit()
  {
  }
}
