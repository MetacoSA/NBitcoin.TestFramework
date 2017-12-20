rm "bin\release\" -Recurse -Force
dotnet pack --configuration Release

dotnet nuget push "bin\Release\*.nupkg" --source "https://www.myget.org/F/metacosa/api/v2/package"
$ver = ((ls .\bin\release -File)[0].Name -replace '([^\.\d]*\.)+(\d+(\.\d+){1,3}).*', '$2')
git tag -a "v$ver" -m "$ver"
git push --tags