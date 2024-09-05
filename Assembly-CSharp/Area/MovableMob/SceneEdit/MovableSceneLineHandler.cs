// Decompiled with JetBrains decompiler
// Type: Area.MovableMob.SceneEdit.MovableSceneLineHandler
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Area.MovableMob.Data;
using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace Area.MovableMob.SceneEdit
{
  [Token(Token = "0x2002833")]
  public class MovableSceneLineHandler : MonoBehaviour
  {
    [Token(Token = "0x400AB72")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private MovablePartialRouteParameter lineParameter;
    [Token(Token = "0x400AB73")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private string singleMobTableLabel;
    [Token(Token = "0x400AB74")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private List<MovableSingleMobInstanceData> popMobInstanceParams;
    [Token(Token = "0x400AB75")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private string pairMobTableLabel;
    [Token(Token = "0x400AB76")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private List<MovablePairMobInstanceData> popTwinMobsInstanceParamList;
    [Token(Token = "0x400AB77")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private List<MovableMobSceneAnchorBase> movableRoute;

    [Token(Token = "0x1700379E")]
    public MovablePartialRouteParameter LineParameter
    {
      [Token(Token = "0x600FD0C"), Address(RVA = "0x442B850", Offset = "0x442B850", VA = "0x442B850")] get
      {
        return (MovablePartialRouteParameter) null;
      }
    }

    [Token(Token = "0x1700379F")]
    public string SingleMobTableLabel
    {
      [Token(Token = "0x600FD0D"), Address(RVA = "0x442B858", Offset = "0x442B858", VA = "0x442B858")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x170037A0")]
    public List<MovableSingleMobInstanceData> PopInstanceSingleDataList
    {
      [Token(Token = "0x600FD0E"), Address(RVA = "0x442B860", Offset = "0x442B860", VA = "0x442B860")] get
      {
        return (List<MovableSingleMobInstanceData>) null;
      }
    }

    [Token(Token = "0x170037A1")]
    public string PairMobTableLabel
    {
      [Token(Token = "0x600FD0F"), Address(RVA = "0x442B868", Offset = "0x442B868", VA = "0x442B868")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x170037A2")]
    public List<MovablePairMobInstanceData> PopTwinMobsInstanceParamList
    {
      [Token(Token = "0x600FD10"), Address(RVA = "0x442B870", Offset = "0x442B870", VA = "0x442B870")] get
      {
        return (List<MovablePairMobInstanceData>) null;
      }
    }

    [Token(Token = "0x170037A3")]
    public IReadOnlyList<MovableMobSceneAnchorBase> MovableRoute
    {
      [Token(Token = "0x600FD11"), Address(RVA = "0x442B878", Offset = "0x442B878", VA = "0x442B878")] get
      {
        return (IReadOnlyList<MovableMobSceneAnchorBase>) null;
      }
    }

    [Token(Token = "0x600FD12")]
    [Address(RVA = "0x442AE78", Offset = "0x442AE78", VA = "0x442AE78")]
    public void DebugInitialize()
    {
    }

    [Token(Token = "0x600FD13")]
    [Address(RVA = "0x442B888", Offset = "0x442B888", VA = "0x442B888")]
    public void AddAnchor(MovableMobSceneAnchorBase anchor)
    {
    }

    [Token(Token = "0x600FD14")]
    [Address(RVA = "0x442B930", Offset = "0x442B930", VA = "0x442B930")]
    public MovableSceneLineHandler()
    {
    }
  }
}
