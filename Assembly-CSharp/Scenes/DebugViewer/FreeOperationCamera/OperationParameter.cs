// Decompiled with JetBrains decompiler
// Type: Scenes.DebugViewer.FreeOperationCamera.OperationParameter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace Scenes.DebugViewer.FreeOperationCamera
{
  [Token(Token = "0x2002F72")]
  [Serializable]
  public struct OperationParameter
  {
    [Token(Token = "0x400CB2C")]
    [FieldOffset(Offset = "0x0")]
    public float MoveSpeed;
    [Token(Token = "0x400CB2D")]
    [FieldOffset(Offset = "0x4")]
    public float RotateSpeed;
    [Token(Token = "0x400CB2E")]
    [FieldOffset(Offset = "0x8")]
    public float RateChangeFoV;
    [Token(Token = "0x400CB2F")]
    [FieldOffset(Offset = "0x0")]
    public static readonly OperationParameter Default;

    [Token(Token = "0x60128CF")]
    [Address(RVA = "0x2127250", Offset = "0x2127250", VA = "0x2127250")]
    public static OperationParameter operator *(OperationParameter self, float rate)
    {
      return new OperationParameter();
    }

    [Token(Token = "0x60128D0")]
    [Address(RVA = "0x2127260", Offset = "0x2127260", VA = "0x2127260")]
    static OperationParameter()
    {
    }
  }
}
