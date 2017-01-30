dotnet restore
dotnet pack -c Release

cd bin/Release

forfiles /m *.nupkg /c "cmd /c NuGet.exe push @FILE -source https://api.nuget.org/v3/index.json"

del "*symbols.nupkg"
(((dir *.nupkg).Name)[0] -match "[0-9]+?\.[0-9]+?\.[0-9]+?\.[0-9]+")
$ver = $Matches.Item(0)
git tag -a "v$ver" -m "$ver"
git push --tags
del "*.nupkg"

cd ../..