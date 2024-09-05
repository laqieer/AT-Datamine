// Decompiled with JetBrains decompiler
// Type: staq.Camera.BaseCameraRegister
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace staq.Camera
{
  [Token(Token = "0x2003D5D")]
  [RequireComponent(typeof (UnityEngine.Camera))]
  public class BaseCameraRegister : MonoBehaviour, ICameraStackData
  {
    [Token(Token = "0x4010DB9")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private int priority;
    [Token(Token = "0x4010DBA")]
    [FieldOffset(Offset = "0x20")]
    private UnityEngine.Camera targetCamera;
    [Token(Token = "0x4010DBB")]
    [FieldOffset(Offset = "0x28")]
    private bool renderPostProcessing;
    [Token(Token = "0x4010DBC")]
    [FieldOffset(Offset = "0x2C")]
    private int enablePostProcessingRequestCount;

    [Token(Token = "0x170050A1")]
    private int staq\u002ECamera\u002EICameraStackData\u002EPriority
    {
      [Token(Token = "0x6018B15"), Address(RVA = "0x2642650", Offset = "0x2642650", VA = "0x2642650", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x170050A2")]
    private UnityEngine.Camera staq\u002ECamera\u002EICameraStackData\u002ETargetCamera
    {
      [Token(Token = "0x6018B16"), Address(RVA = "0x2642658", Offset = "0x2642658", VA = "0x2642658", Slot = "5")] get
      {
        return (UnityEngine.Camera) null;
      }
    }

    [Token(Token = "0x170050A3")]
    private int staq\u002ECamera\u002EICameraStackData\u002EOrder
    {
      [Token(Token = "0x6018B17"), Address(RVA = "0x2642660", Offset = "0x2642660", VA = "0x2642660", Slot = "6")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x170050A4")]
    private string staq\u002ECamera\u002EICameraStackData\u002EOrderName
    {
      [Token(Token = "0x6018B18"), Address(RVA = "0x2642668", Offset = "0x2642668", VA = "0x2642668", Slot = "7")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x170050A5")]
    private string staq\u002ECamera\u002EICameraStackData\u002ECameraTag
    {
      [Token(Token = "0x6018B19"), Address(RVA = "0x26426A8", Offset = "0x26426A8", VA = "0x26426A8", Slot = "8")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x170050A6")]
    public bool IsRenderPostProcessing
    {
      [Token(Token = "0x6018B1A"), Address(RVA = "0x26426B0", Offset = "0x26426B0", VA = "0x26426B0", Slot = "9")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x170050A7")]
    public int EnablePostProcessingRequestCount
    {
      [Token(Token = "0x6018B1B"), Address(RVA = "0x26426B8", Offset = "0x26426B8", VA = "0x26426B8", Slot = "10")] get
      {
        return new int();
      }
      [Token(Token = "0x6018B1C"), Address(RVA = "0x26426C0", Offset = "0x26426C0", VA = "0x26426C0", Slot = "11")] set
      {
      }
    }

    [Token(Token = "0x6018B1D")]
    [Address(RVA = "0x26426C8", Offset = "0x26426C8", VA = "0x26426C8")]
    private void Awake()
    {
    }

    [Token(Token = "0x6018B1E")]
    [Address(RVA = "0x2642808", Offset = "0x2642808", VA = "0x2642808")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x6018B1F")]
    [Address(RVA = "0x2642860", Offset = "0x2642860", VA = "0x2642860")]
    public BaseCameraRegister()
    {
    }
  }
}
