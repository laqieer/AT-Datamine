// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.AreaQuestBoard.CameraController
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

#nullable disable
namespace Scenes.OutGame.AreaQuestBoard
{
  [Token(Token = "0x20038C5")]
  public class CameraController : MonoBehaviour
  {
    [Token(Token = "0x400F83E")]
    [FieldOffset(Offset = "0x1C")]
    private Vector2 _mapBottomRight;
    [Token(Token = "0x400F83F")]
    [FieldOffset(Offset = "0x28")]
    private CameraConfig _config;
    [Token(Token = "0x400F840")]
    [FieldOffset(Offset = "0x30")]
    private Action<Vector2> _tapAction;
    [Token(Token = "0x400F841")]
    [FieldOffset(Offset = "0x38")]
    private Camera _camera;
    [Token(Token = "0x400F842")]
    [FieldOffset(Offset = "0x40")]
    private Vector2 _mapUpperLeft;
    [Token(Token = "0x400F843")]
    [FieldOffset(Offset = "0x48")]
    private bool _isHold;
    [Token(Token = "0x400F844")]
    [FieldOffset(Offset = "0x4C")]
    private float _holdTime;
    [Token(Token = "0x400F845")]
    [FieldOffset(Offset = "0x50")]
    private Vector2 _onMouseDownPosition;
    [Token(Token = "0x400F846")]
    [FieldOffset(Offset = "0x58")]
    private Vector2 _inputMousePosition;
    [Token(Token = "0x400F847")]
    [FieldOffset(Offset = "0x60")]
    private Vector3 _presentPosition;
    [Token(Token = "0x400F848")]
    [FieldOffset(Offset = "0x6C")]
    private Vector2 _focusNode;
    [Token(Token = "0x400F849")]
    [FieldOffset(Offset = "0x74")]
    private bool _startFlick;
    [Token(Token = "0x400F84A")]
    [FieldOffset(Offset = "0x78")]
    private List<RaycastResult> _rayResult;
    [Token(Token = "0x400F84B")]
    [FieldOffset(Offset = "0x80")]
    private bool touchUI;

    [Token(Token = "0x17004972")]
    public bool EnableCamera
    {
      [Token(Token = "0x6016501"), Address(RVA = "0x2077AF4", Offset = "0x2077AF4", VA = "0x2077AF4")] get
      {
        return new bool();
      }
      [Token(Token = "0x6016502"), Address(RVA = "0x2077AFC", Offset = "0x2077AFC", VA = "0x2077AFC")] set
      {
      }
    }

    [Token(Token = "0x17004973")]
    public bool ForcedMovement
    {
      [Token(Token = "0x6016503"), Address(RVA = "0x2077B08", Offset = "0x2077B08", VA = "0x2077B08")] get
      {
        return new bool();
      }
      [Token(Token = "0x6016504"), Address(RVA = "0x2077B10", Offset = "0x2077B10", VA = "0x2077B10")] set
      {
      }
    }

    [Token(Token = "0x6016505")]
    [Address(RVA = "0x2077B1C", Offset = "0x2077B1C", VA = "0x2077B1C")]
    public void Initialize(Camera camera, Action<Vector2> check)
    {
    }

    [Token(Token = "0x6016506")]
    [Address(RVA = "0x2077C18", Offset = "0x2077C18", VA = "0x2077C18")]
    public void SetMovableRange(Rect mapSizeRect)
    {
    }

    [Token(Token = "0x6016507")]
    [Address(RVA = "0x2077CB0", Offset = "0x2077CB0", VA = "0x2077CB0")]
    public void SetFocusNode(int nodeId, bool isMove)
    {
    }

    [Token(Token = "0x6016508")]
    [Address(RVA = "0x2077EAC", Offset = "0x2077EAC", VA = "0x2077EAC")]
    public void SetFocusNodeSubMenu(int nodeId)
    {
    }

    [Token(Token = "0x6016509")]
    [Address(RVA = "0x2077F5C", Offset = "0x2077F5C", VA = "0x2077F5C")]
    private void Update()
    {
    }

    [Token(Token = "0x601650A")]
    [Address(RVA = "0x2078440", Offset = "0x2078440", VA = "0x2078440")]
    private IEnumerator FlickCamera(Vector2 endPosition) => (IEnumerator) null;

    [Token(Token = "0x601650B")]
    [Address(RVA = "0x2077E30", Offset = "0x2077E30", VA = "0x2077E30")]
    private IEnumerator FocusNode(Vector2 endPosition) => (IEnumerator) null;

    [Token(Token = "0x601650C")]
    [Address(RVA = "0x2077DCC", Offset = "0x2077DCC", VA = "0x2077DCC")]
    private Vector3 ClampMapSize(Vector3 pos) => new Vector3();

    [Token(Token = "0x601650D")]
    [Address(RVA = "0x20783A0", Offset = "0x20783A0", VA = "0x20783A0")]
    private bool IsCameraDistanceLessThreshold(Vector2 posA, Vector2 posB) => new bool();

    [Token(Token = "0x601650E")]
    [Address(RVA = "0x207850C", Offset = "0x207850C", VA = "0x207850C")]
    private void ChangeCameraParameter()
    {
    }

    [Token(Token = "0x601650F")]
    [Address(RVA = "0x2078534", Offset = "0x2078534", VA = "0x2078534")]
    public CameraController()
    {
    }
  }
}
