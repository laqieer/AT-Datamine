// Decompiled with JetBrains decompiler
// Type: staq.Camera.CameraStackManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.DesignPattern;
using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace staq.Camera
{
  [Token(Token = "0x2003D6D")]
  public class CameraStackManager : Singleton<CameraStackManager>
  {
    [Token(Token = "0x4010DE0")]
    [FieldOffset(Offset = "0x10")]
    private Dictionary<string, ICameraStackData> taggedCameraStacks;
    [Token(Token = "0x4010DE1")]
    [FieldOffset(Offset = "0x18")]
    private List<ICameraStackData> untaggedCameraStacks;
    [Token(Token = "0x4010DE2")]
    [FieldOffset(Offset = "0x20")]
    private List<CameraStackManager.CameraGetRequest> cameraGetRequests;
    [Token(Token = "0x4010DE3")]
    [FieldOffset(Offset = "0x28")]
    private UnityEngine.Camera baseCamera;

    [Token(Token = "0x170050AF")]
    public Dictionary<string, ICameraStackData> TaggedCameraStacks
    {
      [Token(Token = "0x6018B6D"), Address(RVA = "0x2644064", Offset = "0x2644064", VA = "0x2644064")] get
      {
        return (Dictionary<string, ICameraStackData>) null;
      }
    }

    [Token(Token = "0x170050B0")]
    public List<ICameraStackData> UntaggedCameraStacks
    {
      [Token(Token = "0x6018B6E"), Address(RVA = "0x264406C", Offset = "0x264406C", VA = "0x264406C")] get
      {
        return (List<ICameraStackData>) null;
      }
    }

    [Token(Token = "0x6018B6F")]
    [Address(RVA = "0x2642754", Offset = "0x2642754", VA = "0x2642754")]
    public void RegisterBaseCamera(ICameraStackData cameraStackData)
    {
    }

    [Token(Token = "0x6018B70")]
    [Address(RVA = "0x2642858", Offset = "0x2642858", VA = "0x2642858")]
    public void UnRegisterBaseCamera()
    {
    }

    [Token(Token = "0x6018B71")]
    [Address(RVA = "0x26444AC", Offset = "0x26444AC", VA = "0x26444AC")]
    public void RegisterOverlayCamera(ICameraStackData cameraStackData)
    {
    }

    [Token(Token = "0x6018B72")]
    [Address(RVA = "0x2645290", Offset = "0x2645290", VA = "0x2645290")]
    private static void OverwriteForOverlayCamera(UnityEngine.Camera camera)
    {
    }

    [Token(Token = "0x6018B73")]
    [Address(RVA = "0x2644074", Offset = "0x2644074", VA = "0x2644074")]
    private static void OverwriteForBaseCamera(UnityEngine.Camera camera)
    {
    }

    [Token(Token = "0x6018B74")]
    [Address(RVA = "0x26452C0", Offset = "0x26452C0", VA = "0x26452C0")]
    private void DeliverCameraInstance(string tagName, UnityEngine.Camera camera)
    {
    }

    [Token(Token = "0x6018B75")]
    [Address(RVA = "0x2645504", Offset = "0x2645504", VA = "0x2645504")]
    public void UnRegisterOverlayCamera(ICameraStackData cameraStackData)
    {
    }

    [Token(Token = "0x6018B76")]
    [Address(RVA = "0x2644EE8", Offset = "0x2644EE8", VA = "0x2644EE8")]
    private void RemoveInvalidCameras()
    {
    }

    [Token(Token = "0x6018B77")]
    [Address(RVA = "0x264409C", Offset = "0x264409C", VA = "0x264409C")]
    public void RebuildCameraStack()
    {
    }

    [Token(Token = "0x6018B78")]
    [Address(RVA = "0x2645738", Offset = "0x2645738", VA = "0x2645738")]
    public UnityEngine.Camera GetBaseCamera() => (UnityEngine.Camera) null;

    [Token(Token = "0x6018B79")]
    [Address(RVA = "0x2644CF4", Offset = "0x2644CF4", VA = "0x2644CF4")]
    private string GetHierarchyPath(MonoBehaviour monoBehaviour) => (string) null;

    [Token(Token = "0x6018B7A")]
    [Address(RVA = "0x2645740", Offset = "0x2645740", VA = "0x2645740")]
    public void GetOverlayCamera(string tagName, ICameraIntanceGetter cameraIntanceGetter)
    {
    }

    [Token(Token = "0x6018B7B")]
    [Address(RVA = "0x2645B8C", Offset = "0x2645B8C", VA = "0x2645B8C")]
    public void GetOverlayCamera(string tagName, Action<UnityEngine.Camera> onReceiveCameraInstance)
    {
    }

    [Token(Token = "0x6018B7C")]
    [Address(RVA = "0x2645C08", Offset = "0x2645C08", VA = "0x2645C08")]
    public void SetPostProcessEnable(bool enable)
    {
    }

    [Token(Token = "0x6018B7D")]
    [Address(RVA = "0x2646088", Offset = "0x2646088", VA = "0x2646088")]
    public void SetBackGroundPostProcessEnable(bool enable)
    {
    }

    [Token(Token = "0x6018B7E")]
    [Address(RVA = "0x26465E4", Offset = "0x26465E4", VA = "0x26465E4")]
    public void SetTargetTagPostProcessEnable(string tagName, bool enable)
    {
    }

    [Token(Token = "0x6018B7F")]
    [Address(RVA = "0x26469CC", Offset = "0x26469CC", VA = "0x26469CC")]
    public CameraStackManager()
    {
    }

    [Token(Token = "0x2003D6E")]
    private class CameraGetRequest
    {
      [Token(Token = "0x170050B1")]
      public string tagName
      {
        [Token(Token = "0x6018B80"), Address(RVA = "0x2646AE4", Offset = "0x2646AE4", VA = "0x2646AE4")] get
        {
          return (string) null;
        }
        [Token(Token = "0x6018B81"), Address(RVA = "0x2646AEC", Offset = "0x2646AEC", VA = "0x2646AEC")] set
        {
        }
      }

      [Token(Token = "0x170050B2")]
      public ICameraIntanceGetter cameraInstanceGetter
      {
        [Token(Token = "0x6018B82"), Address(RVA = "0x2646AF4", Offset = "0x2646AF4", VA = "0x2646AF4")] get
        {
          return (ICameraIntanceGetter) null;
        }
        [Token(Token = "0x6018B83"), Address(RVA = "0x2646AFC", Offset = "0x2646AFC", VA = "0x2646AFC")] set
        {
        }
      }

      [Token(Token = "0x6018B84")]
      [Address(RVA = "0x2645B84", Offset = "0x2645B84", VA = "0x2645B84")]
      public CameraGetRequest()
      {
      }
    }
  }
}
