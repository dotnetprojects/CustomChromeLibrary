$root = (split-path -parent $MyInvocation.MyCommand.Definition) + '\..'

Write-Host "root: $root"

$version = [System.Reflection.Assembly]::LoadFile("$root\WpfCustomChromeLib\Libraries\CustomChromeLibrary\bin\Debug\CustomChromeLibrary.dll").GetName().Version
$versionStr = "{0}.{1}.{2}" -f ($version.Major, $version.Minor, $version.Build)

Write-Host "Setting .nuspec version tag to $versionStr"

$content = (Get-Content $root\NuGet\Package.nuspec) 
$content = $content -replace '\$version\$',$versionStr

$content | Out-File $root\nuget\Package.compiled.nuspec

& NuGet pack $root\nuget\Package.compiled.nuspec