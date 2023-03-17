param($path)

Write-Host $path

$signature = @'
[DllImport("oleaut32.dll", CharSet=CharSet.Unicode, ExactSpelling=true, SetLastError=true)]
public static extern int LoadTypeLibEx(string fileName, uint regkind, out System.Runtime.InteropServices.ComTypes.ITypeLib typeLib);
'@

$type = Add-Type -MemberDefinition $signature `
    -Name Win32Utils -Namespace LoadTypeLibEx `
    -PassThru
   
$typeLib = $null
$hr = $type::LoadTypeLibEx($path, 1, ([ref]$typeLib))
if ($hr -ne 0)
{
    throw "LoadTypeLibEx failed, hr = $hr"
}