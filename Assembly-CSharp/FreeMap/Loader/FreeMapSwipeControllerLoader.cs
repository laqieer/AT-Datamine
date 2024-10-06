// Decompiled with JetBrains decompiler
// Type: FreeMap.Loader.FreeMapSwipeControllerLoader
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace FreeMap.Loader
{
  [Token(Token = "0x20018A8")]
  public class FreeMapSwipeControllerLoader : IFreeMapResourceElement
  {
    [Token(Token = "0x4006B16")]
    [FieldOffset(Offset = "0x18")]
    private GameObject swipeController;

    [Token(Token = "0x17001672")]
    public FreeMapBuildOrder BuildOrder
    {
      [Token(Token = "0x6008C03"), Address(RVA = "0x452A834", Offset = "0x452A834", VA = "0x452A834", Slot = "4")] get
      {
        return new FreeMapBuildOrder();
      }
    }

    [Token(Token = "0x17001673")]
    protected FreeMapCommonElement CommonElement
    {
      [Token(Token = "0x6008C04"), Address(RVA = "0x452A83C", Offset = "0x452A83C", VA = "0x452A83C")] get
      {
        return (FreeMapCommonElement) null;
      }
    }

    [Token(Token = "0x17001674")]
    protected Canvas Parent
    {
      [Token(Token = "0x6008C05"), Address(RVA = "0x452A844", Offset = "0x452A844", VA = "0x452A844")] get
      {
        return (Canvas) null;
      }
    }

    [Token(Token = "0x6008C06")]
    [Address(RVA = "0x452A84C", Offset = "0x452A84C", VA = "0x452A84C")]
    public FreeMapSwipeControllerLoader(Canvas parent, FreeMapCommonElement commonElement)
    {
    }

    [Token(Token = "0x6008C07")]
    [Address(RVA = "0x452A87C", Offset = "0x452A87C", VA = "0x452A87C", Slot = "5")]
    public void BeforeBuild(IFreeMapResourceLoader loader)
    {
    }

    [Token(Token = "0x6008C08")]
    [Address(RVA = "0x452A9F4", Offset = "0x452A9F4", VA = "0x452A9F4", Slot = "6")]
    public void Build()
    {
    }

    [Token(Token = "0x6008C09")]
    [Address(RVA = "0x452AD98", Offset = "0x452AD98", VA = "0x452AD98")]
    protected void LoadCallback(GameObject asset)
    {
    }
  }
}
