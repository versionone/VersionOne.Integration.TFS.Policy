$projectPath="VersionOne.Integration.Tfs.Policy.Deployment.VS2012"
$pkgdir="chocolateyPackage"
$nuspec="VersionOne.Integration.Tfs.Policy.VS2012.nuspec"
$filebasename="VersionOne.Integration.Tfs.Policy.Deployment.VS2012"
$configuration="Release"
$ps1file="Install.ps1"
$pkgid="VersionOne.Integration.Tfs.Policy.VS2012"

function Update-Nuspec {
    $filePath = "$baseDirectory\$projectPath\$pkgdir\$nuspec"
    $versionPattern = '<version>[0-9]+(\.([0-9]+|\*)){3}</version>'
    $versionNuspec = '<version>' + $version + '</version>'

    echo "Updating file $nuspec"

    (gc $filePath) |
    % {$_ -replace $versionPattern, $versionNuspec } | Set-Content -Encoding UTF8 -Path $filePath
}

function Update-PSInstall {
    $filePath = "$baseDirectory\$projectPath\$pkgdir\tools\$ps1file"
    echo "Updating file $ps1file"
    Set-Content -Path $filePath -Value "Install-ChocolateyVsixPackage '$pkgid' 'http://platform.versionone.com.s3.amazonaws.com/downloads/$filebasename.$version.vsix'"
}

function Get-GeneratePackageAndPush{
    $nuspecFilePath = "$baseDirectory\$projectPath\$pkgdir\$nuspec"

    #Rename-Item "$baseDirectory\$projectPath\bin\$configuration\$filebasename.vsix" "$filebasename.$version.vsix"

    iex (Get-GeneratePackageCommandFromNuspec $nuspecFilePath)
    #iex (Get-PushMygetCommand $env:MYGET_API_KEY $env:MYGET_REPO_URL)
}

Update-Nuspec

Update-PSInstall

Get-GeneratePackageAndPush