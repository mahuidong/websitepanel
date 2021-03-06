// Copyright (c) 2010, SMB SAAS Systems Inc.
// All rights reserved.
//
// Redistribution and use in source and binary forms, with or without modification,
// are permitted provided that the following conditions are met:
//
// - Redistributions of source code must  retain  the  above copyright notice, this
//   list of conditions and the following disclaimer.
//
// - Redistributions in binary form  must  reproduce the  above  copyright  notice,
//   this list of conditions  and  the  following  disclaimer in  the documentation
//   and/or other materials provided with the distribution.
//
// - Neither  the  name  of  the  SMB SAAS Systems Inc.  nor   the   names  of  its
//   contributors may be used to endorse or  promote  products  derived  from  this
//   software without specific prior written permission.
//
// THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS" AND
// ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING,  BUT  NOT  LIMITED TO, THE IMPLIED
// WARRANTIES  OF  MERCHANTABILITY   AND  FITNESS  FOR  A  PARTICULAR  PURPOSE  ARE
// DISCLAIMED. IN NO EVENT SHALL THE COPYRIGHT HOLDER OR CONTRIBUTORS BE LIABLE FOR
// ANY DIRECT, INDIRECT, INCIDENTAL,  SPECIAL,  EXEMPLARY, OR CONSEQUENTIAL DAMAGES
// (INCLUDING, BUT NOT LIMITED TO,  PROCUREMENT  OF  SUBSTITUTE  GOODS OR SERVICES;
// LOSS OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION)  HOWEVER  CAUSED AND ON
// ANY  THEORY  OF  LIABILITY,  WHETHER  IN  CONTRACT,  STRICT  LIABILITY,  OR TORT
// (INCLUDING NEGLIGENCE OR OTHERWISE)  ARISING  IN  ANY WAY OUT OF THE USE OF THIS
// SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.

using System;
using System.Data;
using System.Web;
using System.Collections;
using System.Collections.Generic;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.ComponentModel;
using Microsoft.Web.Services3;

using WebsitePanel.Providers;
using WebsitePanel.Providers.Web;
using WebsitePanel.Server.Utils;
using WebsitePanel.Providers.ResultObjects;
using WebsitePanel.Providers.WebAppGallery;
using WebsitePanel.Providers.Common;

