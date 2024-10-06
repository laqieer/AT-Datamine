// Decompiled with JetBrains decompiler
// Type: Area.MovableMob.Data.MovableRouteData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Area.MovableMob.SceneEdit;
using Common.Attribute;
using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace Area.MovableMob.Data
{
  [Token(Token = "0x200283F")]
  [Serializable]
  public class MovableRouteData
  {
    [Token(Token = "0x400AB9A")]
    [FieldOffset(Offset = "0x10")]
    [Disable]
    [SerializeField]
    private string routeName;
    [Token(Token = "0x400AB9B")]
    [FieldOffset(Offset = "0x18")]
    [SerializeReference]
    private List<IMovableMobAnchorData> anchorDataList;

    [Token(Token = "0x170037BE")]
    public string RouteName
    {
      [Token(Token = "0x600FD62"), Address(RVA = "0x442E388", Offset = "0x442E388", VA = "0x442E388")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x170037BF")]
    public IReadOnlyList<IMovableMobAnchorData> AnchorDataList
    {
      [Token(Token = "0x600FD63"), Address(RVA = "0x442E390", Offset = "0x442E390", VA = "0x442E390")] get
      {
        return (IReadOnlyList<IMovableMobAnchorData>) null;
      }
    }

    [Token(Token = "0x600FD64")]
    [Address(RVA = "0x442E398", Offset = "0x442E398", VA = "0x442E398")]
    public void SetRouteName(string routeName)
    {
    }

    [Token(Token = "0x600FD65")]
    [Address(RVA = "0x442A94C", Offset = "0x442A94C", VA = "0x442A94C")]
    public void AddSceneAnchor(MovableMobSceneAnchorBase sceneAnchor)
    {
    }

    [Token(Token = "0x600FD66")]
    [Address(RVA = "0x442A944", Offset = "0x442A944", VA = "0x442A944")]
    public MovableRouteData()
    {
    }
  }
}
