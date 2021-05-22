pushd FlatSharpTests

dotnet test /p:AltCoverForce=true /p:AltCover=true /p:AltCoverAttributeFilter=ExcludeFromCodeCoverage /p:AltCoverStrongNameKey=..\..\..\misc\strongname.snk -v d -f net5.0
dotnet %UserProfile%\.nuget\packages\reportgenerator\4.1.2\tools\netcoreapp2.1\ReportGenerator.dll -reports:coverage.net5.0.xml -targetdir:.coverage\

popd

pushd FlatSharpCompilerTests

dotnet test /p:AltCoverForce=true /p:AltCover=true /p:AltCoverAttributeFilter=ExcludeFromCodeCoverage /p:AltCoverStrongNameKey=..\..\..\misc\strongname.snk -v d -f net5.0
dotnet %UserProfile%\.nuget\packages\reportgenerator\4.1.2\tools\netcoreapp2.1\ReportGenerator.dll -reports:coverage.net5.0.xml -targetdir:.coverage\

popd