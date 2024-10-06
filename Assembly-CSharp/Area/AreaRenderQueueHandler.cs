// Decompiled with JetBrains decompiler
// Type: Area.AreaRenderQueueHandler
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace Area
{
  [Token(Token = "0x2002822")]
  public class AreaRenderQueueHandler : MonoBehaviour
  {
    [Token(Token = "0x400AB3E")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private int renderQueue;

    [Token(Token = "0x1700377F")]
    public int CustomRenderQueue
    {
      [Token(Token = "0x600FC97"), Address(RVA = "0x44251A4", Offset = "0x44251A4", VA = "0x44251A4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x600FC98")]
    [Address(RVA = "0x44251AC", Offset = "0x44251AC", VA = "0x44251AC")]
    private void Awake()
    {
    }

    [Token(Token = "0x600FC99")]
    [Address(RVA = "0x44251B0", Offset = "0x44251B0", VA = "0x44251B0")]
    public void Initialize()
    {
    }

    [Token(Token = "0x600FC9A")]
    [Address(RVA = "0x44251E0", Offset = "0x44251E0", VA = "0x44251E0")]
    protected void ChangeChildRenderQueueProcess(Transform target)
    {
    }

    [Token(Token = "0x600FC9B")]
    [Address(RVA = "0x442555C", Offset = "0x442555C", VA = "0x442555C")]
    protected void ChangeRenderQueue(Transform target)
    {
    }

    [Token(Token = "0x600FC9C")]
    [Address(RVA = "0x4425678", Offset = "0x4425678", VA = "0x4425678")]
    public AreaRenderQueueHandler()
    {
    }
  }
}
