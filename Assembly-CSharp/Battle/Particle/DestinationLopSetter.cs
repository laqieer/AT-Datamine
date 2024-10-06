// Decompiled with JetBrains decompiler
// Type: Battle.Particle.DestinationLopSetter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace Battle.Particle
{
  [Token(Token = "0x20024BE")]
  public class DestinationLopSetter : MonoBehaviour
  {
    [Token(Token = "0x4009D8C")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private ParticleSystem edge;
    [Token(Token = "0x4009D8D")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private ParticleSystem line;
    [Token(Token = "0x4009D8E")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private ParticleSystem floor;
    [Token(Token = "0x4009D8F")]
    private const string ClearEdgeColor = "#06153F";
    [Token(Token = "0x4009D90")]
    private const string ClearLineColor = "#074E88";
    [Token(Token = "0x4009D91")]
    private const string ClearFloorColor = "#0B2878";
    [Token(Token = "0x4009D92")]
    private const string FailEdgeColor = "#3F0606";
    [Token(Token = "0x4009D93")]
    private const string FailLineColor = "#732E2E";
    [Token(Token = "0x4009D94")]
    private const string FailFloorColor = "#610909";

    [Token(Token = "0x600E20F")]
    [Address(RVA = "0x426754C", Offset = "0x426754C", VA = "0x426754C")]
    public void SetClearParticleStartColor()
    {
    }

    [Token(Token = "0x600E210")]
    [Address(RVA = "0x4267750", Offset = "0x4267750", VA = "0x4267750")]
    public void SetFailParticleStartColor()
    {
    }

    [Token(Token = "0x600E211")]
    [Address(RVA = "0x4267954", Offset = "0x4267954", VA = "0x4267954")]
    public DestinationLopSetter()
    {
    }
  }
}
