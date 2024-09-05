// Decompiled with JetBrains decompiler
// Type: UnityEngine.PostProcessing.PostProcessingComponentCommandBuffer`1
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine.Rendering;

#nullable disable
namespace UnityEngine.PostProcessing
{
  [Token(Token = "0x2003FAF")]
  public abstract class PostProcessingComponentCommandBuffer<T> : PostProcessingComponent<T> where T : PostProcessingModel
  {
    [Token(Token = "0x60199DC")]
    public abstract CameraEvent GetCameraEvent();

    [Token(Token = "0x60199DD")]
    public abstract string GetName();

    [Token(Token = "0x60199DE")]
    public abstract void PopulateCommandBuffer(CommandBuffer cb);

    [Token(Token = "0x60199DF")]
    protected PostProcessingComponentCommandBuffer()
    {
    }
  }
}
