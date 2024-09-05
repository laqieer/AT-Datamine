// Decompiled with JetBrains decompiler
// Type: UnityEngine.PostProcessing.PostProcessingComponent`1
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace UnityEngine.PostProcessing
{
  [Token(Token = "0x2003FAE")]
  public abstract class PostProcessingComponent<T> : PostProcessingComponentBase where T : PostProcessingModel
  {
    [Token(Token = "0x1700528F")]
    public T model
    {
      [Token(Token = "0x60199D7")] get => (T) null;
      [Token(Token = "0x60199D8")] internal set
      {
      }
    }

    [Token(Token = "0x60199D9")]
    public virtual void Init(PostProcessingContext pcontext, T pmodel)
    {
    }

    [Token(Token = "0x60199DA")]
    public override PostProcessingModel GetModel() => (PostProcessingModel) null;

    [Token(Token = "0x60199DB")]
    protected PostProcessingComponent()
    {
    }
  }
}
