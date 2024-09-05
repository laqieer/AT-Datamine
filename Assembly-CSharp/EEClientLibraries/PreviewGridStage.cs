// Decompiled with JetBrains decompiler
// Type: EEClientLibraries.PreviewGridStage
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace EEClientLibraries
{
  [Token(Token = "0x200036F")]
  public class PreviewGridStage : MonoBehaviour
  {
    [Token(Token = "0x400142E")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private float oneGridSize;
    [Token(Token = "0x400142F")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private int gridNumber;
    [Token(Token = "0x4001430")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Color gridColor;
    [Token(Token = "0x4001431")]
    [FieldOffset(Offset = "0x30")]
    private Mesh floorMesh;
    [Token(Token = "0x4001432")]
    [FieldOffset(Offset = "0x38")]
    private Material floorMaterial;

    [Token(Token = "0x170001ED")]
    public bool IsMaterialNull
    {
      [Token(Token = "0x60013C5"), Address(RVA = "0x286D9BC", Offset = "0x286D9BC", VA = "0x286D9BC")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x60013C6")]
    [Address(RVA = "0x286DA1C", Offset = "0x286DA1C", VA = "0x286DA1C")]
    public void ForceStart()
    {
    }

    [Token(Token = "0x60013C7")]
    [Address(RVA = "0x286DA20", Offset = "0x286DA20", VA = "0x286DA20")]
    private void Start()
    {
    }

    [Token(Token = "0x60013C8")]
    [Address(RVA = "0x286DED8", Offset = "0x286DED8", VA = "0x286DED8")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x60013C9")]
    [Address(RVA = "0x286DFF0", Offset = "0x286DFF0", VA = "0x286DFF0")]
    public PreviewGridStage()
    {
    }
  }
}
