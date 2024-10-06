// Decompiled with JetBrains decompiler
// Type: Area.MovableMob.SceneEdit.MovableMobRouteEditManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Area.MovableMob.Data;
using Area.MovableMob.Scriptable;
using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace Area.MovableMob.SceneEdit
{
  [Token(Token = "0x2002830")]
  public class MovableMobRouteEditManager : MonoBehaviour
  {
    [Token(Token = "0x400AB6B")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private MovableGeneralParameter movableParameter;
    [Token(Token = "0x400AB6C")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private List<MovableSceneLineHandler> lineList;
    [Token(Token = "0x400AB6D")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private MovableRouteObject testScriptable;
    [Token(Token = "0x400AB6E")]
    [FieldOffset(Offset = "0x30")]
    private List<MovableMobRouteHandler> debugLineHandlerList;

    [Token(Token = "0x1700379A")]
    public MovableGeneralParameter Parameter
    {
      [Token(Token = "0x600FCFA"), Address(RVA = "0x442AAFC", Offset = "0x442AAFC", VA = "0x442AAFC")] get
      {
        return (MovableGeneralParameter) null;
      }
    }

    [Token(Token = "0x1700379B")]
    public IReadOnlyList<MovableSceneLineHandler> LineList
    {
      [Token(Token = "0x600FCFB"), Address(RVA = "0x442AB04", Offset = "0x442AB04", VA = "0x442AB04")] get
      {
        return (IReadOnlyList<MovableSceneLineHandler>) null;
      }
    }

    [Token(Token = "0x600FCFC")]
    [Address(RVA = "0x442AB0C", Offset = "0x442AB0C", VA = "0x442AB0C")]
    private void Start()
    {
    }

    [Token(Token = "0x600FCFD")]
    [Address(RVA = "0x442AF64", Offset = "0x442AF64", VA = "0x442AF64")]
    private void Update()
    {
    }

    [Token(Token = "0x600FCFE")]
    [Address(RVA = "0x442B0C0", Offset = "0x442B0C0", VA = "0x442B0C0")]
    public void DebugSetMovableRouteObject(MovableRouteObject testScriptable)
    {
    }

    [Token(Token = "0x600FCFF")]
    [Address(RVA = "0x442B0C8", Offset = "0x442B0C8", VA = "0x442B0C8")]
    public void AddMovableRoute(MovableSceneLineHandler handler)
    {
    }

    [Token(Token = "0x600FD00")]
    [Address(RVA = "0x442B170", Offset = "0x442B170", VA = "0x442B170")]
    public MovableMobRouteEditManager()
    {
    }
  }
}
