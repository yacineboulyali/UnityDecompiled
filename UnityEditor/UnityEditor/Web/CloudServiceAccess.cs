﻿// Decompiled with JetBrains decompiler
// Type: UnityEditor.Web.CloudServiceAccess
// Assembly: UnityEditor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 53BAA40C-AA1D-48D3-AA10-3FCF36D212BC
// Assembly location: C:\Program Files\Unity 5\Editor\Data\Managed\UnityEditor.dll

using UnityEditor.Connect;

namespace UnityEditor.Web
{
  internal abstract class CloudServiceAccess
  {
    public abstract string GetServiceName();

    protected WebView GetWebView()
    {
      return UnityConnectServiceCollection.instance.GetWebViewFromServiceName(this.GetServiceName());
    }

    protected string GetSafeServiceName()
    {
      return this.GetServiceName().Replace(' ', '_');
    }

    public virtual string GetServiceDisplayName()
    {
      return this.GetServiceName();
    }

    public virtual string GetPackageName()
    {
      return string.Empty;
    }

    public virtual bool IsServiceEnabled()
    {
      return PlayerSettings.GetCloudServiceEnabled(this.GetServiceName());
    }

    public virtual void EnableService(bool enabled)
    {
      PlayerSettings.SetCloudServiceEnabled(this.GetServiceName(), enabled);
    }

    public virtual string GetCurrentPackageVersion()
    {
      return PackageUtils.instance.GetCurrentVersion(this.GetPackageName());
    }

    public virtual string GetLatestPackageVersion()
    {
      return PackageUtils.instance.GetLatestVersion(this.GetPackageName());
    }

    public virtual void UpdateLatestPackage()
    {
      PackageUtils.instance.UpdateLatest(this.GetPackageName());
    }

    public virtual void OnProjectUnbound()
    {
    }

    public void ShowServicePage()
    {
      UnityConnectServiceCollection.instance.ShowService(this.GetServiceName(), true, "show_service_page");
    }

    public void GoBackToHub()
    {
      UnityConnectServiceCollection.instance.ShowService("Hub", true, "go_back_to_hub");
    }
  }
}