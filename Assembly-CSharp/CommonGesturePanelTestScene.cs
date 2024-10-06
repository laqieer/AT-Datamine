// Decompiled with JetBrains decompiler
// Type: CommonGesturePanelTestScene
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
[Token(Token = "0x20002E2")]
public class CommonGesturePanelTestScene : GameCore.Scene.Scene
{
  [Token(Token = "0x40010B4")]
  [FieldOffset(Offset = "0x58")]
  [Header("CommonGesturePanelTestScene")]
  public CommonGesturePanel gesturePanel;
  [Token(Token = "0x40010B5")]
  [FieldOffset(Offset = "0x60")]
  public GameObject mainCameraOuterContainer;
  [Token(Token = "0x40010B6")]
  [FieldOffset(Offset = "0x68")]
  public GameObject mainCameraInnerContainer;
  [Token(Token = "0x40010B7")]
  [FieldOffset(Offset = "0x70")]
  private GameObject draggedTarget;
  [Token(Token = "0x40010B8")]
  [FieldOffset(Offset = "0x78")]
  private GameObject rotateTarget;

  [Token(Token = "0x6001207")]
  [Address(RVA = "0x27DB490", Offset = "0x27DB490", VA = "0x27DB490")]
  private void Start()
  {
  }

  [Token(Token = "0x6001208")]
  [Address(RVA = "0x27DB7D8", Offset = "0x27DB7D8", VA = "0x27DB7D8")]
  private new void Update()
  {
  }

  [Token(Token = "0x6001209")]
  [Address(RVA = "0x27DB8A4", Offset = "0x27DB8A4", VA = "0x27DB8A4")]
  private void OnSingleClick(Vector2 position)
  {
  }

  [Token(Token = "0x600120A")]
  [Address(RVA = "0x27DB948", Offset = "0x27DB948", VA = "0x27DB948")]
  private void OnDoubleClick(Vector2 center)
  {
  }

  [Token(Token = "0x600120B")]
  [Address(RVA = "0x27DBA2C", Offset = "0x27DBA2C", VA = "0x27DBA2C")]
  private void OnLongPress(Vector2 Position)
  {
  }

  [Token(Token = "0x600120C")]
  [Address(RVA = "0x27DBBD0", Offset = "0x27DBBD0", VA = "0x27DBBD0")]
  private void OnSinglePointerMoveStart(Vector2 position)
  {
  }

  [Token(Token = "0x600120D")]
  [Address(RVA = "0x27DBCB8", Offset = "0x27DBCB8", VA = "0x27DBCB8")]
  private void OnSinglePointerMove(Vector2 position, Vector2 delta)
  {
  }

  [Token(Token = "0x600120E")]
  [Address(RVA = "0x27DBF2C", Offset = "0x27DBF2C", VA = "0x27DBF2C")]
  private void OnSinglePointerMoveEnd(Vector2 position)
  {
  }

  [Token(Token = "0x600120F")]
  [Address(RVA = "0x27DBF34", Offset = "0x27DBF34", VA = "0x27DBF34")]
  private void OnFlick(CommonGesturePanel.Direction direction, Vector2 speed)
  {
  }

  [Token(Token = "0x6001210")]
  [Address(RVA = "0x27DC1E4", Offset = "0x27DC1E4", VA = "0x27DC1E4")]
  private void OnPinch(float value)
  {
  }

  [Token(Token = "0x6001211")]
  [Address(RVA = "0x27DC39C", Offset = "0x27DC39C", VA = "0x27DC39C")]
  private void OnDoublePointerMoveStart(Vector2 position)
  {
  }

  [Token(Token = "0x6001212")]
  [Address(RVA = "0x27DC484", Offset = "0x27DC484", VA = "0x27DC484")]
  private void OnDoublePointerMove(Vector2 position, Vector2 delta)
  {
  }

  [Token(Token = "0x6001213")]
  [Address(RVA = "0x27DC630", Offset = "0x27DC630", VA = "0x27DC630")]
  private void OnDoublePointerMoveEnd(Vector2 position)
  {
  }

  [Token(Token = "0x6001214")]
  [Address(RVA = "0x27DB7DC", Offset = "0x27DB7DC", VA = "0x27DB7DC")]
  private void UpdateRotateTarget()
  {
  }

  [Token(Token = "0x6001215")]
  [Address(RVA = "0x27DC638", Offset = "0x27DC638", VA = "0x27DC638")]
  public void OnClickReturnButton()
  {
  }

  [Token(Token = "0x6001216")]
  [Address(RVA = "0x27DC6FC", Offset = "0x27DC6FC", VA = "0x27DC6FC")]
  public CommonGesturePanelTestScene()
  {
  }
}