namespace WebsitePanel.Server
{
    /// <summary>
    /// Summary description for WebServer
    /// </summary>
    [WebService(Namespace = "http://smbsaas/websitepanel/server/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [Policy("ServerPolicy")]
    [ToolboxItem(false)]
    public class WebServer : HostingServiceProviderWebService, IWebServer
    {
        private IWebServer WebProvider
        {
            get { return (IWebServer)Provider; }
        }

        #region Web Sites
        [WebMethod, SoapHeader("settings")]
        public void ChangeSiteState(string siteId, ServerState state)
        {
            try
            {
                Log.WriteStart("'{0}' ChangeSiteState", ProviderSettings.ProviderName);
                WebProvider.ChangeSiteState(siteId, state);
                Log.WriteEnd("'{0}' ChangeSiteState", ProviderSettings.ProviderName);
            }
            catch (Exception ex)
            {
                Log.WriteError(String.Format("'{0}' ChangeSiteState", ProviderSettings.ProviderName), ex);
                throw;
            }
        }

        [WebMethod, SoapHeader("settings")]
        public ServerState GetSiteState(string siteId)
        {
            try
            {
                Log.WriteStart("'{0}' GetSiteState", ProviderSettings.ProviderName);
                ServerState result = WebProvider.GetSiteState(siteId);
                Log.WriteEnd("'{0}' GetSiteState", ProviderSettings.ProviderName);
                return result;
            }
            catch (Exception ex)
            {
                Log.WriteError(String.Format("'{0}' GetSiteState", ProviderSettings.ProviderName), ex);
                throw;
            }
        }

        [WebMethod, SoapHeader("settings")]
        public string GetSiteId(string siteName)
        {
            try
            {
                Log.WriteStart("'{0}' GetSiteId", ProviderSettings.ProviderName);
                string result = WebProvider.GetSiteId(siteName);
                Log.WriteEnd("'{0}' GetSiteId", ProviderSettings.ProviderName);
                return result;
            }
            catch (Exception ex)
            {
                Log.WriteError(String.Format("'{0}' GetSiteId", ProviderSettings.ProviderName), ex);
                throw;
            }
        }

        [WebMethod, SoapHeader("settings")]
        public string[] GetSitesAccounts(string[] siteIds)
        {
            try
            {
                Log.WriteStart("'{0}' GetSitesAccounts", ProviderSettings.ProviderName);
                string[] result = WebProvider.GetSitesAccounts(siteIds);
                Log.WriteEnd("'{0}' GetSitesAccounts", ProviderSettings.ProviderName);
                return result;
            }
            catch (Exception ex)
            {
                Log.WriteError(String.Format("'{0}' GetSitesAccounts", ProviderSettings.ProviderName), ex);
                throw;
            }
        }

        [WebMethod, SoapHeader("settings")]
        public bool SiteExists(string siteId)
        {
            try
            {
                Log.WriteStart("'{0}' SiteIdExists", ProviderSettings.ProviderName);
                bool result = WebProvider.SiteExists(siteId);
                Log.WriteEnd("'{0}' SiteIdExists", ProviderSettings.ProviderName);
                return result;
            }
            catch (Exception ex)
            {
                Log.WriteError(String.Format("'{0}' SiteIdExists", ProviderSettings.ProviderName), ex);
                throw;
            }
        }

        [WebMethod, SoapHeader("settings")]
        public string[] GetSites()
        {
            try
            {
                Log.WriteStart("'{0}' GetSites", ProviderSettings.ProviderName);
                string[] result = WebProvider.GetSites();
                Log.WriteEnd("'{0}' GetSites", ProviderSettings.ProviderName);
                return result;
            }
            catch (Exception ex)
            {
                Log.WriteError(String.Format("'{0}' GetSites", ProviderSettings.ProviderName), ex);
                throw;
            }
        }

        [WebMethod, SoapHeader("settings")]
        public WebSite GetSite(string siteId)
        {
            try
            {
                Log.WriteStart("'{0}' GetSite", ProviderSettings.ProviderName);
                WebSite result = WebProvider.GetSite(siteId);
                Log.WriteEnd("'{0}' GetSite", ProviderSettings.ProviderName);
                return result;
            }
            catch (Exception ex)
            {
                Log.WriteError(String.Format("'{0}' GetSite", ProviderSettings.ProviderName), ex);
                throw;
            }
        }

        [WebMethod, SoapHeader("settings")]
        public ServerBinding[] GetSiteBindings(string siteId)
        {
            try
            {
                Log.WriteStart("'{0}' GetSiteBindings", ProviderSettings.ProviderName);
                ServerBinding[] result = WebProvider.GetSiteBindings(siteId);
                Log.WriteEnd("'{0}' GetSiteBindings", ProviderSettings.ProviderName);
                return result;
            }
            catch (Exception ex)
            {
                Log.WriteError(String.Format("'{0}' GetSiteBindings", ProviderSettings.ProviderName), ex);
                throw;
            }
        }

        [WebMethod, SoapHeader("settings")]
        public string CreateSite(WebSite site)
        {
            try
            {
                Log.WriteStart("'{0}' CreateSite", ProviderSettings.ProviderName);
                string result = WebProvider.CreateSite(site);
                Log.WriteEnd("'{0}' CreateSite", ProviderSettings.ProviderName);
                return result;
            }
            catch (Exception ex)
            {
                Log.WriteError(String.Format("'{0}' CreateSite", ProviderSettings.ProviderName), ex);
                throw;
            }
        }

        [WebMethod, SoapHeader("settings")]
        public void UpdateSite(WebSite site)
        {
            try
            {
                Log.WriteStart("'{0}' UpdateSite", ProviderSettings.ProviderName);
                WebProvider.UpdateSite(site);
                Log.WriteEnd("'{0}' UpdateSite", ProviderSettings.ProviderName);
            }
            catch (Exception ex)
            {
                Log.WriteError(String.Format("'{0}' UpdateSite", ProviderSettings.ProviderName), ex);
                throw;
            }
        }

        [WebMethod, SoapHeader("settings")]
        public void UpdateSiteBindings(string siteId, ServerBinding[] bindings)
        {
            try
            {
                Log.WriteStart("'{0}' UpdateSiteBindings", ProviderSettings.ProviderName);
                WebProvider.UpdateSiteBindings(siteId, bindings);
                Log.WriteEnd("'{0}' UpdateSiteBindings", ProviderSettings.ProviderName);
            }
            catch (Exception ex)
            {
                Log.WriteError(String.Format("'{0}' UpdateSiteBindings", ProviderSettings.ProviderName), ex);
                throw;
            }
        }

        [WebMethod, SoapHeader("settings")]
        public void DeleteSite(string siteId)
        {
            try
            {
                Log.WriteStart("'{0}' DeleteSite", ProviderSettings.ProviderName);
                WebProvider.DeleteSite(siteId);
                Log.WriteEnd("'{0}' DeleteSite", ProviderSettings.ProviderName);
            }
            catch (Exception ex)
            {
                Log.WriteError(String.Format("'{0}' DeleteSite", ProviderSettings.ProviderName), ex);
                throw;
            }
        }
        #endregion

        #region Virtual Directories
        [WebMethod, SoapHeader("settings")]
        public bool VirtualDirectoryExists(string siteId, string directoryName)
        {
            try
            {
                Log.WriteStart("'{0}' VirtualDirectoryExists", ProviderSettings.ProviderName);
                bool result = WebProvider.VirtualDirectoryExists(siteId, directoryName);
                Log.WriteEnd("'{0}' VirtualDirectoryExists", ProviderSettings.ProviderName);
                return result;
            }
            catch (Exception ex)
            {
                Log.WriteError(String.Format("'{0}' VirtualDirectoryExists", ProviderSettings.ProviderName), ex);
                throw;
            }
        }

        [WebMethod, SoapHeader("settings")]
        public WebVirtualDirectory[] GetVirtualDirectories(string siteId)
        {
            try
            {
                Log.WriteStart("'{0}' GetVirtualDirectories", ProviderSettings.ProviderName);
                WebVirtualDirectory[] result = WebProvider.GetVirtualDirectories(siteId);
                Log.WriteEnd("'{0}' GetVirtualDirectories", ProviderSettings.ProviderName);
                return result;
            }
            catch (Exception ex)
            {
                Log.WriteError(String.Format("'{0}' GetVirtualDirectories", ProviderSettings.ProviderName), ex);
                throw;
            }
        }

        [WebMethod, SoapHeader("settings")]
        public WebVirtualDirectory GetVirtualDirectory(string siteId, string directoryName)
        {
            try
            {
                Log.WriteStart("'{0}' GetVirtualDirectory", ProviderSettings.ProviderName);
                WebVirtualDirectory result = WebProvider.GetVirtualDirectory(siteId, directoryName);
                Log.WriteEnd("'{0}' GetVirtualDirectory", ProviderSettings.ProviderName);
                return result;
            }
            catch (Exception ex)
            {
                Log.WriteError(String.Format("'{0}' GetVirtualDirectory", ProviderSettings.ProviderName), ex);
                throw;
            }
        }

        [WebMethod, SoapHeader("settings")]
        public void CreateVirtualDirectory(string siteId, WebVirtualDirectory directory)
        {
            try
            {
                Log.WriteStart("'{0}' CreateVirtualDirectory", ProviderSettings.ProviderName);
                WebProvider.CreateVirtualDirectory(siteId, directory);
                Log.WriteEnd("'{0}' CreateVirtualDirectory", ProviderSettings.ProviderName);
            }
            catch (Exception ex)
            {
                Log.WriteError(String.Format("'{0}' CreateVirtualDirectory", ProviderSettings.ProviderName), ex);
                throw;
            }
        }

        [WebMethod, SoapHeader("settings")]
        public void UpdateVirtualDirectory(string siteId, WebVirtualDirectory directory)
        {
            try
            {
                Log.WriteStart("'{0}' UpdateVirtualDirectory", ProviderSettings.ProviderName);
                WebProvider.UpdateVirtualDirectory(siteId, directory);
                Log.WriteEnd("'{0}' UpdateVirtualDirectory", ProviderSettings.ProviderName);
            }
            catch (Exception ex)
            {
                Log.WriteError(String.Format("'{0}' UpdateVirtualDirectory", ProviderSettings.ProviderName), ex);
                throw;
            }
        }

        [WebMethod, SoapHeader("settings")]
        public void DeleteVirtualDirectory(string siteId, string directoryName)
        {
            try
            {
                Log.WriteStart("'{0}' DeleteVirtualDirectory", ProviderSettings.ProviderName);
                WebProvider.DeleteVirtualDirectory(siteId, directoryName);
                Log.WriteEnd("'{0}' DeleteVirtualDirectory", ProviderSettings.ProviderName);
            }
            catch (Exception ex)
            {
                Log.WriteError(String.Format("'{0}' DeleteVirtualDirectory", ProviderSettings.ProviderName), ex);
                throw;
            }
        }
        #endregion

        #region FrontPage
        [WebMethod, SoapHeader("settings")]
        public bool IsFrontPageSystemInstalled()
        {
            try
            {
                Log.WriteStart("'{0}' IsFrontPageSystemInstalled", ProviderSettings.ProviderName);
                bool result = WebProvider.IsFrontPageSystemInstalled();
                Log.WriteEnd("'{0}' IsFrontPageSystemInstalled", ProviderSettings.ProviderName);
                return result;
            }
            catch (Exception ex)
            {
                Log.WriteError(String.Format("'{0}' IsFrontPageSystemInstalled", ProviderSettings.ProviderName), ex);
                throw;
            }
        }

        [WebMethod, SoapHeader("settings")]
        public bool IsFrontPageInstalled(string siteId)
        {
            try
            {
                Log.WriteStart("'{0}' IsFrontPageInstalled", ProviderSettings.ProviderName);
                bool result = WebProvider.IsFrontPageInstalled(siteId);
                Log.WriteEnd("'{0}' IsFrontPageInstalled", ProviderSettings.ProviderName);
                return result;
            }
            catch (Exception ex)
            {
                Log.WriteError(String.Format("'{0}' IsFrontPageInstalled", ProviderSettings.ProviderName), ex);
                throw;
            }
        }

        [WebMethod, SoapHeader("settings")]
        public bool InstallFrontPage(string siteId, string username, string password)
        {
            try
            {
                Log.WriteStart("'{0}' InstallFrontPage", ProviderSettings.ProviderName);
                bool result = WebProvider.InstallFrontPage(siteId, username, password);
                Log.WriteEnd("'{0}' InstallFrontPage", ProviderSettings.ProviderName);
                return result;
            }
            catch (Exception ex)
            {
                Log.WriteError(String.Format("'{0}' InstallFrontPage", ProviderSettings.ProviderName), ex);
                throw;
            }
        }

        [WebMethod, SoapHeader("settings")]
        public void UninstallFrontPage(string siteId, string username)
        {
            try
            {
                Log.WriteStart("'{0}' UninstallFrontPage", ProviderSettings.ProviderName);
                WebProvider.UninstallFrontPage(siteId, username);
                Log.WriteEnd("'{0}' UninstallFrontPage", ProviderSettings.ProviderName);
            }
            catch (Exception ex)
            {
                Log.WriteError(String.Format("'{0}' UninstallFrontPage", ProviderSettings.ProviderName), ex);
                throw;
            }
        }

        [WebMethod, SoapHeader("settings")]
        public void ChangeFrontPagePassword(string username, string password)
        {
            try
            {
                Log.WriteStart("'{0}' ChangeFrontPagePassword", ProviderSettings.ProviderName);
                WebProvider.ChangeFrontPagePassword(username, password);
                Log.WriteEnd("'{0}' ChangeFrontPagePassword", ProviderSettings.ProviderName);
            }
            catch (Exception ex)
            {
                Log.WriteError(String.Format("'{0}' ChangeFrontPagePassword", ProviderSettings.ProviderName), ex);
                throw;
            }
        }
        #endregion

        #region ColdFusion
        [WebMethod, SoapHeader("settings")]
        public bool IsColdFusionSystemInstalled()
        {
            try
            {
                Log.WriteStart("'{0}' IsColdFusionSystemInstalled", ProviderSettings.ProviderName);
                bool result = WebProvider.IsColdFusionSystemInstalled();
                Log.WriteEnd("'{0}' IsColdFusionSystemInstalled", ProviderSettings.ProviderName);
                return result;
            }
            catch (Exception ex)
            {
                Log.WriteError(String.Format("'{0}' IsColdFusionSystemInstalled", ProviderSettings.ProviderName), ex);
                throw;
            }
        }
        #endregion

        #region Permissions
        [WebMethod, SoapHeader("settings")]
        public void GrantWebSiteAccess(string path, string siteId, NTFSPermission permission)
        {
            try
            {
                Log.WriteStart("'{0}' GrantWebSiteAccess", ProviderSettings.ProviderName);
                WebProvider.GrantWebSiteAccess(path, siteId, permission);
                Log.WriteEnd("'{0}' GrantWebSiteAccess", ProviderSettings.ProviderName);
            }
            catch (Exception ex)
            {
                Log.WriteError(String.Format("'{0}' GrantWebSiteAccess", ProviderSettings.ProviderName), ex);
                throw;
            }
        }
        #endregion

        #region Secured Folders
        [WebMethod, SoapHeader("settings")]
        public void InstallSecuredFolders(string siteId)
        {
            try
            {
                Log.WriteStart("'{0}' InstallSecuredFolders", ProviderSettings.ProviderName);
                WebProvider.InstallSecuredFolders(siteId);
                Log.WriteEnd("'{0}' InstallSecuredFolders", ProviderSettings.ProviderName);
            }
            catch (Exception ex)
            {
                Log.WriteError(String.Format("'{0}' InstallSecuredFolders", ProviderSettings.ProviderName), ex);
                throw;
            }
        }

        [WebMethod, SoapHeader("settings")]
        public void UninstallSecuredFolders(string siteId)
        {
            try
            {
                Log.WriteStart("'{0}' UninstallSecuredFolders", ProviderSettings.ProviderName);
                WebProvider.UninstallSecuredFolders(siteId);
                Log.WriteEnd("'{0}' UninstallSecuredFolders", ProviderSettings.ProviderName);
            }
            catch (Exception ex)
            {
                Log.WriteError(String.Format("'{0}' UninstallSecuredFolders", ProviderSettings.ProviderName), ex);
                throw;
            }
        }

        [WebMethod, SoapHeader("settings")]
        public List<WebFolder> GetFolders(string siteId)
        {
            try
            {
                Log.WriteStart("'{0}' GetFolders", ProviderSettings.ProviderName);
                List<WebFolder> result = WebProvider.GetFolders(siteId);
                Log.WriteEnd("'{0}' GetFolders", ProviderSettings.ProviderName);
                return result;
            }
            catch (Exception ex)
            {
                Log.WriteError(String.Format("'{0}' GetFolders", ProviderSettings.ProviderName), ex);
                throw;
            }
        }

        [WebMethod, SoapHeader("settings")]
        public WebFolder GetFolder(string siteId, string folderPath)
        {
            try
            {
                Log.WriteStart("'{0}' GetFolder", ProviderSettings.ProviderName);
                WebFolder result = WebProvider.GetFolder(siteId, folderPath);
                Log.WriteEnd("'{0}' GetFolder", ProviderSettings.ProviderName);
                return result;
            }
            catch (Exception ex)
            {
                Log.WriteError(String.Format("'{0}' GetFolder", ProviderSettings.ProviderName), ex);
                throw;
            }
        }

        [WebMethod, SoapHeader("settings")]
        public void UpdateFolder(string siteId, WebFolder folder)
        {
            try
            {
                Log.WriteStart("'{0}' UpdateFolder", ProviderSettings.ProviderName);
                WebProvider.UpdateFolder(siteId, folder);
                Log.WriteEnd("'{0}' UpdateFolder", ProviderSettings.ProviderName);
            }
            catch (Exception ex)
            {
                Log.WriteError(String.Format("'{0}' UpdateFolder", ProviderSettings.ProviderName), ex);
                throw;
            }
        }

        [WebMethod, SoapHeader("settings")]
        public void DeleteFolder(string siteId, string folderPath)
        {
            try
            {
                Log.WriteStart("'{0}' DeleteFolder", ProviderSettings.ProviderName);
                WebProvider.DeleteFolder(siteId, folderPath);
                Log.WriteEnd("'{0}' DeleteFolder", ProviderSettings.ProviderName);
            }
            catch (Exception ex)
            {
                Log.WriteError(String.Format("'{0}' DeleteFolder", ProviderSettings.ProviderName), ex);
                throw;
            }
        }
        #endregion

        #region Secured Users
        [WebMethod, SoapHeader("settings")]
        public List<WebUser> GetUsers(string siteId)
        {
            try
            {
                Log.WriteStart("'{0}' GetUsers", ProviderSettings.ProviderName);
                List<WebUser> result = WebProvider.GetUsers(siteId);
                Log.WriteEnd("'{0}' GetUsers", ProviderSettings.ProviderName);
                return result;
            }
            catch (Exception ex)
            {
                Log.WriteError(String.Format("'{0}' GetUsers", ProviderSettings.ProviderName), ex);
                throw;
            }
        }

        [WebMethod, SoapHeader("settings")]
        public WebUser GetUser(string siteId, string userName)
        {
            try
            {
                Log.WriteStart("'{0}' GetUser", ProviderSettings.ProviderName);
                WebUser result = WebProvider.GetUser(siteId, userName);
                Log.WriteEnd("'{0}' GetUser", ProviderSettings.ProviderName);
                return result;
            }
            catch (Exception ex)
            {
                Log.WriteError(String.Format("'{0}' GetUser", ProviderSettings.ProviderName), ex);
                throw;
            }
        }

        [WebMethod, SoapHeader("settings")]
        public void UpdateUser(string siteId, WebUser user)
        {
            try
            {
                Log.WriteStart("'{0}' UpdateUser", ProviderSettings.ProviderName);
                WebProvider.UpdateUser(siteId, user);
                Log.WriteEnd("'{0}' UpdateUser", ProviderSettings.ProviderName);
            }
            catch (Exception ex)
            {
                Log.WriteError(String.Format("'{0}' UpdateUser", ProviderSettings.ProviderName), ex);
                throw;
            }
        }

        [WebMethod, SoapHeader("settings")]
        public void DeleteUser(string siteId, string userName)
        {
            try
            {
                Log.WriteStart("'{0}' DeleteUser", ProviderSettings.ProviderName);
                WebProvider.DeleteUser(siteId, userName);
                Log.WriteEnd("'{0}' DeleteUser", ProviderSettings.ProviderName);
            }
            catch (Exception ex)
            {
                Log.WriteError(String.Format("'{0}' DeleteUser", ProviderSettings.ProviderName), ex);
                throw;
            }
        }
        #endregion

        #region Secured Groups
        [WebMethod, SoapHeader("settings")]
        public List<WebGroup> GetGroups(string siteId)
        {
            try
            {
                Log.WriteStart("'{0}' GetGroups", ProviderSettings.ProviderName);
                List<WebGroup> result = WebProvider.GetGroups(siteId);
                Log.WriteEnd("'{0}' GetGroups", ProviderSettings.ProviderName);
                return result;
            }
            catch (Exception ex)
            {
                Log.WriteError(String.Format("'{0}' GetGroups", ProviderSettings.ProviderName), ex);
                throw;
            }
        }

        [WebMethod, SoapHeader("settings")]
        public WebGroup GetGroup(string siteId, string groupName)
        {
            try
            {
                Log.WriteStart("'{0}' GetGroup", ProviderSettings.ProviderName);
                WebGroup result = WebProvider.GetGroup(siteId, groupName);
                Log.WriteEnd("'{0}' GetGroup", ProviderSettings.ProviderName);
                return result;
            }
            catch (Exception ex)
            {
                Log.WriteError(String.Format("'{0}' GetGroup", ProviderSettings.ProviderName), ex);
                throw;
            }
        }

        [WebMethod, SoapHeader("settings")]
        public void UpdateGroup(string siteId, WebGroup group)
        {
            try
            {
                Log.WriteStart("'{0}' UpdateGroup", ProviderSettings.ProviderName);
                WebProvider.UpdateGroup(siteId, group);
                Log.WriteEnd("'{0}' UpdateGroup", ProviderSettings.ProviderName);
            }
            catch (Exception ex)
            {
                Log.WriteError(String.Format("'{0}' UpdateGroup", ProviderSettings.ProviderName), ex);
                throw;
            }
        }

        [WebMethod, SoapHeader("settings")]
        public void DeleteGroup(string siteId, string groupName)
        {
            try
            {
                Log.WriteStart("'{0}' DeleteGroup", ProviderSettings.ProviderName);
                WebProvider.DeleteGroup(siteId, groupName);
                Log.WriteEnd("'{0}' DeleteGroup", ProviderSettings.ProviderName);
            }
            catch (Exception ex)
            {
                Log.WriteError(String.Format("'{0}' DeleteGroup", ProviderSettings.ProviderName), ex);
                throw;
            }
        }
        #endregion

		#region Web Application Gallery
		[WebMethod, SoapHeader("settings")]
		public GalleryCategoriesResult GetGalleryCategories()
		{
			try
			{
				Log.WriteStart("'{0}' GalleryCategoriesResult", ProviderSettings.ProviderName);
				GalleryCategoriesResult result = WebProvider.GetGalleryCategories();
				Log.WriteEnd("'{0}' GalleryCategoriesResult", ProviderSettings.ProviderName);
				return result;
			}
			catch (Exception ex)
			{
				Log.WriteError(String.Format("'{0}' GalleryCategoriesResult", ProviderSettings.ProviderName), ex);
				throw;
			}
		}

		[WebMethod, SoapHeader("settings")]
		public GalleryApplicationsResult GetGalleryApplications(string categoryId)
		{
			try
			{
				Log.WriteStart("'{0}' GetGalleryApplications", ProviderSettings.ProviderName);
				GalleryApplicationsResult result = WebProvider.GetGalleryApplications(categoryId);
				Log.WriteEnd("'{0}' GetGalleryApplications", ProviderSettings.ProviderName);
				return result;
			}
			catch (Exception ex)
			{
				Log.WriteError(String.Format("'{0}' GetGalleryApplications", ProviderSettings.ProviderName), ex);
				throw;
			}
		}
		[WebMethod, SoapHeader("settings")]
		public bool IsMsDeployInstalled()
		{
			try
			{
				Log.WriteStart("'{0}' IsMsDeployInstalled", ProviderSettings.ProviderName);
				bool result = WebProvider.IsMsDeployInstalled();
				Log.WriteEnd("'{0}' IsMsDeployInstalled", ProviderSettings.ProviderName);
				return result;
			}
			catch (Exception ex)
			{
				Log.WriteError(String.Format("'{0}' IsMsDeployInstalled", ProviderSettings.ProviderName), ex);
				throw;
			}
		}

		[WebMethod, SoapHeader("settings")]
		public GalleryApplicationResult GetGalleryApplication(string id)
		{
			try
			{
				Log.WriteStart("'{0}' GetGalleryApplication", ProviderSettings.ProviderName);
				GalleryApplicationResult result = WebProvider.GetGalleryApplication(id);
				Log.WriteEnd("'{0}' GetGalleryApplication", ProviderSettings.ProviderName);
				return result;
			}
			catch (Exception ex)
			{
				Log.WriteError(String.Format("'{0}' GetGalleryApplication", ProviderSettings.ProviderName), ex);
				throw;
			}
		}

		[WebMethod, SoapHeader("settings")]
		public GalleryWebAppStatus GetGalleryApplicationStatus(string id)
		{
			try
			{
				Log.WriteStart("'{0}' GetGalleryApplicationStatus", ProviderSettings.ProviderName);
				GalleryWebAppStatus result = WebProvider.GetGalleryApplicationStatus(id);
				Log.WriteEnd("'{0}' GetGalleryApplicationStatus", ProviderSettings.ProviderName);
				return result;
			}
			catch (Exception ex)
			{
				Log.WriteError(String.Format("'{0}' GetGalleryApplicationStatus", ProviderSettings.ProviderName), ex);
				throw;
			}
		}
		
		[WebMethod, SoapHeader("settings")]
		public GalleryWebAppStatus DownloadGalleryApplication(string id)
		{
			try
			{
				Log.WriteStart("'{0}' DownloadGalleryApplication", ProviderSettings.ProviderName);
				GalleryWebAppStatus result = WebProvider.DownloadGalleryApplication(id);
				Log.WriteEnd("'{0}' DownloadGalleryApplication", ProviderSettings.ProviderName);
				return result;
			}
			catch (Exception ex)
			{
				Log.WriteError(String.Format("'{0}' DownloadGalleryApplication", ProviderSettings.ProviderName), ex);
				throw;
			}
		}

		[WebMethod, SoapHeader("settings")]
		public DeploymentParametersResult GetGalleryApplicationParameters(string id)
		{
			try
			{
				Log.WriteStart("'{0}' GetGalleryApplicationParameters", ProviderSettings.ProviderName);
				DeploymentParametersResult result = WebProvider.GetGalleryApplicationParameters(id);
				Log.WriteEnd("'{0}' GetGalleryApplicationParameters", ProviderSettings.ProviderName);
				return result;
			}
			catch (Exception ex)
			{
				Log.WriteError(String.Format("'{0}' GetGalleryApplicationParameters", ProviderSettings.ProviderName), ex);
				throw;
			}
		}

		[WebMethod, SoapHeader("settings")]
		public StringResultObject InstallGalleryApplication(string id, List<DeploymentParameter> updatedValues)
		{
			try
			{
				Log.WriteStart("'{0}' InstallGalleryApplication", ProviderSettings.ProviderName);
				StringResultObject result = WebProvider.InstallGalleryApplication(id, updatedValues);
				Log.WriteEnd("'{0}' InstallGalleryApplication", ProviderSettings.ProviderName);
				return result;
			}
			catch (Exception ex)
			{
				Log.WriteError(String.Format("'{0}' InstallGalleryApplication", ProviderSettings.ProviderName), ex);
				throw;
			}
		}
	
		#endregion

		#region WebManagement Access

		[WebMethod, SoapHeader("settings")]
		public bool CheckWebManagementAccountExists(string accountName)
		{
			try
			{
				bool accountExists;
				//
				Log.WriteStart("'{0}' CheckWebManagementAccountExtsts", ProviderSettings.ProviderName);
				//
				accountExists = WebProvider.CheckWebManagementAccountExists(accountName);
				//
				Log.WriteEnd("'{0}' CheckWebManagementAccountExtsts", ProviderSettings.ProviderName);
				//
				return accountExists;
			}
			catch (Exception ex)
			{
				Log.WriteError(String.Format("'{0}' CheckWebManagementAccountExtsts", ProviderSettings.ProviderName), ex);
				throw;
			}
		}

		[WebMethod, SoapHeader("settings")]
		public ResultObject CheckWebManagementPasswordComplexity(string accountPassword)
		{
			try
			{
				ResultObject result;

				Log.WriteStart("'{0}' CheckWebManagementPasswordComplexity", ProviderSettings.ProviderName);
				
				result = WebProvider.CheckWebManagementPasswordComplexity(accountPassword);
				
				Log.WriteEnd("'{0}' CheckWebManagementPasswordComplexity", ProviderSettings.ProviderName);
				//
				return result;
			}
			catch (Exception ex)
			{
				Log.WriteError(String.Format("'{0}' CheckWebManagementPasswordComplexity", ProviderSettings.ProviderName), ex);
				throw;
			}
		}

		[WebMethod, SoapHeader("settings")]
		public void GrantWebManagementAccess(string siteId, string accountName, string accountPassword)
		{
			try
			{
				Log.WriteStart("'{0}' GrantWebManagementAccess", ProviderSettings.ProviderName);
				WebProvider.GrantWebManagementAccess(siteId, accountName, accountPassword);
				Log.WriteEnd("'{0}' GrantWebManagementAccess", ProviderSettings.ProviderName);
			}
			catch (Exception ex)
			{
				Log.WriteError(String.Format("'{0}' GrantWebManagementAccess", ProviderSettings.ProviderName), ex);
				throw;
			}
		}

		[WebMethod, SoapHeader("settings")]
		public void RevokeWebManagementAccess(string siteId, string accountName)
		{
			try
			{
				Log.WriteStart("'{0}' RevokeWebManagementAccess", ProviderSettings.ProviderName);
				WebProvider.RevokeWebManagementAccess(siteId, accountName);
				Log.WriteEnd("'{0}' RevokeWebManagementAccess", ProviderSettings.ProviderName);
			}
			catch (Exception ex)
			{
				Log.WriteError(String.Format("'{0}' RevokeWebManagementAccess", ProviderSettings.ProviderName), ex);
				throw;
			}
		}

		[WebMethod, SoapHeader("settings")]
		public void ChangeWebManagementAccessPassword(string accountName, string accountPassword)
		{
			try
			{
				Log.WriteStart("'{0}' ChangeWebManagementAccessPassword", ProviderSettings.ProviderName);
				WebProvider.ChangeWebManagementAccessPassword(accountName, accountPassword);
				Log.WriteEnd("'{0}' ChangeWebManagementAccessPassword", ProviderSettings.ProviderName);
			}
			catch (Exception ex)
			{
				Log.WriteError(String.Format("'{0}' ChangeWebManagementAccessPassword", ProviderSettings.ProviderName), ex);
				throw;
			}
		}

		#endregion
    }
}
