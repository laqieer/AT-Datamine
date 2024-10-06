// Decompiled with JetBrains decompiler
// Type: Scenes.DebugViewer.FreeOperationCamera.IInputEventProvider
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace Scenes.DebugViewer.FreeOperationCamera
{
  [Token(Token = "0x2002F78")]
  public interface IInputEventProvider
  {
    [Token(Token = "0x140001B9")]
    event EventHandler<float> AddFieldOfView;

    [Token(Token = "0x140001BA")]
    event EventHandler<Vector3> MoveDirection;

    [Token(Token = "0x140001BB")]
    event EventHandler<Vector3> MoveRotation;

    [Token(Token = "0x140001BC")]
    event EventHandler ChangeSpeedMode;
  }
}
