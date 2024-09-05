// Decompiled with JetBrains decompiler
// Type: FreeMoveEscape.EscapeEffectControlHolder
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FreeMap.Loader;
using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace FreeMoveEscape
{
  [Token(Token = "0x20015D6")]
  public class EscapeEffectControlHolder : IFreeMapResourceElement
  {
    [Token(Token = "0x40063B2")]
    private const string AssetBundleName = "content_freemap_prefabs_freemovetutorial";
    [Token(Token = "0x40063B3")]
    private const string AssetName = "EscapeEffectControl";
    [Token(Token = "0x40063B5")]
    [FieldOffset(Offset = "0x18")]
    private GameObject controlGo;
    [Token(Token = "0x40063B6")]
    [FieldOffset(Offset = "0x20")]
    private FreeMoveEscapeEffectControl con;

    [Token(Token = "0x17001301")]
    public FreeMapBuildOrder BuildOrder
    {
      [Token(Token = "0x6007B7A"), Address(RVA = "0x22A202C", Offset = "0x22A202C", VA = "0x22A202C", Slot = "4")] get
      {
        return new FreeMapBuildOrder();
      }
    }

    [Token(Token = "0x17001302")]
    public bool IsBuildEnded
    {
      [Token(Token = "0x6007B7B"), Address(RVA = "0x22A2034", Offset = "0x22A2034", VA = "0x22A2034")] set
      {
      }
      [Token(Token = "0x6007B7C"), Address(RVA = "0x22A2040", Offset = "0x22A2040", VA = "0x22A2040")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x6007B7D")]
    [Address(RVA = "0x22A2048", Offset = "0x22A2048", VA = "0x22A2048", Slot = "5")]
    public void BeforeBuild(IFreeMapResourceLoader loader)
    {
    }

    [Token(Token = "0x6007B7E")]
    [Address(RVA = "0x22A2198", Offset = "0x22A2198", VA = "0x22A2198", Slot = "6")]
    public void Build()
    {
    }

    [Token(Token = "0x6007B7F")]
    [Address(RVA = "0x22A21A4", Offset = "0x22A21A4", VA = "0x22A21A4")]
    protected void LoadedCallback(GameObject prefab)
    {
    }

    [Token(Token = "0x6007B80")]
    [Address(RVA = "0x22A224C", Offset = "0x22A224C", VA = "0x22A224C")]
    public void SetGlobalVolumeObject(GameObject obj)
    {
    }

    [Token(Token = "0x6007B81")]
    [Address(RVA = "0x22A22DC", Offset = "0x22A22DC", VA = "0x22A22DC")]
    public void UpdateDistanceRatio(float distanceRatio)
    {
    }

    [Token(Token = "0x6007B82")]
    [Address(RVA = "0x22A235C", Offset = "0x22A235C", VA = "0x22A235C")]
    public void FadeStart()
    {
    }

    [Token(Token = "0x6007B83")]
    [Address(RVA = "0x22A23D4", Offset = "0x22A23D4", VA = "0x22A23D4")]
    public void PostEffectStart()
    {
    }

    [Token(Token = "0x6007B84")]
    [Address(RVA = "0x22A245C", Offset = "0x22A245C", VA = "0x22A245C")]
    public void Destroy()
    {
    }

    [Token(Token = "0x6007B85")]
    [Address(RVA = "0x22A24C0", Offset = "0x22A24C0", VA = "0x22A24C0")]
    public EscapeEffectControlHolder()
    {
    }
  }
}
