# MarkdownNet


## publish to Nuget

https://docs.microsoft.com/en-us/nuget/create-packages/creating-a-package

https://docs.microsoft.com/ja-jp/nuget/quickstart/create-and-publish-a-package-using-visual-studio-net-framework

```
cd C:\Projects\github\infinith4\MarkdownNet\MarkdownNet
nuget spec MarkdownNet.csproj
```

*modified a new version

copy packages directory to same directory.

```
nuget pack MarkdownNet.csproj -IncludeReferencedProjects  -properties Configuration=Release
nuget push infinith.MarkdownNet.1.0.2.nupkg [key] -Source https://api.nuget.org/v3/index.json
```

https://www.nuget.org/packages/infinith.MarkdownNet/