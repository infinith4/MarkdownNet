# MarkdownNet


cd C:\Projects\github\tys-hiroshi\MarkdownNet\MarkdownNet
nuget spec MarkdownNet.csproj
nuget pack MarkdownNet.csproj -IncludeReferencedProjects  -properties Configuration=Release
nuget push infinith.MarkdownNet.1.0.0.nupkg [key] -Source https://api.nuget.org/v3/index.json

https://www.nuget.org/packages/infinith.MarkdownNet/