// Decompiled with JetBrains decompiler
// Type: staq.Camera.CameraStackOrderData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace staq.Camera
{
  [Token(Token = "0x2003D75")]
  [Serializable]
  public class CameraStackOrderData
  {
    [Token(Token = "0x4010DF4")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private string orderName;

    [Token(Token = "0x170050B3")]
    public string OrderName
    {
      [Token(Token = "0x6018B93"), Address(RVA = "0x2647034", Offset = "0x2647034", VA = "0x2647034")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x170050B4")]
    public int Order
    {
      [Token(Token = "0x6018B94"), Address(RVA = "0x264703C", Offset = "0x264703C", VA = "0x264703C")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6018B95")]
    [Address(RVA = "0x2647120", Offset = "0x2647120", VA = "0x2647120")]
    public void SetCameraStackOrder(CameraStackOderType cameraStackOderType)
    {
    }

    [Token(Token = "0x6018B96")]
    [Address(RVA = "0x264713C", Offset = "0x264713C", VA = "0x264713C")]
    public CameraStackOrderData()
    {
    }
  }
}
