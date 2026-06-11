$dotnet = 'C:\Program Files\dotnet'
$userPath = [Environment]::GetEnvironmentVariable('Path', 'User')
if (-not ($userPath -split ';' | ForEach-Object { $_.Trim() } | Where-Object { $_ -eq $dotnet })) {
    $newPath = if ([string]::IsNullOrEmpty($userPath)) { $dotnet } else { "$dotnet;$userPath" }
    [Environment]::SetEnvironmentVariable('Path', $newPath, 'User')
    Write-Host "Added '$dotnet' to user PATH."
} else {
    Write-Host "User PATH already contains '$dotnet'."
}
$env:Path = "$dotnet;$env:Path"
Get-Command dotnet -ErrorAction Stop | Select-Object -ExpandProperty Source
