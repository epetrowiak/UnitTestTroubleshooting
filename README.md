# UnitTestTroubleshooting
Troubleshooting an issue with DataSource not accessing TFS, due to a missing assembly.

Attempted against a TFS server with version 15.112.26307.0.

Solutions tried so far -
Adding nuget package for Microsoft.VisualStudio.Threading 15.4.4
Redirect Assembly in app config: 
 <dependentAssembly>
        <assemblyIdentity name="Microsoft.VisualStudio.Threading" publicKeyToken="b03f5f7f11d50a3a"/>
        <bindingRedirect oldVersion="15.0.0.0-15.3.0.0" newVersion="15.3.0.0"/>
      </dependentAssembly>
