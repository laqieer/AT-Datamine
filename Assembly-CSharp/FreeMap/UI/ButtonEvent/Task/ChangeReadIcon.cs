// Decompiled with JetBrains decompiler
// Type: FreeMap.UI.ButtonEvent.Task.ChangeReadIcon
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FreeMap.Loader;
using FreeMap.Parameter.UIParam;
using FreeMap.UI.Builder;
using Il2CppDummyDll;

#nullable disable
namespace FreeMap.UI.ButtonEvent.Task
{
  [Token(Token = "0x2001719")]
  public class ChangeReadIcon : IFreeMapButtonEventTask
  {
    [Token(Token = "0x40066F0")]
    [FieldOffset(Offset = "0x38")]
    private FreeMapResourceLoader.Handle handle;

    [Token(Token = "0x17001473")]
    private bool IsActive
    {
      [Token(Token = "0x60082B1"), Address(RVA = "0x4201A08", Offset = "0x4201A08", VA = "0x4201A08")] set
      {
      }
      [Token(Token = "0x60082B2"), Address(RVA = "0x4201A14", Offset = "0x4201A14", VA = "0x4201A14")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17001474")]
    private FreeMapResourceLoader ResourceLoader
    {
      [Token(Token = "0x60082B3"), Address(RVA = "0x4201A1C", Offset = "0x4201A1C", VA = "0x4201A1C")] get
      {
        return (FreeMapResourceLoader) null;
      }
    }

    [Token(Token = "0x17001475")]
    private FreeMapUIManageHandler UIManager
    {
      [Token(Token = "0x60082B4"), Address(RVA = "0x4201A24", Offset = "0x4201A24", VA = "0x4201A24")] get
      {
        return (FreeMapUIManageHandler) null;
      }
    }

    [Token(Token = "0x17001476")]
    private SpriteAssetLoader SpriteLoader
    {
      [Token(Token = "0x60082B5"), Address(RVA = "0x4201A2C", Offset = "0x4201A2C", VA = "0x4201A2C")] set
      {
      }
      [Token(Token = "0x60082B6"), Address(RVA = "0x4201A34", Offset = "0x4201A34", VA = "0x4201A34")] get
      {
        return (SpriteAssetLoader) null;
      }
    }

    [Token(Token = "0x17001477")]
    private FreeMapUIParamBase TargetUI
    {
      [Token(Token = "0x60082B7"), Address(RVA = "0x4201A3C", Offset = "0x4201A3C", VA = "0x4201A3C")] set
      {
      }
      [Token(Token = "0x60082B8"), Address(RVA = "0x4201A44", Offset = "0x4201A44", VA = "0x4201A44")] get
      {
        return (FreeMapUIParamBase) null;
      }
    }

    [Token(Token = "0x60082B9")]
    [Address(RVA = "0x41F715C", Offset = "0x41F715C", VA = "0x41F715C")]
    public ChangeReadIcon(
      FreeMapResourceLoader resourceLoader,
      FreeMapUIManageHandler uiManager,
      FreeMapUIParamBase targetUI)
    {
    }

    [Token(Token = "0x60082BA")]
    [Address(RVA = "0x4201A4C", Offset = "0x4201A4C", VA = "0x4201A4C", Slot = "4")]
    public void Execute()
    {
    }

    [Token(Token = "0x60082BB")]
    [Address(RVA = "0x4201B80", Offset = "0x4201B80", VA = "0x4201B80", Slot = "5")]
    public void Update()
    {
    }

    [Token(Token = "0x60082BC")]
    [Address(RVA = "0x4201CB4", Offset = "0x4201CB4", VA = "0x4201CB4", Slot = "6")]
    public bool IsBusy() => new bool();

    [Token(Token = "0x60082BD")]
    [Address(RVA = "0x41F75F8", Offset = "0x41F75F8", VA = "0x41F75F8")]
    public void SetActive(bool isActive)
    {
    }
  }
}
