# play-azure-ad

Play ground to try Azure AD as a User Management.

# Use
 
1. At portal.azure.com setup new shiny `Azure AD`
2. In `App registrations` create new app
   - Url: http://localhost:5000/signin-oidc
   - Record Application ID (it will be your Client ID)
3. You can create few users in `Users anf Groups` now
4. in `src/Play.AzureAd/appsettings.json`
   - ClientId: Application ID
   - Authority: https://login.microsoftonline.com/[your_tenant].onmicrosoft.com
5. in src/Play.AzureAd/ `dotnet run`, open `http://localhost:5000/` and click Login
6. Enjoy The Magic!


# Use cases

- [x] Authentication against Azure AD
- [] Azure AD user singup
- [x] Azure AD claims based on Azure AD Groups
- [] Azure AD list of AD groups
- [] Azure AD user information
- [] Azure AD user list