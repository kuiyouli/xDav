using System;
using System.Reflection;
using System.Resources;
using System.Runtime.InteropServices;
using System.Security.Permissions;

//
// General Information about an assembly is controlled through the following 
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
//
[assembly: AssemblyTitle("WebDAV.NET Server Framework")]
[assembly: AssemblyDescription("Microsoft.NET WebDAV Server Framework which allows users to easily expose WebDAV functionality via IIS to custom solutions")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("Sphorium Technologies")]
[assembly: AssemblyProduct("Sphorium.WebDAV.Server.Framework")]
[assembly: AssemblyCopyright("Copyright Sphorium Technologies �2010")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]		

[assembly:ComVisible(false)]
[assembly:CLSCompliant(true)]
[assembly:EnvironmentPermissionAttribute(SecurityAction.RequestMinimum)]
[assembly: NeutralResourcesLanguageAttribute("en-US")]

//
// Version information for an assembly consists of the following four values:
//
//      Major Version
//      Minor Version 
//      Build Number
//      Revision
//
// You can specify all the values or you can default the Revision and Build Numbers 
// by using the '*' as shown below:


#if DEBUG
[assembly: AssemblyVersion("3.2.*")]
#else
[assembly: AssemblyVersion("3.2.1.0")]
#endif

//
// In order to sign your assembly you must specify a key to use. Refer to the 
// Microsoft .NET Framework documentation for more information on assembly signing.
//
// Use the attributes below to control which key is used for signing. 
//
// Notes: 
//   (*) If no key is specified, the assembly is not signed.
//   (*) KeyName refers to a key that has been installed in the Crypto Service
//       Provider (CSP) on your machine. KeyFile refers to a file which contains
//       a key.
//   (*) If the KeyFile and the KeyName values are both specified, the 
//       following processing occurs:
//       (1) If the KeyName can be found in the CSP, that key is used.
//       (2) If the KeyName does not exist and the KeyFile does exist, the key 
//           in the KeyFile is installed into the CSP and used.
//   (*) In order to create a KeyFile, you can use the sn.exe (Strong Name) utility.
//       When specifying the KeyFile, the location of the KeyFile should be
//       relative to the project output directory which is
//       %Project Directory%\obj\<configuration>. For example, if your KeyFile is
//       located in the project directory, you would specify the AssemblyKeyFile 
//       attribute as [assembly: AssemblyKeyFile("..\\..\\mykey.snk")]
//   (*) Delay Signing is an advanced option - see the Microsoft .NET Framework
//       documentation for more information on this.
//
[assembly: AssemblyDelaySign(false)]

//#if !DEBUG
//    [assembly: AssemblyKeyFile(@"..\Sphorium Assembly Key\Sphorium.snk")]
//#endif 

[assembly: AssemblyKeyName("")]
