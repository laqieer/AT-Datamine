// Decompiled with JetBrains decompiler
// Type: LoginBonus.LoginBonusLoader
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.DLC;
using Il2CppDummyDll;
using System;
using System.Collections;
using System.Collections.Generic;

#nullable disable
namespace LoginBonus
{
  [Token(Token = "0x2000ADE")]
  internal class LoginBonusLoader : IDisposable
  {
    [Token(Token = "0x40031E8")]
    private const string LoginBonusAssetBundleName = "ui_page_loginbonus_prefab";
    [Token(Token = "0x40031E9")]
    private const string AlwaysLoginBonusAssetName = "Container_LoginBonus_Always";
    [Token(Token = "0x40031EC")]
    [FieldOffset(Offset = "0x20")]
    private List<string> loadedAssetBundleNames;

    [Token(Token = "0x170008EA")]
    public AsyncAssetLoader AssetLoader
    {
      [Token(Token = "0x6003DE6"), Address(RVA = "0x2C1223C", Offset = "0x2C1223C", VA = "0x2C1223C")] get
      {
        return (AsyncAssetLoader) null;
      }
      [Token(Token = "0x6003DE7"), Address(RVA = "0x2C12244", Offset = "0x2C12244", VA = "0x2C12244")] private set
      {
      }
    }

    [Token(Token = "0x170008EB")]
    public AlwaysLoginBonusView AlwaysLoginBonusView
    {
      [Token(Token = "0x6003DE8"), Address(RVA = "0x2C1224C", Offset = "0x2C1224C", VA = "0x2C1224C")] get
      {
        return (AlwaysLoginBonusView) null;
      }
      [Token(Token = "0x6003DE9"), Address(RVA = "0x2C12254", Offset = "0x2C12254", VA = "0x2C12254")] private set
      {
      }
    }

    [Token(Token = "0x6003DEA")]
    [Address(RVA = "0x2C0707C", Offset = "0x2C0707C", VA = "0x2C0707C")]
    public LoginBonusLoader(AsyncAssetLoader assetLoader = null)
    {
    }

    [Token(Token = "0x6003DEB")]
    [Address(RVA = "0x2C1225C", Offset = "0x2C1225C", VA = "0x2C1225C")]
    public void AddLoadedAssetBundleName(string assetBundleName)
    {
    }

    [Token(Token = "0x6003DEC")]
    [Address(RVA = "0x2C07688", Offset = "0x2C07688", VA = "0x2C07688", Slot = "4")]
    public void Dispose()
    {
    }

    [Token(Token = "0x6003DED")]
    [Address(RVA = "0x2C12304", Offset = "0x2C12304", VA = "0x2C12304")]
    private string GetLoginBonusAssetBundleName(LoginBonusLoader.LoginBonusType loginBonusType)
    {
      return (string) null;
    }

    [Token(Token = "0x6003DEE")]
    [Address(RVA = "0x2C09108", Offset = "0x2C09108", VA = "0x2C09108")]
    public IEnumerator LoadAlwaysLoginBonusViewAsync(int loginBonusId) => (IEnumerator) null;

    [Token(Token = "0x2000ADF")]
    private enum LoginBonusType
    {
      [Token(Token = "0x40031EE")] Always,
    }
  }
}
