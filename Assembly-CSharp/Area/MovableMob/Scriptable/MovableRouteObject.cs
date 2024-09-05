// Decompiled with JetBrains decompiler
// Type: Area.MovableMob.Scriptable.MovableRouteObject
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Area.MovableMob.Data;
using Area.MovableMob.SceneEdit;
using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace Area.MovableMob.Scriptable
{
  [Token(Token = "0x200282E")]
  public class MovableRouteObject : ScriptableObject
  {
    [Token(Token = "0x400AB68")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private MovableGeneralParameter movableParameter;
    [Token(Token = "0x400AB69")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private List<MovableRouteData> routeData;

    [Token(Token = "0x17003798")]
    public MovableGeneralParameter GeneralParameter
    {
      [Token(Token = "0x600FCF2"), Address(RVA = "0x442A23C", Offset = "0x442A23C", VA = "0x442A23C")] get
      {
        return (MovableGeneralParameter) null;
      }
    }

    [Token(Token = "0x17003799")]
    public IReadOnlyList<MovableRouteData> RouteData
    {
      [Token(Token = "0x600FCF3"), Address(RVA = "0x442A244", Offset = "0x442A244", VA = "0x442A244")] get
      {
        return (IReadOnlyList<MovableRouteData>) null;
      }
    }

    [Token(Token = "0x600FCF4")]
    [Address(RVA = "0x442A24C", Offset = "0x442A24C", VA = "0x442A24C")]
    public void ClearRouteData()
    {
    }

    [Token(Token = "0x600FCF5")]
    [Address(RVA = "0x442A2BC", Offset = "0x442A2BC", VA = "0x442A2BC")]
    public void SetData(MovableMobRouteEditManager manager)
    {
    }

    [Token(Token = "0x600FCF6")]
    [Address(RVA = "0x442873C", Offset = "0x442873C", VA = "0x442873C")]
    public bool TryGetRouteData(string name, out MovableRouteData routeData) => new bool();

    [Token(Token = "0x600FCF7")]
    [Address(RVA = "0x442AA5C", Offset = "0x442AA5C", VA = "0x442AA5C")]
    public MovableRouteObject()
    {
    }
  }
}
