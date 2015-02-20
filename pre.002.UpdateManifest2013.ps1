function Update-Manifest {

$filePath = "VersionOne.Integration.Tfs.Policy.Deployment.VS2013\source.extension.vsixmanifest"
$versionPattern = 'Version\="[0-9]+(\.([0-9]+|\*)){3}"'
$versionManifest = 'Version="' + $version + '"'

echo Updating file $filePath

(gc $filePath) |
% {$_ -replace $versionPattern, $versionManifest } | Set-Content -Encoding UTF8 -Path $filePath
}

Update-Manifest