// Decompiled with JetBrains decompiler
// Type: UniteStratagemTestScene
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.UniteStratagem;
using GameCore.Scene;
using Il2CppDummyDll;
using UnityEngine;

#nullable disable
[Token(Token = "0x20002B4")]
[RequireComponent(typeof (UniteStratagemTester))]
public class UniteStratagemTestScene : GameCore.Scene.Scene
{
  [Token(Token = "0x4000FF2")]
  [FieldOffset(Offset = "0x58")]
  [SerializeField]
  [HideInInspector]
  private UniteStratagemTester tester;

  [Token(Token = "0x60010EB")]
  [Address(RVA = "0x1BEBA0C", Offset = "0x1BEBA0C", VA = "0x1BEBA0C")]
  private void Awake()
  {
  }

  [Token(Token = "0x60010EC")]
  [Address(RVA = "0x1BEBA90", Offset = "0x1BEBA90", VA = "0x1BEBA90", Slot = "6")]
  public override void Initialize(ChangeSceneParameter param = null)
  {
  }

  [Token(Token = "0x60010ED")]
  [Address(RVA = "0x1BEBAB0", Offset = "0x1BEBAB0", VA = "0x1BEBAB0")]
  private void OnValidate()
  {
  }

  [Token(Token = "0x60010EE")]
  [Address(RVA = "0x1BEBB00", Offset = "0x1BEBB00", VA = "0x1BEBB00")]
  public UniteStratagemTestScene()
  {
  }
}
